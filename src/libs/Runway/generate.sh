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
# --reject-unknown-enum-values below is only safe once AutoSDK narrows it to enums that cannot appear
# in a response. An older autosdk.cli accepts the flag and hardens every enum, including task status
# and the model ids the account returns, which would throw on ordinary replies. The flag's own help
# text is the marker for the narrowing; if that wording changes, update this check. Failing here is
# the safe outcome — regenerating with the wrong behaviour is not.
require_direction_aware_enum_rejection() {
  if ! autosdk generate --help 2>&1 | grep -q 'request-reachable enums only'; then
    echo "error: autosdk.cli does not narrow --reject-unknown-enum-values to request-reachable enums." >&2
    echo "       Update it (dotnet tool update --global autosdk.cli --prerelease); needs AutoSDK 7491138523 or later." >&2
    exit 1
  fi
}

install_autosdk_cli
require_direction_aware_enum_rejection
fetch_spec --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/runwayml/openapi/refs/heads/next/openapi.json
python3 patch_openapi.py openapi.json
rm -rf Generated
# --reject-unknown-enum-values: this SDK's CLI passes user input straight into enum-typed options, so a
# typo must fail instead of silently becoming the alphabetically first member. AutoSDK applies it only
# to enums that cannot arrive in a response, so a model id or status Runway ships ahead of the spec
# still deserializes. Needs autosdk.cli with that narrowing (AutoSDK 7491138523 or later).
autosdk generate openapi.json \
  --namespace Runway \
  --clientClassName RunwayClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
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
