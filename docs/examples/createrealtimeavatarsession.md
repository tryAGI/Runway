# CreateRealtimeAvatarSession



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
SkipUnlessRealtimeTestsEnabled();

using var client = new RunwayClient(apiKey);

var sessionId = default(Guid);

try
{
    var session = await client.RealtimeSessions.CreateRealtimeSessionsAsync(
        request: new CreateRealtimeSessionsRequest
        {
            Avatar = new CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar
            {
                PresetId = CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.Influencer,
            },
            MaxDuration = 60,
        });

    sessionId = session.Id;

    Console.WriteLine($"Realtime session ID: {sessionId}");

    var ready = await WaitForRealtimeSessionReadyAsync(
        client: client,
        sessionId: sessionId,
        timeout: TimeSpan.FromSeconds(90));

    var credentials = await client.RealtimeSessions.ConsumeRealtimeSessionAsync(
        id: sessionId,
        sessionKey: ready.SessionKey);

    Console.WriteLine($"Realtime credentials received for room '{credentials.RoomName}' at {credentials.Url.Host}.");
}
finally
{
    if (sessionId != default)
    {
        try
        {
            await client.RealtimeSessions.DeleteRealtimeSessionsByIdAsync(id: sessionId);
        }
        catch (ApiException exception)
        {
            Console.WriteLine($"Realtime session cleanup returned HTTP {(int)exception.StatusCode}.");
        }
    }
}
```