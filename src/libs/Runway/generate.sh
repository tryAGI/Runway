#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/runwayml/openapi/refs/heads/next/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/runwayml/openapi/refs/heads/next/openapi.json
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
