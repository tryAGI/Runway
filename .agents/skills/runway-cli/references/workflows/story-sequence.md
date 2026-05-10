# Story / Sequence workflows

Turn text or one image into a multi-shot piece — panels, b-roll, storyboard frames, manga pages, or rendered film shots. Reach for these when the user wants **more than a single output** and there's a narrative or sequence dimension.

<!-- BEGIN:builtins-table -->
| Command | Required | Optional |
| --- | --- | --- |
| `json-to-manga` | `--character` | `--storyboard` |
| `b-roll-generator` | `--image` | `--b-roll`, `--motion` |
| `storyboard-to-film` | `--character` | `--script`, `--style` |
| `story-panels` | `--horizontal-image`, `--vertical-image` | `--horizontal-prompt`, `--vertical-prompt` |
| `storyboard-creator` | — | `--prompt` |
<!-- END:builtins-table -->

## Examples

```bash
# One-line idea → expanded storyboard PNG.
dnx Runway.Cli storyboard-creator \
  --prompt "a quiet detective scene in a rainy alley" \
  --output ./out

# Render a structured page-by-page storyboard JSON into manga panels.
dnx Runway.Cli json-to-manga \
  --character ./assets/protagonist.png \
  --storyboard @./storyboard.json \
  --output ./out

# Two parallel triptychs (16:9 horizontal + 9:16 vertical) from a source image.
dnx Runway.Cli story-panels \
  --horizontal-image ./assets/scene.jpg \
  --vertical-image ./assets/scene-portrait.jpg \
  --horizontal-prompt "New shots in the sequence" \
  --vertical-prompt "New shots in the sequence showing forward progress" \
  --output ./out

# Extra b-roll clips from one source frame.
dnx Runway.Cli b-roll-generator \
  --image ./assets/scene.jpg \
  --b-roll "wider establishing shot, close-up of hands, slow rack-focus on the desk" \
  --motion "subtle parallax, slow dolly in" \
  --output ./out

# Treatment + character reference → rendered film shot MP4s.
dnx Runway.Cli storyboard-to-film \
  --character ./assets/lead.png \
  --script @./treatment.txt \
  --style "Cinematic, photorealistic, 35mm fine film grain" \
  --output ./out
```

## Picking between them

- Just a story idea → `storyboard-creator` (single PNG storyboard) or `storyboard-to-film` (rendered MP4s) when the user has a real character reference.
- Comic / manga rendering with structured pages → `json-to-manga`.
- One image, want a triptych or "next shots" → `story-panels` (two-aspect output) or `b-roll-generator` (motion-driven clips).

`--script` and `--storyboard` accept `@./path` to read from a file or `-` for stdin — useful for longer prompts.
