# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Auto-generated C# SDK for the [Runway ML API](https://docs.dev.runwayml.com/), built with [AutoSDK](https://github.com/tryAGI/AutoSDK) from an OpenAPI specification. Published as the `Runway` NuGet package.

**Supported APIs:** Image-to-video (Gen3a Turbo, Gen4 Turbo), text-to-video (Veo 3.1 Fast), text-to-image (Gen4 Image Turbo), text-to-speech (ElevenLabs Multilingual V2 with 48 preset voices), sound effects generation, voice dubbing (multi-language with voice cloning), and task management.

## Build & Test Commands

```bash
# Build
dotnet build Runway.slnx

# Run all tests (requires RUNWAY_API_KEY env var)
dotnet test src/tests/IntegrationTests

# Run a single test
dotnet test src/tests/IntegrationTests --filter "CreateImageToVideo"

# Regenerate SDK from OpenAPI spec
cd src/libs/Runway && chmod +x ./generate.sh && ./generate.sh

# Validate trimming/NativeAOT compatibility (requires: dotnet tool install -g autosdk.cli --prerelease)
autosdk trim src/libs/*//*.csproj
```

## Architecture

**Code generation pipeline:** `openapi.json` → AutoSDK (`autosdk.cli`) → `Generated/*.g.cs` files

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
