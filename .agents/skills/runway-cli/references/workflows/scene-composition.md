# Composition / Scene workflows

Place an existing subject (logo, product, person) into a new context — replaced background, advertising mockup, or product label on a bottle. Different from `image-variations` and `asset-reversioning` because **the source image stays semantically the same; it's the surrounding context that changes**.

<!-- BEGIN:builtins-table -->
| Command | Required | Optional |
| --- | --- | --- |
| `mockup-generator` | `--image` | `--mockup` |
| `backplate-generator` | `--image` | `--scene`, `--blur` |
| `wine-label-generator` | `--label-1`, `--label-2`, `--bottle` | `--video-prompt` |
<!-- END:builtins-table -->

## Examples

```bash
# Composite one product image as four advertising mockup placements.
dnx Runway.Cli mockup-generator \
  --image ./assets/logo.png \
  --mockup "Mockup details: Subway billboard, glossy paper, evening commute" \
  --output ./out

# Remove the foreground subject from a photo and re-composite into a new scene.
dnx Runway.Cli backplate-generator \
  --image ./assets/portrait.jpg \
  --scene "in a sunlit cafe with bookshelves" \
  --blur "subtle 30% gaussian on the background" \
  --output ./out

# Composite two label artworks onto a bottle reference and produce a final video shot.
dnx Runway.Cli wine-label-generator \
  --label-1 ./assets/label-front.png \
  --label-2 ./assets/label-back.png \
  --bottle ./assets/bottle-ref.jpg \
  --video-prompt "shattered bottle suspended in mid-air, slow rotation" \
  --output ./out
```

## Picking between them

- Logo or product → environment placements: `mockup-generator`.
- Person or subject → swap their background: `backplate-generator`.
- Bottle + label artworks → packaging shot: `wine-label-generator` (the only built-in that produces a final hero MP4 from images alone).
