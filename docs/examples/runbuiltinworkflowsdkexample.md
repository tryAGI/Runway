# RunBuiltInWorkflowSdkExample



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

// Locate the asset the bot just uploaded — here we use a sample portrait from artifacts.
var portraitPath = Path.Combine(
    CliHarness.FindRunwayRoot(),
    "artifacts", "runway-watch-bridge-inputs", "adv-avatar-4-1024.png");
if (!File.Exists(portraitPath))
{
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
```