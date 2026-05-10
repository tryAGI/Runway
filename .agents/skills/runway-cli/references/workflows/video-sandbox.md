# Video & Prompt Sandbox workflows

Restyle a clip or iterate on prompt-engineering choices through image and video generators. Reach for these when the user has a **video** to transform, or wants to test how a system prompt + style combo looks across both image and video output.

<!-- BEGIN:builtins-table -->
| Command | Required | Optional |
| --- | --- | --- |
| `video-style-transfer` | `--video` | `--style` |
| `build-system-prompt` | — | `--subject`, `--style` |
<!-- END:builtins-table -->

## Examples

```bash
# Restyle one clip with a single style prompt; returns 2 restyled MP4s (Aleph + Gemini paths).
dnx Runway.Cli video-style-transfer \
  --video ./assets/sample-clip.mp4 \
  --style "modern Pixar 3D style with vibrant colors" \
  --output ./out

# Test a system-prompt + style combo on one subject; produces 1 image + 1 video.
dnx Runway.Cli build-system-prompt \
  --subject "A vintage mechanical watch" \
  --style "Macro close-up, extreme detail, subject fills the frame" \
  --output ./out
```

## Picking between them

- Have a video, want a different visual style: `video-style-transfer`.
- Iterating on a system prompt for both image and video output (no source video): `build-system-prompt`.
