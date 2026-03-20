# Runway

[![Nuget package](https://img.shields.io/nuget/vpre/Runway)](https://www.nuget.org/packages/Runway/)
[![dotnet](https://github.com/tryAGI/Runway/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Runway/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Runway)](https://github.com/tryAGI/Runway/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Runway OpenAPI specification](https://raw.githubusercontent.com/runwayml/openapi/refs/heads/main/openapi.json) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage

#### Image to Video
```csharp
using Runway;

using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateImageToVideoAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestGen3aTurbo
    {
        PromptImage = "https://example.com/photo.jpg",
        PromptText = "The girl smiles a little",
        Seed = 999999999,
        Model = "gen3a_turbo",
        Duration = 5,
        Ratio = RequestGen3aTurboRatio.x1280_768,
    });

// Poll until complete
Response taskDetail;
do
{
    taskDetail = await client.TaskManagement.GetTasksByIdAsync(
        id: response.Id,
        xRunwayVersion: "2024-11-06");
    await Task.Delay(TimeSpan.FromSeconds(10));
}
while (!taskDetail.IsFailed && !taskDetail.IsSucceeded && !taskDetail.IsCancelled);

foreach (var output in taskDetail.Succeeded!.Output)
{
    Console.WriteLine($"Video URL: {output}");
}
```

#### Text to Speech
Choose from 48 preset voices including Maya, Arjun, Eleanor, Bernard, and more.
```csharp
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
```

#### Sound Effects
Generate sound effects from text descriptions (0.5–30 seconds, optional seamless looping).
```csharp
var response = await client.StartGenerating.CreateSoundEffectAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestElevenTextToSoundV2
    {
        PromptText = "A thunderstorm with heavy rain and distant thunder rumbling",
        Duration = 10.0,
        Loop = false,
    });
```

#### Voice Dubbing
Dub audio to a target language with automatic voice cloning.
```csharp
var response = await client.StartGenerating.CreateVoiceDubbingAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestElevenVoiceDubbing
    {
        AudioUri = "https://example.com/audio.mp3",
        TargetLang = RequestElevenVoiceDubbingTargetLang.Es,
        DisableVoiceCloning = false,
        DropBackgroundAudio = false,
    });
```

#### Error Handling
All generation APIs return async tasks. Check for failures with machine-readable error codes.
```csharp
if (taskDetail.IsFailed)
{
    Console.WriteLine($"Failure: {taskDetail.Failed!.Failure}");
    Console.WriteLine($"Code: {taskDetail.Failed.FailureCode}");
}
```

## Support

Priority place for bugs: https://github.com/tryAGI/Runway/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Runway/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
