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
# and the model ids the account returns, which would throw on ordinary replies.
#
# The floor is measured rather than guessed: 0.35.0-preview.2.170 is the newest published version whose
# `generate --help` does not describe the narrowing, and AutoSDK's main is linear with a monotonic
# MinVer height, so anything above it contains the fix. 0.35.0-preview.2.170 reports itself as built
# from 4e5f2e105c, the commit immediately before the narrowing landed, which pins the floor exactly. The help-text probe is kept as a backstop in
# case a build ever lands out of order. Failing here is the safe outcome; regenerating with the wrong
# behaviour is not.
AUTOSDK_MIN_VERSION="0.35.0-preview.2.171"

compare_autosdk_version() {
  python3 - "$1" "$2" <<'PYVER'
import re, sys

def key(text):
    match = re.fullmatch(r"(\d+)\.(\d+)\.(\d+)(?:-preview\.(\d+)\.(\d+))?", text.strip())
    if match is None:
        raise SystemExit(2)
    major, minor, patch, series, height = match.groups()
    # A stable release outranks any preview of the same version.
    return (int(major), int(minor), int(patch), 1 if series is None else 0,
            int(series or 0), int(height or 0))

sys.exit(0 if key(sys.argv[1]) >= key(sys.argv[2]) else 1)
PYVER
}

require_direction_aware_enum_rejection() {
  # `autosdk --version` is the source rather than `dotnet tool list --global`, which aborts outright on
  # this machine ("'adv' is not a valid version string") because one unrelated global tool breaks the
  # whole listing. The reported version also carries the build's commit, e.g.
  # 0.35.0-preview.2.170+4e5f2e105c..., which is how the floor below was confirmed; strip that suffix.
  local installed
  installed=$(autosdk --version 2>/dev/null | head -n 1 | cut -d+ -f1)

  # Fail closed: a missing or unparseable version stops the regeneration rather than assuming the best.
  if ! compare_autosdk_version "$installed" "$AUTOSDK_MIN_VERSION"; then
    echo "error: autosdk.cli ${installed:-<not installed>} does not meet the required $AUTOSDK_MIN_VERSION," >&2
    echo "       the first version that narrows --reject-unknown-enum-values to request-reachable enums." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi

  if ! autosdk generate --help 2>&1 | grep -q 'request-reachable enums only'; then
    echo "error: autosdk.cli $installed satisfies the version floor but does not describe the narrowing" >&2
    echo "       of --reject-unknown-enum-values. Refusing to harden response enums." >&2
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
