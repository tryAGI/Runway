namespace Runway.IntegrationTests;

[TestClass]
public sealed class MediaBridgeFfmpegArgumentTests
{
    [TestMethod]
    public void H264SoftwareUsesLibx264LowLatencySettings()
    {
        var startInfo = Fmp4VideoEncoder.CreateStartInfo(
            CreateConfig(BridgeVideoMode.H264Fmp4, BridgeVideoEncoder.Software),
            width: 160,
            height: 90);

        var arguments = startInfo.ArgumentList.ToArray();
        arguments.Should().ContainInOrder("-c:v", "libx264");
        arguments.Should().ContainInOrder("-tune", "zerolatency");
        arguments.Should().ContainInOrder("-profile:v", "baseline");
        arguments.Should().ContainInOrder("-movflags", "empty_moov+default_base_moof+frag_keyframe");
    }

    [TestMethod]
    public void H265SoftwareUsesLibx265Hvc1Settings()
    {
        var startInfo = Fmp4VideoEncoder.CreateStartInfo(
            CreateConfig(BridgeVideoMode.H265Fmp4, BridgeVideoEncoder.Software),
            width: 160,
            height: 90);

        var arguments = startInfo.ArgumentList.ToArray();
        arguments.Should().ContainInOrder("-c:v", "libx265");
        arguments.Should().ContainInOrder("-tune", "zerolatency");
        arguments.Should().ContainInOrder("-profile:v", "main");
        arguments.Should().ContainInOrder("-x265-params", "keyint=8:min-keyint=8:scenecut=0:open-gop=0:bframes=0:rc-lookahead=0:repeat-headers=1:aud=1:hrd=1:vbv-maxrate=180:vbv-bufsize=180:log-level=error");
        arguments.Should().ContainInOrder("-tag:v", "hvc1");
    }

    [TestMethod]
    public void H264VideoToolboxUsesHardwareEncoder()
    {
        var startInfo = Fmp4VideoEncoder.CreateStartInfo(
            CreateConfig(BridgeVideoMode.H264Fmp4, BridgeVideoEncoder.VideoToolbox),
            width: 160,
            height: 90);

        var arguments = startInfo.ArgumentList.ToArray();
        arguments.Should().ContainInOrder("-c:v", "h264_videotoolbox");
        arguments.Should().ContainInOrder("-realtime", "1");
        arguments.Should().ContainInOrder("-power_efficient", "1");
        arguments.Should().ContainInOrder("-profile:v", "baseline");
    }

    [TestMethod]
    public void H265VideoToolboxUsesHardwareEncoder()
    {
        var startInfo = Fmp4VideoEncoder.CreateStartInfo(
            CreateConfig(BridgeVideoMode.H265Fmp4, BridgeVideoEncoder.VideoToolbox),
            width: 160,
            height: 90);

        var arguments = startInfo.ArgumentList.ToArray();
        arguments.Should().ContainInOrder("-c:v", "hevc_videotoolbox");
        arguments.Should().ContainInOrder("-realtime", "1");
        arguments.Should().ContainInOrder("-profile:v", "main");
        arguments.Should().ContainInOrder("-tag:v", "hvc1");
    }

    private static BridgeConfig CreateConfig(
        BridgeVideoMode videoMode,
        BridgeVideoEncoder videoEncoder)
    {
        return new BridgeConfig(
            IngestUrl: "ws://127.0.0.1/internal",
            LiveKitUrl: "wss://livekit.example.test",
            LiveKitToken: "token",
            AudioEnabled: true,
            VideoEnabled: true,
            VideoMode: videoMode,
            VideoEncoder: videoEncoder,
            AudioSampleRate: 16000,
            AudioChannels: 1,
            AudioFrameMs: 20,
            VideoWidth: 160,
            VideoHeight: null,
            VideoResizeMode: BridgeVideoResizeMode.Fit,
            VideoCropTop: 0,
            VideoFps: 8,
            JpegQuality: 55,
            VideoBitrateKbps: 180,
            Fmp4FragmentMs: 500,
            FfmpegBinary: "ffmpeg");
    }
}
