using System.Text.Json;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// Offline coverage for the upscale, character-performance, and creative-recipe surfaces, all gated on the
/// embedded spec. The two video-upscale models take disjoint parameter sets under
/// <c>additionalProperties: false</c>, which is the shape that produced the aleph2 bug.
/// </summary>
[TestClass]
public sealed class RunwayUpscaleGatingTests
{
    private const string VideoUri = "https://example.com/source.mp4";
    private const string ImageUri = "https://example.com/source.png";

    [TestMethod]
    public async Task VideoUpscale_CreativeModelTakesTheDetailKnobs()
    {
        var request = await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            video: VideoUri,
            model: null,
            resolution: "4k",
            targetFramerate: null,
            creativity: 40,
            sharpen: 20,
            smartGrain: 10,
            flavor: "vivid",
            fpsBoost: true,
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("magnific_video_upscaler_creative");
        root.GetProperty("videoUri").GetString().Should().Be(VideoUri);
        root.GetProperty("resolution").GetString().Should().Be("4k");
        root.GetProperty("creativity").GetInt32().Should().Be(40);
        root.GetProperty("flavor").GetString().Should().Be("vivid");
        root.GetProperty("fpsBoost").GetBoolean().Should().BeTrue();
    }

    [TestMethod]
    public async Task VideoUpscale_FrameRateModelTakesOnlyTheTargetFramerate()
    {
        var request = await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            video: VideoUri,
            model: "enhance-frame-rate",
            resolution: null,
            targetFramerate: "59_94",
            creativity: null,
            sharpen: null,
            smartGrain: null,
            flavor: null,
            fpsBoost: null,
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("enhance_frame_rate");
        root.GetProperty("targetFramerate").GetString().Should().Be("59_94");
        root.TryGetProperty("resolution", out _).Should().BeFalse();
    }

    [TestMethod]
    public async Task VideoUpscale_FlagsCrossingModelsAreRefused()
    {
        var creativityOnFrameRate = async () => await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            VideoUri, "enhance_frame_rate", null, "60", creativity: 40,
            sharpen: null, smartGrain: null, flavor: null, fpsBoost: null,
            cancellationToken: CancellationToken.None);
        (await creativityOnFrameRate.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*enhance_frame_rate*does not accept --creativity*magnific_video_upscaler_creative*");

        var framerateOnCreative = async () => await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            VideoUri, null, null, "60", creativity: null,
            sharpen: null, smartGrain: null, flavor: null, fpsBoost: null,
            cancellationToken: CancellationToken.None);
        (await framerateOnCreative.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*does not accept --target-framerate*enhance_frame_rate*");
    }

    [TestMethod]
    public async Task VideoUpscale_MissingRequiredParameterNamesTheFlag()
    {
        // enhance_frame_rate requires targetFramerate per the spec.
        var act = async () => await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            VideoUri, "enhance_frame_rate", null, null, null, null, null, null, null,
            cancellationToken: CancellationToken.None);

        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*requires targetFramerate (--target-framerate)*");
    }

    [TestMethod]
    public async Task ImageUpscale_ValidatesScaleFactorAgainstTheSpecEnum()
    {
        var request = await RunwayCliGeneration.CreateImageUpscaleRequestAsync(
            image: ImageUri,
            model: null,
            scaleFactor: 4,
            sharpen: 20,
            smartGrain: null,
            ultraDetail: 30,
            flavor: "photo",
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("magnific_precision_upscaler_v2");
        root.GetProperty("imageUri").GetString().Should().Be(ImageUri);
        root.GetProperty("scaleFactor").GetDouble().Should().Be(4);
        root.GetProperty("ultraDetail").GetInt32().Should().Be(30);
        root.GetProperty("flavor").GetString().Should().Be("photo");

        var act = async () => await RunwayCliGeneration.CreateImageUpscaleRequestAsync(
            ImageUri, null, scaleFactor: 3, sharpen: null, smartGrain: null, ultraDetail: null,
            flavor: null, cancellationToken: CancellationToken.None);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("--scale-factor must be one of: 2, 4, 8, 16.");
    }

    [TestMethod]
    public async Task CharacterPerformance_IsGatedAndModelAware()
    {
        var request = await RunwayCliGeneration.CreateCharacterPerformanceRequestAsync(
            characterImage: ImageUri,
            characterVideo: null,
            referenceVideo: VideoUri,
            model: null,
            ratio: "1280:720",
            seed: 7,
            bodyControl: true,
            expressionIntensity: 3,
            publicFigureThreshold: null,
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("act_two");
        root.GetProperty("character").GetProperty("type").GetString().Should().Be("image");
        root.GetProperty("reference").GetProperty("type").GetString().Should().Be("video");
        root.GetProperty("seed").GetInt32().Should().Be(7);
        root.GetProperty("bodyControl").GetBoolean().Should().BeTrue();
        root.GetProperty("expressionIntensity").GetInt32().Should().Be(3);

        // A model from another endpoint is rejected with the endpoint named.
        var act = async () => await RunwayCliGeneration.CreateCharacterPerformanceRequestAsync(
            ImageUri, null, VideoUri, "veo3.1_fast", null, null, null, null, null, CancellationToken.None);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*for character_performance*");
    }

    [TestMethod]
    public void CreativeRecipes_ValidateTheResolvedModelWhilePlanning()
    {
        // The default still plans fine.
        var plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
            prompt: "a transparent speaker on a steel table",
            referenceImages: null,
            count: 1,
            ratio: null,
            model: null,
            mode: null,
            productContext: null,
            brandContext: null,
            quality: null,
            resolution: null);
        plan.Model.Should().Be(RunwayCliCreativeRecipes.DefaultImageModel);

        // A new image model the hand-maintained list never knew about is now accepted.
        var seedream = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
            "a transparent speaker", null, 1, "1024:1024", "seedream5-pro", null, null, null, null, null);
        seedream.Model.Should().Be("seedream5_pro");

        // A video model on the image recipe fails while planning instead of per job at generation time.
        var wrongSurface = () => RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
            "a transparent speaker", null, 1, null, "veo3.1_fast", null, null, null, null, null);
        wrongSurface.Should().Throw<ArgumentException>().WithMessage("*for text_to_image*");

        var typo = () => RunwayCliCreativeRecipes.CreateMarketplaceCardsPlan(
            "a transparent speaker", null, null, null, "gpt-image-3", null, null, null);
        typo.Should().Throw<ArgumentException>().WithMessage("*Unsupported model 'gpt-image-3'*");
    }

    [TestMethod]
    public void CreativeRecipes_AdVideoChecksTheEndpointItWillPostTo()
    {
        // No reference images: the plan posts to text_to_video.
        var textPlan = RunwayCliCreativeRecipes.CreateAdVideoPlan(
            "a 4 second spot for a transparent speaker", null, 1, null, null, null, null, audio: false, duration: null);
        textPlan.Model.Should().Be(RunwayCliCreativeRecipes.DefaultVideoModel);

        // gen4_turbo only exists on image_to_video, so it is accepted there and refused for text-only.
        var imagePlan = RunwayCliCreativeRecipes.CreateAdVideoPlan(
            "a 4 second spot", ["https://example.com/product.png"], 1, null, "gen4-turbo", null, null, audio: false, duration: null);
        imagePlan.Model.Should().Be("gen4_turbo");

        var act = () => RunwayCliCreativeRecipes.CreateAdVideoPlan(
            "a 4 second spot", null, 1, null, "gen4-turbo", null, null, audio: false, duration: null);
        act.Should().Throw<ArgumentException>().WithMessage("*for text_to_video*");
    }
}
