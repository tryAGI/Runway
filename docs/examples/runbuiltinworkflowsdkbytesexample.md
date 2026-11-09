# RunBuiltInWorkflowSdkBytesExample



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var portraitPath = Path.Combine(
    CliHarness.FindRunwayRoot(),
    "artifacts", "runway-watch-bridge-inputs", "adv-avatar-4-1024.png");
if (!File.Exists(portraitPath))
{
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

    because: $"failure was: {result.Failure} ({result.FailureCode})");
```