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

The watch bridge controls the client-facing media shape after it receives the realtime avatar track. Set only `watchVideoWidth` to preserve the source aspect ratio, or set both width and height for a fixed player surface:

```json
{
  "presetAvatar": "influencer",
  "maxDurationSeconds": 60,
  "audioEnabled": true,
  "videoEnabled": true,
  "watchVideoMode": "h264-fmp4",
  "watchVideoWidth": 256,
  "watchVideoHeight": 256,
  "watchVideoResizeMode": "cover",
  "watchVideoCropTop": 0,
  "watchVideoFps": 8,
  "watchVideoBitrateKbps": 220,
  "watchFmp4FragmentMs": 500
}
```

`watchVideoResizeMode` can be `cover` for a center-cropped exact size, `fit` for letterboxed/padded exact size, or `stretch` for exact dimensions with distortion. If a generated avatar includes an unwanted top border, set `watchVideoCropTop` to crop output pixels from the top before encoding. For watchOS, start with H.264/fMP4 at `256x256`, `cover`, 6-8 FPS, and roughly 160-300 kbps. H.265 can reduce bandwidth if your watchOS playback path supports HEVC; JPEG mode is simpler but usually costs more bandwidth, so keep it around 45-60 quality for small watch previews. PNG mode preserves alpha when the upstream avatar track has transparent pixels, but it is much larger and should be treated as a diagnostic or overlay-specific mode.

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
        Duration = 4,
    });
```

#### Text to Image
Generate images from text using Gemini 2.5 Flash.
```csharp
var response = await client.StartGenerating.CreateTextToImageAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateTextToImageRequestGemini25Flash
    {
        PromptText = "A vibrant coral reef teeming with tropical fish",
        Ratio = CreateTextToImageRequestGemini25FlashRatio.x1024_1024,
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

var tools = runway.AsTools();
```

### GPT Image 2

Runway's current model list includes `gpt_image_2`. Until it appears in the generated OpenAPI union, the SDK exposes a typed handwritten helper outside `Generated/`.

```csharp
using Runway;

using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateGptImage2TextToImageAsync(
    request: new CreateGptImage2TextToImageRequest
    {
        PromptText = "A clean poster that says RUNWAY CLI in precise typography",
        Ratio = "1024:1024",
        Resolution = GptImage2Resolution.x1K,
        Quality = GptImage2Quality.Low,
        OutputCount = 1,
    });
```

### CLI

This repository includes a local .NET tool project for Runway generation, task management, uploads, documents, voices, realtime sessions, organization usage, workflows, and avatar workflows. It reads `RUNWAY_API_KEY`, `RUNWAYML_API_SECRET`, or the nearest `.env` file by default.

```bash
cat > .env <<'EOF'
RUNWAY_API_KEY=...
EOF

# One-shot via dnx. The installed tool command is `runway`; dnx uses the package ID.
# Add `--prerelease --yes` after `Runway.Cli` until the first stable CLI package is tagged.
dnx Runway.Cli video a cinematic drone shot over a neon desert highway

dnx Runway.Cli image a product photo of a translucent glass speaker on a steel table

dnx Runway.Cli image "a clean app icon for a studio camera tool" \
  --model gemini-2.5-flash \
  --ratio 1024:1024 \
  --output ./runway-image

dnx Runway.Cli image-to-video "a slow push in on the reference image" \
  --image ./reference.png \
  --model gen4-turbo \
  --output ./runway-video

dnx Runway.Cli short-video "a tiny robot finds a glowing seed and turns a rooftop into a garden" \
  --shots 3 \
  --output ./runway-short-video

# Normal generation also saves the exact plan beside the final video as *.plan.json.

dnx Runway.Cli short-video "a calm product launch film for a transparent speaker" \
  --shots 3 \
  --plan-only > ./short-video-plan.json

dnx Runway.Cli short-video "a three-shot cyberpunk food commercial" \
  --planner claude \
  --planner-model opus \
  --planner-tools read-only \
  --plan-only

dnx Runway.Cli short-video run \
  --plan ./short-video-plan.json \
  --output ./runway-short-video

dnx Runway.Cli product-photoshoot create \
  --prompt "transparent speaker on a brushed steel table" \
  --mode social_carousel \
  --plan-only > ./product-photoshoot-plan.json

dnx Runway.Cli marketplace-cards create \
  --prompt "compact travel kettle" \
  --scope full-set \
  --plan-only > ./marketplace-cards-plan.json

dnx Runway.Cli ad-video create \
  --prompt "hands-free camera strap for travel creators" \
  --mode ugc \
  --shots 3 \
  --plan-only > ./ad-video-plan.json

# Installed tool form.
dotnet tool install --global Runway.Cli
runway video a cinematic drone shot over a neon desert highway

# Local development from the repo.
dotnet run --project src/cli/Runway.Cli -- video a cinematic drone shot over a neon desert highway

dotnet run --project src/cli/Runway.Cli -- image a product photo of a translucent glass speaker on a steel table

dotnet run --project src/cli/Runway.Cli -- image a logo-style glass speaker icon \
  --model gemini-2.5-flash \
  --ratio 1024:1024 \
  --output ./runway-image

dotnet run --project src/cli/Runway.Cli -- image "a sharp product poster with readable text" \
  --model gpt-image-2 \
  --ratio 1024:1024 \
  --resolution 1K \
  --quality low \
  --output-count 1 \
  --output ./runway-gpt-image

dotnet run --project src/cli/Runway.Cli -- video a slow push in on the reference image \
  --image ./reference.png \
  --output ./runway-output

dotnet run --project src/cli/Runway.Cli -- short-video "a tiny robot finds a glowing seed and turns a rooftop into a garden" \
  --shots 3 \
  --output ./runway-short-video

dotnet run --project src/cli/Runway.Cli -- short-video run \
  --plan ./short-video-plan.json \
  --output ./runway-short-video

dotnet run --project src/cli/Runway.Cli -- models

dotnet run --project src/cli/Runway.Cli -- text-to-speech "A warm, concise product walkthrough voiceover." \
  --voice-preset clara \
  --output ./runway-audio

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

dotnet run --project src/cli/Runway.Cli -- upload create --file ./reference.png

dotnet run --project src/cli/Runway.Cli -- workflow list

dotnet run --project src/cli/Runway.Cli -- gallery create \
  --input ./runway-short-video \
  --output ./runway-short-video/gallery.html
```

CLI endpoint and model coverage:

| Command | Endpoint(s) | Models |
| --- | --- | --- |
| `video`, `text-to-video` | `POST /v1/text_to_video` | `gen4.5`, `veo3.1`, `veo3.1_fast`, `veo3` |
| `short-video` | Multi-shot planner over `POST /v1/text_to_video`; `short-video run --plan` executes edited plan JSON; optionally concatenates downloaded clips with `ffmpeg` | `gen4.5`, `veo3.1`, `veo3.1_fast`, `veo3` |
| `ad-video create` | Runway-native ad recipe planner over `POST /v1/text_to_video` or `POST /v1/image_to_video` when `--image` is supplied | `veo3.1_fast` by default; accepts video models |
| `image-to-video` | `POST /v1/image_to_video` | `gen4.5`, `gen4_turbo`, `gen3a_turbo`, `veo3.1`, `veo3.1_fast`, `veo3` |
| `video-to-video` | `POST /v1/video_to_video` | `gen4_aleph` |
| `image` | `POST /v1/text_to_image` | `gen4_image_turbo`, `gen4_image`, `gemini_image3_pro`, `gpt_image_2`, `gemini_2.5_flash` |
| `product-photoshoot create` | Runway-native product photoshoot recipe planner over `POST /v1/text_to_image` | `gpt_image_2` by default; accepts image models |
| `marketplace-cards create` | Runway-native marketplace-style card recipe planner over `POST /v1/text_to_image` | `gpt_image_2` by default; accepts image models |
| `character-performance` | `POST /v1/character_performance` | `act_two` |
| `sound-effect` | `POST /v1/sound_effect` | `eleven_text_to_sound_v2` |
| `speech-to-speech` | `POST /v1/speech_to_speech` | `eleven_multilingual_sts_v2` |
| `text-to-speech` | `POST /v1/text_to_speech` | `eleven_multilingual_v2` |
| `voice-dubbing` | `POST /v1/voice_dubbing` | `eleven_voice_dubbing` |
| `voice-isolation` | `POST /v1/voice_isolation` | `eleven_voice_isolation` |
| `task` | `GET /v1/tasks/{id}`, `DELETE /v1/tasks/{id}` | Task management |
| `gallery create` | Local HTML gallery for generated MP4 files and adjacent `*.plan.json` files | No API call |
| `avatar` | `GET/POST/PATCH/DELETE /v1/avatars`, conversation and usage endpoints | `gwm1_avatars`, avatar presets |
| `avatar video` | `POST /v1/avatar_videos` | `gwm1_avatars` |
| `document` | `GET/POST/PATCH/DELETE /v1/documents` | Knowledge documents |
| `upload` | `POST /v1/uploads` | Ephemeral uploads |
| `voice` | `GET/POST/PATCH/DELETE /v1/voices`, `POST /v1/voices/preview` | `eleven_ttv_v3`, `eleven_multilingual_ttv_v2` |
| `realtime` | `POST/GET/DELETE /v1/realtime_sessions` | `gwm1_avatars` |
| `organization` | `GET /v1/organization`, `POST /v1/organization/usage` | Usage and metadata |
| `workflow` | `GET/POST /v1/workflows`, `GET /v1/workflow_invocations/{id}` | Published workflows |

The CLI `short-video` command can plan with external agents before using Runway: `--planner auto` (default) tries Claude Code first, Codex CLI second, then the deterministic planner; `--planner deterministic` keeps output fully local and CI-safe. `--planner-model`, `--planner-tools`, and `--planner-timeout-seconds` also support `RUNWAY_SHORT_VIDEO_PLANNER_MODEL`, `RUNWAY_SHORT_VIDEO_PLANNER_TOOLS`, and `RUNWAY_SHORT_VIDEO_PLANNER_TIMEOUT_SECONDS`. `short-video run --plan` is execution-only and never invokes a planner. The bundled planner prompt is Runway-owned and was shaped by storyboard-creation workflows; no external storyboard skill is installed or required. Normal `short-video` generation writes the exact executed plan next to the final video as `*.plan.json`, and logs which planner source was used.

The creative recipe commands are Runway-native. `product-photoshoot create`, `marketplace-cards create`, and `ad-video create` bundle product/ad/storyboard prompt guidance inspired by compact creator workflows: concise sensory prompts, camera and motion structure, lighting, positive phrasing, mode routing, reference-image handling, and model-fit defaults. They do not install or call Higgsfield, and marketplace-card plans are creative asset bundles rather than marketplace compliance claims. For presenter-like videos, use the existing avatar and character-performance commands; Runway does not expose Higgsfield-style reusable face-model training through this SDK.

The short-video workflow is also available from the SDK through `RunwayShortVideoExtensions.CreateShortVideoPlan(...)`, `IChatClient.CreateShortVideoPlanAsync(...)`, `client.CreateShortVideoAsync(...)`, and `client.CreateShortVideoAsync(plan, ...)`. Backend code can use the deterministic planner, supply a custom `RunwayShortVideoPlanner`, ask any Microsoft.Extensions.AI `IChatClient` for richer storyboard JSON, review or edit the plan, then execute the edited plan. `RunwayShortVideoJsonSerializerContext` provides AOT-safe JSON metadata for serializing plans and results.

### Agent Skill

The repo includes a compact Codex-compatible skill at `.agents/skills/runway-cli/SKILL.md`. It mirrors the official [runwayml/skills](https://github.com/runwayml/skills) agent-skill flow, but uses `dnx Runway.Cli` as the runtime instead of bundled Python or Node scripts. The skill covers direct media generation, scenario-to-short-video planning, creative product/ad recipes, resource inspection, uploads, task polling/downloads, and simple multi-step recipes such as concept image to video and batch product-image animation.

## Support

Priority place for bugs: https://github.com/tryAGI/Runway/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Runway/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
