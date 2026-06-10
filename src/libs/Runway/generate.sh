#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/runwayml/openapi/refs/heads/next/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/runwayml/openapi/refs/heads/next/openapi.json
autosdk generate openapi.json \
  --namespace Runway \
  --clientClassName RunwayClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

rm -rf ../../cli/Runway.Cli/GeneratedApi
autosdk cli-project openapi.json \
  --output ../../cli/Runway.Cli/GeneratedApi \
  --api-only \
  --sdk-project ../../libs/Runway/Runway.csproj \
  --targetFramework net10.0 \
  --namespace Runway \
  --clientClassName RunwayClient \
  --package-id Runway.Cli \
  --root-namespace Runway.Cli.GeneratedApi \
  --tool-command-name runway \
  --user-secrets-id Runway.Cli \
  --api-key-env-var RUNWAY_API_KEY \
  --api-key-env-var RUNWAYML_API_SECRET \
  --base-url-env-var RUNWAY_BASE_URL \
  --cli-keep-api-group \
  --exclude-deprecated-operations
