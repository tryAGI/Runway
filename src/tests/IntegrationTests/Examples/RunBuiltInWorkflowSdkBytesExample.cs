/*
 * order: 99
 * title: Run Built-in Workflow via SDK (byte[] input)
 * slug: run-built-in-workflow-sdk-bytes
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Same shape as Example_RunBuiltInWorkflowSdk_AiHairSalon, but supplies the source asset
    //// as an in-memory byte[] (the common path when the bot has already buffered the upload).

    [TestMethod]
    public async Task Example_RunBuiltInWorkflowSdk_AiHairSalon_BytesInput()
    {
        using var client = GetAuthenticatedClient();

        var portraitPath = Path.Combine(
            CliHarness.FindRunwayRoot(),
            "artifacts", "runway-watch-bridge-inputs", "adv-avatar-4-1024.png");
        if (!File.Exists(portraitPath))
        {
            Assert.Inconclusive($"Sample portrait missing at {portraitPath}.");
        }

        var bytes = await File.ReadAllBytesAsync(portraitPath);

        var inputs = BuiltInWorkflowInputs.Create()
            .SetBytes("--image", bytes, "portrait.png")
            .Set("--hairstyle", "Hairstyle details: short pixie cut, copper highlights");

        var result = await client.RunBuiltInWorkflowAsync(
            BuiltInWorkflows.AiHairSalon,
            inputs,
            waitForCompletion: true,
            pollInterval: TimeSpan.FromSeconds(15));

        result.Status.Should().Be(BuiltInWorkflowStatus.Succeeded,
            because: $"failure was: {result.Failure} ({result.FailureCode})");
        result.AllOutputUris.Should().NotBeEmpty();
    }
}
