using System.Text.Json;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// The generated enum converters read an unknown string as <c>ToEnum(value) ?? default</c>, so an
/// unvalidated flag value silently becomes the enum's default member — the alphabetically first one, as
/// AutoSDK orders them — and the API renders something the caller never asked for. Every flag that lands
/// in a spec enum must therefore be rejected, not coerced.
/// </summary>
[TestClass]
public sealed class RunwayEnumValueValidationTests
{
    private const string VideoUri = "https://example.com/source.mp4";
    private const string AudioUri = "https://example.com/source.mp3";

    [TestMethod]
    public void GeneratedConvertersThrowOnRequestEnumsAndStayLenientOnResponseEnums()
    {
        // `generate.sh` passes --reject-unknown-enum-values, and AutoSDK applies it only where the
        // enum cannot arrive in a response. Both halves matter, so both are pinned here.

        // A request enum: an undeclared value is the caller's typo, so it fails loudly. This is why
        // the CLI-side checks below are belt-and-braces rather than the only line of defence.
        var act = () => JsonSerializer.Deserialize(
            """{"model":"magnific_video_upscaler_creative","videoUri":"https://example.com/a.mp4","flavor":"bogus"}""",
            typeof(CreateVideoUpscaleRequestMagnificVideoUpscalerCreative),
            SourceGenerationContext.Default);

        act.Should().Throw<JsonException>()
            .WithMessage("*Unknown value 'bogus'*",
                "an undeclared value on a request-only enum must not be coerced into a real one");

        // A response enum: an undeclared value means Runway shipped something the spec has not caught
        // up with, which must not break a client. `CreateOrganizationUsageResponseResultUsedCredit.model`
        // is the case that forced this distinction — the account bills models the spec does not list,
        // which is exactly what `runway models --account` reports.
        var coerced = JsonSerializer.Deserialize(
            """{"model":"a_model_the_spec_does_not_know_yet","amount":7}""",
            typeof(CreateOrganizationUsageResponseResultUsedCredit),
            SourceGenerationContext.Default) as CreateOrganizationUsageResponseResultUsedCredit;

        coerced.Should().NotBeNull("a response carrying a newer model id must still deserialize");

        // AutoSDK emits enum members alphabetically, so `default` is the alphabetically first one.
        // Which value it lands on is incidental; that it lands on one instead of throwing is the point.
        coerced!.Model.Should().Be(CreateOrganizationUsageResponseResultUsedCreditModel.ActTwo);
        coerced.Amount.Should().Be(7);

        // `ToEnum` reports the unknown value either way; only the converter's handling differs.
        CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorExtensions.ToEnum("bogus").Should().BeNull();
        CreateOrganizationUsageResponseResultUsedCreditModelExtensions
            .ToEnum("a_model_the_spec_does_not_know_yet").Should().BeNull();
    }

    [TestMethod]
    public async Task CliEnumChecksAreNotMadeRedundantByTheStrictConverters()
    {
        // These two layers look like duplicates once `--reject-unknown-enum-values` is on, and they are
        // not. The converters only reject; the CLI also normalizes. `VIVID` is not a value the spec
        // declares, so the strict converter would throw on it, while the CLI accepts it and sends
        // `vivid`. Deleting the CLI-side check would reject input that works today, so this test is
        // here to say so before someone tidies it away.
        var normalized = await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            VideoUri, null, null, null, null, null, null, flavor: "VIVID", fpsBoost: null,
            cancellationToken: CancellationToken.None);

        normalized.Should().NotBeNull("the CLI normalizes case before the converter ever sees the value");

        // The converter also cannot produce a usable message: it reports
        // `Unknown value 'x' for global::Runway.<GeneratedType>`, naming a generated type and listing
        // no alternatives. The CLI check runs first, while building the request, so that message never
        // reaches a user — every CLI-side failure names the flag and the accepted values instead.
        var act = async () => await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            VideoUri, null, null, null, null, null, null, flavor: "bogus", fpsBoost: null,
            cancellationToken: CancellationToken.None);

        var thrown = await act.Should().ThrowAsync<ArgumentException>();
        thrown.Which.Message.Should().Contain("Accepted values")
            .And.NotContain("global::", "a generated type name is not an actionable CLI error");
    }

    [TestMethod]
    public async Task VideoUpscale_RejectsAnOutOfEnumFlavor()
    {
        var act = async () => await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
            VideoUri, null, null, null, null, null, null, flavor: "bogus", fpsBoost: null,
            cancellationToken: CancellationToken.None);

        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --flavor 'bogus'*Accepted values: vivid, natural*");
    }

    [TestMethod]
    public async Task TextToVideo_RejectsOutOfEnumOutputFormatAndDuration()
    {
        var format = async () => await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            "a shot", "gen4.5", "1280:720", 5, null, true, null,
            new RunwayCliVideoExtras { OutputFormat = "bogus" }, CancellationToken.None);
        (await format.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --output-format 'bogus'*hdr_exr_sequence*");

        // veo3.1 declares duration as an enum of 4/6/8 — 5 used to be remapped silently.
        var duration = async () => await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            "a shot", "veo3.1", "1280:720", 5, null, true, null,
            RunwayCliVideoExtras.None, CancellationToken.None);
        (await duration.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --duration '5'*Accepted values: 4, 6, 8*");

        // A value in the enum still passes.
        var ok = await RunwayCliGeneration.CreateTextToVideoRequestAsync(
            "a shot", "veo3.1", "1280:720", 6, null, true, null,
            RunwayCliVideoExtras.None, CancellationToken.None);
        using var json = JsonDocument.Parse(ok.ToJson());
        json.RootElement.GetProperty("duration").GetDouble().Should().Be(6);
    }

    [TestMethod]
    public async Task VideoToVideo_RejectsOutOfEnumTargetAspectRatioAndMode()
    {
        var aspect = async () => await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
            "restyle", "aleph2", VideoUri, null, null, null, true, null,
            new RunwayCliVideoExtras { TargetAspectRatio = "bogus" }, CancellationToken.None);
        (await aspect.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --target-aspect-ratio 'bogus'*21:9*");

        var mode = async () => await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
            null, "seedance2_5", VideoUri, null, 4, null, true, null,
            new RunwayCliVideoExtras { Mode = "bogus" }, CancellationToken.None);
        (await mode.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --mode 'bogus'*reference, extend*");
    }

    [TestMethod]
    public async Task Ratio_IsValidatedOnTheModelThatDeclaresIt()
    {
        // --ratio flows through the lenient setter, which now validates too.
        var act = async () => await RunwayCliGeneration.CreateImageToVideoRequestAsync(
            "pan", "gen4_turbo", ["https://example.com/a.png"], null, "9999:1", null, null, true, null,
            RunwayCliVideoExtras.None, CancellationToken.None);

        (await act.Should().ThrowAsync<ArgumentException>()).WithMessage("*9999:1*");
    }

    [TestMethod]
    public async Task VoiceDubbing_RejectsAnUnknownTargetLanguage()
    {
        var act = async () => await RunwayCliGeneration.CreateVoiceDubbingRequestAsync(
            AudioUri, "bogus", RunwayCliAudioExtras.None, CancellationToken.None);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --target-language 'bogus'*");

        // Case-insensitive, and the wire value keeps the spec's casing.
        var request = await RunwayCliGeneration.CreateVoiceDubbingRequestAsync(
            AudioUri, "RU", RunwayCliAudioExtras.None, CancellationToken.None);
        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.GetProperty("targetLang").GetString().Should().Be("ru");
    }

    [TestMethod]
    public async Task SpeechToSpeech_RejectsAnUnknownMediaType()
    {
        var act = async () => await RunwayCliGeneration.CreateSpeechToSpeechRequestAsync(
            AudioUri, "bogus", "Maya", null, null, CancellationToken.None);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --media-type 'bogus'*audio, video*");

        var request = await RunwayCliGeneration.CreateSpeechToSpeechRequestAsync(
            AudioUri, "VIDEO", "Maya", null, null, CancellationToken.None);
        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.GetProperty("media").GetProperty("type").GetString().Should().Be("video");
    }

    [TestMethod]
    public async Task TextToSpeech_RejectsOutOfEnumRatesAndFormats()
    {
        var sampleRate = async () => await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", "seed_audio", "Maya", AudioUri,
            new RunwayCliAudioExtras { SampleRate = 12345 }, CancellationToken.None);
        (await sampleRate.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --sample-rate '12345'*48000*");

        var normalization = async () => await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", "eleven_v3", "Maya", null,
            new RunwayCliAudioExtras { ApplyTextNormalization = "sometimes" }, CancellationToken.None);
        (await normalization.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*auto, on, off*");
    }

    [TestMethod]
    public async Task ImageSurface_RejectsOutOfEnumQualityAndOutputFormat()
    {
        var quality = async () => await RunwayCliGeneration.CreateTextToImageJsonBodyAsync(
            "a poster", "grok-imagine-image-2", "1024:1024", null, "object", null, null, null, null,
            quality: "ultra", extras: null, cancellationToken: CancellationToken.None);
        (await quality.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --quality 'ultra'*low, medium*");

        var outputFormat = async () => await RunwayCliGeneration.CreateTextToImageJsonBodyAsync(
            "a poster", "seedream5-pro", "1024:1024", null, "object", null, null, null, null, null,
            extras: new RunwayCliImageExtras { OutputFormat = "tiff" },
            cancellationToken: CancellationToken.None);
        (await outputFormat.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unsupported --output-format 'tiff'*png, jpeg*");
    }

    [TestMethod]
    public void EverySpecEnumIsReachableThroughTheSchemaHelper()
    {
        // Guard for the mechanism itself: the helpers can only validate what the schema reader exposes.
        RunwayModelSchema.GetAllowedValues("magnific_video_upscaler_creative", "video_upscale", "flavor")
            .Should().BeEquivalentTo(["vivid", "natural"]);
        RunwayModelSchema.GetAllowedValues("veo3.1", "text_to_video", "duration")
            .Should().BeEquivalentTo(["4", "6", "8"]);
        RunwayModelSchema.GetAllowedValues("eleven_voice_dubbing", "voice_dubbing", "targetLang")
            .Should().HaveCount(29);
        RunwayModelSchema.GetItemPropertyValues("eleven_multilingual_sts_v2", "speech_to_speech", "media", "type")
            .Should().BeEquivalentTo(["audio", "video"], "a union's variants each contribute their const");
    }
}
