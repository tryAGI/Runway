/*
 * order: 95
 * title: Published Workflows
 * slug: published-workflows
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// List published workflows for the authenticated user. Workflow IDs returned here
    //// can be passed to RunWorkflowsByIdAsync with node output inputs.

    [TestMethod]
    public async Task Example_ListPublishedWorkflows()
    {
        using var client = GetAuthenticatedClient();

        var workflows = await client.Workflows.GetWorkflowsAsync(
            xRunwayVersion: "2024-11-06");

        Console.WriteLine($"Published workflows: {workflows.Data.Count}");

        workflows.Data.Should().NotBeNull();
    }
}
