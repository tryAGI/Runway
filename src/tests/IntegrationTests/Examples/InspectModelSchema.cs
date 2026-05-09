/*
 * order: 82
 * title: Models Schema Auto-Derived from OpenAPI
 * slug: models-schema-auto-derived
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// `runway models schema <model>` reads the embedded Runway OpenAPI spec at runtime
    //// and emits the actual list of endpoints + request parameters that accept that model id.
    //// New Runway models added to the auto-updated spec become discoverable without any code change.

    [TestMethod]
    public void Example_ModelSchemaAutoDerivedFromOpenApi()
    {
        var imageToVideo = RunwayCliModelSchema.Lookup("gen4_turbo");
        imageToVideo.Should().NotBeEmpty();
        imageToVideo.Should().Contain(e => e.Endpoint == "image_to_video");
        imageToVideo.Single().Parameters.Should().Contain("promptImage");
        imageToVideo.Single().RequiredParameters.Should().Contain("promptImage");
        imageToVideo.Single().RequiredParameters.Should().NotContain("model");
        imageToVideo.Single().OptionalParameters.Should().Contain("seed");

        var multiEndpoint = RunwayCliModelSchema.Lookup("veo3.1_fast");
        multiEndpoint.Select(e => e.Endpoint).Distinct().Should().BeEquivalentTo(["image_to_video", "text_to_video"]);
        multiEndpoint.First(e => e.Endpoint == "text_to_video").RequiredParameters.Should().Contain(["promptText", "ratio"]);
        multiEndpoint.First(e => e.Endpoint == "image_to_video").RequiredParameters.Should().Contain(["promptImage", "ratio"]);
        multiEndpoint.First(e => e.Endpoint == "text_to_video").OptionalParameters.Should().Contain("audio");

        var gptImage = RunwayCliModelSchema.Lookup("gpt_image_2");
        gptImage.Single().Parameters.Should().Contain(["referenceImages", "quality"]);
        gptImage.Single().RequiredParameters.Should().Contain(["promptText", "ratio"]);
        gptImage.Single().OptionalParameters.Should().Contain(["quality", "background"]);

        var withDash = RunwayCliModelSchema.Lookup("gen4-turbo");
        withDash.Should().BeEquivalentTo(imageToVideo);

        var unknown = RunwayCliModelSchema.Lookup("definitely_not_a_runway_model");
        unknown.Should().BeEmpty();

        var known = RunwayCliModelSchema.KnownModelIds().ToList();
        known.Should().Contain("gen4_turbo");
        known.Should().Contain("gpt_image_2");
        known.Should().Contain("veo3.1_fast");

        // EnsureModelSupportsEndpoint catches mismatches against the spec.
        var rejection = Action(() => RunwayCliModelSchema.EnsureModelSupportsEndpoint("gpt_image_2", "text_to_video"));
        rejection.Should().Throw<ArgumentException>().WithMessage("*not supported by `text_to_video`*");

        // Correct pairing passes silently.
        Action(() => RunwayCliModelSchema.EnsureModelSupportsEndpoint("gpt_image_2", "text_to_image"))
            .Should().NotThrow();

        // Unknown models are allowed through (so brand-new spec entries work without a CLI release).
        Action(() => RunwayCliModelSchema.EnsureModelSupportsEndpoint("future_model_id", "text_to_image"))
            .Should().NotThrow();

        // EnsureRequiredParametersProvided complains when a spec-required param is marked missing.
        var missingPromptImage = Action(() => RunwayCliModelSchema.EnsureRequiredParametersProvided(
            "gen3a_turbo",
            "image_to_video",
            new Dictionary<string, bool>
            {
                ["promptText"] = true,
                ["promptImage"] = false,
                ["ratio"] = true,
            }));
        missingPromptImage.Should().Throw<ArgumentException>().WithMessage("*requires promptImage*");

        // Spec param the caller didn't list is not enforced (CLI doesn't track every flag).
        Action(() => RunwayCliModelSchema.EnsureRequiredParametersProvided(
            "gen4_image_turbo",
            "text_to_image",
            new Dictionary<string, bool>
            {
                ["promptText"] = true,
                // ratio + referenceImages omitted -> not enforced
            }))
            .Should().NotThrow();

        // All required flags satisfied -> passes silently.
        Action(() => RunwayCliModelSchema.EnsureRequiredParametersProvided(
            "veo3.1_fast",
            "text_to_video",
            new Dictionary<string, bool>
            {
                ["promptText"] = true,
                ["ratio"] = true,
            }))
            .Should().NotThrow();

        // Unknown model -> passes silently (brand-new spec entries don't break the CLI).
        Action(() => RunwayCliModelSchema.EnsureRequiredParametersProvided(
            "future_unknown_model",
            "text_to_image",
            new Dictionary<string, bool>()))
            .Should().NotThrow();

        static Action Action(Action action) => action;
    }
}
