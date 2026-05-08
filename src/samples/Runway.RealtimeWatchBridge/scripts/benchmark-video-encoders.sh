#!/usr/bin/env bash

set -euo pipefail

FFMPEG_BINARY="${FFMPEG_BINARY:-ffmpeg}"
WIDTH="${WIDTH:-160}"
HEIGHT="${HEIGHT:-90}"
FPS="${FPS:-8}"
DURATION_SECONDS="${DURATION_SECONDS:-60}"
BITRATE_KBPS="${BITRATE_KBPS:-180}"
FRAGMENT_MS="${FRAGMENT_MS:-500}"
ENCODERS="${ENCODERS:-h264-software h265-software h264-videotoolbox h265-videotoolbox}"

WORKDIR="$(mktemp -d "${TMPDIR:-/tmp}/runway-encoder-bench.XXXXXX")"
trap 'rm -rf "$WORKDIR"' EXIT

RAW_FILE="$WORKDIR/source.rgba"

build_encoder_args() {
  case "$1" in
    h264-software)
      printf '%s\n' "-c:v libx264 -preset veryfast -tune zerolatency -profile:v baseline -level 3.1 -g ${FPS} -keyint_min ${FPS} -sc_threshold 0"
      ;;
    h265-software)
      printf '%s\n' "-c:v libx265 -preset veryfast -x265-params keyint=${FPS}:min-keyint=${FPS}:scenecut=0:bframes=0:rc-lookahead=0:repeat-headers=1:log-level=error -tag:v hvc1"
      ;;
    h264-videotoolbox)
      printf '%s\n' "-c:v h264_videotoolbox -realtime 1 -prio_speed 1 -power_efficient 1 -g ${FPS} -profile:v baseline -level 3.1"
      ;;
    h265-videotoolbox)
      printf '%s\n' "-c:v hevc_videotoolbox -realtime 1 -prio_speed 1 -power_efficient 1 -g ${FPS} -profile:v main -tag:v hvc1"
      ;;
    *)
      return 1
      ;;
  esac
}

"$FFMPEG_BINARY" \
  -hide_banner \
  -loglevel error \
  -f lavfi \
  -i "testsrc2=size=${WIDTH}x${HEIGHT}:rate=${FPS}" \
  -t "$DURATION_SECONDS" \
  -pix_fmt rgba \
  -f rawvideo \
  "$RAW_FILE"

echo "mode,codec,encoder,width,height,fps,bitrate_kbps,duration_seconds,elapsed_seconds,user_seconds,system_seconds,output_bytes,status"

for mode in $ENCODERS; do
  if ! encoder_args="$(build_encoder_args "$mode" 2>/dev/null)"; then
    echo "$mode,,,${WIDTH},${HEIGHT},${FPS},${BITRATE_KBPS},${DURATION_SECONDS},,,,,unsupported"
    continue
  fi

  codec="${mode%%-*}"
  encoder="${mode#*-}"
  ffmpeg_encoder="$(printf '%s\n' "$encoder_args" | awk 'NR == 1 { print $2 }')"
  if ! "$FFMPEG_BINARY" -hide_banner -encoders 2>/dev/null | grep -q "[[:space:]]${ffmpeg_encoder}[[:space:]]"; then
    echo "$mode,$codec,$encoder,${WIDTH},${HEIGHT},${FPS},${BITRATE_KBPS},${DURATION_SECONDS},,,,,skipped"
    continue
  fi

  output="$WORKDIR/${mode}.mp4"
  stderr="$WORKDIR/${mode}.stderr"

  set +e
  /usr/bin/time -p "$FFMPEG_BINARY" \
    -hide_banner \
    -loglevel error \
    -f rawvideo \
    -pix_fmt rgba \
    -video_size "${WIDTH}x${HEIGHT}" \
    -framerate "$FPS" \
    -i "$RAW_FILE" \
    -an \
    $encoder_args \
    -pix_fmt yuv420p \
    -color_range tv \
    -b:v "${BITRATE_KBPS}k" \
    -f mp4 \
    -movflags empty_moov+default_base_moof+frag_keyframe \
    -frag_duration "$((FRAGMENT_MS * 1000))" \
    -muxdelay 0 \
    -muxpreload 0 \
    -flush_packets 1 \
    "$output" \
    2>"$stderr"
  exit_code=$?
  set -e

  elapsed="$(awk '/^real / { print $2 }' "$stderr" | tail -1)"
  user="$(awk '/^user / { print $2 }' "$stderr" | tail -1)"
  system="$(awk '/^sys / { print $2 }' "$stderr" | tail -1)"
  bytes="0"
  if [ -f "$output" ]; then
    bytes="$(wc -c < "$output" | tr -d ' ')"
  fi

  status="ok"
  if [ "$exit_code" -ne 0 ]; then
    status="failed"
  fi

  echo "$mode,$codec,$encoder,${WIDTH},${HEIGHT},${FPS},${BITRATE_KBPS},${DURATION_SECONDS},${elapsed},${user},${system},${bytes},${status}"
done
