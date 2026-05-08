# ListCustomVoices



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var voices = await client.Voices.GetVoicesAsync(
    limit: 50,
    xRunwayVersion: "2024-11-06");

Console.WriteLine($"Custom voices on page: {voices.Data.Count}");
Console.WriteLine($"Has more: {voices.HasMore}");
```