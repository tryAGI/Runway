/*
 * order: 98
 * title: Run a Built-in Workflow via SDK
 * slug: run-built-in-workflow-sdk
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Run a built-in workflow end-to-end via the SDK API. No CLI shell-out, no JSON crafting,
    //// no manual upload — supply a stream + a text prompt and call <see cref="Runway.RunwayBuiltInWorkflowExtensions.RunBuiltInWorkflowAsync"/>.
    //// This is the same surface a Telegram bot or other library consumer would use.

    [TestMethod]
    public async Task Example_RunBuiltInWorkflowSdk_AiHairSalon()
    {
        using var client = GetAuthenticatedClient();

        // Locate the asset the bot just uploaded — here we use a sample portrait from artifacts.
        var portraitPath = Path.Combine(
            CliHarness.FindRunwayRoot(),
            "artifacts", "runway-watch-bridge-inputs", "adv-avatar-4-1024.png");
        if (!File.Exists(portraitPath))
        {
            Assert.Inconclusive($"Sample portrait missing at {portraitPath}.");
        }

        await using var portrait = File.OpenRead(portraitPath);

        var inputs = BuiltInWorkflowInputs.Create()
            .SetStream("--image", portrait, "portrait.png")
            .Set("--hairstyle", "Hairstyle details: shoulder-length wavy bob with subtle blonde highlights")
            .Set("--background", "Show me this person against a soft sunset gradient backdrop");

        var result = await client.RunBuiltInWorkflowAsync(
            BuiltInWorkflows.AiHairSalon,
            inputs,
            waitForCompletion: true,
            pollInterval: TimeSpan.FromSeconds(15));

        Console.WriteLine($"Invocation ID: {result.InvocationId}");
        Console.WriteLine($"Status: {result.Status}");
        Console.WriteLine($"Output nodes: {result.NodeOutputs.Count}");
        foreach (var url in result.AllOutputUris)
        {
            Console.WriteLine($"  {url}");
        }

        result.Status.Should().Be(BuiltInWorkflowStatus.Succeeded);
        result.NodeOutputs.Should().NotBeEmpty();
        result.AllOutputUris.Should().NotBeEmpty();
    }
}
