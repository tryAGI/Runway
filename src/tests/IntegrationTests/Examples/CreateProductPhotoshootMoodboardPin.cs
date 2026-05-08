/*
 * order: 80
 * title: Product Photoshoot — Pinterest Moodboard Pin
 * slug: product-photoshoot-moodboard-pin
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Plan a Higgsfield-parity `moodboard_pin` product photoshoot.
    //// The CLI emits a vertical-friendly editorial prompt suited to Pinterest-style assets.
    //// This test validates the prompt construction logic without spending generation credits.

    [TestMethod]
    public void Example_CreateProductPhotoshootMoodboardPin()
    {
        var plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
            prompt: "compact ceramic pour-over coffee mug",
            referenceImages: null,
            count: null,
            ratio: null,
            model: null,
            mode: "moodboard_pin",
            productContext: "slow-living lifestyle accessory",
            brandContext: "warm, neutral palette",
            quality: null,
            resolution: null);

        plan.Mode.Should().Be("moodboard_pin");
        plan.Jobs.Should().HaveCount(1);

        var job = plan.Jobs[0];
        job.Label.Should().Be("moodboard-pin");
        job.Prompt.Should().Contain("Pinterest");
        job.Prompt.Should().Contain("editorial");
        job.Prompt.Should().Contain("compact ceramic pour-over coffee mug");

        var json = RunwayCliCreativeRecipes.ToJson(plan);
        json.Should().Contain("\"mode\": \"moodboard_pin\"");
    }
}
