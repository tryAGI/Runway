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
# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}

install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection
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
