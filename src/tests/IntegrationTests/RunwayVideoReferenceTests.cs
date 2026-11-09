using System.Text.Json;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// Offline coverage for the reference-driven video surface: image/video/audio references, per-model
/// capability gating, and the delivery/steering options. No API key or network access required — every
/// assertion is made against the serialized request body.
/// </summary>
[TestClass]
public sealed class RunwayVideoReferenceTests
{
    private const string ImageUri = "https://example.com/reference.jpg";
    private const string SecondImageUri = "https://example.com/reference2.jpg";
    private const string VideoUri = "https://example.com/reference.mp4";
    private const string AudioUri = "https://example.com/reference.mp3";

    [TestMethod]
    public async Task TextToVideo_Wan3_SendsAllThreeReferenceKinds()
    {
        var request = await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            prompt: "a slow dolly across a lit workshop",
            model: "wan3",
            ratio: "1280:720",
            duration: 5,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras
            {
                ReferenceImages = [ImageUri, SecondImageUri],
                ReferenceVideos = [VideoUri],
                ReferenceAudio = [AudioUri],
            },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("wan3");

        var references = root.GetProperty("references");
        references.GetArrayLength().Should().Be(2);
        references[0].GetProperty("uri").GetString().Should().Be(ImageUri);
        // Image references are bare `{ uri }` objects; a `type` discriminator is rejected by the API.
        references[0].TryGetProperty("type", out _).Should().BeFalse();

        var referenceVideos = root.GetProperty("referenceVideos");
        referenceVideos.GetArrayLength().Should().Be(1);
        referenceVideos[0].GetProperty("type").GetString().Should().Be("video");
        referenceVideos[0].GetProperty("uri").GetString().Should().Be(VideoUri);

        var referenceAudio = root.GetProperty("referenceAudio");
        referenceAudio.GetArrayLength().Should().Be(1);
        referenceAudio[0].GetProperty("type").GetString().Should().Be("audio");
        referenceAudio[0].GetProperty("uri").GetString().Should().Be(AudioUri);
    }

    [TestMethod]
    public async Task TextToVideo_Veo31_RejectsImageReferencesAndNamesModelsThatTakeThem()
    {
        var act = async () => await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            prompt: "a slow dolly",
            model: "veo3.1",
            ratio: "1280:720",
            duration: null,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras { ReferenceImages = [ImageUri] },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*does not accept --reference-image*")
            .WithMessage("*seedance2*");
    }

    [TestMethod]
    public async Task TextToVideo_Veo31_CarriesNegativePrompt()
    {
        var request = await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            prompt: "a slow dolly",
            model: "veo3.1",
            ratio: "1280:720",
            duration: null,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras { NegativePrompt = "text, watermark" },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.GetProperty("negativePrompt").GetString().Should().Be("text, watermark");
    }

    [TestMethod]
    public async Task TextToVideo_Hailuo3_UsesResolutionAndOmitsUnsupportedAudioFlag()
    {
        var request = await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            prompt: "a slow dolly",
            model: "hailuo3",
            ratio: "16:9",
            duration: null,
            seed: 7,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras { Resolution = "2K" },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("resolution").GetString().Should().Be("2K");
        root.GetProperty("ratio").GetString().Should().Be("16:9");
        // hailuo3 declares neither `audio` nor `seed` on text_to_video, so neither may be sent.
        root.TryGetProperty("audio", out _).Should().BeFalse();
        root.TryGetProperty("seed", out _).Should().BeFalse();
    }

    [TestMethod]
    public async Task ImageToVideo_Happyhorse_SendsResolutionInsteadOfRatio()
    {
        var request = await RunwayCliGeneration.CreateImageToVideoRequestAsync(
            prompt: "pan right",
            model: "happyhorse-1-0",
            promptImages: [ImageUri],
            lastImage: null,
            ratio: "1280:720",
            duration: null,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras { Resolution = "1080P" },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("happyhorse_1_0");
        root.GetProperty("resolution").GetString().Should().Be("1080P");
        // This variant has no `ratio` and uses additionalProperties:false, so --ratio must be dropped.
        root.TryGetProperty("ratio", out _).Should().BeFalse();
    }

    [TestMethod]
    public async Task VideoToVideo_Aleph2_RejectsImageReferences()
    {
        // Regression guard: the CLI used to attach `references` to every video-to-video request, which
        // aleph2 rejects outright (its schema is additionalProperties:false and declares no references).
        var act = async () => await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
            prompt: "turn the set into a snowy street",
            model: null,
            video: VideoUri,
            ratio: null,
            duration: null,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras { ReferenceImages = [ImageUri] },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*aleph2*does not accept --reference-image*");
    }

    [TestMethod]
    public async Task VideoToVideo_Aleph2_SendsKeyframesAndTargetAspectRatioWithoutDeprecatedRatio()
    {
        var request = await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
            prompt: "turn the set into a snowy street",
            model: "aleph2",
            video: VideoUri,
            ratio: "1280:720",
            duration: null,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras
            {
                Keyframes = [$"{ImageUri}@1.5", $"{SecondImageUri}@50%"],
                TargetAspectRatio = "9:16",
                OutputFormat = "prores",
                ProresProfile = "422 HQ",
            },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("videoUri").GetString().Should().Be(VideoUri);
        root.GetProperty("targetAspectRatio").GetString().Should().Be("9:16");
        root.GetProperty("outputFormat").GetString().Should().Be("prores");
        root.GetProperty("proresProfile").GetString().Should().Be("422 HQ");
        // `ratio` is deprecated on aleph2 and must not be sent alongside targetAspectRatio.
        root.TryGetProperty("ratio", out _).Should().BeFalse();

        var keyframes = root.GetProperty("keyframes");
        keyframes.GetArrayLength().Should().Be(2);
        keyframes[0].GetProperty("uri").GetString().Should().Be(ImageUri);
        keyframes[0].GetProperty("seconds").GetDouble().Should().Be(1.5);
        keyframes[1].GetProperty("at").GetDouble().Should().Be(0.5);
    }

    [TestMethod]
    public async Task VideoToVideo_Seedance25_UsesPromptVideoAndMode()
    {
        var request = await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
            prompt: null,
            model: "seedance2-5",
            video: VideoUri,
            ratio: null,
            duration: 6,
            seed: null,
            audio: false,
            publicFigureThreshold: null,
            extras: new RunwayCliVideoExtras
            {
                Mode = "extend",
                ReferenceImages = [ImageUri],
            },
            cancellationToken: TestContext.CancellationTokenSource.Token);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("seedance2_5");
        // The seedance/hailuo families name the input `promptVideo`, not `videoUri`.
        root.GetProperty("promptVideo").GetString().Should().Be(VideoUri);
        root.TryGetProperty("videoUri", out _).Should().BeFalse();
        root.GetProperty("mode").GetString().Should().Be("extend");
        root.GetProperty("audio").GetBoolean().Should().BeFalse();
        root.GetProperty("references")[0].GetProperty("uri").GetString().Should().Be(ImageUri);
    }

    [TestMethod]
    public async Task VideoToVideo_PromptlessModelRequiringPrompt_Fails()
    {
        var act = async () => await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
            prompt: null,
            model: "hailuo3",
            video: VideoUri,
            ratio: null,
            duration: null,
            seed: null,
            audio: true,
            publicFigureThreshold: null,
            extras: RunwayCliVideoExtras.None,
            cancellationToken: TestContext.CancellationTokenSource.Token);

        (await act.Should().ThrowAsync<ArgumentException>()).WithMessage("*requires a prompt*");
    }

    [TestMethod]
    public void NormalizeVideoModel_AcceptsAliasesAndRejectsWrongEndpoint()
    {
        RunwayCliGeneration.NormalizeVideoModel("seedance2-5", "aleph2", RunwayCliGeneration.VideoToVideoEndpoint)
            .Should().Be("seedance2_5");
        RunwayCliGeneration.NormalizeVideoModel("grok-imagine-1-5", "veo3.1_fast", RunwayCliGeneration.TextToVideoEndpoint)
            .Should().Be("grok_imagine_1_5");
        RunwayCliGeneration.NormalizeVideoModel(null, "aleph2", RunwayCliGeneration.VideoToVideoEndpoint)
            .Should().Be("aleph2");

        // aleph2 is video-to-video only.
        var act = () => RunwayCliGeneration.NormalizeVideoModel("aleph2", "veo3.1_fast", RunwayCliGeneration.TextToVideoEndpoint);
        act.Should().Throw<ArgumentException>().WithMessage("*Unsupported model 'aleph2' for text_to_video*");
    }

    [TestMethod]
    public void ModelSchema_ExposesEndpointModelsAndParameterSupport()
    {
        var textToVideoModels = RunwayModelSchema.ModelsForEndpoint("text_to_video");
        textToVideoModels.Should().Contain("seedance2_5").And.Contain("wan3").And.Contain("veo3.1_fast");
        textToVideoModels.Should().NotContain("aleph2");

        RunwayModelSchema.SupportsParameter("wan3", "text_to_video", "references").Should().BeTrue();
        RunwayModelSchema.SupportsParameter("veo3.1", "text_to_video", "references").Should().BeFalse();
        RunwayModelSchema.SupportsParameter("seedance2_5", "video_to_video", "mode").Should().BeTrue();
        RunwayModelSchema.SupportsParameter("aleph2", "video_to_video", "keyframes").Should().BeTrue();
    }

    [TestMethod]
    public void Factories_Seedance25TextToVideo_MapsReferenceUris()
    {
        var request = RunwayTextToVideo.Seedance25(
            promptText: "a hand places the bottle on the counter",
            referenceImageUris: [ImageUri, SecondImageUri],
            referenceVideoUris: [VideoUri],
            referenceAudioUris: [AudioUri]);

        request.IsSeedance25.Should().BeTrue();
        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("seedance2_5");
        root.GetProperty("references").GetArrayLength().Should().Be(2);
        root.GetProperty("referenceVideos")[0].GetProperty("type").GetString().Should().Be("video");
        root.GetProperty("referenceAudio")[0].GetProperty("type").GetString().Should().Be("audio");
    }

    [TestMethod]
    public void Factories_OmitEmptyReferenceLists()
    {
        var request = RunwayTextToVideo.Wan3("a slow dolly", referenceImageUris: []);

        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.TryGetProperty("references", out _).Should().BeFalse();
    }

    [TestMethod]
    public void Factories_Hailuo3VideoToVideo_UsesPromptVideo()
    {
        var request = RunwayVideoToVideo.Hailuo3(
            promptVideoUri: VideoUri,
            promptText: "make it winter",
            resolution: CreateVideoToVideoRequestHailuo3Resolution.x2k,
            referenceImageUris: [ImageUri]);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("hailuo3");
        root.GetProperty("promptVideo").GetString().Should().Be(VideoUri);
        root.GetProperty("resolution").GetString().Should().Be("2K");
        root.GetProperty("references")[0].GetProperty("uri").GetString().Should().Be(ImageUri);
    }

    [TestMethod]
    public void Factories_Aleph2Keyframes_SerializeSecondsAndFractions()
    {
        var request = RunwayVideoToVideo.Aleph2(
            videoUri: VideoUri,
            promptText: "snowy street",
            targetAspectRatio: CreateVideoToVideoRequestVariant1TargetAspectRatio.x9_16,
            keyframes:
            [
                RunwayVideoKeyframes.AtSeconds(ImageUri, 2),
                RunwayVideoKeyframes.AtFraction(SecondImageUri, 0.75),
            ]);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("targetAspectRatio").GetString().Should().Be("9:16");
        root.GetProperty("keyframes")[0].GetProperty("seconds").GetDouble().Should().Be(2);
        root.GetProperty("keyframes")[1].GetProperty("at").GetDouble().Should().Be(0.75);
    }

    [TestMethod]
    public void Factories_Veo31ImageToVideo_CarriesNegativePrompt()
    {
        var request = RunwayImageToVideo.Veo31(
            promptImageUri: ImageUri,
            ratio: CreateImageToVideoRequestVeo31Ratio.x1280_720,
            promptText: "slow push in",
            negativePrompt: "text, watermark");

        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.GetProperty("negativePrompt").GetString().Should().Be("text, watermark");
    }

    /// <summary>MSTest injects this; used only for the ambient cancellation token.</summary>
    public TestContext TestContext { get; set; } = null!;
}
