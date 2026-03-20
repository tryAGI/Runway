# ListPresetVoices



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var voices = Enum.GetValues<RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId>();

foreach (var voice in voices)
{
    Console.WriteLine(voice.ToValueString());
}
```