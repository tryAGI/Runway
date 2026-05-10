# Custom Workflows reference

This file is the deep-dive companion to the **Custom Workflows** section in `SKILL.md`. The CLI ships **18 named subcommands** that wrap the user's published Runway workflows; each one takes only the user-facing inputs as ergonomic flags, so an agent never needs workflow UUIDs, node UUIDs, or `nodeOutputs` JSON.

For routing, the **machine-readable registry** is the source of truth:

```bash
dnx Runway.Cli workflow built-ins --json
```

That JSON carries `commandName`, `displayName`, `description`, `workflowId`, `category` / `categoryDisplay`, plus per-flag `kind` (Image / Video / Audio / Prompt / Number / Boolean), `description`, and (for optional flags) `defaultPreview`. Filter by `category` to narrow routing.

## Common conventions

- Local files passed to any asset flag (`--image`, `--video`, `--audio`, `--person`, `--garment`, `--character`, `--bottle`, `--label-*`, `--pose`, …) are auto-uploaded as ephemeral assets and replaced with the returned `runway://` URI before the workflow runs.
- `https://`, `runway://`, and `data:` URIs pass through unchanged.
- By default the CLI waits for the workflow to finish and downloads every output URL into `--output` (defaults to `./runway-<command-name>/`).
- `--no-wait` submits and exits with the invocation ID. `--no-download` keeps polling but skips file fetch (URLs still print). `--poll-interval-seconds` controls cadence.
- Any input flag left unset keeps the workflow's authored default.

## Categories

<!-- BEGIN:index -->
- **[Photo / Identity Restyle](workflows/photo-restyle.md)** — `fabric-color-texture-swap`, `ai-hair-salon`, `virtual-try-on`, `image-variations`, `asset-reversioning`, `human-pose-replication`
- **[Composition / Scene](workflows/scene-composition.md)** — `mockup-generator`, `backplate-generator`, `wine-label-generator`
- **[Story / Sequence](workflows/story-sequence.md)** — `json-to-manga`, `b-roll-generator`, `storyboard-to-film`, `story-panels`, `storyboard-creator`
- **[Character & Item Generation](workflows/character-item.md)** — `character-creator`, `game-item-generator`
- **[Video & Prompt Sandbox](workflows/video-sandbox.md)** — `video-style-transfer`, `build-system-prompt`
<!-- END:index -->

For the dynamic-register flow (not in the table above) see [`workflows/registering.md`](workflows/registering.md).

## Routing decision (for agents)

When the user asks to run a published workflow:

1. Run `dnx Runway.Cli workflow built-ins --json` and pick the entry whose `displayName` / `description` / `required` shape matches the user's intent. Filter by `category` if the request maps cleanly to one (e.g. "restyle this photo" → `PhotoRestyle`).
2. If nothing matches and the user knows the workflow UUID (or just published it), `dnx Runway.Cli workflow register <uuid> --name <command>` creates a dynamic subcommand. See [`workflows/registering.md`](workflows/registering.md).
3. Only fall back to `dnx Runway.Cli workflow run <uuid> --node-outputs-json '<...>'` as a last-resort escape hatch when neither named built-in nor registered command will do.
