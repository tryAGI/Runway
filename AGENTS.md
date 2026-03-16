# AGENTS.md

This file provides guidance to Codex (Codex.ai/code) when working with code in this repository.

## Project Overview

Auto-generated C# SDK for the [Runway ML API](https://docs.dev.runwayml.com/), built with [AutoSDK](https://github.com/HavenDV/AutoSDK) from an OpenAPI specification. Published as the `Runway` NuGet package.

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

# Validate trimming/NativeAOT compatibility
dotnet build src/helpers/TrimmingHelper/TrimmingHelper.csproj
```

## Architecture

**Code generation pipeline:** `openapi.yaml` → AutoSDK (`autosdk.cli`) → `Generated/*.g.cs` files

- `src/libs/Runway/` — Main SDK library (net10.0)
  - `openapi.yaml` — Source OpenAPI specification (~6400 lines)
  - `generate.sh` — Regeneration script
  - `Generated/` — All auto-generated code (41 `.g.cs` files). **Do not edit manually.**
- `src/tests/IntegrationTests/` — MSTest + FluentAssertions integration tests
- `src/helpers/` — Build utilities (FixOpenApiSpec, GenerateDocs, TrimmingHelper)

**Client pattern:** `RunwayClient` (sealed partial class) implements `IRunwayClient`. Extensible via partial methods (`PrepareArguments`, `PrepareRequest`, `ProcessResponse`). Bearer token auth via constructor `apiKey` parameter.

**Test pattern:** Partial `Tests` class split across files (`Tests.cs` base + `Tests.*.cs` per feature). Uses `GetAuthenticatedClient()` which reads `RUNWAY_API_KEY` from environment.

## Key Conventions

- Target framework: `net10.0` single-target
- LangVersion: `preview`, nullable enabled, implicit usings
- AOT/trimming compatible: source-generated JSON serialization, no reflection
- Strong-named assembly (`key.snk`), CLSCompliant
- Versioning: MinVer with `v` tag prefix (e.g., `v7.0.0`)
- CI auto-updates OpenAPI spec every 3 hours via `.github/workflows/auto-update.yml`
