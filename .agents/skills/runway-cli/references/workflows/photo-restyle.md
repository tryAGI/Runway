# Photo / Identity Restyle workflows

Take one source image and return restyled image(s) of the same subject. Use these when the user wants to **change something about a photo while keeping the subject recognizable** — outfit color, hairstyle, garment, pose, or just "give me variations."

<!-- BEGIN:builtins-table -->
| Command | Required | Optional |
| --- | --- | --- |
| `fabric-color-texture-swap` | `--image` | `--change-1`, `--change-2`, `--change-3`, `--change-4` |
| `ai-hair-salon` | `--image` | `--hairstyle`, `--background` |
| `virtual-try-on` | `--person`, `--garment` | `--scene` |
| `image-variations` | `--image` | `--variations` |
| `asset-reversioning` | `--image` | — |
| `human-pose-replication` | `--character`, `--pose` | `--driving-prompt` |
<!-- END:builtins-table -->

## Examples

```bash
# Restyle one source dress in four directions.
dnx Runway.Cli fabric-color-texture-swap \
  --image ./assets/sample-dress.jpg \
  --change-1 "Change: color to teal" \
  --change-2 "Change: fabric to silk" \
  --output ./out

# Try a new hairstyle on a portrait, with an optional new background.
dnx Runway.Cli ai-hair-salon \
  --image ./assets/portrait.jpg \
  --hairstyle "shoulder-length wavy bob with subtle blonde highlights" \
  --background "soft sunset gradient backdrop" \
  --output ./out

# Put a garment from one image onto a person from another.
dnx Runway.Cli virtual-try-on \
  --person ./assets/model.jpg \
  --garment ./assets/jacket.png \
  --scene "wearing the jacket on a foggy harbor at dawn" \
  --output ./out

# Free-form variation request (e.g. swap palette, redo pose).
dnx Runway.Cli image-variations \
  --image ./assets/product.jpg \
  --variations "Vary: 3 alternative outfit colors, white background" \
  --output ./out

# Bulk reversioned variants of one source image (Canvas Reversion Engine).
dnx Runway.Cli asset-reversioning --image ./assets/hero.png --output ./out

# Re-render a character image in a target reference pose.
dnx Runway.Cli human-pose-replication \
  --character ./assets/hero.jpg \
  --pose ./assets/pose-ref.jpg \
  --output ./out
```

## Picking between them

- One image, change a single attribute → `ai-hair-salon`, or `fabric-color-texture-swap` for clothing.
- One image, multiple parallel "what-ifs" → `image-variations`, `asset-reversioning`.
- Two images, swap garment → `virtual-try-on`.
- Two images, transfer pose → `human-pose-replication`.
