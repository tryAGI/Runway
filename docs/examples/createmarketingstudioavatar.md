# CreateMarketingStudioAvatar



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var response = await client.Avatars.GetAvatarsAsync(
    xRunwayVersion: "2024-11-06",
    limit: 5);

Console.WriteLine($"Returned {response.Data.Count} avatar(s).");
foreach (var avatar in response.Data)
{
    Console.WriteLine($"- {avatar.Match(processing: p => p!.Id, ready: r => r!.Id, failed: f => f!.Id)}");
}
```