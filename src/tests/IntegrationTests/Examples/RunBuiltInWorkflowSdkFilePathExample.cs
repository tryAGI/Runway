/*
 * order: 100
 * title: Run Built-in Workflow via SDK (file path input)
 * slug: run-built-in-workflow-sdk-file-path
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Same shape as Example_RunBuiltInWorkflowSdk_AiHairSalon, but supplies the source asset
    //// as a local file path. The runner opens, uploads, and disposes the file stream.

    [TestMethod]
    public async Task Example_RunBuiltInWorkflowSdk_AiHairSalon_FilePathInput()
    {
        using var client = GetAuthenticatedClient();

        var portraitPath = Path.Combine(
            CliHarness.FindRunwayRoot(),
            "artifacts", "runway-watch-bridge-inputs", "adv-avatar-4-1024.png");
        if (!File.Exists(portraitPath))
        {
            Assert.Inconclusive($"Sample portrait missing at {portraitPath}.");
        }

        var inputs = BuiltInWorkflowInputs.Create()
            .SetFilePath("--image", portraitPath)
            .Set("--hairstyle", "Hairstyle details: tousled long beach waves");

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
