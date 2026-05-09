namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwayCliRatioValidationTests
{
    [TestMethod]
    public void GetSupportedTextToImageRatios_ListsAllPortraitFor3Pro()
    {
        var supported = RunwayCliGeneration.GetSupportedTextToImageRatios("gemini_image3_pro");

        supported.Should().NotBeNull();
        supported!.Should().Contain("768:1344");
        supported.Should().Contain("1024:1024");
    }

    [TestMethod]
    public void GetSupportedTextToImageRatios_GptImage2_IncludesSquareDefault()
    {
        var supported = RunwayCliGeneration.GetSupportedTextToImageRatios("gpt_image_2");

        supported.Should().NotBeNull();
        supported!.Should().Contain("1920:1920");
    }

    [TestMethod]
    public void GetSupportedTextToImageRatios_UnknownModel_ReturnsNull()
    {
        var supported = RunwayCliGeneration.GetSupportedTextToImageRatios("unknown_model");

        supported.Should().BeNull();
    }

    [TestMethod]
    public void ValidateTextToImageRatio_AcceptsKnownGoodRatio()
    {
        var act = () => RunwayCliGeneration.ValidateTextToImageRatio("768:1344", "gemini_image3_pro");

        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidateTextToImageRatio_RejectsUnsupportedRatioForGeminiImage3Pro()
    {
        var act = () => RunwayCliGeneration.ValidateTextToImageRatio("720:1280", "gemini_image3_pro");

        act.Should().Throw<ArgumentException>()
            .WithMessage("*'720:1280'*gemini_image3_pro*Supported values:*768:1344*");
    }

    [TestMethod]
    public void ValidateTextToImageRatio_RejectsUnsupportedRatioForGptImage2()
    {
        var act = () => RunwayCliGeneration.ValidateTextToImageRatio("100:100", "gpt_image_2");

        act.Should().Throw<ArgumentException>()
            .WithMessage("*'100:100'*gpt_image_2*1920:1920*");
    }

    [TestMethod]
    public void ValidateTextToImageRatio_NoOpsForUnknownModel()
    {
        var act = () => RunwayCliGeneration.ValidateTextToImageRatio("anything:anything", "future_model_we_dont_know_about");

        act.Should().NotThrow();
    }

    [TestMethod]
    public async Task CreateTextToImageRequestAsync_ThrowsWhenRatioIsUnsupportedForModel()
    {
        var act = async () => await RunwayCliGeneration.CreateTextToImageRequestAsync(
            prompt: "test",
            model: "gemini-image3-pro",
            ratio: "720:1280",
            referenceImages: null,
            referenceSubject: "object",
            seed: null,
            outputCount: null,
            publicFigureThreshold: null,
            CancellationToken.None);

        await act.Should().ThrowAsync<ArgumentException>().ConfigureAwait(false);
    }
}
