/*
 * order: 83
 * title: Model Schema — Public Surface and Embedded Spec
 * slug: model-schema-public-surface
 */

// Place the tests in a sibling namespace (not under `Runway.IntegrationTests`) to defeat the
// C# implicit parent-namespace lookup. An external consumer would have to add an explicit
// `using Runway;` to see `RunwayModelSchema`; this file does the same.
namespace Runway.IntegrationTests.Public;

using System.Reflection;
using AwesomeAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runway;

[TestClass]
[TestCategory("Sdk")]
[TestCategory("PublicApi")]
public sealed class RunwayModelSchemaPublicApiTests
{
    //// Drive RunwayModelSchema through the same public surface an external NuGet consumer would
    //// see — no internals, no [InternalsVisibleTo] crutch — to prove the API compiles and behaves
    //// the same for end users as it does for the bundled CLI.

    [TestMethod]
    public void Example_PublicApiIsUsableFromAnExternalConsumer()
    {
        IReadOnlyList<RunwayModelEndpoint> entries = RunwayModelSchema.Lookup("gen4_turbo");
        entries.Should().NotBeEmpty();
        entries.Single().Endpoint.Should().Be("image_to_video");
        entries.Single().RequiredParameters.Should().Contain("promptImage");

        // Multi-endpoint model surfaces both endpoints and per-endpoint required sets.
        var multi = RunwayModelSchema.Lookup("veo3.1_fast");
        multi.Select(e => e.Endpoint).Distinct().Should().BeEquivalentTo(["image_to_video", "text_to_video"]);

        // Validators throw the documented message format.
        Assert.ThrowsExactly<ArgumentException>(static () =>
            RunwayModelSchema.EnsureModelSupportsEndpoint("gpt_image_2", "text_to_video"));

        Assert.ThrowsExactly<ArgumentException>(static () =>
            RunwayModelSchema.EnsureRequiredParametersProvided(
                "gen3a_turbo",
                "image_to_video",
                new Dictionary<string, bool>
                {
                    ["promptText"] = false,
                    ["promptImage"] = true,
                    ["ratio"] = true,
                }));

        // Flag annotation renders the user-facing CLI flag.
        RunwayModelSchema.DescribeRequiredParam("referenceImages").Should().Be("referenceImages (--reference-image)");

        // ArgumentNullException on null providedFlags — public-surface input validation contract.
        Assert.ThrowsExactly<ArgumentNullException>(static () =>
            RunwayModelSchema.EnsureRequiredParametersProvided("gpt_image_2", "text_to_image", null!));
    }

    //// AsTools() now exposes a Runway_GetModelSchema tool and enriches every other tool's
    //// description with spec-derived endpoint + required/optional metadata so an agent picking
    //// between Runway_TextToVideo / Runway_ImageToVideo / Runway_GenerateImage can read the
    //// constraints from the tool schema itself.

    [TestMethod]
    public async Task Example_AsToolsExposesSchemaAwareTools()
    {
        // Use a stub HttpClient — we only inspect tool metadata, never invoke a network call.
        using var client = new RunwayClient(apiKey: "test-key");
        var tools = client.AsTools();

        tools.Should().HaveCount(6);
        tools.Select(t => t.Name).Should().Contain([
            "Runway_ShortVideo",
            "Runway_TextToVideo",
            "Runway_ImageToVideo",
            "Runway_GenerateImage",
            "Runway_GetTask",
            "Runway_GetModelSchema",
        ]);

        var textToVideo = tools.Single(t => t.Name == "Runway_TextToVideo");
        textToVideo.Description.Should().Contain("veo3.1_fast");
        textToVideo.Description.Should().Contain("text_to_video");
        textToVideo.Description.Should().Contain("promptText");
        textToVideo.Description.Should().Contain("Runway_GetModelSchema");

        var imageToVideo = tools.Single(t => t.Name == "Runway_ImageToVideo");
        imageToVideo.Description.Should().Contain("gen4_turbo");
        imageToVideo.Description.Should().Contain("promptImage");

        var getSchema = tools.Single(t => t.Name == "Runway_GetModelSchema");
        var result = await getSchema.InvokeAsync(
            new Microsoft.Extensions.AI.AIFunctionArguments
            {
                ["modelId"] = "gen4_turbo",
            }).ConfigureAwait(false);

        var rendered = result?.ToString() ?? string.Empty;
        rendered.Should().Contain("model: gen4_turbo");
        rendered.Should().Contain("endpoint: image_to_video");
        rendered.Should().Contain("required: promptImage");
    }

    //// Sentinel: the OpenAPI spec is embedded into the SDK assembly as `Runway.openapi.json`.
    //// If a future csproj edit drops the EmbeddedResource entry, this test catches it before
    //// downstream consumers hit a "Embedded resource missing from Runway assembly" runtime error.

    [TestMethod]
    public void Example_OpenApiSpecIsEmbeddedInRunwayAssembly()
    {
        var assembly = typeof(RunwayModelSchema).Assembly;
        var resources = assembly.GetManifestResourceNames();
        resources.Should().Contain("Runway.openapi.json", "the SDK relies on the spec being shipped inside the assembly");

        using var stream = assembly.GetManifestResourceStream("Runway.openapi.json");
        stream.Should().NotBeNull();
        stream!.Length.Should().BeGreaterThan(100_000, "the Runway OpenAPI spec is non-trivial");

        // Extra defense: confirm the runtime parser actually finds at least one model in the spec.
        // If parsing silently fails, KnownModelIds() returns empty and downstream Lookup() never
        // succeeds — so this acts as an integration sentinel for the parser too.
        RunwayModelSchema.KnownModelIds().Should().NotBeEmpty();
    }
}
