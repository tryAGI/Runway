#!/usr/bin/env python3
"""Keep announced Runway Dev models available until upstream OpenAPI catches up.

Everything this script used to add — the `enhance_frame_rate` upscale variant, the ACEScg EXR
delivery formats and the NTSC frame rates — is in the upstream spec now, so only the newest models
are left here.

These four shipped on 2026-11-05 and are documented on Runway's model index and API changelog, but
are not in https://github.com/runwayml/openapi yet. Each is cloned from its nearest sibling in the
spec, so no field is invented; only the limits the changelog states for the new model are changed.
Drop an entry once upstream carries it — the script asserts the sibling still exists, so a stale
entry fails loudly instead of silently generating nothing.
"""

import copy
import json
import sys
from pathlib import Path


VIDEO_PATHS = ["/v1/image_to_video", "/v1/text_to_video", "/v1/video_to_video"]


def kling_4_flash(variant):
    """Kling 4.0 Flash: 720p only, 3-20 seconds, default 5.

    Only the endpoints that generate a new clip carry `duration`; the video-to-video variant edits
    the source and has none, so each field is adjusted only where the sibling has it.
    """
    properties = variant["properties"]
    if "ratio" in properties:
        properties["ratio"]["enum"] = ["auto_720p"]
    if "duration" in properties:
        properties["duration"].update({
            "description": "The duration of the output video in seconds. Defaults to 5.",
            "maximum": 20,
            "default": 5,
        })
    return variant


def gemini_omni_flash_1_2(variant):
    """Gemini Omni 1.2 Flash: 3-15 seconds, where 1.1 allows 3-10."""
    duration = variant["properties"].get("duration")
    if duration is None:
        return variant
    for option in duration["anyOf"]:
        if option.get("type") == "integer":
            option["maximum"] = 15
    duration["description"] = duration["description"].replace("between 3 and 10 seconds", "between 3 and 15 seconds")
    return variant


def gpt_image_2_6(variant):
    """GPT Image 2.6: quality and reasoningEffort both take low, medium or high."""
    properties = variant["properties"]
    properties["quality"]["enum"] = ["low", "medium", "high"]
    properties["quality"]["default"] = "high"
    properties["reasoningEffort"] = {
        "description": "How much reasoning the model spends on the image. Defaults to `high`.",
        "type": "string",
        "enum": ["low", "medium", "high"],
        "default": "high",
    }
    return variant


# (endpoint paths, new model id, sibling model id to clone, what the changelog says differs)
ADDITIONS = [
    (VIDEO_PATHS, "kling_4_flash", "kling_4", kling_4_flash),
    (VIDEO_PATHS, "gemini_omni_flash_1.2", "gemini_omni_flash_1.1", gemini_omni_flash_1_2),
    (["/v1/text_to_image"], "gpt_image_2_6_flare", "gpt_image_2_5_flare", gpt_image_2_6),
    (["/v1/text_to_image"], "gpt_image_2_6_sunburst", "gpt_image_2_5_sunburst", gpt_image_2_6),
]


def title_single_variant(source, path):
    """Give a lone oneOf variant the title every other endpoint's variants carry.

    Upstream titles each variant with its model id, which is what makes the generated type
    `...RequestKling4` rather than `...RequestVariant1`. /v1/realtime_sessions is the one endpoint
    that forgot, and it has a single variant, so the generated C# name was `Variant1`. Naming it
    after its own `model` const follows the convention the rest of the spec already sets.
    """
    document = json.loads(source)
    variants = request_variants(document, path)
    if len(variants) != 1 or variants[0].get("title"):
        return source
    model_id = variants[0]["properties"]["model"]["const"]
    endpoint = source.index(json.dumps(path) + ":")
    array_start = source.index("[", source.index('"oneOf": [', endpoint))
    brace = source.index("{", array_start)
    return source[: brace + 1] + f'\n{" " * 18}"title": {json.dumps(model_id)},' + source[brace + 1 :]


def request_variants(document, path):
    schema = document["paths"][path]["post"]["requestBody"]["content"]["application/json"]["schema"]
    return schema["oneOf"]


def find_variant(document, path, model_id):
    for variant in request_variants(document, path):
        if variant.get("properties", {}).get("model", {}).get("const") == model_id:
            return variant
    return None


def insert_variant(source, path, variant):
    """Append one variant to an endpoint's oneOf without reformatting the rest of the spec."""
    endpoint = source.index(json.dumps(path) + ":")
    array_start = source.index("[", source.index('"oneOf": [', endpoint))
    _, end = json.JSONDecoder().raw_decode(source[array_start:])
    array_end = array_start + end - 1
    fragment = json.dumps(variant, indent=2, ensure_ascii=False)
    fragment = "\n".join("                  " + line for line in fragment.splitlines())
    return source[:array_end].rstrip() + ",\n" + fragment + "\n                " + source[array_end:]


def patch(path):
    source = path.read_text()
    for paths, model_id, sibling_id, adjust in ADDITIONS:
        for endpoint in paths:
            document = json.loads(source)
            if find_variant(document, endpoint, model_id) is not None:
                continue  # upstream has caught up with this one
            sibling = find_variant(document, endpoint, sibling_id)
            if sibling is None:
                raise SystemExit(
                    f"error: {endpoint} has no '{sibling_id}' to clone '{model_id}' from. "
                    f"The spec changed shape; review this addition instead of guessing."
                )
            variant = adjust(copy.deepcopy(sibling))
            variant["title"] = model_id
            variant["properties"]["model"] = {"type": "string", "const": model_id}
            source = insert_variant(source, endpoint, variant)

    source = title_single_variant(source, "/v1/realtime_sessions")

    document = json.loads(source)  # fails loudly if an insert produced invalid JSON
    for paths, model_id, _, _ in ADDITIONS:
        for endpoint in paths:
            assert find_variant(document, endpoint, model_id) is not None, f"{model_id} missing from {endpoint}"
    if source != path.read_text():
        path.write_text(source)


if __name__ == "__main__":
    patch(Path(sys.argv[1]))
