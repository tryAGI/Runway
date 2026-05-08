# CreateAvatar



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var avatar = await client.Avatars.CreateAvatarsAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateAvatarsRequest
    {
        Name = "Hackathon Producer",
        ReferenceImage = "https://example.com/reference.jpg",
        Personality = "You are a concise creative producer who helps teams turn rough ideas into practical video plans.",
        StartScript = "Tell me what you want to make and I will help shape the shot list.",
        Voice = new CreateAvatarsRequestVoiceRunwayLivePresetVoice
        {
            PresetId = CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId.Adrian,
        },
        ImageProcessing = CreateAvatarsRequestImageProcessing.Optimize,
    });

var avatarId = avatar.Match(
    processing: processing => processing!.Id,
    ready: ready => ready!.Id,
    failed: failed => failed!.Id);

Console.WriteLine($"Avatar ID: {avatarId}");
```