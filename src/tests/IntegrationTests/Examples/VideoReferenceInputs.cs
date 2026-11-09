/*
 * order: 84
 * title: Video Reference Inputs - Images, Videos, Audio, Keyframes
 * slug: video-reference-inputs
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Beyond a single prompt image, Runway's newer video models accept *reference inputs*: image
    //// references that fix the subject, product, or style; video references that hand the model a
    //// camera move or motion to reuse; and audio references the output can be driven by. Each model
    //// has its own ceiling — 9 image references for `seedance2`/`hailuo3`, 10 for `wan3`, 7 for
    //// `grok_imagine_1_5`, and 30 for `seedance2_5`. The `RunwayTextToVideo` / `RunwayImageToVideo` /
    //// `RunwayVideoToVideo` factories take them as plain URI strings (HTTPS, `runway://`, or `data:`)
    //// and build the per-model request types for you. This example runs entirely offline — it asserts
    //// on the serialized request bodies and never calls the API.

    [TestMethod]
    public void Example_VideoReferenceInputs()
    {
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

        referenced.IsSeedance25.Should().BeTrue();

        using var referencedJson = global::System.Text.Json.JsonDocument.Parse(referenced.ToJson());
        var root = referencedJson.RootElement;
        root.GetProperty("model").GetString().Should().Be("seedance2_5");

        //// Image references serialize as bare `{ "uri": ... }` objects, while video and audio
        //// references carry a `type` discriminator.

        root.GetProperty("references").GetArrayLength().Should().Be(2);
        root.GetProperty("references")[0].TryGetProperty("type", out _).Should().BeFalse();
        root.GetProperty("referenceVideos")[0].GetProperty("type").GetString().Should().Be("video");
        root.GetProperty("referenceAudio")[0].GetProperty("type").GetString().Should().Be("audio");

        //// `grok_imagine_1_5` lets the prompt address each reference positionally as `[Image 1]`,
        //// `[Image 2]`, and so on, and sizes output by `resolution` rather than an aspect enum.

        var grok = RunwayTextToVideo.GrokImagine15(
            promptText: "[Image 1] walks into the room lit like [Image 2]",
            resolution: CreateTextToVideoRequestGrokImagine15Resolution.x720p,
            referenceImageUris:
            [
                "https://example.com/person.png",
                "https://example.com/lighting-plate.png",
            ]);

        using var grokJson = global::System.Text.Json.JsonDocument.Parse(grok.ToJson());
        grokJson.RootElement.GetProperty("resolution").GetString().Should().Be("720p");
        grokJson.RootElement.GetProperty("references").GetArrayLength().Should().Be(2);

        //// On `video_to_video`, `aleph2` restyles a clip and can be pinned to timed guidance stills
        //// via `keyframes` — either at an absolute offset or at a fraction of the clip — and reframed
        //// with `targetAspectRatio` (which replaces the endpoint's deprecated `ratio`).

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
        restyleJson.RootElement.GetProperty("targetAspectRatio").GetString().Should().Be("9:16");
        restyleJson.RootElement.GetProperty("keyframes")[0].GetProperty("seconds").GetDouble().Should().Be(0);
        restyleJson.RootElement.GetProperty("keyframes")[1].GetProperty("at").GetDouble().Should().Be(0.9);

        //// The seedance/hailuo/gemini models on that same endpoint take references instead, and
        //// `seedance2_5` adds a `mode` that switches between referencing a clip and extending it.
        //// Note the input field name: this family uses `promptVideo`, not aleph2's `videoUri`.

        var extended = RunwayVideoToVideo.Seedance25(
            promptVideoUri: "https://example.com/source.mp4",
            promptText: "continue the move past the counter",
            mode: CreateVideoToVideoRequestSeedance25Mode.Extend,
            referenceImageUris: ["https://example.com/product.png"]);

        using var extendedJson = global::System.Text.Json.JsonDocument.Parse(extended.ToJson());
        extendedJson.RootElement.GetProperty("promptVideo").GetString().Should().Be("https://example.com/source.mp4");
        extendedJson.RootElement.GetProperty("mode").GetString().Should().Be("extend");

        //// Which models accept which reference kind is answered by the embedded spec, so an agent or
        //// a UI can offer only the inputs the chosen model actually supports instead of guessing.

        var referenceCapable = RunwayModelSchema.ModelsForEndpoint("text_to_video")
            .Where(model => RunwayModelSchema.SupportsParameter(model, "text_to_video", "references"))
            .ToList();

        referenceCapable.Should().Contain("seedance2_5").And.Contain("wan3").And.Contain("hailuo3");
        referenceCapable.Should().NotContain("veo3.1_fast", "the veo family takes a negative prompt, not references");

        RunwayModelSchema.SupportsParameter("wan3", "text_to_video", "referenceVideos").Should().BeTrue();
        RunwayModelSchema.SupportsParameter("aleph2", "video_to_video", "keyframes").Should().BeTrue();
        RunwayModelSchema.DescribeRequiredParam("referenceVideos").Should().Be("referenceVideos (--reference-video)");
    }
}
