#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
  dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/runwayml/openapi/refs/heads/main/openapi.json
autosdk generate openapi.json \
  --namespace Runway \
  --clientClassName RunwayClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
