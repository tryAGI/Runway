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
| Image with accurate text | `image --model gpt-image-2 --ratio 1920:1088 --quality low` |
| Product photoshoot plan | `product-photoshoot create --mode product_shot --plan-only` |
| Marketplace card bundle | `marketplace-cards create --scope full-set --plan-only` |
| Text-to-video | `video --model veo3.1-fast --duration 4 --ratio 1280:720` |
| Ad-video recipe | `ad-video create --mode ugc --shots 1 --duration 4` |
| Scenario to short film | `short-video --planner auto --shots 3 --duration 4 --ratio 1280:720` |
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

Generate a planned multi-shot short video from one scenario:

```bash
dnx Runway.Cli short-video "a tiny robot finds a glowing seed and turns a rooftop into a garden" \
  --shots 3 \
  --duration 4 \
  --output ./runway-short-video
```

Review the generated scenario/keyframe prompts before spending credits:

```bash
dnx Runway.Cli short-video "a calm product launch film for a transparent speaker" \
  --shots 3 \
  --plan-only > ./short-video-plan.json
```

`short-video` defaults to `--planner auto`: Claude Code first, Codex CLI second, deterministic fallback. Use `--planner deterministic` for reproducible local-only plans, or `--planner claude --planner-model opus` when the user wants stronger external storyboard planning. The bundled Runway planner prompt is informed by storyboard-creation workflows; no external storyboard skill is required.

## Short Video

Use `short-video` when the user has an idea and wants Runway to turn it into a finished multi-shot video. The user should be able to describe the result in plain language, such as "show how a small business owner makes product photos in minutes" or "make a simple launch video for a travel mug." The CLI expands that one sentence into a short plan, creates each shot with Runway, downloads the clips, and tries to stitch them into one final video.

Default to simple, product-focused language:

```bash
dnx Runway.Cli short-video "A simple product video showing how Runway CLI helps someone turn one idea into ready-to-use images, product cards, and a short ad video from their laptop. Keep it friendly, clear, and made for everyday business owners, creators, and shop teams." \
  --planner auto \
  --shots 3 \
  --duration 4 \
  --ratio 1280:720 \
  --model veo3.1-fast \
  --output ./runway-short-video
```

What `short-video` does:

- Turns one plain-language request into a small storyboard.
- Creates a key visual idea for every shot.
- Writes a video prompt for every shot.
- Starts Runway video jobs for the planned shots.
- Downloads the finished clips.
- Saves the exact executed plan beside the final video as `*.plan.json`.
- Uses `ffmpeg` when available to create one final video file.

Use `--planner auto` for normal work. Auto planning tries Claude Code first, then Codex CLI, then the built-in planner. Use `--planner deterministic` only for CI, demos that must be repeatable, or environments with no external planner access. Use `--plan-only` when the user wants to review the idea before spending credits.

Keep prompts friendly for non-technical users. Talk about outcomes, products, customers, creators, shops, campaigns, listings, and videos. Avoid implementation language such as SDK, endpoint, schema, CLI internals, auth, generated code, tests, or workflow names unless the user explicitly asks for that.

Good user-facing short-video prompts:

- "Show a candle shop owner making clean product photos, marketplace cards, and a short launch video from one idea."
- "Create a warm 12-second launch video for a travel mug, from product photo to ad video."
- "Show a creator turning one product image into a polished store listing and a simple social ad."
- "Make a calm product walkthrough showing how a small team plans, creates, and saves ready-to-use media."

When the user wants to edit the plan, split the flow:

```bash
dnx Runway.Cli short-video "a simple launch video for a transparent speaker" \
  --planner auto \
  --shots 3 \
  --plan-only > ./short-video-plan.json

dnx Runway.Cli short-video run \
  --plan ./short-video-plan.json \
  --output ./runway-short-video
```

Run an edited short-video plan:

```bash
dnx Runway.Cli short-video run \
  --plan ./short-video-plan.json \
  --output ./runway-short-video
```

Browse generated videos and their saved plans:

```bash
dnx Runway.Cli gallery create \
  --input ./runway-short-video \
  --output ./runway-short-video/gallery.html
```

Plan Runway-native creative recipes before spending credits:

```bash
dnx Runway.Cli product-photoshoot create \
  --prompt "transparent speaker on a brushed steel table" \
  --mode social_carousel \
  --plan-only

dnx Runway.Cli marketplace-cards create \
  --prompt "compact travel kettle" \
  --scope full-set \
  --plan-only

dnx Runway.Cli ad-video create \
  --prompt "hands-free camera strap for travel creators" \
  --mode ugc \
  --shots 3 \
  --plan-only
```

Execute a recipe by removing `--plan-only`. The recipe commands stay Runway-native: they use bundled prompt guidance for product/ad/storyboard work and call only Runway image/video generation endpoints. They do not install or call Higgsfield. For presenter-style video, use `avatar video` or `character-performance`; Runway does not provide Higgsfield-style reusable face-model training through this SDK.

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

Keep orchestration simple. Use `short-video` for scenario-to-keyframe-to-video one-shot work. Use `short-video --plan-only` followed by `short-video run --plan` when the user wants to review or edit keyframes before spending video credits.

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
