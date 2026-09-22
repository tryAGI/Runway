#!/usr/bin/env python3
"""Keep announced Runway Dev video features available until upstream OpenAPI catches up."""

import json
import sys
from pathlib import Path


FRAME_RATES = ["24", "25", "30", "48", "50", "60", "120", "23_98", "29_97", "59_94"]
ACES_FORMATS = ["hdr_exr_acescg_sequence_1_3", "hdr_exr_acescg_sequence_2_0"]


def request_variants(document, path):
    return document["paths"][path]["post"]["requestBody"]["content"]["application/json"]["schema"]["oneOf"]


def replace_array(source, path, property_name, value, replacement):
    """Replace one JSON array within a particular endpoint without reformatting the spec."""
    endpoint = source.index(json.dumps(path) + ":")
    property_start = source.index(json.dumps(property_name) + ":", endpoint)
    array_start = source.index("[", source.index(json.dumps(value) + ":", property_start))
    old_value, end = json.JSONDecoder().raw_decode(source[array_start:])
    if not isinstance(old_value, list):
        raise ValueError(f"Expected an array at {path} {property_name} {value}")
    return source[:array_start] + replacement + source[array_start + end :]


def patch(path):
    source = path.read_text()
    document = json.loads(source)
    upscale_path = "/v1/video_upscale"
    upscale_variants = request_variants(document, upscale_path)
    existing = next((variant for variant in upscale_variants if variant["properties"]["model"]["const"] == "enhance_frame_rate"), None)
    if existing is None:
        video_uri = upscale_variants[0]["properties"]["videoUri"]
        variant = {
            "title": "enhance_frame_rate",
            "type": "object",
            "properties": {
                "videoUri": {
                    **video_uri,
                    "description": "Input video to interpolate. Maximum duration is 300 seconds; output keeps the source resolution up to 4K.",
                },
                "targetFramerate": {
                    "description": "Target frames per second. NTSC rates use underscored values (23_98, 29_97, 59_94).",
                    "type": "string",
                    "enum": FRAME_RATES,
                },
                "model": {"type": "string", "const": "enhance_frame_rate"},
            },
            "required": ["videoUri", "targetFramerate", "model"],
            "additionalProperties": False,
        }
        endpoint = source.index(json.dumps(upscale_path) + ":")
        one_of = source.index('"oneOf": [', endpoint)
        array_start = source.index("[", one_of)
        _, end = json.JSONDecoder().raw_decode(source[array_start:])
        array_end = array_start + end - 1
        fragment = json.dumps(variant, indent=2, ensure_ascii=False)
        fragment = "\n".join("                  " + line for line in fragment.splitlines())
        source = source[:array_end].rstrip() + ",\n" + fragment + "\n                " + source[array_end:]
    else:
        assert set(existing["required"]) >= {"videoUri", "targetFramerate", "model"}
        assert set(existing["properties"]["targetFramerate"]["enum"]) >= set(FRAME_RATES)

    document = json.loads(source)
    ruby = request_variants(document, "/v1/video_to_hdr")[0]
    formats = ruby["properties"]["outputFormat"]["enum"]
    missing = [value for value in ACES_FORMATS if value not in formats]
    if missing:
        updated = formats + missing
        array_text = "[\n" + ",\n".join("                          " + json.dumps(value) for value in updated) + "\n                        ]"
        source = replace_array(source, "/v1/video_to_hdr", "outputFormat", "enum", array_text)

    old_description = ruby["properties"]["outputFormat"]["description"]
    if "All four profiles bill" in old_description:
        new_description = (
            "HDR delivery format. `hdr10` (default) and `hlg` deliver 10-bit HEVC without alpha. "
            "`hdr_prores` delivers BT.2020 + PQ ProRes and preserves source alpha as 4444. "
            "`hdr_exr_sequence` delivers linear BT.2020 EXR; "
            "`hdr_exr_acescg_sequence_1_3` and `hdr_exr_acescg_sequence_2_0` deliver scene-referred ACEScg EXR. "
            "EXR sequences preserve source alpha in the A channel and include colorimetry and provenance sidecars, "
            "plus source audio when present. All formats cost 20 credits per second, or 40 above 4 megapixels."
        )
        source = source.replace(json.dumps(old_description, ensure_ascii=False), json.dumps(new_description, ensure_ascii=False), 1)

    # Alpha is detected from the input. Only EXR and HDR ProRes can retain it.
    original_video_description = "The SDR input video to upconvert. Must be 30 seconds or shorter."
    if ruby["properties"]["videoUri"]["description"] == original_video_description:
        source = source.replace(
            json.dumps(original_video_description),
            json.dumps(original_video_description + " Alpha in ProRes 4444, WebM, and RGBA sources is detected automatically."),
            1,
        )
    source = source.replace(
        "The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`.",
        "The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`; sources with alpha are delivered as `4444` regardless of this value.",
        1,
    )
    assert json.loads(source)
    if source != path.read_text():
        path.write_text(source)


if __name__ == "__main__":
    patch(Path(sys.argv[1]))
