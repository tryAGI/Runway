# Character & Item Generation workflows

Generate fresh assets from a description — multi-view characters with expressions and a 360 turntable, or four rarity-tier item icons + an animated icon clip. These differ from the **Photo Restyle** category because there's no input image required; the workflows synthesize everything from a text description.

<!-- BEGIN:builtins-table -->
| Command | Required | Optional |
| --- | --- | --- |
| `character-creator` | — | `--description`, `--rotation-prompt`, `--catchphrase` |
| `game-item-generator` | — | `--item`, `--motion`, `--variant-instruction` |
<!-- END:builtins-table -->

## Examples

```bash
# Whole character pack: expressions, side / front profiles, 360 turntable, talking head.
dnx Runway.Cli character-creator \
  --description "an old whimsical librarian, watercolor style" \
  --catchphrase "Welcome, traveler. The card catalog awaits." \
  --output ./out

# Four rarity variants of one item description plus an animated icon MP4.
dnx Runway.Cli game-item-generator \
  --item "A jeweled rune-staff with glowing sapphire core, oak handle, HEX #2C5F8D" \
  --motion "subtle levitating loop with gentle sapphire glow" \
  --output ./out
```

## Picking between them

- Player-character / companion / NPC with multiple poses → `character-creator`.
- Game item, weapon, consumable, collectible card → `game-item-generator`.

Both workflows accept the same source pattern (text → multi-output asset pack), so leaving every flag at the authored default still produces a useful demo render.
