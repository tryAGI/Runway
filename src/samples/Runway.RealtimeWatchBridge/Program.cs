using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using Runway;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, WatchBridgeJsonContext.Default);
});

builder.Services.AddSingleton(sp =>
{
    var apiKey = RunwayEnvironment.GetApiKey()
        ?? throw new InvalidOperationException("Set RUNWAY_API_KEY, RUNWAYML_API_SECRET, or a .env file before starting the sample.");

    return new RunwayClient(apiKey);
});
builder.Services.AddSingleton<WatchBridgeSessionStore>();

var app = builder.Build();

app.UseWebSockets(new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromSeconds(20),
});

app.MapGet("/", () => Results.Text(
    """
    Runway realtime watch bridge sample.

    POST /sessions to create a Runway realtime avatar session.
    Connect watchOS to the returned watchWebSocketUrl and send PCM16 mic frames with protocol kind 17.
    """,
    "text/plain"));

app.MapPost("/sessions", async (
    CreateWatchBridgeSessionRequest request,
    HttpContext httpContext,
    WatchBridgeSessionStore sessions,
    CancellationToken cancellationToken) =>
{
    var response = await sessions.CreateAsync(request, httpContext, cancellationToken);
    return Results.Ok(response);
});

app.MapGet("/sessions/{sessionId}", (
    string sessionId,
    WatchBridgeSessionStore sessions) =>
{
    return sessions.TryGetStatus(sessionId, out var status)
        ? Results.Ok(status)
        : Results.NotFound();
});

app.MapDelete("/sessions/{sessionId}", async (
    string sessionId,
    WatchBridgeSessionStore sessions) =>
{
    await sessions.StopAsync(sessionId);
    return Results.NoContent();
});

app.MapGet("/watch/{sessionId}", async (
    string sessionId,
    HttpContext httpContext,
    WatchBridgeSessionStore sessions) =>
{
    if (!httpContext.WebSockets.IsWebSocketRequest)
    {
        return Results.BadRequest("Expected WebSocket request.");
    }

    var token = httpContext.Request.Query["token"].ToString();
    using var socket = await httpContext.WebSockets.AcceptWebSocketAsync();
    await sessions.AcceptWatchSocketAsync(sessionId, token, socket, httpContext.RequestAborted);
    return Results.Empty;
});

app.MapGet("/internal/bridge/{sessionId}", async (
    string sessionId,
    HttpContext httpContext,
    WatchBridgeSessionStore sessions) =>
{
    if (!httpContext.WebSockets.IsWebSocketRequest)
    {
        return Results.BadRequest("Expected WebSocket request.");
    }

    var token = httpContext.Request.Query["token"].ToString();
    using var socket = await httpContext.WebSockets.AcceptWebSocketAsync();
    await sessions.AcceptBridgeSocketAsync(sessionId, token, socket, httpContext.RequestAborted);
    return Results.Empty;
});

app.Run();

public sealed record CreateWatchBridgeSessionRequest(
    string? PresetAvatar = "influencer",
    Guid? AvatarId = null,
    int MaxDurationSeconds = 300,
    string? Personality = null,
    string? StartScript = null,
    bool AudioEnabled = true,
    bool VideoEnabled = true,
    int WatchAudioSampleRate = 16000,
    int WatchAudioChannels = 1,
    int WatchAudioFrameMs = 20,
    string WatchVideoMode = "jpeg",
    string WatchVideoEncoder = "software",
    int WatchVideoWidth = 160,
    int? WatchVideoHeight = null,
    string WatchVideoResizeMode = "fit",
    int WatchVideoCropTop = 0,
    int WatchVideoFps = 8,
    int WatchJpegQuality = 55,
    int WatchVideoBitrateKbps = 180,
    int WatchFmp4FragmentMs = 500);

public sealed record CreateWatchBridgeSessionResponse(
    string SessionId,
    Guid RunwaySessionId,
    string WatchWebSocketUrl,
    string WatchToken,
    WatchBridgeProtocol Protocol);

public sealed record WatchBridgeSessionStatus(
    string SessionId,
    Guid RunwaySessionId,
    string State,
    int WatchClients,
    bool BridgeConnected,
    long WatchAudioFrames,
    long AvatarAudioFrames,
    long AvatarVideoFrames,
    long AvatarJpegFrames,
    long AvatarFmp4Frames,
    long DownstreamBinaryFrames,
    DateTimeOffset CreatedAt);

public sealed record WatchBridgeProtocol(
    int Version,
    string DownstreamAudio,
    string DownstreamVideo,
    string UpstreamAudio,
    int HeaderBytes,
    string ByteOrder);

[JsonSerializable(typeof(CreateWatchBridgeSessionRequest))]
[JsonSerializable(typeof(CreateWatchBridgeSessionResponse))]
[JsonSerializable(typeof(WatchBridgeSessionStatus))]
[JsonSerializable(typeof(WatchBridgeProtocol))]
[JsonSerializable(typeof(BridgeControlMessage))]
internal sealed partial class WatchBridgeJsonContext : JsonSerializerContext;

public sealed class WatchBridgeSessionStore(
    RunwayClient runway,
    IWebHostEnvironment environment,
    ILogger<WatchBridgeSessionStore> logger)
{
    private static readonly WatchBridgeProtocol Protocol = new(
        Version: 1,
        DownstreamAudio: "kind=1, pcm_s16le, arg0=sampleRate, arg1=channels",
        DownstreamVideo: "kind=2, jpeg, arg0=width, arg1=height; kind=3, fmp4 byte stream, arg0=1 h264 / 2 h265; kind=4, png, arg0=width, arg1=height",
        UpstreamAudio: "kind=17, pcm_s16le, arg0=sampleRate, arg1=channels",
        HeaderBytes: 24,
        ByteOrder: "little-endian");
    internal const byte KindAvatarAudio = 1;
    internal const byte KindAvatarJpeg = 2;
    internal const byte KindAvatarFmp4 = 3;
    internal const byte KindAvatarPng = 4;
    internal const byte KindWatchAudio = 17;

    private readonly ConcurrentDictionary<string, WatchBridgeSession> _sessions = [];

    public async Task<CreateWatchBridgeSessionResponse> CreateAsync(
        CreateWatchBridgeSessionRequest request,
        HttpContext httpContext,
        CancellationToken cancellationToken)
    {
        ValidateRequest(request);

        var runwaySession = await runway.RealtimeSessions.CreateRealtimeSessionsAsync(
            request: new CreateRealtimeSessionsRequest
            {
                Avatar = CreateAvatar(request),
                MaxDuration = request.MaxDurationSeconds,
                Personality = request.Personality,
                StartScript = request.StartScript,
            },
            cancellationToken: cancellationToken);

        var ready = await WaitForReadyAsync(runwaySession.Id, cancellationToken);
        var credentials = await runway.RealtimeSessions.ConsumeRealtimeSessionAsync(
            id: runwaySession.Id,
            sessionKey: ready.SessionKey,
            cancellationToken: cancellationToken);

        var sessionId = RandomToken(bytes: 16);
        var watchToken = RandomToken(bytes: 32);
        var bridgeToken = RandomToken(bytes: 32);
        var watchUrl = BuildWebSocketUrl(httpContext, $"/watch/{sessionId}", watchToken, forceLoopback: false);
        var bridgeUrl = BuildWebSocketUrl(httpContext, $"/internal/bridge/{sessionId}", bridgeToken, forceLoopback: true);

        var session = new WatchBridgeSession(
            SessionId: sessionId,
            RunwaySessionId: runwaySession.Id,
            WatchToken: watchToken,
            BridgeToken: bridgeToken,
            CreatedAt: DateTimeOffset.UtcNow);

        if (!_sessions.TryAdd(sessionId, session))
        {
            throw new InvalidOperationException("Failed to allocate bridge session.");
        }

        StartMediaBridge(session, credentials, bridgeUrl, request);

        return new CreateWatchBridgeSessionResponse(
            SessionId: sessionId,
            RunwaySessionId: runwaySession.Id,
            WatchWebSocketUrl: watchUrl,
            WatchToken: watchToken,
            Protocol: Protocol);
    }

    public bool TryGetStatus(string sessionId, out WatchBridgeSessionStatus status)
    {
        if (!_sessions.TryGetValue(sessionId, out var session))
        {
            status = default!;
            return false;
        }

        status = new WatchBridgeSessionStatus(
            SessionId: session.SessionId,
            RunwaySessionId: session.RunwaySessionId,
            State: session.State,
            WatchClients: session.WatchClients.Count,
            BridgeConnected: session.BridgeSocket is { State: WebSocketState.Open },
            WatchAudioFrames: session.WatchAudioFrames,
            AvatarAudioFrames: session.AvatarAudioFrames,
            AvatarVideoFrames: session.AvatarVideoFrames,
            AvatarJpegFrames: session.AvatarJpegFrames,
            AvatarFmp4Frames: session.AvatarFmp4Frames,
            DownstreamBinaryFrames: session.DownstreamBinaryFrames,
            CreatedAt: session.CreatedAt);
        return true;
    }

    public async Task StopAsync(string sessionId)
    {
        if (!_sessions.TryRemove(sessionId, out var session))
        {
            return;
        }

        session.SetState("stopping");
        await StopMediaBridgeProcessAsync(session.MediaBridgeProcess);
        await CloseSocketAsync(session.BridgeSocket);
        foreach (var client in session.WatchClients.Values)
        {
            await CloseSocketAsync(client.Socket);
        }

        try
        {
            using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            await runway.RealtimeSessions.DeleteRealtimeSessionsByIdAsync(
                id: session.RunwaySessionId,
                cancellationToken: timeout.Token);
        }
        catch (Exception exception) when (exception is not OperationCanceledException)
        {
            logger.LogWarning(exception, "Failed to cancel Runway realtime session {RunwaySessionId}", session.RunwaySessionId);
        }
        catch (OperationCanceledException exception)
        {
            logger.LogWarning(exception, "Timed out cancelling Runway realtime session {RunwaySessionId}", session.RunwaySessionId);
        }
    }

    public async Task AcceptBridgeSocketAsync(
        string sessionId,
        string token,
        WebSocket socket,
        CancellationToken cancellationToken)
    {
        if (!TryAuthorize(sessionId, token, static s => s.BridgeToken, out var session))
        {
            await socket.CloseAsync(WebSocketCloseStatus.PolicyViolation, "Invalid token.", cancellationToken);
            return;
        }

        session.BridgeSocket = socket;
        session.SetState("bridge-connected");
        await BroadcastTextAsync(session, new BridgeControlMessage("bridge-connected"), cancellationToken);

        try
        {
            while (socket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
            {
                var message = await ReceiveMessageAsync(socket, cancellationToken);
                if (message is null)
                {
                    break;
                }

                if (message.Value.MessageType == WebSocketMessageType.Text)
                {
                    await BroadcastTextAsync(session, Encoding.UTF8.GetString(message.Value.Payload), cancellationToken);
                }
                else if (message.Value.MessageType == WebSocketMessageType.Binary)
                {
                    await BroadcastBinaryAsync(session, message.Value.Payload, cancellationToken);
                }
            }
        }
        finally
        {
            if (ReferenceEquals(session.BridgeSocket, socket))
            {
                session.BridgeSocket = null;
            }

            session.SetState("bridge-disconnected");
        }
    }

    public async Task AcceptWatchSocketAsync(
        string sessionId,
        string token,
        WebSocket socket,
        CancellationToken cancellationToken)
    {
        if (!TryAuthorize(sessionId, token, static s => s.WatchToken, out var session))
        {
            await socket.CloseAsync(WebSocketCloseStatus.PolicyViolation, "Invalid token.", cancellationToken);
            return;
        }

        var client = new WatchSocketClient(socket);
        session.WatchClients[client.Id] = client;

        await client.SendTextAsync(new BridgeControlMessage(
            Type: "connected",
            ProtocolVersion: Protocol.Version,
            HeaderBytes: Protocol.HeaderBytes), cancellationToken);

        try
        {
            while (socket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
            {
                var message = await ReceiveMessageAsync(socket, cancellationToken);
                if (message is null)
                {
                    break;
                }

                if (session.BridgeSocket is not { State: WebSocketState.Open } bridgeSocket)
                {
                    await client.SendTextAsync(new BridgeControlMessage("bridge-not-connected"), cancellationToken);
                    continue;
                }

                if (message.Value.MessageType == WebSocketMessageType.Binary)
                {
                    session.RecordWatchBinary(message.Value.Payload);
                    await session.SendToBridgeAsync(message.Value.Payload, WebSocketMessageType.Binary, cancellationToken);
                }
                else if (message.Value.MessageType == WebSocketMessageType.Text)
                {
                    await session.SendToBridgeAsync(message.Value.Payload, WebSocketMessageType.Text, cancellationToken);
                }
            }
        }
        finally
        {
            session.WatchClients.TryRemove(client.Id, out _);
        }
    }

    private static void ValidateRequest(CreateWatchBridgeSessionRequest request)
    {
        if (request.AvatarId is null && string.IsNullOrWhiteSpace(request.PresetAvatar))
        {
            throw new ArgumentException("Provide either avatarId or presetAvatar.");
        }

        if (request.WatchAudioSampleRate is < 8000 or > 48000)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchAudioSampleRate));
        }

        if (request.WatchAudioChannels is < 1 or > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchAudioChannels));
        }

        if (request.WatchVideoWidth is < 64 or > 1024)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchVideoWidth));
        }

        if (request.WatchVideoHeight is < 64 or > 1024)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchVideoHeight));
        }

        if (request.WatchVideoFps is < 1 or > 30)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchVideoFps));
        }

        if (request.WatchVideoCropTop is < 0 or > 256)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchVideoCropTop));
        }

        if (request.WatchJpegQuality is < 1 or > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchJpegQuality));
        }

        if (request.WatchVideoBitrateKbps is < 32 or > 2_000)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchVideoBitrateKbps));
        }

        if (request.WatchFmp4FragmentMs is < 100 or > 2_000)
        {
            throw new ArgumentOutOfRangeException(nameof(request.WatchFmp4FragmentMs));
        }

        _ = NormalizeVideoMode(request.WatchVideoMode);
        _ = NormalizeVideoEncoder(request.WatchVideoEncoder);
        _ = NormalizeVideoResizeMode(request.WatchVideoResizeMode);
    }

    private static Avatar2 CreateAvatar(CreateWatchBridgeSessionRequest request)
    {
        if (request.AvatarId is { } avatarId)
        {
            return new CreateRealtimeSessionsRequestAvatarCustomAvatar
            {
                AvatarId = avatarId,
            };
        }

        var preset = CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetIdExtensions.ToEnum(request.PresetAvatar!)
            ?? throw new ArgumentException($"Unknown preset avatar '{request.PresetAvatar}'.");

        return new CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar
        {
            PresetId = preset,
        };
    }

    private async Task<GetRealtimeSessionsResponseSessionReady> WaitForReadyAsync(
        Guid runwaySessionId,
        CancellationToken cancellationToken)
    {
        var deadline = TimeProvider.System.GetUtcNow().AddSeconds(45);
        while (TimeProvider.System.GetUtcNow() < deadline)
        {
            var status = await runway.RealtimeSessions.GetRealtimeSessionsByIdAsync(
                id: runwaySessionId,
                cancellationToken: cancellationToken);

            if (status.IsReady)
            {
                return status.Ready;
            }

            if (status.IsFailed)
            {
                throw new InvalidOperationException($"Runway realtime session failed: {status.Failed.Failure}");
            }

            if (status.IsCancelled || status.IsCompleted)
            {
                throw new InvalidOperationException("Runway realtime session ended before it became ready.");
            }

            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
        }

        throw new TimeoutException("Timed out waiting for Runway realtime session credentials.");
    }

    private void StartMediaBridge(
        WatchBridgeSession session,
        RealtimeSessionConnectionCredentials credentials,
        string bridgeUrl,
        CreateWatchBridgeSessionRequest request)
    {
        var startInfo = CreateMediaBridgeStartInfo();
        ConfigureMediaBridgeEnvironment(startInfo, credentials, bridgeUrl, request);

        var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Failed to start media bridge.");
        session.MediaBridgeProcess = process;

        _ = Task.Run(async () =>
        {
            string? line;
            while ((line = await process.StandardOutput.ReadLineAsync()) is not null)
            {
                logger.LogInformation("[media-bridge:{SessionId}] {Line}", session.SessionId, line);
            }
        });

        _ = Task.Run(async () =>
        {
            string? line;
            while ((line = await process.StandardError.ReadLineAsync()) is not null)
            {
                logger.LogWarning("[media-bridge:{SessionId}] {Line}", session.SessionId, line);
            }
        });
    }

    private ProcessStartInfo CreateMediaBridgeStartInfo()
    {
        var runtime = Environment.GetEnvironmentVariable("RUNWAY_WATCH_BRIDGE_RUNTIME") is { Length: > 0 } value
            ? value
            : "dotnet";

        if (runtime.Equals("node", StringComparison.OrdinalIgnoreCase))
        {
            var bridgeScript = Path.Combine(environment.ContentRootPath, "media-bridge", "bridge.mjs");
            if (!File.Exists(bridgeScript))
            {
                throw new FileNotFoundException("Node media bridge script was not found.", bridgeScript);
            }

            return new ProcessStartInfo
            {
                FileName = Environment.GetEnvironmentVariable("NODE_BINARY") is { Length: > 0 } nodeBinary ? nodeBinary : "node",
                ArgumentList = { bridgeScript },
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };
        }

        return CreateDotNetMediaBridgeStartInfo();
    }

    private ProcessStartInfo CreateDotNetMediaBridgeStartInfo()
    {
        var dotnetBinary = Environment.GetEnvironmentVariable("DOTNET_BINARY") is { Length: > 0 } value ? value : "dotnet";
        if (Environment.GetEnvironmentVariable("RUNWAY_WATCH_BRIDGE_BINARY") is { Length: > 0 } bridgeBinary)
        {
            return bridgeBinary.EndsWith(".dll", StringComparison.OrdinalIgnoreCase)
                ? ProcessFor(dotnetBinary, bridgeBinary)
                : ProcessFor(bridgeBinary);
        }

        var projectPath = Path.GetFullPath(Path.Combine(
            environment.ContentRootPath,
            "..",
            "Runway.RealtimeWatchBridge.MediaBridge",
            "Runway.RealtimeWatchBridge.MediaBridge.csproj"));
        if (!File.Exists(projectPath))
        {
            throw new FileNotFoundException("C# media bridge project was not found.", projectPath);
        }

        var configuration = Environment.GetEnvironmentVariable("RUNWAY_WATCH_BRIDGE_CONFIGURATION") is { Length: > 0 } config
            ? config
            : "Debug";
        var bridgeDll = Path.Combine(
            Path.GetDirectoryName(projectPath)!,
            "bin",
            configuration,
            "net10.0",
            "Runway.RealtimeWatchBridge.MediaBridge.dll");

        return File.Exists(bridgeDll)
            ? ProcessFor(dotnetBinary, bridgeDll)
            : ProcessFor(dotnetBinary, "run", "--project", projectPath, "--no-launch-profile");
    }

    private static ProcessStartInfo ProcessFor(string fileName, params string[] arguments)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = fileName,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };

        foreach (var argument in arguments)
        {
            startInfo.ArgumentList.Add(argument);
        }

        return startInfo;
    }

    private static void ConfigureMediaBridgeEnvironment(
        ProcessStartInfo startInfo,
        RealtimeSessionConnectionCredentials credentials,
        string bridgeUrl,
        CreateWatchBridgeSessionRequest request)
    {
        startInfo.Environment["BRIDGE_INGEST_URL"] = bridgeUrl;
        startInfo.Environment["LIVEKIT_URL"] = credentials.Url.ToString();
        startInfo.Environment["LIVEKIT_TOKEN"] = credentials.Token;
        startInfo.Environment["WATCH_AUDIO_ENABLED"] = request.AudioEnabled ? "true" : "false";
        startInfo.Environment["WATCH_VIDEO_ENABLED"] = request.VideoEnabled ? "true" : "false";
        startInfo.Environment["WATCH_AUDIO_SAMPLE_RATE"] = request.WatchAudioSampleRate.ToString();
        startInfo.Environment["WATCH_AUDIO_CHANNELS"] = request.WatchAudioChannels.ToString();
        startInfo.Environment["WATCH_AUDIO_FRAME_MS"] = request.WatchAudioFrameMs.ToString();
        startInfo.Environment["WATCH_VIDEO_MODE"] = NormalizeVideoMode(request.WatchVideoMode);
        startInfo.Environment["WATCH_VIDEO_ENCODER"] = NormalizeVideoEncoder(request.WatchVideoEncoder);
        startInfo.Environment["WATCH_VIDEO_WIDTH"] = request.WatchVideoWidth.ToString();
        if (request.WatchVideoHeight is { } videoHeight)
        {
            startInfo.Environment["WATCH_VIDEO_HEIGHT"] = videoHeight.ToString();
        }

        startInfo.Environment["WATCH_VIDEO_RESIZE_MODE"] = NormalizeVideoResizeMode(request.WatchVideoResizeMode);
        startInfo.Environment["WATCH_VIDEO_CROP_TOP"] = request.WatchVideoCropTop.ToString();
        startInfo.Environment["WATCH_VIDEO_FPS"] = request.WatchVideoFps.ToString();
        startInfo.Environment["WATCH_JPEG_QUALITY"] = request.WatchJpegQuality.ToString();
        startInfo.Environment["WATCH_VIDEO_BITRATE_KBPS"] = request.WatchVideoBitrateKbps.ToString();
        startInfo.Environment["WATCH_FMP4_FRAGMENT_MS"] = request.WatchFmp4FragmentMs.ToString();
    }

    private static string NormalizeVideoMode(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "jpeg" or "jpg" => "jpeg",
            "png" => "png",
            "h264" or "h264-fmp4" or "fmp4-h264" => "h264-fmp4",
            "h265" or "hevc" or "h265-fmp4" or "hevc-fmp4" or "fmp4-h265" or "fmp4-hevc" => "h265-fmp4",
            _ => throw new ArgumentException("watchVideoMode must be jpeg, png, h264-fmp4, or h265-fmp4.", nameof(value)),
        };
    }

    private static string NormalizeVideoEncoder(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "software" or "sw" or "libx264" or "libx265" => "software",
            "videotoolbox" or "video-toolbox" or "vt" or "hardware" or "hw" => "videotoolbox",
            _ => throw new ArgumentException("watchVideoEncoder must be software or videotoolbox.", nameof(value)),
        };
    }

    private static string NormalizeVideoResizeMode(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "fit" or "contain" or "pad" or "letterbox" => "fit",
            "cover" or "crop" => "cover",
            "stretch" or "fill" => "stretch",
            _ => throw new ArgumentException("watchVideoResizeMode must be fit, cover, or stretch.", nameof(value)),
        };
    }

    private bool TryAuthorize(
        string sessionId,
        string token,
        Func<WatchBridgeSession, string> tokenSelector,
        out WatchBridgeSession session)
    {
        if (_sessions.TryGetValue(sessionId, out session!) &&
            CryptographicOperations.FixedTimeEquals(
                Encoding.UTF8.GetBytes(tokenSelector(session)),
                Encoding.UTF8.GetBytes(token)))
        {
            return true;
        }

        session = default!;
        return false;
    }

    private static string BuildWebSocketUrl(
        HttpContext httpContext,
        string path,
        string token,
        bool forceLoopback)
    {
        var scheme = httpContext.Request.Scheme.Equals("https", StringComparison.OrdinalIgnoreCase) ? "wss" : "ws";
        var host = forceLoopback
            ? new HostString("127.0.0.1", httpContext.Connection.LocalPort)
            : httpContext.Request.Host;

        return $"{scheme}://{host}{path}?token={Uri.EscapeDataString(token)}";
    }

    private static string RandomToken(int bytes)
    {
        return Convert.ToHexString(RandomNumberGenerator.GetBytes(bytes)).ToLowerInvariant();
    }

    private static async Task<SocketMessage?> ReceiveMessageAsync(
        WebSocket socket,
        CancellationToken cancellationToken)
    {
        var buffer = ArrayPool<byte>.Shared.Rent(64 * 1024);
        await using var stream = new MemoryStream();
        try
        {
            while (true)
            {
                var result = await socket.ReceiveAsync(buffer, cancellationToken);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    return null;
                }

                stream.Write(buffer.AsSpan(0, result.Count));
                if (result.EndOfMessage)
                {
                    return new SocketMessage(result.MessageType, stream.ToArray());
                }
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }

    private static async Task BroadcastTextAsync(
        WatchBridgeSession session,
        BridgeControlMessage message,
        CancellationToken cancellationToken)
    {
        var json = System.Text.Json.JsonSerializer.Serialize(message, WatchBridgeJsonContext.Default.BridgeControlMessage);
        await BroadcastTextAsync(session, json, cancellationToken);
    }

    private static async Task BroadcastTextAsync(
        WatchBridgeSession session,
        string json,
        CancellationToken cancellationToken)
    {
        var payload = Encoding.UTF8.GetBytes(json);
        foreach (var client in session.WatchClients.Values)
        {
            await client.SendAsync(payload, WebSocketMessageType.Text, cancellationToken);
        }
    }

    private static async Task BroadcastBinaryAsync(
        WatchBridgeSession session,
        byte[] payload,
        CancellationToken cancellationToken)
    {
        session.RecordBridgeBinary(payload, session.WatchClients.Count);
        foreach (var client in session.WatchClients.Values)
        {
            await client.SendAsync(payload, WebSocketMessageType.Binary, cancellationToken);
        }
    }

    private static async Task CloseSocketAsync(WebSocket? socket)
    {
        if (socket is null || socket.State is not (WebSocketState.Open or WebSocketState.CloseReceived))
        {
            return;
        }

        try
        {
            using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(2));
            await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Session stopped.", timeout.Token);
        }
        catch (Exception exception) when (exception is WebSocketException or OperationCanceledException or ObjectDisposedException)
        {
            socket.Abort();
        }
    }

    private static async Task StopMediaBridgeProcessAsync(Process? process)
    {
        if (process is null || process.HasExited)
        {
            return;
        }

        try
        {
            process.Kill(entireProcessTree: true);
        }
        catch (InvalidOperationException)
        {
            return;
        }

        try
        {
            await process.WaitForExitAsync().WaitAsync(TimeSpan.FromSeconds(2));
        }
        catch (TimeoutException)
        {
        }
    }

    private readonly record struct SocketMessage(WebSocketMessageType MessageType, byte[] Payload);
}

public sealed record BridgeControlMessage(
    string Type,
    int? ProtocolVersion = null,
    int? HeaderBytes = null);

public sealed class WatchBridgeSession(
    string SessionId,
    Guid RunwaySessionId,
    string WatchToken,
    string BridgeToken,
    DateTimeOffset CreatedAt)
{
    public string SessionId { get; } = SessionId;
    public Guid RunwaySessionId { get; } = RunwaySessionId;
    public string WatchToken { get; } = WatchToken;
    public string BridgeToken { get; } = BridgeToken;
    public DateTimeOffset CreatedAt { get; } = CreatedAt;
    public ConcurrentDictionary<Guid, WatchSocketClient> WatchClients { get; } = [];
    public SemaphoreSlim BridgeSendLock { get; } = new(1, 1);
    public WebSocket? BridgeSocket { get; set; }
    public Process? MediaBridgeProcess { get; set; }
    public string State { get; private set; } = "created";
    private long _watchAudioFrames;
    private long _avatarAudioFrames;
    private long _avatarVideoFrames;
    private long _avatarJpegFrames;
    private long _avatarFmp4Frames;
    private long _downstreamBinaryFrames;

    public long WatchAudioFrames => Interlocked.Read(ref _watchAudioFrames);

    public long AvatarAudioFrames => Interlocked.Read(ref _avatarAudioFrames);

    public long AvatarVideoFrames => Interlocked.Read(ref _avatarVideoFrames);

    public long AvatarJpegFrames => Interlocked.Read(ref _avatarJpegFrames);

    public long AvatarFmp4Frames => Interlocked.Read(ref _avatarFmp4Frames);

    public long DownstreamBinaryFrames => Interlocked.Read(ref _downstreamBinaryFrames);

    public void SetState(string state)
    {
        State = state;
    }

    public void RecordWatchBinary(byte[] payload)
    {
        if (TryParseFrameKind(payload, out var kind) && kind == WatchBridgeSessionStore.KindWatchAudio)
        {
            Interlocked.Increment(ref _watchAudioFrames);
        }
    }

    public void RecordBridgeBinary(byte[] payload, int watchClientCount)
    {
        if (!TryParseFrameKind(payload, out var kind))
        {
            return;
        }

        if (watchClientCount > 0)
        {
            Interlocked.Add(ref _downstreamBinaryFrames, watchClientCount);
        }

        switch (kind)
        {
            case WatchBridgeSessionStore.KindAvatarAudio:
                Interlocked.Increment(ref _avatarAudioFrames);
                break;
            case WatchBridgeSessionStore.KindAvatarJpeg:
                Interlocked.Increment(ref _avatarVideoFrames);
                Interlocked.Increment(ref _avatarJpegFrames);
                break;
            case WatchBridgeSessionStore.KindAvatarFmp4:
                Interlocked.Increment(ref _avatarVideoFrames);
                Interlocked.Increment(ref _avatarFmp4Frames);
                break;
            case WatchBridgeSessionStore.KindAvatarPng:
                Interlocked.Increment(ref _avatarVideoFrames);
                break;
        }
    }

    public async Task SendToBridgeAsync(
        byte[] payload,
        WebSocketMessageType messageType,
        CancellationToken cancellationToken)
    {
        if (BridgeSocket is not { State: WebSocketState.Open } socket)
        {
            return;
        }

        await BridgeSendLock.WaitAsync(cancellationToken);
        try
        {
            await socket.SendAsync(payload, messageType, WebSocketMessageFlags.EndOfMessage, cancellationToken);
        }
        finally
        {
            BridgeSendLock.Release();
        }
    }

    private static bool TryParseFrameKind(byte[] payload, out byte kind)
    {
        kind = default;
        if (payload.Length < 24 ||
            payload[1] != 1 ||
            BinaryPrimitives.ReadUInt16LittleEndian(payload.AsSpan(2)) != 24 ||
            BinaryPrimitives.ReadUInt32LittleEndian(payload.AsSpan(16)) != payload.Length - 24)
        {
            return false;
        }

        kind = payload[0];
        return true;
    }
}

public sealed class WatchSocketClient(WebSocket socket)
{
    private readonly SemaphoreSlim _sendLock = new(1, 1);

    public Guid Id { get; } = Guid.NewGuid();
    public WebSocket Socket { get; } = socket;

    public async Task SendTextAsync(
        BridgeControlMessage message,
        CancellationToken cancellationToken)
    {
        var json = System.Text.Json.JsonSerializer.Serialize(message, WatchBridgeJsonContext.Default.BridgeControlMessage);
        await SendAsync(Encoding.UTF8.GetBytes(json), WebSocketMessageType.Text, cancellationToken);
    }

    public async Task SendAsync(
        byte[] payload,
        WebSocketMessageType messageType,
        CancellationToken cancellationToken)
    {
        if (Socket.State != WebSocketState.Open)
        {
            return;
        }

        await _sendLock.WaitAsync(cancellationToken);
        try
        {
            await Socket.SendAsync(payload, messageType, WebSocketMessageFlags.EndOfMessage, cancellationToken);
        }
        finally
        {
            _sendLock.Release();
        }
    }
}
