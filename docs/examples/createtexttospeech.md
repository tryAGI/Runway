# CreateTextToSpeech



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateTextToSpeechAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestElevenMultilingualV2
    {
        PromptText = "Hello! Welcome to Runway's text-to-speech API.",
        Voice = new RequestElevenMultilingualV2VoiceRunwayPresetVoice
        {
            PresetId = RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Maya,
        },
    });

Console.WriteLine($"Task ID: {response.Id}");
```