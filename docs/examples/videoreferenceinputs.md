# VideoReferenceInputs



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var referenced = RunwayTextToVideo.Seedance25(
    promptText: "the hand places the bottle on the lit counter, camera drifts right",
    duration: 5,
    referenceImageUris:
    [
        "https://example.com/bottle.png",
        "https://example.com/counter.png",
    ],
    referenceVideoUris: ["https://example.com/camera-move.mp4"],
    referenceAudioUris: ["https://example.com/room-tone.mp3"]);

using var referencedJson = global::System.Text.Json.JsonDocument.Parse(referenced.ToJson());
var root = referencedJson.RootElement;

// Image references serialize as bare `{ "uri": ... }` objects, while video and audio
// references carry a `type` discriminator.

// `grok_imagine_1_5` lets the prompt address each reference positionally as `[Image 1]`,
// `[Image 2]`, and so on, and sizes output by `resolution` rather than an aspect enum.

var grok = RunwayTextToVideo.GrokImagine15(
    promptText: "[Image 1] walks into the room lit like [Image 2]",
    resolution: CreateTextToVideoRequestGrokImagine15Resolution.x720p,
    referenceImageUris:
    [
        "https://example.com/person.png",
        "https://example.com/lighting-plate.png",
    ]);

using var grokJson = global::System.Text.Json.JsonDocument.Parse(grok.ToJson());

// On `video_to_video`, `aleph2` restyles a clip and can be pinned to timed guidance stills
// via `keyframes` — either at an absolute offset or at a fraction of the clip — and reframed
// with `targetAspectRatio` (which replaces the endpoint's deprecated `ratio`).

var restyle = RunwayVideoToVideo.Aleph2(
    videoUri: "https://example.com/source.mp4",
    promptText: "restyle as a snowy street at night",
    targetAspectRatio: CreateVideoToVideoRequestVariant1TargetAspectRatio.x9_16,
    keyframes:
    [
        RunwayVideoKeyframes.AtSeconds("https://example.com/open.png", 0),
        RunwayVideoKeyframes.AtFraction("https://example.com/close.png", 0.9),
    ]);

using var restyleJson = global::System.Text.Json.JsonDocument.Parse(restyle.ToJson());

// The seedance/hailuo/gemini models on that same endpoint take references instead, and
// `seedance2_5` adds a `mode` that switches between referencing a clip and extending it.
// Note the input field name: this family uses `promptVideo`, not aleph2's `videoUri`.

var extended = RunwayVideoToVideo.Seedance25(
    promptVideoUri: "https://example.com/source.mp4",
    promptText: "continue the move past the counter",
    mode: CreateVideoToVideoRequestSeedance25Mode.Extend,
    referenceImageUris: ["https://example.com/product.png"]);

using var extendedJson = global::System.Text.Json.JsonDocument.Parse(extended.ToJson());

// Which models accept which reference kind is answered by the embedded spec, so an agent or
// a UI can offer only the inputs the chosen model actually supports instead of guessing.

var referenceCapable = RunwayModelSchema.ModelsForEndpoint("text_to_video")
    .Where(model => RunwayModelSchema.SupportsParameter(model, "text_to_video", "references"))
    .ToList();
```