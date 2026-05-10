/*
 * order: 96
 * title: Run Fabric, Color, Texture Swap Workflow
 * slug: run-fabric-color-texture-swap-workflow
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Run a previously-published workflow ("Fabric, Color, Texture Swap") by overriding
    //// one of its exposed `nodeOutputs` prompts. Other inputs use the workflow's authored
    //// defaults, so the request body only needs to mention the nodes you actually want to change.
    ////
    //// The workflow ID and node ID below come from this user's published workflow registry;
    //// the same shape applies to any workflow you publish from the Runway dev portal.
    //// The `runway` CLI wraps this same call as `runway fabric-color-texture-swap --change-1 "..."`.

    [TestMethod]
    public async Task Example_RunFabricColorTextureSwap()
    {
        using var client = GetAuthenticatedClient();

        var workflowId = Guid.Parse("bd4dd01e-bb65-46ae-9db4-170c997c36f2");
        var changeOnePromptNodeId = "1f3f4dfa-8b05-49fb-86ca-cc7b2510434f";

        var request = new CreateWorkflowsRequest
        {
            NodeOutputs = new Dictionary<string, object>
            {
                [changeOnePromptNodeId] = new Dictionary<string, object>
                {
                    ["prompt"] = new Dictionary<string, object>
                    {
                        ["type"] = "primitive",
                        ["value"] = "Change: color to teal",
                    },
                },
            },
        };

        var runResponse = await client.Workflows.CreateWorkflowsByIdAsync(
            id: workflowId,
            request: request,
            xRunwayVersion: "2024-11-06");

        runResponse.Id.Should().NotBe(default(Guid));
        Console.WriteLine($"Invocation ID: {runResponse.Id}");

        GetWorkflowInvocationsResponse invocation;
        do
        {
            invocation = await client.Workflows.GetWorkflowInvocationsByIdAsync(
                id: runResponse.Id,
                xRunwayVersion: "2024-11-06");

            if (invocation.IsRunning)
            {
                Console.WriteLine($"Progress: {invocation.Running!.Progress:P0}");
            }

            await Task.Delay(TimeSpan.FromSeconds(10));
        }
        while (!invocation.IsSucceeded && !invocation.IsFailed && !invocation.IsCancelled);

        if (invocation.IsFailed)
        {
            Console.WriteLine($"Failure: {invocation.Failed!.Failure}");
        }

        invocation.IsSucceeded.Should().BeTrue();
        invocation.Succeeded!.Output.Should().NotBeEmpty();
    }
}
