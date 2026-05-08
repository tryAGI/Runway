# Runway

[![Nuget package](https://img.shields.io/nuget/vpre/Runway)](https://www.nuget.org/packages/Runway/)
[![dotnet](https://github.com/tryAGI/Runway/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Runway/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Runway)](https://github.com/tryAGI/Runway/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Runway OpenAPI specification](https://raw.githubusercontent.com/runwayml/openapi/refs/heads/next/openapi.json) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage

#### Avatar Video
Generate a talking-avatar video from text using a Runway preset avatar.
```csharp
using Runway;

using var client = new RunwayClient(apiKey);

var response = await client.AvatarVideos.CreateAvatarVideosAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateAvatarVideosRequest
    {
        Avatar = new CreateAvatarVideosRequestAvatarRunwayPresetAvatar
        {
            PresetId = CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.Influencer,
        },
        Speech = new CreateAvatarVideosRequestSpeechTextInput
        {
            Text = "Welcome to the Runway API hackathon. Here is a quick prototype walkthrough.",
            Voice = new CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice
            {
                PresetId = CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Clara,
            },
        },
    });
```

#### Create Avatar
Create a custom realtime avatar from a reference image, personality prompt, and voice.
```csharp
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
```

#### Realtime Avatar Session
Use this path for live Characters calls and backend bridges. The session ID is also the conversation ID for transcript and recording retrieval.
```csharp
var session = await client.RealtimeSessions.CreateRealtimeSessionsAsync(
    request: new CreateRealtimeSessionsRequest
    {
        Avatar = new CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar
        {
            PresetId = CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.Influencer,
        },
        MaxDuration = 60,
    });

GetRealtimeSessionsResponse status;
do
{
    status = await client.RealtimeSessions.GetRealtimeSessionsByIdAsync(id: session.Id);
    await Task.Delay(TimeSpan.FromSeconds(1));
}
while (status.IsNotReady);

if (!status.IsReady)
{
    throw new InvalidOperationException("Realtime session did not become ready.");
}

var credentials = await client.RealtimeSessions.ConsumeRealtimeSessionAsync(
    id: session.Id,
    sessionKey: status.Ready!.SessionKey);
```

For watchOS or other clients without WebRTC support, terminate WebRTC in your backend using the returned LiveKit credentials and relay optimized media over your own transport. `AvatarVideos.CreateAvatarVideosAsync` and `StartGenerating.CreateCharacterPerformanceAsync` are asynchronous generation endpoints, not live conversation transports.

#### Image to Video
```csharp
using Runway;

using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateImageToVideoAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateImageToVideoRequestGen3aTurbo
    {
        PromptImage = "https://example.com/photo.jpg",
        PromptText = "The girl smiles a little",
        Seed = 999999999,
        Model = "gen3a_turbo",
        Duration = 5,
        Ratio = CreateImageToVideoRequestGen3aTurboRatio.x1280_768,
    });

// Poll until complete
GetTasksResponse taskDetail;
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

#### Text to Video
Generate video from a text prompt using Veo 3.1 Fast.
```csharp
var response = await client.StartGenerating.CreateTextToVideoAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateTextToVideoRequestVeo31Fast
    {
        PromptText = "A calm ocean with gentle waves under a starlit sky",
        Ratio = CreateTextToVideoRequestVeo31FastRatio.x1280_720,
        Duration = 5,
    });
```

#### Text to Image
Generate images from text using Gen4 Image Turbo.
```csharp
var response = await client.StartGenerating.CreateTextToImageAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateTextToImageRequestGen4ImageTurbo
    {
        PromptText = "A vibrant coral reef teeming with tropical fish",
        Ratio = CreateTextToImageRequestGen4ImageTurboRatio.x1280_720,
        ReferenceImages = [],
    });
```

#### Text to Speech
Choose from 48 preset voices including Maya, Arjun, Eleanor, Bernard, and more.
```csharp
var response = await client.StartGenerating.CreateTextToSpeechAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateTextToSpeechRequestElevenMultilingualV2
    {
        PromptText = "Hello! Welcome to Runway's text-to-speech API.",
        Voice = new CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice
        {
            PresetId = CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Maya,
        },
    });
```

#### Sound Effects
Generate sound effects from text descriptions (0.5–30 seconds, optional seamless looping).
```csharp
var response = await client.StartGenerating.CreateSoundEffectAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateSoundEffectRequestElevenTextToSoundV2
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
    request: new CreateVoiceDubbingRequestElevenVoiceDubbing
    {
        AudioUri = "https://example.com/audio.mp3",
        TargetLang = CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es,
        DisableVoiceCloning = false,
        DropBackgroundAudio = false,
    });
```

#### Speech to Speech
Transform the voice in an audio file while preserving the original speech content.
```csharp
var response = await client.StartGenerating.CreateSpeechToSpeechAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateSpeechToSpeechRequestElevenMultilingualStsV2
    {
        Media = new CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio
        {
            Uri = "https://example.com/speech.mp3",
        },
        Voice = new CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice
        {
            PresetId = CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId.Eleanor,
        },
        RemoveBackgroundNoise = true,
    });
```

#### Error Handling and Cancellation
All generation APIs return async tasks. Check for failures or cancel running tasks.
```csharp
// Check for failures with machine-readable error codes
if (taskDetail.IsFailed)
{
    Console.WriteLine($"Failure: {taskDetail.Failed!.Failure}");
    Console.WriteLine($"Code: {taskDetail.Failed.FailureCode}");
}

// Cancel a running task or delete a completed one
await client.TaskManagement.DeleteTasksByIdAsync(
    id: taskId,
    xRunwayVersion: "2024-11-06");
```

### AI Agent Tools

The SDK exposes Runway generation endpoints as `Microsoft.Extensions.AI` tools for use with any `IChatClient`.

```csharp
using Microsoft.Extensions.AI;
using Runway;

using var runway = new RunwayClient(apiKey);

var tools = new AIFunction[]
{
    runway.AsTextToVideoTool(),
    runway.AsGenerateImageTool(),
    runway.AsImageToVideoTool(),
    runway.AsGetTaskTool(),
};
```

### CLI

This repository includes a local .NET tool project for image, video, task, and avatar workflows. It reads `RUNWAY_API_KEY` or `RUNWAYML_API_SECRET` by default.

```bash
# One-shot via dnx. The installed tool command is `runway`; dnx uses the package ID.
dnx Runway.Cli video a cinematic drone shot over a neon desert highway

dnx Runway.Cli image a product photo of a translucent glass speaker on a steel table

# Installed tool form.
dotnet tool install --global Runway.Cli
runway video a cinematic drone shot over a neon desert highway

# Local development from the repo.
dotnet run --project src/cli/Runway.Cli -- video a cinematic drone shot over a neon desert highway

dotnet run --project src/cli/Runway.Cli -- image a product photo of a translucent glass speaker on a steel table

dotnet run --project src/cli/Runway.Cli -- video a slow push in on the reference image \
  --image ./reference.png \
  --output ./runway-output

dotnet run --project src/cli/Runway.Cli -- task get 17f20503-6c24-4c16-946b-35dbbce2af2f \
  --wait \
  --download \
  --kind video

dotnet run --project src/cli/Runway.Cli -- avatar presets

dotnet run --project src/cli/Runway.Cli -- avatar list --limit 20

dotnet run --project src/cli/Runway.Cli -- avatar video \
  --preset-avatar influencer \
  --voice-preset clara \
  --text "Welcome to the Runway API hackathon." \
  --wait
```

## Support

Priority place for bugs: https://github.com/tryAGI/Runway/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Runway/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
