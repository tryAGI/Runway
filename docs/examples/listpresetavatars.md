# ListPresetAvatars



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var avatars = Enum.GetValues<CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId>();

foreach (var avatar in avatars)
{
    Console.WriteLine(avatar.ToValueString());
}

var voices = Enum.GetValues<CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId>();

foreach (var voice in voices)
{
    Console.WriteLine(voice.ToValueString());
}
```