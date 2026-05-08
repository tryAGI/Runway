---
name: runway-cli
description: Use when an agent should operate Runway through the .NET CLI with `dnx Runway.Cli`: generate images, videos, and audio; upload local assets; manage tasks, avatars, documents, voices, workflows, and organization usage; or orchestrate compact multi-step Runway media workflows.
---

# Runway CLI

Use the packaged .NET tool as the runtime. Stable packages can use `dnx Runway.Cli`; current main-branch packages are prerelease, so add `--prerelease --yes` when NuGet has no stable CLI version yet:

```bash
dnx Runway.Cli -- --help
dnx Runway.Cli models

dnx Runway.Cli --prerelease --yes -- --help
dnx Runway.Cli --prerelease --yes models
```

The NuGet package ID is `Runway.Cli`; the installed tool command is `runway`. In a source checkout before publishing, use:

```bash
dotnet run --project src/cli/Runway.Cli -- <command>
```

## Preflight

1. Run commands from the directory where outputs should be saved.
2. Credentials come from `RUNWAY_API_KEY`, `RUNWAYML_API_SECRET`, or the nearest `.env`. Do not pass API keys on the command line unless the user explicitly asks.
3. Run `dnx Runway.Cli models` before choosing a model if model support matters.
4. For new or uncertain API fields, prefer `--json @request.json` after checking current Runway API docs.

## Model Choices

Default to low-cost, practical choices:

| Request | Default |
| --- | --- |
| Quick image | `image --model gemini-2.5-flash --ratio 1024:1024` |
| Image with accurate text | `image --model gpt-image-2 --resolution 1K --quality low` |
| Text-to-video | `video --model veo3.1-fast --duration 4 --ratio 1280:720` |
| Image-to-video from a local file | `image-to-video --model gen4-turbo --image <file>` |
| Highest quality video | `video --model gen4.5` or `video --model veo3` |
| Video edit / transformation | `video-to-video --video <file>` |
| Text-to-speech | `text-to-speech --voice-preset clara` |

If the user asks for exact pricing, latest models, or a model not shown by `models`, verify against official docs before running.

## Direct Generation

Generate and download an image:

```bash
dnx Runway.Cli image "a clean product icon for a camera tool" \
  --model gemini-2.5-flash \
  --ratio 1024:1024 \
  --output ./runway-output
```

Generate and download a video from text:

```bash
dnx Runway.Cli video "a cinematic drone shot over a neon desert highway" \
  --model veo3.1-fast \
  --duration 4 \
  --ratio 1280:720 \
  --output ./runway-output
```

Animate a local image:

```bash
dnx Runway.Cli image-to-video "slow product turntable, soft studio light" \
  --image ./product.png \
  --model gen4-turbo \
  --output ./runway-output
```

Generate audio:

```bash
dnx Runway.Cli text-to-speech "Welcome to the launch." --voice-preset clara --output ./runway-output
dnx Runway.Cli sound-effect "short bright camera shutter and soft whoosh" --output ./runway-output
```

Inspect or resume work:

```bash
dnx Runway.Cli task get <task-id> --wait --download --kind image --output ./runway-output
dnx Runway.Cli task cancel <task-id>
```

## Account And Resources

Use compact list/get commands first:

```bash
dnx Runway.Cli organization get
dnx Runway.Cli voice list
dnx Runway.Cli avatar list --limit 20
dnx Runway.Cli document list
dnx Runway.Cli workflow list
```

For local files that are too large for data URIs or need reusable `runway://` references:

```bash
dnx Runway.Cli upload create --file ./reference.png
```

## Multi-Step Recipes

Keep orchestration simple. Use shell loops or two-command recipes before adding new app code.

Concept image, then animated video:

```bash
image_path=$(dnx Runway.Cli image "hero frame of a minimalist coffee grinder on steel" \
  --model gemini-2.5-flash \
  --ratio 1024:1024 \
  --output ./runway-output | tail -1)

dnx Runway.Cli image-to-video "slow push-in, steam drifting, premium product ad" \
  --image "$image_path" \
  --model gen4-turbo \
  --output ./runway-output
```

Batch product images into short videos:

```bash
for image in ./products/*.{png,jpg,jpeg}; do
  [ -e "$image" ] || continue
  dnx Runway.Cli image-to-video "elegant 4 second product ad, subtle camera move" \
    --image "$image" \
    --model gen4-turbo \
    --output ./runway-output
done
```

Voiceover plus sound effect:

```bash
dnx Runway.Cli text-to-speech "The future of editing starts here." --voice-preset clara --output ./runway-output
dnx Runway.Cli sound-effect "short cinematic impact with airy tail" --output ./runway-output
```

## Raw JSON Escape Hatch

For newly released fields or exact endpoint parity, create a body file and pass it through:

```bash
dnx Runway.Cli image "ignored when --json is used" --json @text-to-image.json --output ./runway-output
dnx Runway.Cli text-to-video "ignored when --json is used" --json @text-to-video.json --output ./runway-output
```

Use this only when the friendly command cannot express the request.

## Integration Boundary

For direct account actions and media generation, use this CLI. For application integration, keep the API key server-side and prefer the `Runway` C# SDK or normal backend code. Do not build browser-only integrations that expose the key.
