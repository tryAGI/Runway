# CreateRealtimeAvatarSession

This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var session = await client.RealtimeSessions.CreateRealtimeSessionsAsync(
    request: new CreateRealtimeSessionsRequest
    {
        Avatar = new CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar
        {
            PresetId = CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.Influencer,
        },
        MaxDuration = 60,
    });

Console.WriteLine($"Realtime session ID: {session.Id}");

GetRealtimeSessionsResponse status;
do
{
    status = await client.RealtimeSessions.GetRealtimeSessionsByIdAsync(id: session.Id);
    await Task.Delay(TimeSpan.FromSeconds(1));
}
while (status.IsNotReady);

if (status.IsFailed)
{
    throw new InvalidOperationException(status.Failed!.Failure);
}

if (!status.IsReady)
{
    throw new InvalidOperationException("Realtime session did not become ready.");
}

var credentials = await client.RealtimeSessions.ConsumeRealtimeSessionAsync(
    id: session.Id,
    sessionKey: status.Ready!.SessionKey);

Console.WriteLine($"LiveKit server: {credentials.Url}");
Console.WriteLine($"LiveKit room: {credentials.RoomName}");

await client.RealtimeSessions.DeleteRealtimeSessionsByIdAsync(id: session.Id);
```

Use realtime sessions for live Characters calls and backend bridges. Use avatar videos or character performance for offline generated video.
