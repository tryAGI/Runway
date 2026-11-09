# RunVideoStyleTransfer



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
RequireBillableExamplesEnabled("The Video to Video - Style Transfer built-in workflow", approximateCredits: 90);

using var client = new RunwayClient(apiKey);

var workflowId = Guid.Parse("d1d344d1-8321-4f29-9d9d-90503abcd4fd");
var stylePromptNodeId = "e1f923c4-464c-46d8-8ddc-3883814872e8";

var request = new CreateWorkflowsRequest
{
    NodeOutputs = new Dictionary<string, object>
    {
        [stylePromptNodeId] = new Dictionary<string, object>
        {
            ["prompt"] = new Dictionary<string, object>
            {
                ["type"] = "primitive",
                ["value"] = "modern Pixar 3D style with vibrant colors",
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

EnsureWorkflowInvocationUsable(invocation, workflowId, "Video to Video - Style Transfer");
```