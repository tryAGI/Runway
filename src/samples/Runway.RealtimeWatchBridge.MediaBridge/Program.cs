using System.Buffers;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Globalization;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using LiveKit.Proto;
using LiveKit.Rtc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;


var config = BridgeConfig.FromEnvironment();
using var shutdown = new CancellationTokenSource();

Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    shutdown.Cancel();
};

var bridge = new WatchMediaBridge(config);
await bridge.RunAsync(shutdown.Token);

internal sealed class WatchMediaBridge(BridgeConfig config) : IAsyncDisposable
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    private readonly ClientWebSocket _relay = new();
    private readonly SemaphoreSlim _relaySendLock = new(1, 1);
    private readonly Room _room = new();
    private readonly object _disposeLock = new();
    private CancellationTokenSource? _runCancellation;
    private AudioSource? _audioSource;
    private int _audioSequence;
    private int _videoSequence;
    private bool _disposed;

    public async Task RunAsync(CancellationToken cancellationToken)
    {
        using var runCancellation = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        _runCancellation = runCancellation;

        RegisterRoomEvents(runCancellation.Token);

        try
        {
            await _relay.ConnectAsync(new Uri(config.IngestUrl), runCancellation.Token);
            await SendJsonAsync(new { type = "bridge-starting", runtime = "dotnet" }, runCancellation.Token);

            var relayReceiveTask = ReceiveRelayAsync(runCancellation.Token);

            await _room.ConnectAsync(
                config.LiveKitUrl,
                config.LiveKitToken,
                new LiveKit.Rtc.RoomOptions { AutoSubscribe = true },
                runCancellation.Token);
            await SendJsonAsync(new { type = "livekit-connected" }, runCancellation.Token);

            if (config.AudioEnabled)
            {
                await PublishWatchMicrophoneTrackAsync(runCancellation.Token);
            }

            await SendJsonAsync(new
            {
                type = "bridge-ready",
                runtime = "dotnet",
                audio = new
                {
                    codec = "pcm_s16le",
                    sampleRate = config.AudioSampleRate,
                    channels = config.AudioChannels,
                    frameMs = config.AudioFrameMs,
                },
                video = new
                {
                    codec = config.VideoMode.ToCodecName(),
                    container = config.VideoMode.ToContainerName(),
                    encoder = config.VideoEncoder.ToName(),
                    width = config.VideoWidth,
                    height = config.VideoHeight,
                    resizeMode = config.VideoResizeMode.ToName(),
                    cropTop = config.VideoCropTop,
                    fps = config.VideoFps,
                    quality = config.JpegQuality,
                    bitrateKbps = config.VideoBitrateKbps,
                    fragmentMs = config.Fmp4FragmentMs,
                },
            }, runCancellation.Token);

            await relayReceiveTask;
        }
        catch (OperationCanceledException) when (runCancellation.IsCancellationRequested)
        {
        }
        finally
        {
            await DisposeAsync();
        }
    }

    public async ValueTask DisposeAsync()
    {
        lock (_disposeLock)
        {
            if (_disposed)
            {
                return;
            }

            _disposed = true;
        }

        _runCancellation?.Cancel();
        _audioSource?.Dispose();
        _room.Disconnect();
        _room.Dispose();
        _relaySendLock.Dispose();

        if (_relay.State is WebSocketState.Open or WebSocketState.CloseReceived)
        {
            try
            {
                await _relay.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bridge stopped.", CancellationToken.None);
            }
            catch (WebSocketException)
            {
            }
        }

        _relay.Dispose();
    }

    private void RegisterRoomEvents(CancellationToken cancellationToken)
    {
        _room.Disconnected += (_, reason) =>
        {
            _ = SendJsonBestEffortAsync(new { type = "livekit-disconnected", reason = reason.ToString() });
            _runCancellation?.Cancel();
        };

        _room.TrackSubscribed += (_, e) =>
        {
            if (e.Track is RemoteAudioTrack audioTrack && config.AudioEnabled)
            {
                _ = Task.Run(
                    () => ConsumeAudioTrackAsync(audioTrack, e.Participant.Identity, cancellationToken),
                    cancellationToken);
            }

            if (e.Track is RemoteVideoTrack videoTrack && config.VideoEnabled)
            {
                _ = Task.Run(
                    () => ConsumeVideoTrackAsync(videoTrack, e.Participant.Identity, cancellationToken),
                    cancellationToken);
            }
        };
    }

    private async Task PublishWatchMicrophoneTrackAsync(CancellationToken cancellationToken)
    {
        if (_room.LocalParticipant is not { } localParticipant)
        {
            throw new InvalidOperationException("LiveKit local participant is unavailable.");
        }

        _audioSource = new AudioSource(config.AudioSampleRate, config.AudioChannels);
        var track = LocalAudioTrack.Create("watch-microphone", _audioSource);
        var publication = await localParticipant.PublishTrackAsync(
            track,
            new LiveKit.Rtc.TrackPublishOptions { Source = TrackSource.SourceMicrophone },
            cancellationToken);

        await SendJsonAsync(new { type = "watch-microphone-published", trackSid = publication.Sid }, cancellationToken);
    }

    private async Task ReceiveRelayAsync(CancellationToken cancellationToken)
    {
        var buffer = ArrayPool<byte>.Shared.Rent(64 * 1024);
        try
        {
            while (_relay.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
            {
                await using var stream = new MemoryStream();
                WebSocketReceiveResult result;
                do
                {
                    result = await _relay.ReceiveAsync(buffer, cancellationToken);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        _runCancellation?.Cancel();
                        return;
                    }

                    stream.Write(buffer.AsSpan(0, result.Count));
                }
                while (!result.EndOfMessage);

                if (result.MessageType == WebSocketMessageType.Binary)
                {
                    await HandleWatchAudioFrameAsync(stream.ToArray(), cancellationToken);
                }
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
        }
        catch (WebSocketException exception)
        {
            await SendJsonBestEffortAsync(new { type = "relay-error", message = exception.Message });
            _runCancellation?.Cancel();
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    private async Task HandleWatchAudioFrameAsync(byte[] message, CancellationToken cancellationToken)
    {
        if (_audioSource is null ||
            !TryParseFrameHeader(message, out var header) ||
            header.Kind != BridgeProtocol.KindWatchAudio ||
            header.Arg1 == 0)
        {
            return;
        }

        var payload = message.AsSpan(BridgeProtocol.FrameHeaderBytes).ToArray();
        var samplesPerChannel = payload.Length / sizeof(short) / header.Arg1;
        if (samplesPerChannel <= 0)
        {
            return;
        }

        var frame = new AudioFrame(payload, header.Arg0, header.Arg1, samplesPerChannel);
        await _audioSource.CaptureFrameAsync(frame, cancellationToken);
    }

    private async Task ConsumeAudioTrackAsync(
        RemoteAudioTrack track,
        string participantIdentity,
        CancellationToken cancellationToken)
    {
        await SendJsonAsync(new { type = "avatar-audio-subscribed", participantIdentity }, cancellationToken);

        try
        {
            using var stream = new AudioStream(
                track,
                (uint)config.AudioSampleRate,
                (uint)config.AudioChannels,
                (uint)config.AudioFrameMs);

            await foreach (var frameEvent in stream.WithCancellation(cancellationToken))
            {
                var frame = frameEvent.Frame;
                await SendBinaryFrameAsync(
                    kind: BridgeProtocol.KindAvatarAudio,
                    sequence: NextSequence(ref _audioSequence),
                    timestampUs: NowUs(),
                    arg0: (ushort)frame.SampleRate,
                    arg1: (ushort)frame.NumChannels,
                    payload: frame.DataBytes,
                    cancellationToken);
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
        }
        catch (Exception exception)
        {
            await SendJsonBestEffortAsync(new { type = "avatar-audio-error", message = exception.Message });
        }
    }

    private async Task ConsumeVideoTrackAsync(
        RemoteVideoTrack track,
        string participantIdentity,
        CancellationToken cancellationToken)
    {
        await SendJsonAsync(new { type = "avatar-video-subscribed", participantIdentity }, cancellationToken);

        if (config.VideoMode is BridgeVideoMode.H264Fmp4 or BridgeVideoMode.H265Fmp4)
        {
            await ConsumeFmp4VideoTrackAsync(track, participantIdentity, cancellationToken);
            return;
        }

        var minFrameInterval = TimeSpan.FromSeconds(1d / config.VideoFps);
        long lastFrameAt = 0;
        var alphaProbeSent = false;

        try
        {
            using var stream = new VideoStream(track, VideoBufferType.Rgba);
            await foreach (var frameEvent in stream.WithCancellation(cancellationToken))
            {
                var now = Stopwatch.GetTimestamp();
                if (lastFrameAt != 0 && Stopwatch.GetElapsedTime(lastFrameAt, now) < minFrameInterval)
                {
                    continue;
                }

                lastFrameAt = now;
                if (!alphaProbeSent)
                {
                    await SendVideoAlphaProbeAsync(frameEvent.Frame, participantIdentity, cancellationToken);
                    alphaProbeSent = true;
                }

                var encoded = await EncodeImageAsync(frameEvent.Frame, cancellationToken);
                await SendBinaryFrameAsync(
                    kind: config.VideoMode.ToProtocolFrameKind(),
                    sequence: NextSequence(ref _videoSequence),
                    timestampUs: NowUs(),
                    arg0: (ushort)encoded.Width,
                    arg1: (ushort)encoded.Height,
                    payload: encoded.Payload,
                    cancellationToken);
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
        }
        catch (Exception exception)
        {
            await SendJsonBestEffortAsync(new { type = "avatar-video-error", message = exception.Message });
        }
    }

    private async Task ConsumeFmp4VideoTrackAsync(
        RemoteVideoTrack track,
        string participantIdentity,
        CancellationToken cancellationToken)
    {
        var minFrameInterval = TimeSpan.FromSeconds(1d / config.VideoFps);
        long lastFrameAt = 0;
        Fmp4VideoEncoder? encoder = null;
        var alphaProbeSent = false;

        try
        {
            using var stream = new VideoStream(track, VideoBufferType.Rgba);
            await foreach (var frameEvent in stream.WithCancellation(cancellationToken))
            {
                var now = Stopwatch.GetTimestamp();
                if (lastFrameAt != 0 && Stopwatch.GetElapsedTime(lastFrameAt, now) < minFrameInterval)
                {
                    continue;
                }

                lastFrameAt = now;
                var videoFrameTimestampUs = NowUs();
                if (!alphaProbeSent)
                {
                    await SendVideoAlphaProbeAsync(frameEvent.Frame, participantIdentity, cancellationToken);
                    alphaProbeSent = true;
                }

                var resized = ResizeRgbaFrame(frameEvent.Frame, config, encoder?.Height);
                if (encoder is null)
                {
                    await SendJsonAsync(new
                    {
                        type = "avatar-video-fmp4-started",
                        participantIdentity,
                        codec = config.VideoMode.ToCodecName(),
                        container = "fmp4",
                        encoder = config.VideoEncoder.ToName(),
                        width = resized.Width,
                        height = resized.Height,
                        fps = config.VideoFps,
                        bitrateKbps = config.VideoBitrateKbps,
                        fragmentMs = config.Fmp4FragmentMs,
                    }, cancellationToken);

                    encoder = await Fmp4VideoEncoder.StartAsync(
                        config,
                        resized.Width,
                        resized.Height,
                        videoFrameTimestampUs,
                        resized.Payload,
                        SendFmp4ChunkAsync,
                        SendJsonBestEffortAsync,
                        cancellationToken);
                    continue;
                }

                await encoder.WriteFrameAsync(resized.Payload, cancellationToken);
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
        }
        catch (Exception exception)
        {
            await SendJsonBestEffortAsync(new { type = "avatar-video-fmp4-error", message = exception.Message });
        }
        finally
        {
            if (encoder is not null)
            {
                await encoder.DisposeAsync();
            }
        }
    }

    private async Task<EncodedImage> EncodeImageAsync(
        VideoFrame frame,
        CancellationToken cancellationToken)
    {
        var rgbaFrame = frame.Type == VideoBufferType.Rgba
            ? frame
            : frame.Convert(VideoBufferType.Rgba, flipY: false);

        using var image = Image.LoadPixelData<Rgba32>(rgbaFrame.DataBytes, rgbaFrame.Width, rgbaFrame.Height);
        ResizeImageForWatch(image, config, lockedHeight: null, requireEvenDimensions: false);

        await using var output = new MemoryStream();
        if (config.VideoMode == BridgeVideoMode.Png)
        {
            await image.SaveAsPngAsync(
                output,
                new PngEncoder
                {
                    ColorType = PngColorType.RgbWithAlpha,
                    CompressionLevel = PngCompressionLevel.BestCompression,
                },
                cancellationToken);
        }
        else
        {
            await image.SaveAsJpegAsync(output, new JpegEncoder { Quality = config.JpegQuality }, cancellationToken);
        }

        return new EncodedImage(image.Width, image.Height, output.ToArray());
    }

    private async Task SendVideoAlphaProbeAsync(
        VideoFrame frame,
        string participantIdentity,
        CancellationToken cancellationToken)
    {
        var rgbaFrame = frame.Type == VideoBufferType.Rgba
            ? frame
            : frame.Convert(VideoBufferType.Rgba, flipY: false);
        var alpha = AlphaStats.FromRgba(rgbaFrame.DataBytes);

        await SendJsonAsync(new
        {
            type = "avatar-video-alpha-probe",
            participantIdentity,
            width = rgbaFrame.Width,
            height = rgbaFrame.Height,
            alpha.Min,
            alpha.Max,
            alpha.TransparentPixels,
            alpha.TranslucentPixels,
            alpha.OpaquePixels,
            alpha.TotalPixels,
            hasTransparency = alpha.TransparentPixels > 0 || alpha.TranslucentPixels > 0,
        }, cancellationToken);
    }

    private static EncodedImage ResizeRgbaFrame(
        VideoFrame frame,
        BridgeConfig config,
        int? lockedHeight = null)
    {
        var rgbaFrame = frame.Type == VideoBufferType.Rgba
            ? frame
            : frame.Convert(VideoBufferType.Rgba, flipY: false);

        using var image = Image.LoadPixelData<Rgba32>(rgbaFrame.DataBytes, rgbaFrame.Width, rgbaFrame.Height);
        ResizeImageForWatch(image, config, lockedHeight, requireEvenDimensions: true);

        var output = new byte[image.Width * image.Height * 4];
        image.CopyPixelDataTo(output);
        return new EncodedImage(image.Width, image.Height, output);
    }

    private static void ResizeImageForWatch(
        Image<Rgba32> image,
        BridgeConfig config,
        int? lockedHeight,
        bool requireEvenDimensions)
    {
        var targetWidth = requireEvenDimensions ? MakeEven(config.VideoWidth) : config.VideoWidth;
        var explicitHeight = config.VideoHeight ?? lockedHeight;

        if (explicitHeight is null)
        {
            var targetHeight = Math.Max(
                requireEvenDimensions ? 2 : 1,
                (int)Math.Round(image.Height * (targetWidth / (double)image.Width)));
            if (requireEvenDimensions)
            {
                targetHeight = MakeEven(targetHeight);
            }

            image.Mutate(context => context.Resize(targetWidth, targetHeight));
            ApplyOutputCrop(image, config);
            return;
        }

        var fixedHeight = requireEvenDimensions ? MakeEven(explicitHeight.Value) : explicitHeight.Value;
        if (config.VideoHeight is null)
        {
            image.Mutate(context => context.Resize(targetWidth, fixedHeight));
            ApplyOutputCrop(image, config);
            return;
        }

        image.Mutate(context => context.Resize(new ResizeOptions
        {
            Size = new Size(targetWidth, fixedHeight),
            Mode = config.VideoResizeMode.ToImageSharpResizeMode(),
            Position = AnchorPositionMode.Center,
            PadColor = config.VideoMode == BridgeVideoMode.Png ? Color.Transparent : Color.Black,
        }));
        ApplyOutputCrop(image, config);
    }

    private static void ApplyOutputCrop(Image<Rgba32> image, BridgeConfig config)
    {
        if (config.VideoCropTop <= 0)
        {
            return;
        }

        var cropTop = Math.Min(config.VideoCropTop, image.Height - 1);
        var targetSize = image.Size;
        image.Mutate(context => context
            .Crop(new Rectangle(0, cropTop, image.Width, image.Height - cropTop))
            .Resize(targetSize));
    }

    private Task SendFmp4ChunkAsync(
        byte[] payload,
        BridgeVideoMode videoMode,
        long timestampUs,
        CancellationToken cancellationToken)
    {
        return SendBinaryFrameAsync(
            kind: BridgeProtocol.KindAvatarFmp4,
            sequence: NextSequence(ref _videoSequence),
            timestampUs: timestampUs,
            arg0: videoMode.ToProtocolCodecId(),
            arg1: 0,
            payload: payload,
            cancellationToken);
    }

    private async Task SendBinaryFrameAsync(
        byte kind,
        uint sequence,
        long timestampUs,
        ushort arg0,
        ushort arg1,
        byte[] payload,
        CancellationToken cancellationToken)
    {
        if (_relay.State != WebSocketState.Open)
        {
            return;
        }

        var frame = new byte[BridgeProtocol.FrameHeaderBytes + payload.Length];
        frame[0] = kind;
        frame[1] = BridgeProtocol.ProtocolVersion;
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(2), BridgeProtocol.FrameHeaderBytes);
        BinaryPrimitives.WriteUInt32LittleEndian(frame.AsSpan(4), sequence);
        BinaryPrimitives.WriteUInt64LittleEndian(frame.AsSpan(8), (ulong)timestampUs);
        BinaryPrimitives.WriteUInt32LittleEndian(frame.AsSpan(16), (uint)payload.Length);
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(20), arg0);
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(22), arg1);
        payload.CopyTo(frame.AsSpan(BridgeProtocol.FrameHeaderBytes));

        await SendAsync(frame, WebSocketMessageType.Binary, cancellationToken);
    }

    private async Task SendJsonAsync(object value, CancellationToken cancellationToken)
    {
        var payload = JsonSerializer.SerializeToUtf8Bytes(value, JsonOptions);
        await SendAsync(payload, WebSocketMessageType.Text, cancellationToken);
    }

    private async Task SendJsonBestEffortAsync(object value)
    {
        try
        {
            await SendJsonAsync(value, CancellationToken.None);
        }
        catch (Exception exception) when (exception is WebSocketException or ObjectDisposedException or InvalidOperationException)
        {
        }
    }

    private async Task SendAsync(
        byte[] payload,
        WebSocketMessageType messageType,
        CancellationToken cancellationToken)
    {
        if (_relay.State != WebSocketState.Open)
        {
            return;
        }

        await _relaySendLock.WaitAsync(cancellationToken);
        try
        {
            await _relay.SendAsync(payload, messageType, WebSocketMessageFlags.EndOfMessage, cancellationToken);
        }
        finally
        {
            _relaySendLock.Release();
        }
    }

    private static bool TryParseFrameHeader(byte[] buffer, out FrameHeader header)
    {
        header = default;
        if (buffer.Length < BridgeProtocol.FrameHeaderBytes)
        {
            return false;
        }

        var headerBytes = BinaryPrimitives.ReadUInt16LittleEndian(buffer.AsSpan(2));
        if (headerBytes != BridgeProtocol.FrameHeaderBytes)
        {
            return false;
        }

        var payloadLength = BinaryPrimitives.ReadUInt32LittleEndian(buffer.AsSpan(16));
        if (payloadLength != buffer.Length - BridgeProtocol.FrameHeaderBytes)
        {
            return false;
        }

        header = new FrameHeader(
            Kind: buffer[0],
            Version: buffer[1],
            PayloadLength: payloadLength,
            Arg0: BinaryPrimitives.ReadUInt16LittleEndian(buffer.AsSpan(20)),
            Arg1: BinaryPrimitives.ReadUInt16LittleEndian(buffer.AsSpan(22)));
        return header.Version == BridgeProtocol.ProtocolVersion;
    }

    private static uint NextSequence(ref int sequence)
    {
        return unchecked((uint)Interlocked.Increment(ref sequence) - 1u);
    }

    private static long NowUs()
    {
        return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1000;
    }

    private static int MakeEven(int value)
    {
        return value % 2 == 0 ? value : value + 1;
    }
}

internal sealed class Fmp4VideoEncoder : IAsyncDisposable
{
    private readonly BridgeConfig _config;
    private readonly Func<byte[], BridgeVideoMode, long, CancellationToken, Task> _sendChunkAsync;
    private readonly Func<object, Task> _sendStatusAsync;
    private readonly CancellationTokenSource _cancellation = new();
    private readonly CancellationTokenSource _inputCancellation = new();
    private readonly object _frameLock = new();
    private readonly Process _process;
    private readonly Task _inputTask;
    private readonly Task _stdoutTask;
    private readonly Task _stderrTask;
    private byte[] _latestFrame;
    private int _latestFrameVersion;
    private int _lastWrittenFrameVersion = -1;
    private int _sourceFrameCount;
    private int _writtenFrameCount;
    private int _duplicatedFrameCount;
    private bool _sentFirstChunk;

    private Fmp4VideoEncoder(
        BridgeConfig config,
        int width,
        int height,
        long streamStartTimestampUs,
        byte[] initialFrame,
        Func<byte[], BridgeVideoMode, long, CancellationToken, Task> sendChunkAsync,
        Func<object, Task> sendStatusAsync)
    {
        _config = config;
        Width = width;
        Height = height;
        StreamStartTimestampUs = streamStartTimestampUs;
        _latestFrame = initialFrame;
        _sourceFrameCount = 1;
        _sendChunkAsync = sendChunkAsync;
        _sendStatusAsync = sendStatusAsync;

        _process = Process.Start(CreateStartInfo(config, width, height))
            ?? throw new InvalidOperationException("Failed to start FFmpeg.");
        _inputTask = Task.Run(PumpInputAsync);
        _stdoutTask = Task.Run(PumpStdoutAsync);
        _stderrTask = Task.Run(PumpStderrAsync);
    }

    public int Width { get; }

    public int Height { get; }

    public long StreamStartTimestampUs { get; }

    public static Task<Fmp4VideoEncoder> StartAsync(
        BridgeConfig config,
        int width,
        int height,
        long streamStartTimestampUs,
        byte[] initialFrame,
        Func<byte[], BridgeVideoMode, long, CancellationToken, Task> sendChunkAsync,
        Func<object, Task> sendStatusAsync,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        return Task.FromResult(new Fmp4VideoEncoder(config, width, height, streamStartTimestampUs, initialFrame, sendChunkAsync, sendStatusAsync));
    }

    public Task WriteFrameAsync(byte[] rgbaFrame, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        if (_process.HasExited)
        {
            throw new InvalidOperationException($"FFmpeg exited with code {_process.ExitCode}.");
        }

        lock (_frameLock)
        {
            _latestFrame = rgbaFrame;
            _latestFrameVersion++;
            _sourceFrameCount++;
        }

        return Task.CompletedTask;
    }

    public async ValueTask DisposeAsync()
    {
        await _inputCancellation.CancelAsync();
        await WaitBestEffortAsync(_inputTask);

        try
        {
            _process.StandardInput.Close();
        }
        catch (InvalidOperationException)
        {
        }

        try
        {
            await _process.WaitForExitAsync().WaitAsync(TimeSpan.FromSeconds(2));
        }
        catch (TimeoutException)
        {
            try
            {
                _process.Kill(entireProcessTree: true);
            }
            catch (InvalidOperationException)
            {
            }
        }

        await Task.WhenAll(
            WaitBestEffortAsync(_stdoutTask),
            WaitBestEffortAsync(_stderrTask));

        await _cancellation.CancelAsync();

        _process.Dispose();
        _inputCancellation.Dispose();
        _cancellation.Dispose();
    }

    private async Task PumpInputAsync()
    {
        var frameInterval = TimeSpan.FromSeconds(1d / _config.VideoFps);
        var nextFrameAt = Stopwatch.GetTimestamp();

        try
        {
            while (!_inputCancellation.IsCancellationRequested)
            {
                if (_process.HasExited)
                {
                    break;
                }

                byte[] frame;
                int version;
                lock (_frameLock)
                {
                    frame = _latestFrame;
                    version = _latestFrameVersion;
                }

                await _process.StandardInput.BaseStream.WriteAsync(frame, _inputCancellation.Token);
                _writtenFrameCount++;
                if (version == _lastWrittenFrameVersion)
                {
                    _duplicatedFrameCount++;
                }

                _lastWrittenFrameVersion = version;

                nextFrameAt += (long)(frameInterval.TotalSeconds * Stopwatch.Frequency);
                var delay = Stopwatch.GetElapsedTime(Stopwatch.GetTimestamp(), nextFrameAt);
                if (delay > TimeSpan.Zero)
                {
                    await Task.Delay(delay, _inputCancellation.Token);
                }
                else
                {
                    nextFrameAt = Stopwatch.GetTimestamp();
                }
            }
        }
        catch (OperationCanceledException) when (_inputCancellation.IsCancellationRequested)
        {
        }
        catch (Exception exception)
        {
            await _sendStatusAsync(new { type = "avatar-video-fmp4-input-error", message = exception.Message });
        }
        finally
        {
            await _sendStatusAsync(new
            {
                type = "avatar-video-fmp4-input-stopped",
                sourceFrames = _sourceFrameCount,
                writtenFrames = _writtenFrameCount,
                duplicatedFrames = _duplicatedFrameCount,
                fps = _config.VideoFps,
            });
        }
    }

    private async Task PumpStdoutAsync()
    {
        var buffer = ArrayPool<byte>.Shared.Rent(32 * 1024);
        try
        {
            while (!_cancellation.IsCancellationRequested)
            {
                var read = await _process.StandardOutput.BaseStream.ReadAsync(buffer, _cancellation.Token);
                if (read <= 0)
                {
                    break;
                }

                var timestampUs = _sentFirstChunk ? NowUs() : StreamStartTimestampUs;
                _sentFirstChunk = true;
                await _sendChunkAsync(buffer.AsSpan(0, read).ToArray(), _config.VideoMode, timestampUs, _cancellation.Token);
            }
        }
        catch (OperationCanceledException) when (_cancellation.IsCancellationRequested)
        {
        }
        catch (Exception exception)
        {
            await _sendStatusAsync(new { type = "avatar-video-fmp4-output-error", message = exception.Message });
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    private async Task PumpStderrAsync()
    {
        try
        {
            string? line;
            while (!_cancellation.IsCancellationRequested &&
                (line = await _process.StandardError.ReadLineAsync(_cancellation.Token)) is not null)
            {
                if (line.Length > 0)
                {
                    await _sendStatusAsync(new { type = "ffmpeg-log", line });
                }
            }
        }
        catch (OperationCanceledException) when (_cancellation.IsCancellationRequested)
        {
        }
    }

    internal static ProcessStartInfo CreateStartInfo(
        BridgeConfig config,
        int width,
        int height)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = config.FfmpegBinary,
            UseShellExecute = false,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };

        Add(startInfo,
            "-hide_banner",
            "-loglevel", "warning",
            "-f", "rawvideo",
            "-pix_fmt", "rgba",
            "-video_size", FormattableString.Invariant($"{width}x{height}"),
            "-framerate", config.VideoFps.ToString(CultureInfo.InvariantCulture),
            "-i", "pipe:0",
            "-an",
            "-c:v", SelectCodec(config),
            "-pix_fmt", "yuv420p",
            "-color_range", "tv",
            "-b:v", FormattableString.Invariant($"{config.VideoBitrateKbps}k"));

        if (config.VideoEncoder == BridgeVideoEncoder.VideoToolbox)
        {
            AddVideoToolboxOptions(startInfo, config);
        }
        else if (config.VideoMode == BridgeVideoMode.H265Fmp4)
        {
            var vbvKbps = Math.Max(config.VideoBitrateKbps, 64);
            Add(startInfo,
                "-preset", "veryfast",
                "-tune", "zerolatency",
                "-profile:v", "main",
                "-level", "3.1",
                "-g", config.VideoFps.ToString(CultureInfo.InvariantCulture),
                "-keyint_min", config.VideoFps.ToString(CultureInfo.InvariantCulture),
                "-sc_threshold", "0",
                "-x265-params", FormattableString.Invariant($"keyint={config.VideoFps}:min-keyint={config.VideoFps}:scenecut=0:open-gop=0:bframes=0:rc-lookahead=0:repeat-headers=1:aud=1:hrd=1:vbv-maxrate={vbvKbps}:vbv-bufsize={vbvKbps}:log-level=error"),
                "-tag:v", "hvc1");
        }
        else
        {
            Add(startInfo,
                "-preset", "veryfast",
                "-tune", "zerolatency",
                "-profile:v", "baseline",
                "-level", "3.1",
                "-g", config.VideoFps.ToString(CultureInfo.InvariantCulture),
                "-keyint_min", config.VideoFps.ToString(CultureInfo.InvariantCulture),
                "-sc_threshold", "0");
        }

        Add(startInfo,
            "-f", "mp4",
            "-movflags", "empty_moov+default_base_moof+frag_keyframe",
            "-frag_duration", (config.Fmp4FragmentMs * 1000).ToString(CultureInfo.InvariantCulture),
            "-muxdelay", "0",
            "-muxpreload", "0",
            "-flush_packets", "1",
            "pipe:1");

        return startInfo;
    }

    private static string SelectCodec(BridgeConfig config)
    {
        return (config.VideoEncoder, config.VideoMode) switch
        {
            (BridgeVideoEncoder.VideoToolbox, BridgeVideoMode.H264Fmp4) => "h264_videotoolbox",
            (BridgeVideoEncoder.VideoToolbox, BridgeVideoMode.H265Fmp4) => "hevc_videotoolbox",
            (_, BridgeVideoMode.H265Fmp4) => "libx265",
            _ => "libx264",
        };
    }

    private static void AddVideoToolboxOptions(
        ProcessStartInfo startInfo,
        BridgeConfig config)
    {
        Add(startInfo,
            "-realtime", "1",
            "-prio_speed", "1",
            "-power_efficient", "1",
            "-g", config.VideoFps.ToString(CultureInfo.InvariantCulture));

        if (config.VideoMode == BridgeVideoMode.H265Fmp4)
        {
            Add(startInfo,
                "-profile:v", "main",
                "-tag:v", "hvc1");
        }
        else
        {
            Add(startInfo,
                "-profile:v", "baseline",
                "-level", "3.1");
        }
    }

    private static void Add(ProcessStartInfo startInfo, params string[] arguments)
    {
        foreach (var argument in arguments)
        {
            startInfo.ArgumentList.Add(argument);
        }
    }

    private static async Task WaitBestEffortAsync(Task task)
    {
        try
        {
            await task.WaitAsync(TimeSpan.FromSeconds(1));
        }
        catch (Exception exception) when (exception is TimeoutException or OperationCanceledException)
        {
        }
    }

    private static long NowUs()
    {
        return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1000;
    }
}

internal sealed record BridgeConfig(
    string IngestUrl,
    string LiveKitUrl,
    string LiveKitToken,
    bool AudioEnabled,
    bool VideoEnabled,
    BridgeVideoMode VideoMode,
    BridgeVideoEncoder VideoEncoder,
    int AudioSampleRate,
    int AudioChannels,
    int AudioFrameMs,
    int VideoWidth,
    int? VideoHeight,
    BridgeVideoResizeMode VideoResizeMode,
    int VideoCropTop,
    int VideoFps,
    int JpegQuality,
    int VideoBitrateKbps,
    int Fmp4FragmentMs,
    string FfmpegBinary)
{
    public static BridgeConfig FromEnvironment()
    {
        return new BridgeConfig(
            IngestUrl: RequireEnv("BRIDGE_INGEST_URL"),
            LiveKitUrl: RequireEnv("LIVEKIT_URL"),
            LiveKitToken: RequireEnv("LIVEKIT_TOKEN"),
            AudioEnabled: EnvBool("WATCH_AUDIO_ENABLED", defaultValue: true),
            VideoEnabled: EnvBool("WATCH_VIDEO_ENABLED", defaultValue: true),
            VideoMode: ParseVideoMode(Env("WATCH_VIDEO_MODE", "jpeg")),
            VideoEncoder: ParseVideoEncoder(Env("WATCH_VIDEO_ENCODER", "software")),
            AudioSampleRate: EnvInt("WATCH_AUDIO_SAMPLE_RATE", defaultValue: 16000),
            AudioChannels: EnvInt("WATCH_AUDIO_CHANNELS", defaultValue: 1),
            AudioFrameMs: EnvInt("WATCH_AUDIO_FRAME_MS", defaultValue: 20),
            VideoWidth: EnvInt("WATCH_VIDEO_WIDTH", defaultValue: 160),
            VideoHeight: EnvNullableInt("WATCH_VIDEO_HEIGHT"),
            VideoResizeMode: ParseVideoResizeMode(Env("WATCH_VIDEO_RESIZE_MODE", "fit")),
            VideoCropTop: EnvInt("WATCH_VIDEO_CROP_TOP", defaultValue: 0),
            VideoFps: EnvInt("WATCH_VIDEO_FPS", defaultValue: 8),
            JpegQuality: EnvInt("WATCH_JPEG_QUALITY", defaultValue: 55),
            VideoBitrateKbps: EnvInt("WATCH_VIDEO_BITRATE_KBPS", defaultValue: 180),
            Fmp4FragmentMs: EnvInt("WATCH_FMP4_FRAGMENT_MS", defaultValue: 500),
            FfmpegBinary: Env("FFMPEG_BINARY", "ffmpeg"));
    }

    private static string RequireEnv(string name)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : throw new InvalidOperationException($"{name} is required.");
    }

    private static bool EnvBool(string name, bool defaultValue)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? bool.Parse(value)
            : defaultValue;
    }

    private static int EnvInt(string name, int defaultValue)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? int.Parse(value, CultureInfo.InvariantCulture)
            : defaultValue;
    }

    private static int? EnvNullableInt(string name)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? int.Parse(value, CultureInfo.InvariantCulture)
            : null;
    }

    private static string Env(string name, string defaultValue)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : defaultValue;
    }

    private static BridgeVideoMode ParseVideoMode(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "jpeg" or "jpg" => BridgeVideoMode.Jpeg,
            "png" => BridgeVideoMode.Png,
            "h264" or "h264-fmp4" or "fmp4-h264" => BridgeVideoMode.H264Fmp4,
            "h265" or "hevc" or "h265-fmp4" or "hevc-fmp4" or "fmp4-h265" or "fmp4-hevc" => BridgeVideoMode.H265Fmp4,
            _ => throw new InvalidOperationException($"Unsupported WATCH_VIDEO_MODE '{value}'. Use jpeg, png, h264-fmp4, or h265-fmp4."),
        };
    }

    private static BridgeVideoEncoder ParseVideoEncoder(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "software" or "sw" or "libx264" or "libx265" => BridgeVideoEncoder.Software,
            "videotoolbox" or "video-toolbox" or "vt" or "hardware" or "hw" => BridgeVideoEncoder.VideoToolbox,
            _ => throw new InvalidOperationException($"Unsupported WATCH_VIDEO_ENCODER '{value}'. Use software or videotoolbox."),
        };
    }

    private static BridgeVideoResizeMode ParseVideoResizeMode(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "fit" or "contain" or "pad" or "letterbox" => BridgeVideoResizeMode.Fit,
            "cover" or "crop" => BridgeVideoResizeMode.Cover,
            "stretch" or "fill" => BridgeVideoResizeMode.Stretch,
            _ => throw new InvalidOperationException($"Unsupported WATCH_VIDEO_RESIZE_MODE '{value}'. Use fit, cover, or stretch."),
        };
    }
}

internal enum BridgeVideoMode
{
    Jpeg,
    Png,
    H264Fmp4,
    H265Fmp4,
}

internal enum BridgeVideoEncoder
{
    Software,
    VideoToolbox,
}

internal enum BridgeVideoResizeMode
{
    Fit,
    Cover,
    Stretch,
}

internal static class BridgeVideoResizeModeExtensions
{
    public static string ToName(this BridgeVideoResizeMode mode)
    {
        return mode switch
        {
            BridgeVideoResizeMode.Fit => "fit",
            BridgeVideoResizeMode.Cover => "cover",
            BridgeVideoResizeMode.Stretch => "stretch",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }

    public static ResizeMode ToImageSharpResizeMode(this BridgeVideoResizeMode mode)
    {
        return mode switch
        {
            BridgeVideoResizeMode.Fit => ResizeMode.Pad,
            BridgeVideoResizeMode.Cover => ResizeMode.Crop,
            BridgeVideoResizeMode.Stretch => ResizeMode.Stretch,
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }
}

internal static class BridgeVideoModeExtensions
{
    public static string ToCodecName(this BridgeVideoMode mode)
    {
        return mode switch
        {
            BridgeVideoMode.Jpeg => "jpeg",
            BridgeVideoMode.Png => "png",
            BridgeVideoMode.H264Fmp4 => "h264",
            BridgeVideoMode.H265Fmp4 => "h265",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }

    public static string ToContainerName(this BridgeVideoMode mode)
    {
        return mode is BridgeVideoMode.Jpeg or BridgeVideoMode.Png ? "image" : "fmp4";
    }

    public static ushort ToProtocolCodecId(this BridgeVideoMode mode)
    {
        return mode switch
        {
            BridgeVideoMode.H264Fmp4 => 1,
            BridgeVideoMode.H265Fmp4 => 2,
            _ => 0,
        };
    }

    public static byte ToProtocolFrameKind(this BridgeVideoMode mode)
    {
        return mode switch
        {
            BridgeVideoMode.Jpeg => BridgeProtocol.KindAvatarJpeg,
            BridgeVideoMode.Png => BridgeProtocol.KindAvatarPng,
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null),
        };
    }
}

internal static class BridgeVideoEncoderExtensions
{
    public static string ToName(this BridgeVideoEncoder encoder)
    {
        return encoder switch
        {
            BridgeVideoEncoder.Software => "software",
            BridgeVideoEncoder.VideoToolbox => "videotoolbox",
            _ => throw new ArgumentOutOfRangeException(nameof(encoder), encoder, null),
        };
    }
}

internal static class BridgeProtocol
{
    public const int FrameHeaderBytes = 24;
    public const byte ProtocolVersion = 1;
    public const byte KindAvatarAudio = 1;
    public const byte KindAvatarJpeg = 2;
    public const byte KindAvatarFmp4 = 3;
    public const byte KindAvatarPng = 4;
    public const byte KindWatchAudio = 17;
}

internal readonly record struct AlphaStats(
    byte Min,
    byte Max,
    long TransparentPixels,
    long TranslucentPixels,
    long OpaquePixels,
    long TotalPixels)
{
    public static AlphaStats FromRgba(ReadOnlySpan<byte> rgba)
    {
        if (rgba.Length < 4)
        {
            return new AlphaStats(0, 0, 0, 0, 0, 0);
        }

        byte min = byte.MaxValue;
        byte max = byte.MinValue;
        long transparent = 0;
        long translucent = 0;
        long opaque = 0;

        for (var index = 3; index < rgba.Length; index += 4)
        {
            var alpha = rgba[index];
            min = Math.Min(min, alpha);
            max = Math.Max(max, alpha);
            if (alpha == 0)
            {
                transparent++;
            }
            else if (alpha == byte.MaxValue)
            {
                opaque++;
            }
            else
            {
                translucent++;
            }
        }

        return new AlphaStats(
            Min: min,
            Max: max,
            TransparentPixels: transparent,
            TranslucentPixels: translucent,
            OpaquePixels: opaque,
            TotalPixels: transparent + translucent + opaque);
    }
}

internal readonly record struct FrameHeader(
    byte Kind,
    byte Version,
    uint PayloadLength,
    ushort Arg0,
    ushort Arg1);

internal readonly record struct EncodedImage(
    int Width,
    int Height,
    byte[] Payload);
