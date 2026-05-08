import {
  AudioFrame,
  AudioSource,
  AudioStream,
  LocalAudioTrack,
  RemoteAudioTrack,
  RemoteVideoTrack,
  Room,
  RoomEvent,
  TrackPublishOptions,
  TrackSource,
  VideoBufferType,
  VideoStream,
} from '@livekit/rtc-node';
import sharp from 'sharp';
import WebSocket from 'ws';

const FRAME_HEADER_BYTES = 24;
const KIND_AVATAR_AUDIO = 1;
const KIND_AVATAR_JPEG = 2;
const KIND_AVATAR_PNG = 4;
const KIND_WATCH_AUDIO = 17;

const config = {
  ingestUrl: requireEnv('BRIDGE_INGEST_URL'),
  liveKitUrl: requireEnv('LIVEKIT_URL'),
  liveKitToken: requireEnv('LIVEKIT_TOKEN'),
  audioEnabled: envBool('WATCH_AUDIO_ENABLED', true),
  videoEnabled: envBool('WATCH_VIDEO_ENABLED', true),
  audioSampleRate: envInt('WATCH_AUDIO_SAMPLE_RATE', 16000),
  audioChannels: envInt('WATCH_AUDIO_CHANNELS', 1),
  audioFrameMs: envInt('WATCH_AUDIO_FRAME_MS', 20),
  videoMode: envString('WATCH_VIDEO_MODE', 'jpeg'),
  videoWidth: envInt('WATCH_VIDEO_WIDTH', 160),
  videoHeight: envOptionalInt('WATCH_VIDEO_HEIGHT'),
  videoResizeMode: normalizeResizeMode(envString('WATCH_VIDEO_RESIZE_MODE', 'fit')),
  videoCropTop: envInt('WATCH_VIDEO_CROP_TOP', 0),
  videoFps: envInt('WATCH_VIDEO_FPS', 8),
  jpegQuality: envInt('WATCH_JPEG_QUALITY', 55),
};

let relay;
let room;
let audioSource;
let audioSequence = 0;
let videoSequence = 0;
let shuttingDown = false;

main().catch((error) => {
  console.error(error);
  process.exitCode = 1;
});

async function main() {
  if (!['jpeg', 'png'].includes(config.videoMode)) {
    throw new Error('The Node media bridge only supports WATCH_VIDEO_MODE=jpeg or png. Use the default .NET bridge for fMP4 video modes.');
  }

  relay = await connectRelay(config.ingestUrl);
  sendJson({ type: 'bridge-starting' });

  room = new Room();
  room.on(RoomEvent.Disconnected, (reason) => {
    sendJson({ type: 'livekit-disconnected', reason: String(reason ?? '') });
    closeSoon();
  });
  room.on(RoomEvent.TrackSubscribed, (track, publication, participant) => {
    if (track instanceof RemoteAudioTrack && config.audioEnabled) {
      void consumeAudioTrack(track, participant?.identity ?? 'unknown');
    }

    if (track instanceof RemoteVideoTrack && config.videoEnabled) {
      void consumeVideoTrack(track, participant?.identity ?? 'unknown');
    }
  });

  await room.connect(config.liveKitUrl, config.liveKitToken, { autoSubscribe: true });
  sendJson({ type: 'livekit-connected' });

  await publishWatchMicrophoneTrack();
  sendJson({
    type: 'bridge-ready',
    audio: {
      codec: 'pcm_s16le',
      sampleRate: config.audioSampleRate,
      channels: config.audioChannels,
      frameMs: config.audioFrameMs,
    },
    video: {
      codec: config.videoMode,
      container: 'image',
      width: config.videoWidth,
      height: config.videoHeight,
      resizeMode: config.videoResizeMode,
      cropTop: config.videoCropTop,
      fps: config.videoFps,
      quality: config.jpegQuality,
    },
  });
}

async function publishWatchMicrophoneTrack() {
  audioSource = new AudioSource(config.audioSampleRate, config.audioChannels);
  const track = LocalAudioTrack.createAudioTrack('watch-microphone', audioSource);
  const publication = await room.localParticipant.publishTrack(
    track,
    new TrackPublishOptions({
      source: TrackSource.SOURCE_MICROPHONE,
      dtx: true,
    }),
  );

  sendJson({ type: 'watch-microphone-published', trackSid: publication.sid });
}

async function consumeAudioTrack(track, participantIdentity) {
  sendJson({ type: 'avatar-audio-subscribed', participantIdentity });
  const stream = new AudioStream(track, {
    sampleRate: config.audioSampleRate,
    numChannels: config.audioChannels,
    frameSizeMs: config.audioFrameMs,
  });

  try {
    for await (const frame of stream) {
      if (shuttingDown || !isRelayOpen()) {
        break;
      }

      const payload = Buffer.from(frame.data.buffer, frame.data.byteOffset, frame.data.byteLength);
      sendBinaryFrame({
        kind: KIND_AVATAR_AUDIO,
        sequence: audioSequence++,
        timestampUs: nowUs(),
        arg0: frame.sampleRate,
        arg1: frame.channels,
        payload,
      });
    }
  } catch (error) {
    sendJson({ type: 'avatar-audio-error', message: errorMessage(error) });
  }
}

async function consumeVideoTrack(track, participantIdentity) {
  sendJson({ type: 'avatar-video-subscribed', participantIdentity });
  const stream = new VideoStream(track);
  const minFrameIntervalMs = 1000 / config.videoFps;
  let lastFrameAt = 0;
  let alphaProbeSent = false;

  try {
    for await (const event of stream) {
      if (shuttingDown || !isRelayOpen()) {
        break;
      }

      const now = Date.now();
      if (now - lastFrameAt < minFrameIntervalMs) {
        continue;
      }

      lastFrameAt = now;
      const rgba = event.frame.convert(VideoBufferType.RGBA);
      const rgbaBuffer = Buffer.from(rgba.data);
      if (!alphaProbeSent) {
        sendAlphaProbe(rgbaBuffer, rgba.width, rgba.height, participantIdentity);
        alphaProbeSent = true;
      }

      const image = sharp(rgbaBuffer, {
        raw: {
          width: rgba.width,
          height: rgba.height,
          channels: 4,
        },
      })
        .resize({
          width: config.videoWidth,
          height: config.videoHeight ?? undefined,
          fit: toSharpFit(config.videoResizeMode),
          background: { r: 0, g: 0, b: 0, alpha: config.videoMode === 'png' ? 0 : 1 },
          withoutEnlargement: false,
        });
      if (config.videoCropTop > 0 && config.videoHeight) {
        image
          .extract({
            left: 0,
            top: Math.min(config.videoCropTop, config.videoHeight - 1),
            width: config.videoWidth,
            height: Math.max(1, config.videoHeight - config.videoCropTop),
          })
          .resize({
            width: config.videoWidth,
            height: config.videoHeight,
            fit: 'fill',
          });
      }

      const encoded = config.videoMode === 'png'
        ? await image.png({ compressionLevel: 9 }).toBuffer({ resolveWithObject: true })
        : await image.jpeg({ quality: config.jpegQuality, mozjpeg: true }).toBuffer({ resolveWithObject: true });

      sendBinaryFrame({
        kind: config.videoMode === 'png' ? KIND_AVATAR_PNG : KIND_AVATAR_JPEG,
        sequence: videoSequence++,
        timestampUs: typeof event.timestampUs === 'bigint' ? event.timestampUs : nowUs(),
        arg0: encoded.info.width,
        arg1: encoded.info.height,
        payload: encoded.data,
      });
    }
  } catch (error) {
    sendJson({ type: 'avatar-video-error', message: errorMessage(error) });
  }
}

function sendAlphaProbe(rgba, width, height, participantIdentity) {
  let min = 255;
  let max = 0;
  let transparentPixels = 0;
  let translucentPixels = 0;
  let opaquePixels = 0;

  for (let index = 3; index < rgba.length; index += 4) {
    const alpha = rgba[index];
    min = Math.min(min, alpha);
    max = Math.max(max, alpha);
    if (alpha === 0) {
      transparentPixels++;
    } else if (alpha === 255) {
      opaquePixels++;
    } else {
      translucentPixels++;
    }
  }

  sendJson({
    type: 'avatar-video-alpha-probe',
    participantIdentity,
    width,
    height,
    min,
    max,
    transparentPixels,
    translucentPixels,
    opaquePixels,
    totalPixels: transparentPixels + translucentPixels + opaquePixels,
    hasTransparency: transparentPixels > 0 || translucentPixels > 0,
  });
}

async function handleWatchAudioFrame(buffer) {
  if (!audioSource) {
    return;
  }

  const header = parseFrameHeader(buffer);
  if (!header || header.kind !== KIND_WATCH_AUDIO) {
    return;
  }

  const payload = buffer.subarray(FRAME_HEADER_BYTES);
  const data = new Int16Array(payload.buffer, payload.byteOffset, payload.byteLength / 2);
  const samplesPerChannel = data.length / header.arg1;
  const frame = new AudioFrame(data, header.arg0, header.arg1, samplesPerChannel);
  await audioSource.captureFrame(frame);
}

function connectRelay(url) {
  return new Promise((resolve, reject) => {
    const socket = new WebSocket(url);
    socket.binaryType = 'nodebuffer';
    socket.once('open', () => resolve(socket));
    socket.once('error', reject);
    socket.on('close', () => closeSoon());
    socket.on('message', (data, isBinary) => {
      if (!isBinary) {
        return;
      }

      handleWatchAudioFrame(Buffer.from(data)).catch((error) => {
        sendJson({ type: 'watch-audio-error', message: errorMessage(error) });
      });
    });
  });
}

function sendBinaryFrame({ kind, sequence, timestampUs, arg0, arg1, payload }) {
  if (!isRelayOpen()) {
    return;
  }

  const header = Buffer.alloc(FRAME_HEADER_BYTES);
  header.writeUInt8(kind, 0);
  header.writeUInt8(1, 1);
  header.writeUInt16LE(FRAME_HEADER_BYTES, 2);
  header.writeUInt32LE(sequence >>> 0, 4);
  header.writeBigUInt64LE(BigInt(timestampUs), 8);
  header.writeUInt32LE(payload.byteLength >>> 0, 16);
  header.writeUInt16LE(arg0, 20);
  header.writeUInt16LE(arg1, 22);
  relay.send(Buffer.concat([header, payload]), { binary: true });
}

function parseFrameHeader(buffer) {
  if (buffer.byteLength < FRAME_HEADER_BYTES) {
    return null;
  }

  const headerBytes = buffer.readUInt16LE(2);
  if (headerBytes !== FRAME_HEADER_BYTES) {
    return null;
  }

  const payloadLength = buffer.readUInt32LE(16);
  if (payloadLength !== buffer.byteLength - FRAME_HEADER_BYTES) {
    return null;
  }

  return {
    kind: buffer.readUInt8(0),
    version: buffer.readUInt8(1),
    sequence: buffer.readUInt32LE(4),
    timestampUs: buffer.readBigUInt64LE(8),
    payloadLength,
    arg0: buffer.readUInt16LE(20),
    arg1: buffer.readUInt16LE(22),
  };
}

function sendJson(value) {
  if (isRelayOpen()) {
    relay.send(JSON.stringify(value));
  }
}

function isRelayOpen() {
  return relay?.readyState === WebSocket.OPEN;
}

function closeSoon() {
  if (shuttingDown) {
    return;
  }

  shuttingDown = true;
  setTimeout(() => {
    room?.disconnect().catch(() => {});
    relay?.close();
    process.exit(0);
  }, 25).unref();
}

function requireEnv(name) {
  const value = process.env[name];
  if (!value) {
    throw new Error(`Missing ${name}.`);
  }

  return value;
}

function envBool(name, fallback) {
  const value = process.env[name];
  return value == null ? fallback : value.toLowerCase() === 'true';
}

function envString(name, fallback) {
  return process.env[name] || fallback;
}

function envInt(name, fallback) {
  const value = process.env[name];
  return value == null ? fallback : Number.parseInt(value, 10);
}

function envOptionalInt(name) {
  const value = process.env[name];
  return value == null || value.length === 0 ? null : Number.parseInt(value, 10);
}

function normalizeResizeMode(value) {
  switch (value.trim().toLowerCase()) {
    case 'fit':
    case 'contain':
    case 'pad':
    case 'letterbox':
      return 'fit';
    case 'cover':
    case 'crop':
      return 'cover';
    case 'stretch':
    case 'fill':
      return 'stretch';
    default:
      throw new Error(`Unsupported WATCH_VIDEO_RESIZE_MODE '${value}'. Use fit, cover, or stretch.`);
  }
}

function toSharpFit(value) {
  switch (value) {
    case 'fit':
      return 'contain';
    case 'cover':
      return 'cover';
    case 'stretch':
      return 'fill';
    default:
      return 'contain';
  }
}

function nowUs() {
  return BigInt(Date.now()) * 1000n;
}

function errorMessage(error) {
  return error instanceof Error ? error.message : String(error);
}

process.on('SIGTERM', closeSoon);
process.on('SIGINT', closeSoon);
