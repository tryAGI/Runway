#!/usr/bin/env bash
set -euo pipefail

AUTOSDK_VERSION=0.30.1-dev.1

dotnet tool update --global autosdk.cli --version "$AUTOSDK_VERSION" >/dev/null 2>&1 || \
  dotnet tool install --global autosdk.cli --version "$AUTOSDK_VERSION"
rm -rf Generated
curl -L -o openapi.json https://raw.githubusercontent.com/runwayml/openapi/refs/heads/main/openapi.json
autosdk generate openapi.json \
  --namespace Runway \
  --clientClassName RunwayClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
perl ./normalize-generated-consts.pl Generated
