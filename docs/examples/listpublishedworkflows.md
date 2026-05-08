# ListPublishedWorkflows



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var workflows = await client.Workflows.GetWorkflowsAsync(
    xRunwayVersion: "2024-11-06");

Console.WriteLine($"Published workflows: {workflows.Data.Count}");
```