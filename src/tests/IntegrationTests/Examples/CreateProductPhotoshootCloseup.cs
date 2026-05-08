/*
 * order: 79
 * title: Product Photoshoot — Closeup with Person
 * slug: product-photoshoot-closeup-with-person
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Plan a Higgsfield-parity `closeup_product_with_person` product photoshoot.
    //// The CLI produces a structured prompt bundle ready for `runway image --model gpt-image-2`.
    //// This test validates the prompt construction logic without spending generation credits.

    [TestMethod]
    public void Example_CreateProductPhotoshootCloseup()
    {
        var plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
            prompt: "wireless earbud charging case with brushed aluminum finish",
            referenceImages: null,
            count: null,
            ratio: null,
            model: null,
            mode: "closeup_product_with_person",
            productContext: "premium audio accessory targeted at on-the-go professionals",
            brandContext: "minimal Scandinavian design language",
            quality: null,
            resolution: null);

        plan.Kind.Should().Be(RunwayCliCreativeRecipes.ProductPhotoshootKind);
        plan.Mode.Should().Be("closeup_product_with_person");
        plan.Model.Should().Be(RunwayCliCreativeRecipes.DefaultImageModel);
        plan.Jobs.Should().HaveCount(1);

        var job = plan.Jobs[0];
        job.Label.Should().Be("closeup-with-person");
        job.Prompt.Should().Contain("close-up");
        job.Prompt.Should().Contain("hand");
        job.Prompt.Should().Contain("wireless earbud charging case");

        var json = RunwayCliCreativeRecipes.ToJson(plan);
        json.Should().Contain("\"mode\": \"closeup_product_with_person\"");
    }
}
