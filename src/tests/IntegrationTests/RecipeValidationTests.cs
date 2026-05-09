namespace Runway.IntegrationTests;

[TestClass]
[TestCategory("Cli")]
[TestCategory("RecipeValidation")]
public sealed class RecipeValidationTests
{
    //// Recipe-path tests live in their own file (separate class) and use the shared
    //// `CliHarness.RunCliAsync` instead of growing inside `RunwayCliTests.cs`. They prove that
    //// `EnsureRequiredParametersProvided` runs upfront for every recipe command and that
    //// `--soul-id` merging satisfies `referenceImages`-required models like `gen4_image_turbo`.

    [TestMethod]
    public async Task RecipeRejectsModelMissingRequiredImages()
    {
        // gen4_image_turbo requires referenceImages per the spec; product-photoshoot without
        // --image / --soul-id should be rejected upfront, even with --plan-only (which would
        // otherwise short-circuit before any API call).
        var result = await CliHarness.RunCliAsync(
            "product-photoshoot create --prompt=tiny-camera --mode product_shot --model gen4_image_turbo --plan-only",
            removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Model `gen4_image_turbo` on `text_to_image` requires");
        result.Stderr.Should().Contain("referenceImages (--reference-image)");
        result.Stderr.Should().Contain("runway models schema gen4_image_turbo");
    }

    [TestMethod]
    public async Task RecipeAcceptsSoulIdAsReferenceImages()
    {
        // --soul-id merges registered photos into plan.ReferenceImages, which satisfies
        // gen4_image_turbo's required `referenceImages` field. The recipe should accept the
        // pairing even though the user didn't pass --image directly.
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-soulid-recipe-{Guid.NewGuid():N}");
        Directory.CreateDirectory(sandbox);
        try
        {
            var photos = new List<string>(5);
            for (var i = 1; i <= 5; i++)
            {
                var path = Path.Combine(sandbox, $"photo{i}.jpg");
                File.WriteAllBytes(path, [(byte)i, 0x10, 0x20, 0x30]);
                photos.Add(path);
            }

            var env = new Dictionary<string, string?> { ["RUNWAY_CLI_HOME"] = sandbox };

            var imageArgs = string.Join(' ', photos.Select(p => $"--image {p}"));
            var create = await CliHarness.RunCliAsync(
                $"soul-id create --name alice {imageArgs}",
                removeApiKey: true,
                environment: env).ConfigureAwait(false);

            create.ExitCode.Should().Be(0);
            using var doc = System.Text.Json.JsonDocument.Parse(create.Stdout);
            var soulId = doc.RootElement.GetProperty("id").GetString();
            soulId.Should().NotBeNullOrEmpty();

            var recipe = await CliHarness.RunCliAsync(
                $"product-photoshoot create --prompt tiny-camera --mode product_shot --model gen4_image_turbo --soul-id {soulId} --plan-only",
                removeApiKey: true,
                environment: env).ConfigureAwait(false);

            recipe.ExitCode.Should().Be(0);
            recipe.Stdout.Should().Contain("\"model\": \"gen4_image_turbo\"");
            recipe.Stdout.Should().Contain($"soul-ids/{soulId}");
        }
        finally
        {
            if (Directory.Exists(sandbox))
            {
                Directory.Delete(sandbox, recursive: true);
            }
        }
    }
}
