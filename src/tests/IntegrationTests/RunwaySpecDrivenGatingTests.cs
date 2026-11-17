using System.Text.Json;
using System.Text.Json.Nodes;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// Offline coverage for the spec-driven parts of the CLI and SDK: the image surface's model and
/// parameter gating, short-video reference inputs, the ratio matrix, and base-URL resolution.
/// No API key or network access required.
/// </summary>
[TestClass]
public sealed class RunwaySpecDrivenGatingTests
{
    private const string ImageUri = "https://example.com/reference.jpg";

    private static Task<JsonObject> BuildImageBodyAsync(
        string model,
        string ratio,
        string[]? referenceImages = null,
        string referenceSubject = "object",
        int? seed = null,
        string? quality = null,
        RunwayCliImageExtras? extras = null) =>
        RunwayCliGeneration.CreateTextToImageJsonBodyAsync(
            prompt: "a clean product poster",
            model: model,
            ratio: ratio,
            referenceImages: referenceImages,
            referenceSubject: referenceSubject,
            seed: seed,
            outputCount: null,
            publicFigureThreshold: null,
            resolution: null,
            quality: quality,
            extras: extras,
            cancellationToken: CancellationToken.None);

    [TestMethod]
    public void TextToImage_ModelListComesFromTheSpec()
    {
        var models = RunwayModelSchema.ModelsForEndpoint("text_to_image");
        models.Should()
            .Contain("muse_image").And.Contain("seedream5_pro").And.Contain("seedream5_lite")
            .And.Contain("grok_imagine_image_2").And.Contain("gemini_image3.1_flash");

        // Aliases resolve to the spec's wire ids.
        RunwayCliGeneration.NormalizeTextToImageModel("seedream5-pro").Should().Be("seedream5_pro");
        RunwayCliGeneration.NormalizeTextToImageModel("muse-image").Should().Be("muse_image");
        RunwayCliGeneration.NormalizeTextToImageModel("grok-imagine-image-2").Should().Be("grok_imagine_image_2");
        RunwayCliGeneration.NormalizeTextToImageModel(null).Should().Be("gemini_2.5_flash");

        // A video model on the image endpoint is rejected with the endpoint named.
        var act = () => RunwayCliGeneration.NormalizeTextToImageModel("veo3.1_fast");
        act.Should().Throw<ArgumentException>().WithMessage("*for text_to_image*");
    }

    [TestMethod]
    public async Task TextToImage_ReferenceItemShapeFollowsTheModel()
    {
        // muse_image items accept `uri` only — a `tag` would be rejected by its additionalProperties:false schema.
        var muse = await BuildImageBodyAsync("muse-image", "1600:1600", [ImageUri]);
        var museReference = muse["referenceImages"]!.AsArray()[0]!.AsObject();
        museReference.Should().ContainKey("uri");
        museReference.Should().NotContainKey("tag");
        museReference.Should().NotContainKey("subject");

        // The gemini pair accepts both a tag and a subject.
        var gemini = await BuildImageBodyAsync("gemini-image3-pro", "1024:1024", [ImageUri], referenceSubject: "human");
        var geminiReference = gemini["referenceImages"]!.AsArray()[0]!.AsObject();
        geminiReference["tag"]!.GetValue<string>().Should().Be("reference1");
        geminiReference["subject"]!.GetValue<string>().Should().Be("human");

        // gpt_image_2 takes a tag but no subject.
        var gpt = await BuildImageBodyAsync("gpt-image-2", "1920:1920", [ImageUri], referenceSubject: "human");
        var gptReference = gpt["referenceImages"]!.AsArray()[0]!.AsObject();
        gptReference.Should().ContainKey("tag");
        gptReference.Should().NotContainKey("subject");
    }

    [TestMethod]
    public async Task TextToImage_ReferenceImageCapComesFromTheSpec()
    {
        RunwayModelSchema.GetMaxItems("gpt_image_2", "text_to_image", "referenceImages").Should().Be(16);
        RunwayModelSchema.GetMaxItems("gemini_image3_pro", "text_to_image", "referenceImages").Should().Be(14);
        RunwayModelSchema.GetMaxItems("grok_imagine_image_2", "text_to_image", "referenceImages").Should().Be(3);

        // Four references are fine for gpt_image_2 (cap 16) but too many for grok (cap 3).
        var gpt = await BuildImageBodyAsync("gpt-image-2", "1920:1920", [ImageUri, ImageUri, ImageUri, ImageUri]);
        gpt["referenceImages"]!.AsArray().Count.Should().Be(4);

        var act = async () => await BuildImageBodyAsync("grok-imagine-image-2", "1024:1024", [ImageUri, ImageUri, ImageUri, ImageUri]);
        (await act.Should().ThrowAsync<ArgumentException>()).WithMessage("*up to 3 reference images*");
    }

    [TestMethod]
    public async Task TextToImage_PerModelKnobsAreGated()
    {
        var seedream = await BuildImageBodyAsync(
            "seedream5-pro",
            "1024:1024",
            extras: new RunwayCliImageExtras { Grounding = true, OutputFormat = "jpeg" });
        seedream["grounding"]!.GetValue<bool>().Should().BeTrue();
        seedream["outputFormat"]!.GetValue<string>().Should().Be("jpeg");

        var grok = await BuildImageBodyAsync(
            "grok-imagine-image-2",
            "1024:1024",
            [ImageUri],
            extras: new RunwayCliImageExtras { Edit = true, });
        grok["edit"]!.GetValue<bool>().Should().BeTrue();

        // gpt_image_2 declares neither, so the flags are refused rather than dropped.
        var grounding = async () => await BuildImageBodyAsync(
            "gpt-image-2", "1920:1920", extras: new RunwayCliImageExtras { Grounding = true });
        (await grounding.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*gpt_image_2*does not accept --grounding*seedream5_pro*");

        var edit = async () => await BuildImageBodyAsync(
            "muse-image", "1600:1600", extras: new RunwayCliImageExtras { Edit = true });
        (await edit.Should().ThrowAsync<ArgumentException>()).WithMessage("*does not accept --edit*");
    }

    [TestMethod]
    public async Task TextToImage_SeedIsRefusedByModelsThatDoNotDeclareIt()
    {
        var gen4 = await BuildImageBodyAsync("gen4-image", "1024:1024", seed: 7);
        gen4["seed"]!.GetValue<int>().Should().Be(7);

        var act = async () => await BuildImageBodyAsync("muse-image", "1600:1600", seed: 7);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*muse_image*does not accept --seed*");
    }

    [TestMethod]
    public async Task TextToImage_ReferenceRequirementIsReadFromTheSpec()
    {
        var act = async () => await BuildImageBodyAsync("gen4-image-turbo", "1280:720");
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*gen4_image_turbo*requires at least one --reference-image*");
    }

    [TestMethod]
    public void RatioMatrix_CoversModelsBeyondTheOldHandRegisteredSet()
    {
        // Previously only gen4.5/veo3.1/veo3.1_fast (text_to_video) were registered, so every newer model
        // fell out of ratio validation entirely.
        RunwayRatioSupport.GetSupportedRatios("seedance2_5", RunwayRatioEndpoints.TextToVideo)
            .Should().Contain("1280:720");
        RunwayRatioSupport.GetSupportedRatios("wan3", RunwayRatioEndpoints.TextToVideo)
            .Should().Contain("auto_1080p");
        RunwayRatioSupport.GetSupportedRatios("hailuo3", RunwayRatioEndpoints.TextToVideo)
            .Should().Contain("adaptive");
        RunwayRatioSupport.GetSupportedRatios("seedream5_pro", RunwayRatioEndpoints.TextToImage)
            .Should().Contain("auto_2k");
        RunwayRatioSupport.GetSupportedRatios("gemini_omni_flash", RunwayRatioEndpoints.VideoToVideo)
            .Should().BeEmpty("gemini_omni_flash declares no ratio on video_to_video");

        RunwayRatioSupport.GetSupportingModels("adaptive").Should().Contain("hailuo3");
        RunwayRatioSupport.IsSupportedBy("1280:720", "seedance2_5").Should().BeTrue();
    }

    [TestMethod]
    public void ShortVideo_CarriesReferenceImagesOnReferenceCapableModels()
    {
        var options = new RunwayShortVideoOptions
        {
            Model = "seedance2-5",
            Ratio = "1280:720",
            ShotDurationSeconds = 5,
            ReferenceImageUris = [ImageUri],
            ReferenceAudioUris = ["https://example.com/room-tone.mp3"],
        };

        var request = RunwayShortVideoExtensions.CreateTextToVideoRequest("shot one", options);

        request.IsSeedance25.Should().BeTrue();
        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.GetProperty("references")[0].GetProperty("uri").GetString().Should().Be(ImageUri);
        json.RootElement.GetProperty("referenceAudio")[0].GetProperty("type").GetString().Should().Be("audio");
    }

    [TestMethod]
    public void ShortVideo_RejectsReferencesOnModelsThatDoNotTakeThem()
    {
        var options = new RunwayShortVideoOptions
        {
            Model = "veo3.1_fast",
            ReferenceImageUris = [ImageUri],
        };

        // Fails while planning, not after the first shot has been submitted.
        var plan = () => RunwayShortVideoExtensions.CreateShortVideoPlan("a robot finds a seed", options);
        plan.Should().Throw<ArgumentException>()
            .WithMessage("*veo3.1_fast*does not accept ReferenceImageUris*seedance2_5*");
    }

    [TestMethod]
    public void ShortVideo_AcceptsEveryTextToVideoModelInTheSpec()
    {
        // The old hand-maintained list allowed three models; the planner now tracks the spec.
        foreach (var model in new[] { "hailuo3", "seedance2", "wan3", "gemini_omni_flash" })
        {
            var ratio = RunwayRatioSupport.GetSupportedRatios(model, RunwayRatioEndpoints.TextToVideo)[0];
            var request = RunwayShortVideoExtensions.CreateTextToVideoRequest(
                "shot one",
                new RunwayShortVideoOptions { Model = model, Ratio = ratio, ShotDurationSeconds = 5 });

            using var json = JsonDocument.Parse(request.ToJson());
            json.RootElement.GetProperty("model").GetString().Should().Be(model);
        }
    }

    [TestMethod]
    public void ShortVideo_UnsupportedRatioNamesTheAcceptedValues()
    {
        var act = () => RunwayShortVideoExtensions.CreateTextToVideoRequest(
            "shot one",
            new RunwayShortVideoOptions { Model = "hailuo3", Ratio = "1280:720", ShotDurationSeconds = 5 });

        act.Should().Throw<ArgumentException>().WithMessage("*hailuo3 supports ratios:*adaptive*");
    }

    [TestMethod]
    public void GetBaseUrl_ReadsTheEnvironmentAndRejectsNonAbsoluteValues()
    {
        var previous = Environment.GetEnvironmentVariable("RUNWAY_BASE_URL");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_BASE_URL", "https://proxy.example.com/v1/");
            RunwayEnvironment.GetBaseUrl().Should().Be(new Uri("https://proxy.example.com/v1/"));

            Environment.SetEnvironmentVariable("RUNWAY_BASE_URL", "not-a-url");
            var act = () => RunwayEnvironment.GetBaseUrl();
            act.Should().Throw<FormatException>().WithMessage("*absolute http or https URL*");

            Environment.SetEnvironmentVariable("RUNWAY_BASE_URL", null);
            RunwayEnvironment.GetBaseUrl().Should().BeNull();
        }
        finally
        {
            Environment.SetEnvironmentVariable("RUNWAY_BASE_URL", previous);
        }
    }

    [TestMethod]
    public async Task NormalizeReferenceAssets_IsTheSinglePathForEveryReferenceSurface()
    {
        // Remote URIs pass through untouched.
        var remote = await RunwayCliGeneration.NormalizeReferenceAssetsAsync(
            [ImageUri, "runway://token", "data:image/png;base64,AAAA"],
            CancellationToken.None);
        remote.Should().BeEquivalentTo([ImageUri, "runway://token", "data:image/png;base64,AAAA"]);

        // A local path is inlined as a data URI — the short-video runner takes URIs, not paths, and sending
        // a bare path is rejected by the API with "Invalid image input".
        var pngPath = Path.Combine(Path.GetTempPath(), $"runway-ref-{Guid.NewGuid():N}.png");
        await File.WriteAllBytesAsync(pngPath, [0x89, 0x50, 0x4E, 0x47], CancellationToken.None);
        try
        {
            var local = await RunwayCliGeneration.NormalizeReferenceAssetsAsync([pngPath], CancellationToken.None);
            local.Should().HaveCount(1);
            local![0].Should().StartWith("data:image/png;base64,");
        }
        finally
        {
            File.Delete(pngPath);
        }

        // Empty and null collapse to null so callers omit the field entirely.
        (await RunwayCliGeneration.NormalizeReferenceAssetsAsync([], CancellationToken.None)).Should().BeNull();
        (await RunwayCliGeneration.NormalizeReferenceAssetsAsync(null, CancellationToken.None)).Should().BeNull();

        var missing = async () => await RunwayCliGeneration.NormalizeReferenceAssetsAsync(
            ["./definitely-not-here.png"], CancellationToken.None);
        await missing.Should().ThrowAsync<FileNotFoundException>();
    }

    [TestMethod]
    public void ModelGapReport_SerializesTheScriptableShape()
    {
        // `models --account --json` is meant for CI checks, so the field names and shape are pinned.
        var report = new RunwayCliModelGapReport
        {
            SpecModelCount = 39,
            AccountModelCount = 81,
            MissingFromSpec = ["some_unreleased_model", "another_unreleased_model"],
            EndpointCapabilities = ["product_ad"],
            MissingFromAccount = ["eleven_ttv_v3"],
        };

        using var json = global::System.Text.Json.JsonDocument.Parse(RunwayCliModelGap.ToJson(report));
        var root = json.RootElement;
        root.GetProperty("specModelCount").GetInt32().Should().Be(39);
        root.GetProperty("accountModelCount").GetInt32().Should().Be(81);
        root.GetProperty("missingFromSpec").GetArrayLength().Should().Be(2);
        root.GetProperty("missingFromSpec")[0].GetString().Should().Be("some_unreleased_model");
        root.GetProperty("endpointCapabilities")[0].GetString().Should().Be("product_ad");
        root.GetProperty("missingFromAccount")[0].GetString().Should().Be("eleven_ttv_v3");

        // Defaults serialize as empty arrays, not null, so a consumer can index without a null check.
        using var empty = global::System.Text.Json.JsonDocument.Parse(RunwayCliModelGap.ToJson(new RunwayCliModelGapReport()));
        empty.RootElement.GetProperty("missingFromSpec").GetArrayLength().Should().Be(0);
    }

    [TestMethod]
    public void ModelSchema_SeparatesEndpointCapabilitiesFromModels()
    {
        var endpoints = RunwayModelSchema.KnownEndpoints();
        endpoints.Should().Contain("text_to_video").And.Contain("recipes/product_ad").And.Contain("uploads");

        // Some account entitlements are whole endpoints rather than a `model` value, so `models --account`
        // must not report them as missing from the spec.
        RunwayModelSchema.IsKnown("product_ad").Should().BeTrue();
        RunwayModelSchema.IsKnown("multi_shot_video").Should().BeTrue();
        RunwayModelSchema.IsKnown("ad_localization").Should().BeTrue();

        // Ordinary model values resolve too.
        RunwayModelSchema.IsKnown("seedance2_5").Should().BeTrue();
        RunwayModelSchema.IsKnown("muse_image").Should().BeTrue();

        // These two used to be pinned here as "the account has them, the spec has not caught up". That
        // was the wrong diagnosis: the spec was fetched from the `next` branch, which Runway had frozen,
        // and both were in the default branch all along. Pinned the other way round now, so that a
        // regression back to a stale source fails here instead of looking like upstream's fault.
        RunwayModelSchema.IsKnown("kling3.0_pro").Should().BeTrue();
        RunwayModelSchema.IsKnown("nano_banana_2.1").Should().BeTrue();

        // An id that is genuinely not a model still does not resolve.
        RunwayModelSchema.IsKnown("definitely_not_a_runway_model").Should().BeFalse();
        RunwayModelSchema.IsKnown("").Should().BeFalse();
    }

    [TestMethod]
    public void ModelSchema_CarriesTheModelsPatchedInAheadOfUpstream()
    {
        // patch_openapi.py adds four models Runway released on 2026-11-05 and documents on its model
        // index, but has not put in its OpenAPI repository yet. Each is cloned from a sibling already
        // in the spec, so the shape is the API's and only the limits the changelog states differ.
        // Delete an entry here together with its entry in the script once upstream ships it.
        foreach (var model in new[] { "kling_4_flash", "gemini_omni_flash_1.2", "gpt_image_2_6_flare", "gpt_image_2_6_sunburst" })
        {
            RunwayModelSchema.IsKnown(model).Should().BeTrue($"{model} is patched into the spec");
        }

        foreach (var endpoint in new[] { RunwayRatioEndpoints.TextToVideo, RunwayRatioEndpoints.ImageToVideo, RunwayRatioEndpoints.VideoToVideo })
        {
            // Kling 4.0 Flash is 720p only, where Kling 4.0 also offers 1080p.
            RunwayRatioSupport.GetSupportedRatios("kling_4_flash", endpoint).Should().Equal(["auto_720p"]);
            RunwayRatioSupport.GetSupportedRatios("kling_4", endpoint).Should().Contain("auto_1080p");
        }

        // The endpoints that start a new clip carry a duration; video-to-video edits the source and has
        // none, so the clone must not have invented one.
        RunwayModelSchema.SupportsParameter("kling_4_flash", "image_to_video", "duration").Should().BeTrue();
        RunwayModelSchema.SupportsParameter("kling_4_flash", "video_to_video", "duration").Should().BeFalse();

        // GPT Image 2.6 takes a reasoning effort, which 2.5 does not.
        RunwayModelSchema.GetAllowedValues("gpt_image_2_6_flare", "text_to_image", "reasoningEffort")
            .Should().Equal(["low", "medium", "high"]);
        RunwayModelSchema.SupportsParameter("gpt_image_2_5_flare", "text_to_image", "reasoningEffort").Should().BeFalse();
    }

    [TestMethod]
    public void ModelSchema_ExposesEnumValuesAndArrayShapes()
    {
        RunwayModelSchema.GetAllowedValues("seedance2_5", "video_to_video", "mode")
            .Should().BeEquivalentTo(["reference", "extend"]);
        RunwayModelSchema.GetAllowedValues("hailuo3", "text_to_video", "resolution")
            .Should().Contain("2K").And.Contain("768P");

        RunwayModelSchema.GetMaxItems("seedance2_5", "text_to_video", "references").Should().Be(30);
        RunwayModelSchema.GetMaxItems("wan3", "text_to_video", "references").Should().Be(10);

        // Video references carry a type discriminator; image references do not.
        RunwayModelSchema.SupportsItemProperty("wan3", "text_to_video", "referenceVideos", "type").Should().BeTrue();
        RunwayModelSchema.SupportsItemProperty("wan3", "text_to_video", "references", "type").Should().BeFalse();

        // aleph2 keyframes are a union of the seconds- and fraction-addressed shapes.
        var keyframes = RunwayModelSchema.GetParameter("aleph2", "video_to_video", "keyframes");
        keyframes.Should().NotBeNull();
        keyframes!.MaxItems.Should().Be(5);
        keyframes.ItemProperties.Should().Contain("seconds").And.Contain("at").And.Contain("uri");

        RunwayModelSchema.GetParameter("veo3.1", "text_to_video", "references").Should().BeNull();
    }
}
