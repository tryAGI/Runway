# RunFabricColorTextureSwap



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

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

EnsureWorkflowInvocationUsable(invocation, workflowId, "Fabric, Color, Texture Swap");
```