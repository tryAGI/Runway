#!/usr/bin/env bash
# Fails when generate.sh fetches the spec from anything but the upstream repository's default branch.
#
# Why this exists: the spec was fetched from `runwayml/openapi`'s `next` branch, which upstream froze
# while publishing to `main`. Nothing noticed. auto-update ran every three hours, fetched the frozen
# file, saw no change and opened no PR, so the SDK sat 29 models and a whole endpoint behind for weeks
# while looking perfectly up to date. A branch that stops moving is indistinguishable from a spec that
# has not changed -- unless something checks which branch it is.
set -euo pipefail

generate_script="${1:-src/libs/Runway/generate.sh}"

url=$(grep -oE 'https://raw\.githubusercontent\.com/[^"]+/openapi\.json' "$generate_script" | sort -u)
if [ "$(printf '%s\n' "$url" | grep -c .)" -ne 1 ]; then
  echo "error: expected exactly one spec URL in $generate_script, found:" >&2
  printf '%s\n' "$url" >&2
  exit 1
fi

# https://raw.githubusercontent.com/<owner>/<repo>/refs/heads/<branch>/openapi.json
rest=${url#https://raw.githubusercontent.com/}
owner=$(printf '%s' "$rest" | cut -d/ -f1)
repo=$(printf '%s' "$rest" | cut -d/ -f2)
branch=$(printf '%s' "$rest" | cut -d/ -f5)
if [ -z "$owner" ] || [ -z "$repo" ] || [ -z "$branch" ]; then
  echo "error: could not read owner/repo/branch out of $url" >&2
  exit 1
fi

# An empty array expands as an unbound variable under `set -u` on bash 3.2, which is what macOS ships,
# so the expansion below guards it rather than relying on "${auth[@]}" alone.
auth=()
if [ -n "${GITHUB_TOKEN:-}" ]; then
  auth=(--header "Authorization: Bearer ${GITHUB_TOKEN}")
fi
default_branch=$(curl --fail --silent --show-error --location --retry 3 --retry-all-errors \
  --header "Accept: application/vnd.github+json" ${auth[@]+"${auth[@]}"} \
  "https://api.github.com/repos/${owner}/${repo}" | python3 -c 'import json,sys; print(json.load(sys.stdin)["default_branch"])')

if [ "$branch" != "$default_branch" ]; then
  echo "error: $generate_script fetches the spec from '${owner}/${repo}@${branch}', but that repository's" >&2
  echo "       default branch is '${default_branch}'. A non-default branch can be frozen without any sign:" >&2
  echo "       auto-update keeps fetching it, sees no change, and the SDK silently falls behind." >&2
  echo "       Point the fetch at '${default_branch}', or state here why this branch is the right one." >&2
  exit 1
fi

echo "ok: spec is fetched from ${owner}/${repo}@${branch}, the repository's default branch"
