using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Runway.IntegrationTests;

public partial class Tests
{
    private const int WatchBridgeHeaderBytes = 24;
    private const byte WatchBridgeProtocolVersion = 1;
    private const byte WatchBridgeAvatarAudioKind = 1;
    private const byte WatchBridgeAvatarJpegKind = 2;
    private const byte WatchBridgeAvatarFmp4Kind = 3;
    private const byte WatchBridgeAvatarPngKind = 4;
    private const int WatchBridgeH264CodecId = 1;
    private const int WatchBridgeH265CodecId = 2;

    [TestMethod]
    public async Task RealtimeWatchBridge_DeliversAvatarVideoFrame()
    {
        SkipUnlessWatchBridgeE2ETestsEnabled();

        var apiKey =
            Environment.GetEnvironmentVariable("RUNWAY_API_KEY") is { Length: > 0 } runwayApiKey ? runwayApiKey :
            Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET") is { Length: > 0 } runwayMlApiSecret ? runwayMlApiSecret :
            throw new AssertInconclusiveException("RUNWAY_API_KEY or RUNWAYML_API_SECRET environment variable is not found.");

        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(8));
        var port = GetFreeTcpPort();
        var baseAddress = new Uri($"http://127.0.0.1:{port}");
        var logs = new ConcurrentQueue<string>();
        var artifactSettings = WatchBridgeE2EArtifactSettings.FromEnvironment();
        var videoSettings = artifactSettings.Video;
        var avatar = await ResolveWatchBridgeAvatarAsync(apiKey, artifactSettings.Avatar, logs, timeout.Token);
        using var server = StartWatchBridgeServer(port, apiKey, logs);
        WatchBridgeE2ESessionResponse? session = null;

        try
        {
            using var http = new HttpClient { BaseAddress = baseAddress };
            await WaitForWatchBridgeServerAsync(http, server, logs, timeout.Token);

            session = await CreateWatchBridgeSessionAsync(
                http: http,
                logs: logs,
                watchVideoMode: "jpeg",
                audioEnabled: true,
                videoSettings: videoSettings,
                startScript: null,
                avatarId: avatar?.AvatarId,
                cancellationToken: timeout.Token);

            using var watch = new ClientWebSocket();
            await watch.ConnectAsync(new Uri(session.WatchWebSocketUrl), timeout.Token);

            await SendWarmupSilenceAsync(watch, timeout.Token);

            var media = await ReceiveAvatarMediaAsync(
                socket: watch,
                expectedVideoKind: WatchBridgeAvatarJpegKind,
                requireAudio: true,
                logs: logs,
                cancellationToken: timeout.Token);

            media.AudioFrame.Should().NotBeNull();
            AssertValidAudioFrame(media.AudioFrame!.Value);
            media.VideoFrame.Should().NotBeNull();
            AssertValidJpegFrame(media.VideoFrame!.Value);
            media.VideoFrame.Value.Arg0.Should().Be(videoSettings.Width);
            if (videoSettings.Height is { } expectedHeight)
            {
                media.VideoFrame.Value.Arg1.Should().Be(expectedHeight);
            }
            else
            {
                media.VideoFrame.Value.Arg1.Should().BeGreaterThan(0);
            }

            Console.WriteLine(
                $"Received avatar JPEG frame {media.VideoFrame.Value.Arg0}x{media.VideoFrame.Value.Arg1}, " +
                $"{media.VideoFrame.Value.Payload.Length} bytes, plus audio frame " +
                $"{media.AudioFrame.Value.Arg0} Hz/{media.AudioFrame.Value.Arg1} ch.");

            var status = await GetWatchBridgeSessionStatusAsync(http, session.SessionId, logs, timeout.Token);
            status.WatchAudioFrames.Should().BeGreaterThan(0);
            status.AvatarAudioFrames.Should().BeGreaterThan(0);
            status.AvatarVideoFrames.Should().BeGreaterThan(0);
            status.AvatarJpegFrames.Should().BeGreaterThan(0);
            status.DownstreamBinaryFrames.Should().BeGreaterThan(0);

            var artifacts = CreateWatchBridgeArtifactDirectory(nameof(RealtimeWatchBridge_DeliversAvatarVideoFrame));
            var jpegPath = Path.Combine(artifacts, "avatar-frame.jpg");
            var jpegFramePath = Path.Combine(artifacts, "avatar-frame.bridgeframe.bin");
            var audioFramePath = Path.Combine(artifacts, "avatar-audio-frame.bridgeframe.bin");
            await File.WriteAllBytesAsync(jpegPath, media.VideoFrame.Value.Payload, timeout.Token);
            await File.WriteAllBytesAsync(jpegFramePath, media.VideoFrame.Value.RawFrame, timeout.Token);
            await File.WriteAllBytesAsync(audioFramePath, media.AudioFrame.Value.RawFrame, timeout.Token);
            await WriteWatchBridgeArtifactManifestAsync(
                artifacts,
                new
                {
                    kind = "jpeg-audio",
                    session.SessionId,
                    session.RunwaySessionId,
                    avatar,
                    videoSettings,
                    status,
                    artifacts = new
                    {
                        jpeg = jpegPath,
                        jpegBridgeFrame = jpegFramePath,
                        audioBridgeFrame = audioFramePath,
                    },
                },
                timeout.Token);
            Console.WriteLine($"Wrote watch bridge artifacts: {artifacts}");

            await StopWatchBridgeSessionBestEffortAsync(http, session.SessionId, logs);
        }
        finally
        {
            if (session is not null)
            {
                await CancelRunwaySessionBestEffortAsync(apiKey, session.RunwaySessionId, logs);
            }

            await StopProcessAsync(server);
        }
    }

    [TestMethod]
    public async Task RealtimeWatchBridge_DeliversAvatarH264Fmp4Frame()
    {
        SkipUnlessWatchBridgeE2ETestsEnabled();
        SkipUnlessFfmpegEncoderAvailable("libx264", "H.264/fMP4");

        await RunFmp4ArtifactE2EAsync(
            watchVideoMode: "h264-fmp4",
            expectedCodecId: WatchBridgeH264CodecId,
            artifactFileName: "avatar-h264-fmp4.mp4");
    }

    [TestMethod]
    public async Task RealtimeWatchBridge_DeliversAvatarH265Fmp4Frame()
    {
        SkipUnlessWatchBridgeE2ETestsEnabled();
        SkipUnlessFfmpegEncoderAvailable("libx265", "H.265/fMP4");

        await RunFmp4ArtifactE2EAsync(
            watchVideoMode: "h265-fmp4",
            expectedCodecId: WatchBridgeH265CodecId,
            artifactFileName: "avatar-h265-fmp4.mp4");
    }

    [TestMethod]
    public async Task RealtimeWatchBridge_ProducesAvatarPngAlphaMovArtifact()
    {
        SkipUnlessWatchBridgeE2ETestsEnabled();
        SkipUnlessFfmpegEncoderAvailable("prores_ks", "ProRes 4444 alpha MOV");

        await RunPngAlphaArtifactE2EAsync();
    }

    private static async Task RunFmp4ArtifactE2EAsync(
        string watchVideoMode,
        int expectedCodecId,
        string artifactFileName)
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RUNWAY_API_KEY") is { Length: > 0 } runwayApiKey ? runwayApiKey :
            Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET") is { Length: > 0 } runwayMlApiSecret ? runwayMlApiSecret :
            throw new AssertInconclusiveException("RUNWAY_API_KEY or RUNWAYML_API_SECRET environment variable is not found.");

        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(8));
        var port = GetFreeTcpPort();
        var baseAddress = new Uri($"http://127.0.0.1:{port}");
        var logs = new ConcurrentQueue<string>();
        var artifactSettings = WatchBridgeE2EArtifactSettings.FromEnvironment();
        var videoSettings = artifactSettings.Video;
        var avatar = await ResolveWatchBridgeAvatarAsync(apiKey, artifactSettings.Avatar, logs, timeout.Token);
        using var server = StartWatchBridgeServer(port, apiKey, logs);
        WatchBridgeE2ESessionResponse? session = null;

        try
        {
            using var http = new HttpClient { BaseAddress = baseAddress };
            await WaitForWatchBridgeServerAsync(http, server, logs, timeout.Token);

            session = await CreateWatchBridgeSessionAsync(
                http: http,
                logs: logs,
                watchVideoMode: watchVideoMode,
                audioEnabled: artifactSettings.IncludeAudio,
                videoSettings: videoSettings,
                startScript: artifactSettings.StartScript,
                avatarId: avatar?.AvatarId,
                cancellationToken: timeout.Token);

            using var watch = new ClientWebSocket();
            await watch.ConnectAsync(new Uri(session.WatchWebSocketUrl), timeout.Token);
            if (artifactSettings.IncludeAudio)
            {
                await SendWarmupSilenceAsync(watch, timeout.Token);
            }

            var media = await ReceiveAvatarFmp4ArtifactAsync(
                socket: watch,
                expectedCodecId: expectedCodecId,
                requireAudio: artifactSettings.IncludeAudio,
                logs: logs,
                cancellationToken: timeout.Token);

            media.Frames.Should().NotBeEmpty();
            AssertValidFmp4Artifact(media, expectedCodecId);
            if (artifactSettings.IncludeAudio)
            {
                media.AudioFrames.Should().NotBeEmpty();
                media.AudioPayload.Should().NotBeEmpty();
            }

            Console.WriteLine(
                $"Received avatar {watchVideoMode} artifact {media.Payload.Length} bytes across {media.Frames.Count} chunks.");

            var status = await GetWatchBridgeSessionStatusAsync(http, session.SessionId, logs, timeout.Token);
            status.AvatarVideoFrames.Should().BeGreaterThan(0);
            status.AvatarFmp4Frames.Should().BeGreaterThan(0);
            status.DownstreamBinaryFrames.Should().BeGreaterThan(0);
            if (artifactSettings.IncludeAudio)
            {
                status.WatchAudioFrames.Should().BeGreaterThan(0);
                status.AvatarAudioFrames.Should().BeGreaterThan(0);
            }

            var artifacts = CreateWatchBridgeArtifactDirectory($"RealtimeWatchBridge_{watchVideoMode}");
            var mp4Path = Path.Combine(artifacts, artifactFileName);
            var rawFramesPath = Path.Combine(artifacts, Path.ChangeExtension(artifactFileName, ".bridgeframes.bin"));
            await File.WriteAllBytesAsync(mp4Path, media.Payload, timeout.Token);
            await File.WriteAllBytesAsync(rawFramesPath, media.RawFrames, timeout.Token);
            var mkvPath = await TryRemuxToMkvAsync(mp4Path, logs, timeout.Token);
            string? audioPcmPath = null;
            string? audioRawFramesPath = null;
            string? muxedMp4Path = null;
            string? muxedMkvPath = null;
            AudioVideoSyncOffset? audioVideoSync = null;
            if (media.AudioPayload.Length > 0)
            {
                audioVideoSync = AudioVideoSyncOffset.From(media);
                audioPcmPath = Path.Combine(artifacts, Path.ChangeExtension(artifactFileName, ".audio.pcm"));
                audioRawFramesPath = Path.Combine(artifacts, Path.ChangeExtension(artifactFileName, ".audio.bridgeframes.bin"));
                await File.WriteAllBytesAsync(audioPcmPath, media.AudioPayload, timeout.Token);
                await File.WriteAllBytesAsync(audioRawFramesPath, media.RawAudioFrames, timeout.Token);
                muxedMp4Path = await TryMuxFmp4WithPcmAudioAsync(
                    videoMp4Path: mp4Path,
                    audioPcmPath: audioPcmPath,
                    audioSampleRate: media.AudioSampleRate,
                    audioChannels: media.AudioChannels,
                    audioBitrateKbps: artifactSettings.AudioBitrateKbps,
                    audioTrimUs: audioVideoSync.AudioTrimUs,
                    audioDelayUs: audioVideoSync.AudioDelayUs,
                    logs: logs,
                    cancellationToken: timeout.Token);
                muxedMkvPath = muxedMp4Path is null
                    ? null
                    : await TryRemuxToMkvAsync(muxedMp4Path, logs, timeout.Token);
            }

            await WriteWatchBridgeArtifactManifestAsync(
                artifacts,
                new
                {
                    kind = watchVideoMode,
                    session.SessionId,
                    session.RunwaySessionId,
                    avatar,
                    artifactSettings,
                    videoSettings,
                    status,
                    chunkCount = media.Frames.Count,
                    payloadBytes = media.Payload.Length,
                    rawFrameBytes = media.RawFrames.Length,
                    audioChunkCount = media.AudioFrames.Count,
                    audioPayloadBytes = media.AudioPayload.Length,
                    media.AudioSampleRate,
                    media.AudioChannels,
                    audioVideoSync,
                    artifacts = new
                    {
                        mp4 = mp4Path,
                        mkv = mkvPath,
                        rawBridgeFrames = rawFramesPath,
                        audioPcm = audioPcmPath,
                        audioBridgeFrames = audioRawFramesPath,
                        muxedMp4 = muxedMp4Path,
                        muxedMkv = muxedMkvPath,
                    },
                },
                timeout.Token);
            Console.WriteLine($"Wrote watch bridge artifacts: {artifacts}");

            await StopWatchBridgeSessionBestEffortAsync(http, session.SessionId, logs);
        }
        finally
        {
            if (session is not null)
            {
                await CancelRunwaySessionBestEffortAsync(apiKey, session.RunwaySessionId, logs);
            }

            await StopProcessAsync(server);
        }
    }

    private static async Task RunPngAlphaArtifactE2EAsync()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RUNWAY_API_KEY") is { Length: > 0 } runwayApiKey ? runwayApiKey :
            Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET") is { Length: > 0 } runwayMlApiSecret ? runwayMlApiSecret :
            throw new AssertInconclusiveException("RUNWAY_API_KEY or RUNWAYML_API_SECRET environment variable is not found.");

        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(8));
        var port = GetFreeTcpPort();
        var baseAddress = new Uri($"http://127.0.0.1:{port}");
        var logs = new ConcurrentQueue<string>();
        var artifactSettings = WatchBridgeE2EArtifactSettings.FromEnvironment();
        var videoSettings = artifactSettings.Video;
        var avatar = await ResolveWatchBridgeAvatarAsync(apiKey, artifactSettings.Avatar, logs, timeout.Token);
        using var server = StartWatchBridgeServer(port, apiKey, logs);
        WatchBridgeE2ESessionResponse? session = null;

        try
        {
            using var http = new HttpClient { BaseAddress = baseAddress };
            await WaitForWatchBridgeServerAsync(http, server, logs, timeout.Token);

            session = await CreateWatchBridgeSessionAsync(
                http: http,
                logs: logs,
                watchVideoMode: "png",
                audioEnabled: true,
                videoSettings: videoSettings,
                startScript: artifactSettings.StartScript,
                avatarId: avatar?.AvatarId,
                cancellationToken: timeout.Token);

            using var watch = new ClientWebSocket();
            await watch.ConnectAsync(new Uri(session.WatchWebSocketUrl), timeout.Token);
            await SendWarmupSilenceAsync(watch, timeout.Token);

            var media = await ReceiveAvatarImageSequenceArtifactAsync(
                socket: watch,
                expectedVideoKind: WatchBridgeAvatarPngKind,
                minDuration: TimeSpan.FromSeconds(4),
                logs: logs,
                cancellationToken: timeout.Token);

            media.Frames.Should().NotBeEmpty();
            media.Frames.Should().OnlyContain(frame => frame.Kind == WatchBridgeAvatarPngKind);
            foreach (var frame in media.Frames)
            {
                AssertValidPngFrame(frame);
            }

            var status = await GetWatchBridgeSessionStatusAsync(http, session.SessionId, logs, timeout.Token);
            status.AvatarVideoFrames.Should().BeGreaterThan(0);
            status.DownstreamBinaryFrames.Should().BeGreaterThan(0);

            var artifacts = CreateWatchBridgeArtifactDirectory("RealtimeWatchBridge_png-alpha");
            var frameDirectory = Path.Combine(artifacts, "frames");
            Directory.CreateDirectory(frameDirectory);

            for (var index = 0; index < media.Frames.Count; index++)
            {
                var framePath = Path.Combine(frameDirectory, FormattableString.Invariant($"frame-{index + 1:0000}.png"));
                await File.WriteAllBytesAsync(framePath, media.Frames[index].Payload, timeout.Token);
            }

            var rawFramesPath = Path.Combine(artifacts, "avatar-png.bridgeframes.bin");
            await File.WriteAllBytesAsync(rawFramesPath, media.RawFrames, timeout.Token);

            var firstFramePath = Path.Combine(frameDirectory, "frame-0001.png");
            var firstFrameAlpha = await ReadPngAlphaStatsAsync(firstFramePath, timeout.Token);
            var alphaProbe = media.TextMessages.LastOrDefault(message =>
                message.Contains("\"type\":\"avatar-video-alpha-probe\"", StringComparison.OrdinalIgnoreCase));
            var alphaMovPath = await TryEncodePngSequenceToAlphaMovAsync(
                frameDirectory: frameDirectory,
                fps: videoSettings.Fps,
                logs: logs,
                cancellationToken: timeout.Token);

            await WriteWatchBridgeArtifactManifestAsync(
                artifacts,
                new
                {
                    kind = "png-alpha",
                    session.SessionId,
                    session.RunwaySessionId,
                    avatar,
                    artifactSettings,
                    videoSettings,
                    status,
                    frameCount = media.Frames.Count,
                    rawFrameBytes = media.RawFrames.Length,
                    firstFrameAlpha,
                    alphaProbe,
                    textMessages = media.TextMessages,
                    artifacts = new
                    {
                        frames = frameDirectory,
                        firstFrame = firstFramePath,
                        rawBridgeFrames = rawFramesPath,
                        alphaMov = alphaMovPath,
                    },
                },
                timeout.Token);
            Console.WriteLine($"Wrote watch bridge PNG alpha artifacts: {artifacts}");

            await StopWatchBridgeSessionBestEffortAsync(http, session.SessionId, logs);
        }
        finally
        {
            if (session is not null)
            {
                await CancelRunwaySessionBestEffortAsync(apiKey, session.RunwaySessionId, logs);
            }

            await StopProcessAsync(server);
        }
    }

    private static void SkipUnlessWatchBridgeE2ETestsEnabled()
    {
        var value = Environment.GetEnvironmentVariable("RUNWAY_RUN_WATCH_BRIDGE_E2E_TESTS");
        var enabled =
            string.Equals(value, "true", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(value, "1", StringComparison.OrdinalIgnoreCase);

        if (!enabled)
        {
            throw new AssertInconclusiveException(
                "Set RUNWAY_RUN_WATCH_BRIDGE_E2E_TESTS=true to run this paid realtime watch bridge e2e test.");
        }
    }

    private static void SkipUnlessFfmpegEncoderAvailable(string encoderName, string description)
    {
        var ffmpeg = Environment.GetEnvironmentVariable("FFMPEG_BINARY") is { Length: > 0 } configured
            ? configured
            : FindExecutableOnPath("ffmpeg");

        if (ffmpeg is null)
        {
            throw new AssertInconclusiveException($"ffmpeg is required for the {description} watch bridge e2e test.");
        }

        var startInfo = new ProcessStartInfo
        {
            FileName = ffmpeg,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        startInfo.ArgumentList.Add("-hide_banner");
        startInfo.ArgumentList.Add("-encoders");

        using var process = Process.Start(startInfo)
            ?? throw new AssertInconclusiveException("Failed to start ffmpeg.");
        var stdout = process.StandardOutput.ReadToEnd();
        var stderr = process.StandardError.ReadToEnd();

        if (!process.WaitForExit(milliseconds: 5_000))
        {
            process.Kill(entireProcessTree: true);
            throw new AssertInconclusiveException($"Timed out checking ffmpeg {description} encoder availability.");
        }

        var output = stdout + stderr;
        if (!output.Contains(encoderName, StringComparison.OrdinalIgnoreCase))
        {
            throw new AssertInconclusiveException($"ffmpeg must include {encoderName} for the {description} e2e test.");
        }
    }

    private static async Task<WatchBridgeE2EAvatarResolution?> ResolveWatchBridgeAvatarAsync(
        string apiKey,
        WatchBridgeE2EAvatarSettings settings,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        if (settings.AvatarId is { } existingAvatarId)
        {
            return new WatchBridgeE2EAvatarResolution(
                AvatarId: existingAvatarId,
                Source: "existing",
                ReferenceImagePath: settings.ReferenceImagePath);
        }

        if (settings.ReferenceImagePath is not { Length: > 0 } referenceImagePath)
        {
            return null;
        }

        if (!File.Exists(referenceImagePath))
        {
            throw new AssertInconclusiveException($"Avatar reference image '{referenceImagePath}' was not found.");
        }

        var imageBytes = await File.ReadAllBytesAsync(referenceImagePath, cancellationToken);
        var referenceImage = CreateImageDataUri(referenceImagePath, imageBytes);
        if (referenceImage.Length > 5_242_880)
        {
            throw new AssertInconclusiveException(
                $"Avatar reference image data URI is {referenceImage.Length:n0} characters; Runway accepts up to 5,242,880.");
        }

        using var client = new RunwayClient(apiKey);
        var created = await client.Avatars.CreateAvatarsAsync(
            request: new CreateAvatarsRequest
            {
                Name = settings.Name,
                ReferenceImage = referenceImage,
                Personality = settings.Personality,
                StartScript = settings.StartScript,
                Voice = new CreateAvatarsRequestVoiceRunwayLivePresetVoice
                {
                    PresetId = ParseCreateAvatarVoicePreset(settings.VoicePreset),
                },
                ImageProcessing = settings.ImageProcessing,
            },
            cancellationToken: cancellationToken);

        if (IsAvatarFailed(created))
        {
            throw new AssertFailedException($"Runway avatar creation failed: {GetAvatarFailureReason(created)}");
        }

        var avatarId = created.Ready?.Id ?? created.Processing?.Id ?? created.Failed?.Id
            ?? throw new AssertFailedException("Runway avatar creation returned no avatar id.");
        logs.Enqueue($"[avatar] Created custom avatar {avatarId} from {referenceImagePath}.");

        if (!IsAvatarReady(created))
        {
            await WaitForCustomAvatarReadyAsync(client, avatarId, logs, cancellationToken);
        }

        return new WatchBridgeE2EAvatarResolution(
            AvatarId: avatarId,
            Source: "created",
            ReferenceImagePath: referenceImagePath);
    }

    private static async Task WaitForCustomAvatarReadyAsync(
        RunwayClient client,
        Guid avatarId,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var deadline = DateTimeOffset.UtcNow.AddMinutes(6);
        while (DateTimeOffset.UtcNow < deadline)
        {
            var avatar = await client.Avatars.GetAvatarsByIdAsync(
                id: avatarId,
                cancellationToken: cancellationToken);

            var status = GetAvatarStatus(avatar);
            if (string.Equals(status, "READY", StringComparison.OrdinalIgnoreCase))
            {
                logs.Enqueue($"[avatar] Custom avatar {avatarId} is READY.");
                return;
            }

            if (string.Equals(status, "FAILED", StringComparison.OrdinalIgnoreCase))
            {
                throw new AssertFailedException($"Runway avatar {avatarId} failed: {GetAvatarFailureReason(avatar)}");
            }

            logs.Enqueue($"[avatar] Custom avatar {avatarId} is still {status ?? "PROCESSING"}.");
            await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
        }

        throw new AssertFailedException($"Timed out waiting for Runway avatar {avatarId} to become READY.");
    }

    private static string CreateImageDataUri(string path, byte[] bytes)
    {
        var mimeType = Path.GetExtension(path).ToLowerInvariant() switch
        {
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".webp" => "image/webp",
            _ => throw new AssertInconclusiveException("Reference image must be a .jpg, .jpeg, .png, or .webp file."),
        };

        return $"data:{mimeType};base64,{Convert.ToBase64String(bytes)}";
    }

    private static bool IsAvatarReady(CreateAvatarsResponse avatar)
    {
        return string.Equals(GetAvatarStatus(avatar), "READY", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsAvatarFailed(CreateAvatarsResponse avatar)
    {
        return string.Equals(GetAvatarStatus(avatar), "FAILED", StringComparison.OrdinalIgnoreCase);
    }

    private static string? GetAvatarStatus(CreateAvatarsResponse avatar)
    {
        return avatar.Ready?.Status ?? avatar.Processing?.Status ?? avatar.Failed?.Status;
    }

    private static string? GetAvatarStatus(GetAvatarsResponse2 avatar)
    {
        return avatar.Ready?.Status ?? avatar.Processing?.Status ?? avatar.Failed?.Status;
    }

    private static string GetAvatarFailureReason(CreateAvatarsResponse avatar)
    {
        return avatar.Failed?.FailureReason ?? "unknown failure";
    }

    private static string GetAvatarFailureReason(GetAvatarsResponse2 avatar)
    {
        return avatar.Failed?.FailureReason ?? "unknown failure";
    }

    private static CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId ParseCreateAvatarVoicePreset(string value)
    {
        return CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdExtensions.ToEnum(value)
            ?? throw new AssertInconclusiveException($"Unsupported avatar voice preset '{value}'.");
    }

    private static async Task<WatchBridgeE2ESessionResponse> CreateWatchBridgeSessionAsync(
        HttpClient http,
        ConcurrentQueue<string> logs,
        string watchVideoMode,
        bool audioEnabled,
        WatchBridgeE2EVideoSettings videoSettings,
        string? startScript,
        Guid? avatarId,
        CancellationToken cancellationToken)
    {
        var response = await http.PostAsJsonAsync(
            "/sessions",
            new
            {
                presetAvatar = avatarId is null ? "influencer" : null,
                avatarId,
                maxDurationSeconds = 60,
                startScript = avatarId is null ? null : startScript,
                audioEnabled,
                videoEnabled = true,
                watchAudioSampleRate = 16000,
                watchAudioChannels = 1,
                watchAudioFrameMs = 20,
                watchVideoMode,
                watchVideoEncoder = videoSettings.Encoder,
                watchVideoWidth = videoSettings.Width,
                watchVideoHeight = videoSettings.Height,
                watchVideoResizeMode = videoSettings.ResizeMode,
                watchVideoCropTop = videoSettings.CropTop,
                watchVideoFps = videoSettings.Fps,
                watchJpegQuality = videoSettings.JpegQuality,
                watchVideoBitrateKbps = videoSettings.BitrateKbps,
                watchFmp4FragmentMs = videoSettings.FragmentMs,
            },
            cancellationToken: cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var error = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new AssertFailedException(
                $"Failed to create watch bridge session: HTTP {(int)response.StatusCode}. {error}\n{LastLines(logs)}");
        }

        var session = await response.Content.ReadFromJsonAsync<WatchBridgeE2ESessionResponse>(
            cancellationToken: cancellationToken);
        session.Should().NotBeNull();
        session!.WatchWebSocketUrl.Should().StartWith("ws://");
        return session;
    }

    private static async Task<WatchBridgeE2ESessionStatus> GetWatchBridgeSessionStatusAsync(
        HttpClient http,
        string sessionId,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var response = await http.GetAsync($"/sessions/{sessionId}", cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            var error = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new AssertFailedException(
                $"Failed to get watch bridge session status: HTTP {(int)response.StatusCode}. {error}\n{LastLines(logs)}");
        }

        var status = await response.Content.ReadFromJsonAsync<WatchBridgeE2ESessionStatus>(
            cancellationToken: cancellationToken);
        status.Should().NotBeNull();
        return status!;
    }

    private static async Task StopWatchBridgeSessionBestEffortAsync(
        HttpClient http,
        string sessionId,
        ConcurrentQueue<string> logs)
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        try
        {
            using var response = await http.DeleteAsync($"/sessions/{sessionId}", timeout.Token);
            if (!response.IsSuccessStatusCode)
            {
                logs.Enqueue($"[cleanup] DELETE /sessions/{sessionId} returned HTTP {(int)response.StatusCode}.");
            }
        }
        catch (Exception exception) when (exception is HttpRequestException or TaskCanceledException or OperationCanceledException)
        {
            logs.Enqueue($"[cleanup] DELETE /sessions/{sessionId} did not complete: {exception.GetType().Name}.");
        }
    }

    private static async Task CancelRunwaySessionBestEffortAsync(
        string apiKey,
        Guid runwaySessionId,
        ConcurrentQueue<string> logs)
    {
        try
        {
            using var client = new RunwayClient(apiKey);
            await client.RealtimeSessions.DeleteRealtimeSessionsByIdAsync(id: runwaySessionId);
        }
        catch (Exception exception)
        {
            logs.Enqueue($"[cleanup] Runway realtime session cancel for {runwaySessionId} returned {exception.GetType().Name}.");
        }
    }

    private static Process StartWatchBridgeServer(
        int port,
        string apiKey,
        ConcurrentQueue<string> logs)
    {
        var projectPath = FindProjectFromBaseDirectory(
            "samples",
            "Runway.RealtimeWatchBridge",
            "Runway.RealtimeWatchBridge.csproj");

        var startInfo = new ProcessStartInfo
        {
            FileName = "dotnet",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        startInfo.ArgumentList.Add("run");
        startInfo.ArgumentList.Add("--project");
        startInfo.ArgumentList.Add(projectPath);
        startInfo.ArgumentList.Add("--no-launch-profile");
        startInfo.Environment["ASPNETCORE_URLS"] = $"http://127.0.0.1:{port}";
        startInfo.Environment["RUNWAY_API_KEY"] = apiKey;
        startInfo.Environment["RUNWAY_WATCH_BRIDGE_RUNTIME"] = "dotnet";
        startInfo.Environment["RUNWAY_WATCH_BRIDGE_CONFIGURATION"] = "Debug";

        var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Failed to start watch bridge sample.");

        _ = Task.Run(() => PumpProcessOutputAsync(process.StandardOutput, logs, "stdout"));
        _ = Task.Run(() => PumpProcessOutputAsync(process.StandardError, logs, "stderr"));

        return process;
    }

    private static async Task WaitForWatchBridgeServerAsync(
        HttpClient http,
        Process server,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var deadline = DateTimeOffset.UtcNow.AddSeconds(45);
        while (DateTimeOffset.UtcNow < deadline)
        {
            if (server.HasExited)
            {
                throw new AssertFailedException(
                    $"Watch bridge sample exited with code {server.ExitCode}.\n{LastLines(logs)}");
            }

            try
            {
                using var response = await http.GetAsync("/", cancellationToken);
                if (response.IsSuccessStatusCode)
                {
                    return;
                }
            }
            catch (HttpRequestException)
            {
            }
            catch (SocketException)
            {
            }

            await Task.Delay(TimeSpan.FromMilliseconds(500), cancellationToken);
        }

        throw new AssertFailedException($"Timed out waiting for watch bridge sample.\n{LastLines(logs)}");
    }

    private static async Task SendWarmupSilenceAsync(
        ClientWebSocket socket,
        CancellationToken cancellationToken)
    {
        var payloadBytes = 320 * sizeof(short);
        var frame = new byte[WatchBridgeHeaderBytes + payloadBytes];
        frame[0] = 17;
        frame[1] = WatchBridgeProtocolVersion;
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(2), WatchBridgeHeaderBytes);
        BinaryPrimitives.WriteUInt32LittleEndian(frame.AsSpan(16), (uint)payloadBytes);
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(20), 16000);
        BinaryPrimitives.WriteUInt16LittleEndian(frame.AsSpan(22), 1);

        for (var i = 0; i < 20; i++)
        {
            BinaryPrimitives.WriteUInt32LittleEndian(frame.AsSpan(4), (uint)i);
            BinaryPrimitives.WriteUInt64LittleEndian(
                frame.AsSpan(8),
                (ulong)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1000));

            await socket.SendAsync(
                new ArraySegment<byte>(frame),
                WebSocketMessageType.Binary,
                endOfMessage: true,
                cancellationToken);
            await Task.Delay(TimeSpan.FromMilliseconds(20), cancellationToken);
        }
    }

    private static async Task<WatchBridgeMediaResult> ReceiveAvatarMediaAsync(
        ClientWebSocket socket,
        byte expectedVideoKind,
        bool requireAudio,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var deadline = DateTimeOffset.UtcNow.AddSeconds(90);
        var textMessages = new List<string>();
        WatchBridgeFrame? audioFrame = null;
        WatchBridgeFrame? videoFrame = null;

        while (DateTimeOffset.UtcNow < deadline)
        {
            WebSocketE2EMessage? message;
            using (var receiveTimeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
            {
                receiveTimeout.CancelAfter(deadline - DateTimeOffset.UtcNow);
                try
                {
                    message = await ReceiveWebSocketMessageAsync(socket, receiveTimeout.Token);
                }
                catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
                {
                    break;
                }
            }

            if (message is null)
            {
                throw new AssertFailedException("Watch WebSocket closed before an avatar video frame arrived.");
            }

            if (message.Value.MessageType == WebSocketMessageType.Text)
            {
                textMessages.Add(Encoding.UTF8.GetString(message.Value.Payload));
                continue;
            }

            if (!TryParseWatchBridgeFrame(message.Value.Payload, out var frame))
            {
                continue;
            }

            if (frame.Kind == WatchBridgeAvatarAudioKind && audioFrame is null)
            {
                audioFrame = frame;
            }
            else if (frame.Kind == expectedVideoKind && videoFrame is null)
            {
                videoFrame = frame;
            }

            if (videoFrame is not null && (!requireAudio || audioFrame is not null))
            {
                return new WatchBridgeMediaResult(audioFrame, videoFrame);
            }
        }

        throw new AssertFailedException(
            $"Timed out waiting for avatar media. Audio received: {audioFrame is not null}. " +
            $"Video kind {expectedVideoKind} received: {videoFrame is not null}. " +
            $"Text messages: {string.Join(", ", textMessages.TakeLast(20))}\n{LastLines(logs)}");
    }

    private static async Task<WatchBridgeFmp4Artifact> ReceiveAvatarFmp4ArtifactAsync(
        ClientWebSocket socket,
        int expectedCodecId,
        bool requireAudio,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var deadline = DateTimeOffset.UtcNow.AddSeconds(90);
        var textMessages = new List<string>();
        var frames = new List<WatchBridgeFrame>();
        var audioFrames = new List<WatchBridgeFrame>();
        await using var payloadStream = new MemoryStream();
        await using var rawFrameStream = new MemoryStream();
        await using var audioPayloadStream = new MemoryStream();
        await using var rawAudioFrameStream = new MemoryStream();
        DateTimeOffset? firstVideoFrameAt = null;
        int? audioSampleRate = null;
        int? audioChannels = null;

        while (DateTimeOffset.UtcNow < deadline)
        {
            WebSocketE2EMessage? message;
            using (var receiveTimeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
            {
                receiveTimeout.CancelAfter(deadline - DateTimeOffset.UtcNow);
                try
                {
                    message = await ReceiveWebSocketMessageAsync(socket, receiveTimeout.Token);
                }
                catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
                {
                    break;
                }
            }

            if (message is null)
            {
                throw new AssertFailedException("Watch WebSocket closed before an avatar fMP4 frame arrived.");
            }

            if (message.Value.MessageType == WebSocketMessageType.Text)
            {
                textMessages.Add(Encoding.UTF8.GetString(message.Value.Payload));
                continue;
            }

            if (!TryParseWatchBridgeFrame(message.Value.Payload, out var frame))
            {
                continue;
            }

            if (frame.Kind == WatchBridgeAvatarAudioKind)
            {
                AssertValidAudioFrame(frame);
                audioSampleRate ??= frame.Arg0;
                audioChannels ??= frame.Arg1;
                frame.Arg0.Should().Be(audioSampleRate.Value);
                frame.Arg1.Should().Be(audioChannels.Value);
                audioFrames.Add(frame);
                await audioPayloadStream.WriteAsync(frame.Payload, cancellationToken);
                await rawAudioFrameStream.WriteAsync(frame.RawFrame, cancellationToken);
                continue;
            }

            if (frame.Kind != WatchBridgeAvatarFmp4Kind)
            {
                continue;
            }

            frame.Arg0.Should().Be(expectedCodecId);
            firstVideoFrameAt ??= DateTimeOffset.UtcNow;
            frames.Add(frame);
            await payloadStream.WriteAsync(frame.Payload, cancellationToken);
            await rawFrameStream.WriteAsync(frame.RawFrame, cancellationToken);

            var payload = TrimToCompleteMp4Boxes(payloadStream.ToArray());
            if (DateTimeOffset.UtcNow - firstVideoFrameAt >= TimeSpan.FromSeconds(4) &&
                IsUsableFmp4Artifact(payload) &&
                (!requireAudio || audioFrames.Count > 0))
            {
                return new WatchBridgeFmp4Artifact(
                    Frames: frames,
                    Payload: payload,
                    RawFrames: rawFrameStream.ToArray(),
                    AudioFrames: audioFrames,
                    AudioPayload: audioPayloadStream.ToArray(),
                    RawAudioFrames: rawAudioFrameStream.ToArray(),
                    AudioSampleRate: audioSampleRate ?? 0,
                    AudioChannels: audioChannels ?? 0);
            }
        }

        var finalPayload = TrimToCompleteMp4Boxes(payloadStream.ToArray());
        if (frames.Count > 0 &&
            IsUsableFmp4Artifact(finalPayload) &&
            (!requireAudio || audioFrames.Count > 0))
        {
            return new WatchBridgeFmp4Artifact(
                Frames: frames,
                Payload: finalPayload,
                RawFrames: rawFrameStream.ToArray(),
                AudioFrames: audioFrames,
                AudioPayload: audioPayloadStream.ToArray(),
                RawAudioFrames: rawAudioFrameStream.ToArray(),
                AudioSampleRate: audioSampleRate ?? 0,
                AudioChannels: audioChannels ?? 0);
        }

        throw new AssertFailedException(
            $"Timed out waiting for complete fMP4 artifact. Chunks: {frames.Count}, bytes: {payloadStream.Length}, " +
            $"audio chunks: {audioFrames.Count}, audio bytes: {audioPayloadStream.Length}. " +
            $"Text messages: {string.Join(", ", textMessages.TakeLast(20))}\n{LastLines(logs)}");
    }

    private static async Task<WatchBridgeImageSequenceArtifact> ReceiveAvatarImageSequenceArtifactAsync(
        ClientWebSocket socket,
        byte expectedVideoKind,
        TimeSpan minDuration,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var deadline = DateTimeOffset.UtcNow.AddSeconds(90);
        var textMessages = new List<string>();
        var frames = new List<WatchBridgeFrame>();
        await using var rawFrameStream = new MemoryStream();
        DateTimeOffset? firstVideoFrameAt = null;

        while (DateTimeOffset.UtcNow < deadline)
        {
            WebSocketE2EMessage? message;
            using (var receiveTimeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
            {
                receiveTimeout.CancelAfter(deadline - DateTimeOffset.UtcNow);
                try
                {
                    message = await ReceiveWebSocketMessageAsync(socket, receiveTimeout.Token);
                }
                catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
                {
                    break;
                }
            }

            if (message is null)
            {
                throw new AssertFailedException("Watch WebSocket closed before an avatar image frame arrived.");
            }

            if (message.Value.MessageType == WebSocketMessageType.Text)
            {
                textMessages.Add(Encoding.UTF8.GetString(message.Value.Payload));
                continue;
            }

            if (!TryParseWatchBridgeFrame(message.Value.Payload, out var frame) ||
                frame.Kind != expectedVideoKind)
            {
                continue;
            }

            firstVideoFrameAt ??= DateTimeOffset.UtcNow;
            frames.Add(frame);
            await rawFrameStream.WriteAsync(frame.RawFrame, cancellationToken);

            if (DateTimeOffset.UtcNow - firstVideoFrameAt >= minDuration &&
                frames.Count >= Math.Max(2, (int)Math.Ceiling(minDuration.TotalSeconds)))
            {
                return new WatchBridgeImageSequenceArtifact(
                    Frames: frames,
                    RawFrames: rawFrameStream.ToArray(),
                    TextMessages: textMessages);
            }
        }

        if (frames.Count > 0)
        {
            return new WatchBridgeImageSequenceArtifact(
                Frames: frames,
                RawFrames: rawFrameStream.ToArray(),
                TextMessages: textMessages);
        }

        throw new AssertFailedException(
            $"Timed out waiting for avatar image sequence. Frames: {frames.Count}. " +
            $"Text messages: {string.Join(", ", textMessages.TakeLast(20))}\n{LastLines(logs)}");
    }

    private static async Task<WebSocketE2EMessage?> ReceiveWebSocketMessageAsync(
        ClientWebSocket socket,
        CancellationToken cancellationToken)
    {
        var buffer = new byte[1024 * 1024];
        await using var stream = new MemoryStream();

        while (true)
        {
            var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);
            if (result.MessageType == WebSocketMessageType.Close)
            {
                return null;
            }

            stream.Write(buffer, 0, result.Count);
            if (result.EndOfMessage)
            {
                return new WebSocketE2EMessage(result.MessageType, stream.ToArray());
            }
        }
    }

    private static bool TryParseWatchBridgeFrame(
        byte[] message,
        out WatchBridgeFrame frame)
    {
        frame = default;
        if (message.Length < WatchBridgeHeaderBytes)
        {
            return false;
        }

        var headerBytes = BinaryPrimitives.ReadUInt16LittleEndian(message.AsSpan(2));
        var payloadBytes = BinaryPrimitives.ReadUInt32LittleEndian(message.AsSpan(16));
        if (message[1] != WatchBridgeProtocolVersion ||
            headerBytes != WatchBridgeHeaderBytes ||
            payloadBytes != message.Length - WatchBridgeHeaderBytes)
        {
            return false;
        }

        frame = new WatchBridgeFrame(
            Kind: message[0],
            Sequence: BinaryPrimitives.ReadUInt32LittleEndian(message.AsSpan(4)),
            TimestampUs: (long)BinaryPrimitives.ReadUInt64LittleEndian(message.AsSpan(8)),
            Arg0: BinaryPrimitives.ReadUInt16LittleEndian(message.AsSpan(20)),
            Arg1: BinaryPrimitives.ReadUInt16LittleEndian(message.AsSpan(22)),
            Payload: message.AsSpan(WatchBridgeHeaderBytes).ToArray(),
            RawFrame: message);
        return true;
    }

    private static void AssertValidAudioFrame(WatchBridgeFrame frame)
    {
        frame.Kind.Should().Be(WatchBridgeAvatarAudioKind);
        frame.Arg0.Should().BeGreaterThan(0);
        frame.Arg1.Should().BeGreaterThan(0);
        frame.Payload.Length.Should().BeGreaterThan(0);
        (frame.Payload.Length % sizeof(short)).Should().Be(0);
    }

    private static void AssertValidJpegFrame(WatchBridgeFrame frame)
    {
        frame.Kind.Should().Be(WatchBridgeAvatarJpegKind);
        frame.Arg0.Should().BeGreaterThan(0);
        frame.Arg1.Should().BeGreaterThan(0);
        frame.Payload.Length.Should().BeGreaterThan(100);
        frame.Payload[0].Should().Be(0xFF);
        frame.Payload[1].Should().Be(0xD8);
        frame.Payload[^2].Should().Be(0xFF);
        frame.Payload[^1].Should().Be(0xD9);
    }

    private static void AssertValidPngFrame(WatchBridgeFrame frame)
    {
        frame.Kind.Should().Be(WatchBridgeAvatarPngKind);
        frame.Arg0.Should().BeGreaterThan(0);
        frame.Arg1.Should().BeGreaterThan(0);
        frame.Payload.Length.Should().BeGreaterThan(100);
        frame.Payload[0].Should().Be(0x89);
        frame.Payload[1].Should().Be(0x50);
        frame.Payload[2].Should().Be(0x4E);
        frame.Payload[3].Should().Be(0x47);
    }

    private static void AssertValidFmp4Artifact(
        WatchBridgeFmp4Artifact artifact,
        int expectedCodecId)
    {
        artifact.Frames.Should().OnlyContain(frame =>
            frame.Kind == WatchBridgeAvatarFmp4Kind &&
            frame.Arg0 == expectedCodecId &&
            frame.Payload.Length > 0);
        IsUsableFmp4Artifact(artifact.Payload).Should().BeTrue();
    }

    private static bool IsUsableFmp4Artifact(byte[] payload)
    {
        return payload.Length > 1024 &&
            ContainsAscii(payload, "ftyp") &&
            ContainsAscii(payload, "moof") &&
            ContainsAscii(payload, "mdat");
    }

    private static byte[] TrimToCompleteMp4Boxes(byte[] payload)
    {
        var offset = 0;
        while (offset + 8 <= payload.Length)
        {
            var boxSize = BinaryPrimitives.ReadUInt32BigEndian(payload.AsSpan(offset));
            var headerBytes = 8;
            long resolvedSize = boxSize;

            if (boxSize == 1)
            {
                if (offset + 16 > payload.Length)
                {
                    break;
                }

                resolvedSize = (long)BinaryPrimitives.ReadUInt64BigEndian(payload.AsSpan(offset + 8));
                headerBytes = 16;
            }

            if (resolvedSize < headerBytes ||
                resolvedSize > int.MaxValue ||
                offset + resolvedSize > payload.Length)
            {
                break;
            }

            offset += (int)resolvedSize;
        }

        return offset == payload.Length ? payload : payload[..offset];
    }

    private static async Task<string?> TryRemuxToMkvAsync(
        string mp4Path,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var ffmpeg = Environment.GetEnvironmentVariable("FFMPEG_BINARY") is { Length: > 0 } configured
            ? configured
            : FindExecutableOnPath("ffmpeg");
        if (ffmpeg is null)
        {
            return null;
        }

        var mkvPath = Path.ChangeExtension(mp4Path, ".mkv");
        var startInfo = new ProcessStartInfo
        {
            FileName = ffmpeg,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        startInfo.ArgumentList.Add("-y");
        startInfo.ArgumentList.Add("-v");
        startInfo.ArgumentList.Add("error");
        startInfo.ArgumentList.Add("-err_detect");
        startInfo.ArgumentList.Add("ignore_err");
        startInfo.ArgumentList.Add("-i");
        startInfo.ArgumentList.Add(mp4Path);
        startInfo.ArgumentList.Add("-c");
        startInfo.ArgumentList.Add("copy");
        startInfo.ArgumentList.Add(mkvPath);

        using var process = Process.Start(startInfo);
        if (process is null)
        {
            return null;
        }

        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeout.CancelAfter(TimeSpan.FromSeconds(15));

        try
        {
            var stderrTask = process.StandardError.ReadToEndAsync(timeout.Token);
            await process.WaitForExitAsync(timeout.Token);
            var stderr = await stderrTask;
            if (process.ExitCode == 0 && File.Exists(mkvPath))
            {
                return mkvPath;
            }

            logs.Enqueue($"[artifact] ffmpeg remux failed with exit {process.ExitCode}: {stderr}");
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                process.Kill(entireProcessTree: true);
            }
            catch (InvalidOperationException)
            {
            }

            logs.Enqueue("[artifact] ffmpeg remux timed out.");
        }

        return null;
    }

    private static async Task<string?> TryMuxFmp4WithPcmAudioAsync(
        string videoMp4Path,
        string audioPcmPath,
        int audioSampleRate,
        int audioChannels,
        int audioBitrateKbps,
        long audioTrimUs,
        long audioDelayUs,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        if (audioSampleRate <= 0 || audioChannels <= 0)
        {
            logs.Enqueue("[artifact] audio mux skipped because audio sample rate/channels were not captured.");
            return null;
        }

        var ffmpeg = Environment.GetEnvironmentVariable("FFMPEG_BINARY") is { Length: > 0 } configured
            ? configured
            : FindExecutableOnPath("ffmpeg");
        if (ffmpeg is null)
        {
            return null;
        }

        var muxedPath = Path.Combine(
            Path.GetDirectoryName(videoMp4Path)!,
            $"{Path.GetFileNameWithoutExtension(videoMp4Path)}.with-audio.mp4");
        var startInfo = new ProcessStartInfo
        {
            FileName = ffmpeg,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        startInfo.ArgumentList.Add("-y");
        startInfo.ArgumentList.Add("-v");
        startInfo.ArgumentList.Add("error");
        startInfo.ArgumentList.Add("-err_detect");
        startInfo.ArgumentList.Add("ignore_err");
        startInfo.ArgumentList.Add("-i");
        startInfo.ArgumentList.Add(videoMp4Path);
        startInfo.ArgumentList.Add("-f");
        startInfo.ArgumentList.Add("s16le");
        startInfo.ArgumentList.Add("-ar");
        startInfo.ArgumentList.Add(audioSampleRate.ToString(CultureInfo.InvariantCulture));
        startInfo.ArgumentList.Add("-ac");
        startInfo.ArgumentList.Add(audioChannels.ToString(CultureInfo.InvariantCulture));
        startInfo.ArgumentList.Add("-i");
        startInfo.ArgumentList.Add(audioPcmPath);
        startInfo.ArgumentList.Add("-map");
        startInfo.ArgumentList.Add("0:v:0");
        startInfo.ArgumentList.Add("-map");
        startInfo.ArgumentList.Add("1:a:0");
        startInfo.ArgumentList.Add("-c:v");
        startInfo.ArgumentList.Add("copy");
        startInfo.ArgumentList.Add("-c:a");
        startInfo.ArgumentList.Add("aac");
        startInfo.ArgumentList.Add("-b:a");
        startInfo.ArgumentList.Add(FormattableString.Invariant($"{audioBitrateKbps}k"));
        var audioFilter = CreateAudioSyncFilter(audioTrimUs, audioDelayUs, audioChannels);
        if (audioFilter is not null)
        {
            startInfo.ArgumentList.Add("-af");
            startInfo.ArgumentList.Add(audioFilter);
        }

        startInfo.ArgumentList.Add("-shortest");
        startInfo.ArgumentList.Add("-movflags");
        startInfo.ArgumentList.Add("+faststart");
        startInfo.ArgumentList.Add(muxedPath);

        using var process = Process.Start(startInfo);
        if (process is null)
        {
            return null;
        }

        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeout.CancelAfter(TimeSpan.FromSeconds(20));

        try
        {
            var stderrTask = process.StandardError.ReadToEndAsync(timeout.Token);
            await process.WaitForExitAsync(timeout.Token);
            var stderr = await stderrTask;
            if (process.ExitCode == 0 && File.Exists(muxedPath))
            {
                return muxedPath;
            }

            logs.Enqueue($"[artifact] ffmpeg audio mux failed with exit {process.ExitCode}: {stderr}");
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                process.Kill(entireProcessTree: true);
            }
            catch (InvalidOperationException)
            {
            }

            logs.Enqueue("[artifact] ffmpeg audio mux timed out.");
        }

        return null;
    }

    private static string? CreateAudioSyncFilter(
        long audioTrimUs,
        long audioDelayUs,
        int audioChannels)
    {
        var filters = new List<string>();
        if (audioTrimUs > 0)
        {
            filters.Add(FormattableString.Invariant($"atrim=start={audioTrimUs / 1_000_000d:0.######}"));
        }

        if (audioTrimUs > 0 || audioDelayUs > 0)
        {
            filters.Add("asetpts=PTS-STARTPTS");
        }

        if (audioDelayUs > 0)
        {
            var delayMs = (int)Math.Round(audioDelayUs / 1000d);
            var perChannelDelay = string.Join("|", Enumerable.Repeat(delayMs.ToString(CultureInfo.InvariantCulture), Math.Max(1, audioChannels)));
            filters.Add($"adelay={perChannelDelay}");
        }

        return filters.Count == 0 ? null : string.Join(",", filters);
    }

    private static string CreateWatchBridgeArtifactDirectory(string name)
    {
        var baseDirectory =
            Environment.GetEnvironmentVariable("RUNWAY_WATCH_BRIDGE_ARTIFACT_DIR") is { Length: > 0 } configured
                ? configured
                : Path.Combine(FindRepositoryRoot(), "artifacts", "runway-watch-bridge-e2e");

        var safeName = string.Concat(name.Select(character =>
            char.IsLetterOrDigit(character) || character is '-' or '_' ? character : '-'));
        var directory = Path.Combine(
            baseDirectory,
            $"{DateTimeOffset.UtcNow:yyyyMMdd-HHmmssfff}-{safeName}");

        Directory.CreateDirectory(directory);
        return directory;
    }

    private static async Task WriteWatchBridgeArtifactManifestAsync(
        string artifactsDirectory,
        object manifest,
        CancellationToken cancellationToken)
    {
        var manifestPath = Path.Combine(artifactsDirectory, "manifest.json");
        var json = JsonSerializer.Serialize(
            manifest,
            new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                WriteIndented = true,
            });
        await File.WriteAllTextAsync(manifestPath, json, cancellationToken);
    }

    private static string FindRepositoryRoot()
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory);
             directory is not null;
             directory = directory.Parent)
        {
            if (File.Exists(Path.Combine(directory.FullName, "Runway.slnx")) &&
                Directory.Exists(Path.Combine(directory.FullName, ".git")))
            {
                return directory.FullName;
            }
        }

        return Directory.GetCurrentDirectory();
    }

    private static string FindProjectFromBaseDirectory(params string[] pathParts)
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory);
             directory is not null;
             directory = directory.Parent)
        {
            var candidate = Path.Combine([directory.FullName, .. pathParts]);
            if (File.Exists(candidate))
            {
                return candidate;
            }
        }

        throw new FileNotFoundException($"Could not find project '{Path.Combine(pathParts)}'.");
    }

    private static int GetFreeTcpPort()
    {
        var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        try
        {
            return ((IPEndPoint)listener.LocalEndpoint).Port;
        }
        finally
        {
            listener.Stop();
        }
    }

    private static string? FindExecutableOnPath(string executable)
    {
        var paths = Environment.GetEnvironmentVariable("PATH")?.Split(Path.PathSeparator) ?? [];
        foreach (var path in paths)
        {
            var candidate = Path.Combine(path, executable);
            if (File.Exists(candidate))
            {
                return candidate;
            }
        }

        return null;
    }

    private static async Task<ImageAlphaStats> ReadPngAlphaStatsAsync(
        string path,
        CancellationToken cancellationToken)
    {
        using var image = await Image.LoadAsync<Rgba32>(path, cancellationToken);
        var pixels = new Rgba32[image.Width * image.Height];
        image.CopyPixelDataTo(pixels);

        byte min = byte.MaxValue;
        byte max = byte.MinValue;
        long transparent = 0;
        long translucent = 0;
        long opaque = 0;

        foreach (var pixel in pixels)
        {
            min = Math.Min(min, pixel.A);
            max = Math.Max(max, pixel.A);
            if (pixel.A == 0)
            {
                transparent++;
            }
            else if (pixel.A == byte.MaxValue)
            {
                opaque++;
            }
            else
            {
                translucent++;
            }
        }

        return new ImageAlphaStats(
            Width: image.Width,
            Height: image.Height,
            Min: min,
            Max: max,
            TransparentPixels: transparent,
            TranslucentPixels: translucent,
            OpaquePixels: opaque,
            TotalPixels: transparent + translucent + opaque);
    }

    private static async Task<string?> TryEncodePngSequenceToAlphaMovAsync(
        string frameDirectory,
        int fps,
        ConcurrentQueue<string> logs,
        CancellationToken cancellationToken)
    {
        var ffmpeg = Environment.GetEnvironmentVariable("FFMPEG_BINARY") is { Length: > 0 } configured
            ? configured
            : FindExecutableOnPath("ffmpeg");
        if (ffmpeg is null)
        {
            return null;
        }

        var outputPath = Path.Combine(Path.GetDirectoryName(frameDirectory)!, "avatar-png-alpha.mov");
        var inputPattern = Path.Combine(frameDirectory, "frame-%04d.png");
        var startInfo = new ProcessStartInfo
        {
            FileName = ffmpeg,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        startInfo.ArgumentList.Add("-y");
        startInfo.ArgumentList.Add("-v");
        startInfo.ArgumentList.Add("error");
        startInfo.ArgumentList.Add("-framerate");
        startInfo.ArgumentList.Add(fps.ToString(CultureInfo.InvariantCulture));
        startInfo.ArgumentList.Add("-i");
        startInfo.ArgumentList.Add(inputPattern);
        startInfo.ArgumentList.Add("-c:v");
        startInfo.ArgumentList.Add("prores_ks");
        startInfo.ArgumentList.Add("-profile:v");
        startInfo.ArgumentList.Add("4");
        startInfo.ArgumentList.Add("-pix_fmt");
        startInfo.ArgumentList.Add("yuva444p10le");
        startInfo.ArgumentList.Add("-vendor");
        startInfo.ArgumentList.Add("apl0");
        startInfo.ArgumentList.Add("-movflags");
        startInfo.ArgumentList.Add("+faststart");
        startInfo.ArgumentList.Add(outputPath);

        using var process = Process.Start(startInfo);
        if (process is null)
        {
            return null;
        }

        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeout.CancelAfter(TimeSpan.FromSeconds(30));

        try
        {
            var stderrTask = process.StandardError.ReadToEndAsync(timeout.Token);
            await process.WaitForExitAsync(timeout.Token);
            var stderr = await stderrTask;
            if (process.ExitCode == 0 && File.Exists(outputPath))
            {
                return outputPath;
            }

            logs.Enqueue($"[artifact] ffmpeg alpha MOV encode failed with exit {process.ExitCode}: {stderr}");
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                process.Kill(entireProcessTree: true);
            }
            catch (InvalidOperationException)
            {
            }

            logs.Enqueue("[artifact] ffmpeg alpha MOV encode timed out.");
        }

        return null;
    }

    private static async Task PumpProcessOutputAsync(
        StreamReader reader,
        ConcurrentQueue<string> logs,
        string streamName)
    {
        string? line;
        while ((line = await reader.ReadLineAsync()) is not null)
        {
            logs.Enqueue($"[{streamName}] {line}");
            while (logs.Count > 200 && logs.TryDequeue(out _))
            {
            }
        }
    }

    private static async Task StopProcessAsync(Process process)
    {
        if (!process.HasExited)
        {
            process.Kill(entireProcessTree: true);
        }

        await process.WaitForExitAsync();
        process.Dispose();
    }

    private static string LastLines(ConcurrentQueue<string> logs)
    {
        return string.Join(Environment.NewLine, logs.TakeLast(80));
    }

    private sealed record WatchBridgeE2ESessionResponse(
        string SessionId,
        Guid RunwaySessionId,
        string WatchWebSocketUrl,
        string WatchToken);

    private sealed record WatchBridgeE2ESessionStatus(
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
        long DownstreamBinaryFrames);

    private sealed record WatchBridgeE2EArtifactSettings(
        WatchBridgeE2EVideoSettings Video,
        WatchBridgeE2EAvatarSettings Avatar,
        bool IncludeAudio,
        int AudioBitrateKbps,
        string? StartScript)
    {
        public static WatchBridgeE2EArtifactSettings FromEnvironment()
        {
            var includeAudio = EnvBool("RUNWAY_WATCH_BRIDGE_E2E_INCLUDE_AUDIO", false);
            return new WatchBridgeE2EArtifactSettings(
                Video: WatchBridgeE2EVideoSettings.FromEnvironment(),
                Avatar: WatchBridgeE2EAvatarSettings.FromEnvironment(),
                IncludeAudio: includeAudio,
                AudioBitrateKbps: EnvInt("RUNWAY_WATCH_BRIDGE_E2E_AUDIO_BITRATE_KBPS", 48),
                StartScript: EnvNullable("RUNWAY_WATCH_BRIDGE_E2E_START_SCRIPT"));
        }

        private static bool EnvBool(string name, bool fallback)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
                ? bool.Parse(value)
                : fallback;
        }

        private static int EnvInt(string name, int fallback)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
                ? int.Parse(value, CultureInfo.InvariantCulture)
                : fallback;
        }

        private static string? EnvNullable(string name)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : null;
        }
    }

    private sealed record WatchBridgeE2EAvatarSettings(
        Guid? AvatarId,
        string? ReferenceImagePath,
        string Name,
        string Personality,
        string? StartScript,
        string VoicePreset,
        CreateAvatarsRequestImageProcessing? ImageProcessing)
    {
        public static WatchBridgeE2EAvatarSettings FromEnvironment()
        {
            return new WatchBridgeE2EAvatarSettings(
                AvatarId: EnvGuid("RUNWAY_WATCH_BRIDGE_E2E_AVATAR_ID"),
                ReferenceImagePath: EnvNullable("RUNWAY_WATCH_BRIDGE_E2E_REFERENCE_IMAGE_PATH"),
                Name: Env("RUNWAY_WATCH_BRIDGE_E2E_AVATAR_NAME", $"Watch Bridge Avatar {DateTimeOffset.UtcNow:yyyyMMdd-HHmmss}"),
                Personality: Env(
                    "RUNWAY_WATCH_BRIDGE_E2E_AVATAR_PERSONALITY",
                    "You are a concise realtime avatar used for watchOS media bridge testing."),
                StartScript: EnvNullable("RUNWAY_WATCH_BRIDGE_E2E_AVATAR_START_SCRIPT"),
                VoicePreset: Env("RUNWAY_WATCH_BRIDGE_E2E_AVATAR_VOICE_PRESET", "adrian"),
                ImageProcessing: ParseImageProcessing(Env("RUNWAY_WATCH_BRIDGE_E2E_AVATAR_IMAGE_PROCESSING", "optimize")));
        }

        private static Guid? EnvGuid(string name)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
                ? Guid.Parse(value)
                : null;
        }

        private static string Env(string name, string fallback)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : fallback;
        }

        private static string? EnvNullable(string name)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : null;
        }

        private static CreateAvatarsRequestImageProcessing? ParseImageProcessing(string value)
        {
            return CreateAvatarsRequestImageProcessingExtensions.ToEnum(value)
                ?? throw new AssertInconclusiveException($"Unsupported avatar image processing mode '{value}'.");
        }
    }

    private sealed record WatchBridgeE2EVideoSettings(
        int Width,
        int? Height,
        string ResizeMode,
        int CropTop,
        int Fps,
        int JpegQuality,
        int BitrateKbps,
        int FragmentMs,
        string Encoder)
    {
        public static WatchBridgeE2EVideoSettings FromEnvironment()
        {
            var width = EnvInt("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_WIDTH", 96);
            return new WatchBridgeE2EVideoSettings(
                Width: width,
                Height: EnvNullableInt("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_HEIGHT"),
                ResizeMode: Env("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_RESIZE_MODE", "cover"),
                CropTop: EnvInt("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_CROP_TOP", 0),
                Fps: EnvInt("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_FPS", 4),
                JpegQuality: EnvInt("RUNWAY_WATCH_BRIDGE_E2E_JPEG_QUALITY", 45),
                BitrateKbps: EnvInt("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_BITRATE_KBPS", 140),
                FragmentMs: EnvInt("RUNWAY_WATCH_BRIDGE_E2E_FMP4_FRAGMENT_MS", 500),
                Encoder: Env("RUNWAY_WATCH_BRIDGE_E2E_VIDEO_ENCODER", "software"));
        }

        private static int EnvInt(string name, int fallback)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
                ? int.Parse(value, CultureInfo.InvariantCulture)
                : fallback;
        }

        private static int? EnvNullableInt(string name)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
                ? int.Parse(value, CultureInfo.InvariantCulture)
                : null;
        }

        private static string Env(string name, string fallback)
        {
            return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value ? value : fallback;
        }
    }

    private readonly record struct WebSocketE2EMessage(
        WebSocketMessageType MessageType,
        byte[] Payload);

    private readonly record struct WatchBridgeMediaResult(
        WatchBridgeFrame? AudioFrame,
        WatchBridgeFrame? VideoFrame);

    private sealed record WatchBridgeFmp4Artifact(
        IReadOnlyList<WatchBridgeFrame> Frames,
        byte[] Payload,
        byte[] RawFrames,
        IReadOnlyList<WatchBridgeFrame> AudioFrames,
        byte[] AudioPayload,
        byte[] RawAudioFrames,
        int AudioSampleRate,
        int AudioChannels);

    private sealed record WatchBridgeImageSequenceArtifact(
        IReadOnlyList<WatchBridgeFrame> Frames,
        byte[] RawFrames,
        IReadOnlyList<string> TextMessages);

    private sealed record WatchBridgeE2EAvatarResolution(
        Guid AvatarId,
        string Source,
        string? ReferenceImagePath);

    private sealed record ImageAlphaStats(
        int Width,
        int Height,
        byte Min,
        byte Max,
        long TransparentPixels,
        long TranslucentPixels,
        long OpaquePixels,
        long TotalPixels);

    private sealed record AudioVideoSyncOffset(
        long FirstVideoTimestampUs,
        long FirstAudioTimestampUs,
        long AudioTrimUs,
        long AudioDelayUs,
        double AudioTrimMs,
        double AudioDelayMs)
    {
        public static AudioVideoSyncOffset From(WatchBridgeFmp4Artifact artifact)
        {
            var firstVideoTimestampUs = artifact.Frames.First().TimestampUs;
            var firstAudioTimestampUs = artifact.AudioFrames.First().TimestampUs;
            var audioStartsBeforeVideoUs = Math.Max(0, firstVideoTimestampUs - firstAudioTimestampUs);
            var audioStartsAfterVideoUs = Math.Max(0, firstAudioTimestampUs - firstVideoTimestampUs);

            return new AudioVideoSyncOffset(
                FirstVideoTimestampUs: firstVideoTimestampUs,
                FirstAudioTimestampUs: firstAudioTimestampUs,
                AudioTrimUs: audioStartsBeforeVideoUs,
                AudioDelayUs: audioStartsAfterVideoUs,
                AudioTrimMs: audioStartsBeforeVideoUs / 1000d,
                AudioDelayMs: audioStartsAfterVideoUs / 1000d);
        }
    }

    private readonly record struct WatchBridgeFrame(
        byte Kind,
        uint Sequence,
        long TimestampUs,
        int Arg0,
        int Arg1,
        byte[] Payload,
        byte[] RawFrame);
}
