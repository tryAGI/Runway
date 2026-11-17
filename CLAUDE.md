# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Auto-generated C# SDK for the [Runway ML API](https://docs.dev.runwayml.com/), built with [AutoSDK](https://github.com/tryAGI/AutoSDK) from an OpenAPI specification. Published as the `Runway` NuGet package.

**Supported APIs:** Image-to-video, text-to-video, video-to-video, text-to-image, image and video upscaling, video-to-HDR, video-to-audio, character performance, text-to-speech and speech-to-speech, sound effects, voice dubbing and isolation, avatars and realtime sessions, workflows, and task management.

Which models each endpoint accepts comes from the spec, so this file deliberately names none: a model list written here goes stale on the next regeneration. Ask the SDK instead — `RunwayModelSchema.KnownEndpoints()` and `RunwayModelSchema.IsKnown(id)`, or `runway models --account` to compare the spec against what the account can actually call.

## Build & Test Commands

```bash
# Build
dotnet build Runway.slnx

# Run all tests (requires RUNWAY_API_KEY env var)
dotnet test src/tests/IntegrationTests

# The three built-in-workflow examples (AI Hair Salon) each run a published Runway graph that fans out
# into several image generations — roughly 90 credits per test, ~270 for the set. They report
# inconclusive unless you opt in:
RUNWAY_RUN_BILLABLE_EXAMPLES=1 dotnet test src/tests/IntegrationTests

# Run a single test
dotnet test src/tests/IntegrationTests --filter "CreateImageToVideo"

# Regenerate SDK from OpenAPI spec.
# generate.sh refuses to run unless the installed autosdk.cli reports
# `behavior:request-scoped-enum-rejection` from `autosdk capabilities`. An older CLI accepts
# --reject-unknown-enum-values but also hardens response enums, which would throw on ordinary replies
# carrying a model id newer than the spec. Asking the build what it does replaces the version floor this
# used to carry; a CLI with no `capabilities` subcommand fails the check, so it is fail-closed.
cd src/libs/Runway && chmod +x ./generate.sh && ./generate.sh

# Validate trimming/NativeAOT compatibility (requires: dotnet tool install -g autosdk.cli --prerelease)
autosdk trim src/libs/*//*.csproj
```

## Architecture

**Code generation pipeline:** `openapi.json` → AutoSDK (`autosdk.cli`) → `Generated/*.g.cs` files

The spec is fetched from `runwayml/openapi`'s **default branch**. It used to come from that repository's
`next` branch, which upstream froze while publishing elsewhere; auto-update kept fetching the frozen file,
saw no change, opened no PR, and the SDK sat 29 models and a whole endpoint behind while looking current.
`scripts/check-spec-source.sh` now fails CI if the fetch points anywhere but the default branch.

`patch_openapi.py` adds models Runway has announced and documented but not yet published in its spec.
Each is cloned from a sibling already in the spec, so no field is invented, and the script fails loudly if
that sibling disappears. Delete an entry once upstream ships it.

- `src/libs/Runway/` — Main SDK library (net10.0)
  - `openapi.json` — Source OpenAPI specification
  - `generate.sh` — Regeneration script
  - `Generated/` — All auto-generated code (41 `.g.cs` files). **Do not edit manually.**
- `src/tests/IntegrationTests/` — MSTest + AwesomeAssertions integration tests
- `src/helpers/` — Build utilities ()

**Client pattern:** `RunwayClient` (sealed partial class) implements `IRunwayClient`. Extensible via partial methods (`PrepareArguments`, `PrepareRequest`, `ProcessResponse`). Bearer token auth via constructor `apiKey` parameter.

**Test pattern:** Partial `Tests` class split across files (`Tests.cs` base + `Tests.*.cs` per feature). Uses `GetAuthenticatedClient()` which reads `RUNWAY_API_KEY` from environment.

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`

## Key Conventions

- Target framework: `net10.0` single-target
- LangVersion: `preview`, nullable enabled, implicit usings
- AOT/trimming compatible: source-generated JSON serialization, no reflection
- Strong-named assembly (`key.snk`), CLSCompliant
- Versioning: MinVer with `v` tag prefix (e.g., `v7.0.0`)
- CI auto-updates OpenAPI spec every 3 hours via `.github/workflows/auto-update.yml`
