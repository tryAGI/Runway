# ListAvatarConversations



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var conversations = await client.Avatars.GetAvatarConversationsAsync(
    limit: 20,
    xRunwayVersion: "2024-11-06");

Console.WriteLine($"Conversations on page: {conversations.Data.Count}");
Console.WriteLine($"Has more: {conversations.HasMore}");

var endDate = DateTime.UtcNow.Date;
var startDate = endDate.AddDays(-7);

var usage = await client.Avatars.GetAvatarUsageAsync(
    startDate: startDate,
    endDate: endDate,
    xRunwayVersion: "2024-11-06");

Console.WriteLine($"Sessions: {usage.TotalSessions}");
Console.WriteLine($"Total seconds: {usage.TotalSeconds}");
```