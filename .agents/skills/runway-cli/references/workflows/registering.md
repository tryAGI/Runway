# Registering other workflows

Workflows that aren't in the curated built-in list can be registered as a top-level subcommand on the fly — no SDK release needed. Useful when the user has just published a new workflow in the Runway dev portal and wants the same ergonomic CLI experience as the built-ins.

```bash
# Fetch the graph, derive ergonomic flags, persist under ~/.runway-cli/workflows/<command>.json.
dnx Runway.Cli workflow register <workflow-uuid>                      # default name = slug of the workflow's display name
dnx Runway.Cli workflow register <workflow-uuid> --name my-fashion-tool

# Inspect / manage what's registered.
dnx Runway.Cli workflow registered list
dnx Runway.Cli workflow registered show my-fashion-tool
dnx Runway.Cli workflow registered remove my-fashion-tool

# Use the registered subcommand exactly like the built-ins.
dnx Runway.Cli my-fashion-tool --help
dnx Runway.Cli my-fashion-tool --image-1 ./photo.jpg --specifics-of-product-1 "Change: color to teal"
```

## Storage shape

`~/.runway-cli/workflows/<command>.json`:

```json
{
  "commandName": "my-fashion-tool",
  "description": "...",
  "picks": [{ "flag": "--image-1", "nodeId": "<uuid>", "description": "..." }],
  "graph": <full GET /v1/workflows/{id} response>
}
```

Inputs (Kind / OutputKey / Required / DefaultPreview) are NOT persisted — they're re-derived from the cached graph each time `LoadAll` runs. Default-value or label edits in the workflow flow through automatically once the user re-registers.

`Save` rejects an empty picks list with a clear error: a registered command with no overrides would just re-run the workflow's authored defaults every time.

## Flag derivation rules

- Inputs with a `nodeProps.name` slug into `--<slugified-name>` (case-insensitive, kebab). Duplicates get a `-1` / `-2` suffix in graph-position order.
- Inputs without a name fall back to `--<type>-<index>` (e.g. `--image-1`, `--prompt-2`), ordered top-to-bottom then left-to-right by graph position.
- Asset inputs (image / video / audio) are marked required; primitives stay optional and inherit the workflow's authored default.

## When to register vs. when to use a built-in

Routing decision (for an agent acting on a user request):

1. Run `dnx Runway.Cli workflow built-ins --json` to see the curated 18-command registry. Match against the user's intent first.
2. If nothing matches and the user knows the workflow UUID (or just published it), `dnx Runway.Cli workflow register <uuid> --name <command>` creates a dynamic subcommand named after the slugified workflow title.
3. Only fall back to `dnx Runway.Cli workflow run <uuid> --node-outputs-json '<...>'` as a last-resort escape hatch when neither named built-in nor registered command will do.

Dynamically-registered workflows show up under the **Other / User-registered** category in `workflow built-ins --json` (technically they're not built-ins, but the JSON output of `workflow registered list` carries the same shape with an `Uncategorized` category for routing purposes).
