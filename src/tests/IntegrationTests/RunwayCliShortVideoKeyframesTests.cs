namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwayCliShortVideoKeyframesTests
{
    [TestMethod]
    public void PickClosestImageRatio_PortraitVideoTargets720x1280()
    {
        var supported = new[] { "1024:1024", "1344:768", "768:1344", "1248:832", "1920:1080" };

        var picked = RunwayCliShortVideoKeyframes.PickClosestImageRatio("720:1280", supported);

        picked.Should().Be("768:1344");
    }

    [TestMethod]
    public void PickClosestImageRatio_LandscapeVideoPrefersSmallestWithinTolerance()
    {
        // Both 1344:768 (~1.03MP, aspect 1.75) and 1920:1080 (~2.07MP, aspect 1.78) are within
        // 5% of the target 1.78 aspect. The smaller one wins to keep keyframe cost down — the
        // image-to-video call resizes the input anyway.
        var supported = new[] { "1024:1024", "1344:768", "768:1344", "1248:832", "1920:1080" };

        var picked = RunwayCliShortVideoKeyframes.PickClosestImageRatio("1920:1080", supported);

        picked.Should().Be("1344:768");
    }

    [TestMethod]
    public void PickClosestImageRatio_SquareVideoTargets1024x1024()
    {
        var supported = new[] { "1024:1024", "1344:768", "768:1344" };

        var picked = RunwayCliShortVideoKeyframes.PickClosestImageRatio("1080:1080", supported);

        picked.Should().Be("1024:1024");
    }

    [TestMethod]
    public void PickClosestImageRatio_GeminiImage3ProForYoutubeShorts()
    {
        var supported = RunwayCliGeneration.GetSupportedTextToImageRatios("gemini_image3_pro");

        supported.Should().NotBeNull();
        var picked = RunwayCliShortVideoKeyframes.PickClosestImageRatio("720:1280", supported!);

        picked.Should().Be("768:1344");
    }

    [TestMethod]
    public void PickClosestImageRatio_TiebreaksDeterministicallyByLexOrder()
    {
        var supported = new[] { "100:100", "200:200" };

        var picked = RunwayCliShortVideoKeyframes.PickClosestImageRatio("400:400", supported);

        picked.Should().Be("100:100");
    }

    [TestMethod]
    public void ParseRatio_RejectsMalformedInput()
    {
        var act = () => RunwayCliShortVideoKeyframes.ParseRatio("not:a:ratio");

        act.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void ParseRatio_RejectsNegativeDimensions()
    {
        var act = () => RunwayCliShortVideoKeyframes.ParseRatio("-100:200");

        act.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void ParseRatio_AcceptsWellFormed()
    {
        var (w, h) = RunwayCliShortVideoKeyframes.ParseRatio("720:1280");

        w.Should().Be(720);
        h.Should().Be(1280);
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoKeyframesFlagShowsInHelp()
    {
        var result = await CliHarness.RunCliAsync("short-video --help", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("--keyframes");
        result.Stdout.Should().Contain("image-to-video");
    }
}
