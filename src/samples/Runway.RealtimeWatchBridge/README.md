# Runway Realtime Watch Bridge

This sample is for watchOS clients that cannot use WebRTC directly.

ASP.NET Core creates and consumes a Runway realtime avatar session. A local C# media bridge joins the returned LiveKit room with `Livekit.Rtc.Dotnet`, publishes watch microphone audio into that room, and forwards avatar audio/video back through ASP.NET Core over a private WebSocket. The watch connects to ASP.NET Core with a separate WebSocket.

## Setup

```bash
cd src/samples/Runway.RealtimeWatchBridge
RUNWAY_API_KEY=... ASPNETCORE_URLS=http://127.0.0.1:5088 dotnet run
```

Do not paste API keys into source files. Use `RUNWAY_API_KEY`, `RUNWAYML_API_SECRET`, or a `.env` file in this directory or a parent directory.

The default media bridge is pure .NET and uses the sibling `Runway.RealtimeWatchBridge.MediaBridge` project. Build the full solution first if you want session startup to avoid the first-run `dotnet run --project` build cost:

```bash
dotnet build ../../../Runway.slnx
```

Set `RUNWAY_WATCH_BRIDGE_RUNTIME=node` to use the Node bridge in `media-bridge/` instead. The Node bridge requires `npm install` in that folder.

Install FFmpeg if you want encoded video modes:

```bash
brew install ffmpeg
```

## Create A Session

```bash
curl -X POST http://127.0.0.1:5088/sessions \
  -H 'content-type: application/json' \
  -d '{
    "presetAvatar": "influencer",
    "maxDurationSeconds": 300,
    "watchAudioSampleRate": 16000,
    "watchAudioChannels": 1,
    "watchAudioFrameMs": 20,
    "watchVideoMode": "jpeg",
    "watchVideoEncoder": "software",
    "watchVideoWidth": 160,
    "watchVideoCropTop": 0,
    "watchVideoFps": 8,
    "watchJpegQuality": 55,
    "watchVideoBitrateKbps": 180,
    "watchFmp4FragmentMs": 500
  }'
```

The response contains `watchWebSocketUrl`. Connect the watch to that URL.

`watchVideoMode` supports:

| Mode | Payload | Notes |
|---|---|---|
| `jpeg` | Individual JPEG images, kind `2`. | Simplest watchOS path and no FFmpeg required. |
| `png` | Individual PNG images, kind `4`. | Preserves alpha if the source video track contains alpha; higher bandwidth than JPEG/H.264. |
| `h264-fmp4` | Fragmented MP4 byte stream with H.264, kind `3`. | Better bandwidth and the recommended encoded mode. |
| `h265-fmp4` | Fragmented MP4 byte stream with H.265/HEVC, kind `3`. | Smaller at the same quality, but only use when the server FFmpeg build and watch client can decode it. |

For fMP4 modes, the .NET media bridge starts FFmpeg and sends each output chunk as a kind `3` binary frame. Set `FFMPEG_BINARY` if `ffmpeg` is not on `PATH`.

Set `watchVideoCropTop` when the generated avatar frame includes an unwanted top border. The bridge crops that many output pixels from the top after resize, then scales back to the requested dimensions so watchOS layout stays stable.

`watchVideoEncoder` supports:

| Encoder | FFmpeg codec | Notes |
|---|---|---|
| `software` | `libx264` or `libx265` | Portable default. Uses CPU. |
| `videotoolbox` | `h264_videotoolbox` or `hevc_videotoolbox` | macOS hardware encoder path. Lower CPU, but requires an FFmpeg build with VideoToolbox encoders. |

Example H.264 hardware encoding request:

```json
{
  "presetAvatar": "influencer",
  "watchVideoMode": "h264-fmp4",
  "watchVideoEncoder": "videotoolbox",
  "watchVideoWidth": 160,
  "watchVideoFps": 8,
  "watchVideoBitrateKbps": 180,
  "watchFmp4FragmentMs": 500
}
```

Check encoder availability on the host:

```bash
ffmpeg -hide_banner -encoders | grep videotoolbox
```

## Encoder Benchmarking

For AWS Fargate on Linux ARM64, benchmark the software encoders. VideoToolbox is a macOS framework and will not be available in a normal Linux Fargate task.

Run this inside the same container image, ECS task, or matching Linux ARM64 host:

```bash
FFMPEG_BINARY=/app/Resources/Tools/ffmpeg/linux-arm64/ffmpeg \
ENCODERS="h264-software h265-software" \
DURATION_SECONDS=60 \
WIDTH=160 \
HEIGHT=90 \
FPS=8 \
BITRATE_KBPS=180 \
bash scripts/benchmark-video-encoders.sh
```

For local macOS comparison:

```bash
ENCODERS="h264-software h265-software h264-videotoolbox h265-videotoolbox" \
DURATION_SECONDS=60 \
bash scripts/benchmark-video-encoders.sh
```

Use the CSV output to compare elapsed time and output bytes. On ECS, also compare CloudWatch `CPUUtilization` and `MemoryUtilization` while the benchmark or live bridge is running. If one realtime avatar session pushes sustained CPU above roughly 70% on a 1 vCPU task, test 2 vCPU before scaling session concurrency.

## Binary Protocol

All binary frames use a 24-byte little-endian header:

| Offset | Type | Meaning |
|---:|---|---|
| 0 | `uint8` | Kind |
| 1 | `uint8` | Protocol version, currently `1` |
| 2 | `uint16` | Header bytes, currently `24` |
| 4 | `uint32` | Sequence |
| 8 | `uint64` | Timestamp in microseconds |
| 16 | `uint32` | Payload bytes |
| 20 | `uint16` | `arg0` |
| 22 | `uint16` | `arg1` |

Frame kinds:

| Kind | Direction | Payload |
|---:|---|---|
| `1` | backend -> watch | Avatar audio, PCM signed 16-bit little-endian. `arg0=sampleRate`, `arg1=channels`. |
| `2` | backend -> watch | Avatar video, JPEG. `arg0=width`, `arg1=height`. |
| `3` | backend -> watch | Avatar video, fragmented MP4 byte stream. `arg0=1` for H.264, `arg0=2` for H.265. Concatenate payloads in sequence order. |
| `4` | backend -> watch | Avatar video, PNG. `arg0=width`, `arg1=height`. This preserves alpha only when the upstream avatar track has non-opaque alpha. |
| `17` | watch -> backend | Watch microphone audio, PCM signed 16-bit little-endian. `arg0=sampleRate`, `arg1=channels`. |

Text WebSocket messages are JSON status/control messages such as `bridge-ready`, `avatar-audio-subscribed`, `avatar-video-subscribed`, and `avatar-video-alpha-probe`. The alpha probe reports the first RGBA frame's alpha range so clients can detect whether transparent avatar output is actually available.

## watchOS Notes

Capture mic audio as mono PCM16 at 16 kHz if possible, package each 20 ms chunk as kind `17`, and send it as binary WebSocket data. For output, schedule kind `1` PCM frames into `AVAudioPlayerNode`. Decode kind `2` JPEG frames into an image view only at the UI rate you can afford.

For kind `3`, concatenate payloads into a single fMP4 stream and feed that stream to an AVFoundation pipeline that can consume fragmented MP4. H.264 is the safer default for compatibility. H.265/HEVC can reduce bandwidth further, but test it on the exact watch models you plan to support.
