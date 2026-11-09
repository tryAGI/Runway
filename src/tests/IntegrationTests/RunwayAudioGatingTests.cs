using System.Text.Json;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// Offline coverage for the audio surfaces. The CLI used to hardcode one model per endpoint, so the
/// expressiveness controls of <c>eleven_v3</c>, the rate/format controls and voice cloning of
/// <c>seed_audio</c>, and the voice-dubbing options were all unreachable.
/// </summary>
[TestClass]
public sealed class RunwayAudioGatingTests
{
    private const string AudioUri = "https://example.com/reference.mp3";

    [TestMethod]
    public void AudioModelLists_ComeFromTheSpec()
    {
        RunwayModelSchema.ModelsForEndpoint("text_to_speech")
            .Should().BeEquivalentTo(["eleven_multilingual_v2", "eleven_v3", "seed_audio"]);
        RunwayModelSchema.ModelsForEndpoint("sound_effect")
            .Should().BeEquivalentTo(["eleven_text_to_sound_v2", "seed_audio"]);

        RunwayCliGeneration.NormalizeVideoModel(null, RunwayCliGeneration.DefaultTextToSpeechModel, RunwayCliGeneration.TextToSpeechEndpoint)
            .Should().Be("eleven_multilingual_v2");

        var act = () => RunwayCliGeneration.NormalizeVideoModel("veo3.1_fast", RunwayCliGeneration.DefaultTextToSpeechModel, RunwayCliGeneration.TextToSpeechEndpoint);
        act.Should().Throw<ArgumentException>().WithMessage("*for text_to_speech*");
    }

    [TestMethod]
    public async Task TextToSpeech_Eleven3TakesTheExpressivenessControls()
    {
        var request = await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            prompt: "hello there",
            model: "eleven_v3",
            voicePreset: "Claudia",
            referenceAudio: null,
            extras: new RunwayCliAudioExtras
            {
                Stability = 0.4,
                Style = 0.2,
                Speed = 1.1,
                SimilarityBoost = 0.8,
                LanguageCode = "ru",
                ApplyTextNormalization = "on",
                UseSpeakerBoost = true,
                Seed = 7,
            },
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("eleven_v3");
        root.GetProperty("voice").GetProperty("type").GetString().Should().Be("runway-preset");
        root.GetProperty("voice").GetProperty("presetId").GetString().Should().Be("Claudia");
        root.GetProperty("stability").GetDouble().Should().Be(0.4);
        root.GetProperty("speed").GetDouble().Should().Be(1.1);
        root.GetProperty("languageCode").GetString().Should().Be("ru");
        root.GetProperty("applyTextNormalization").GetString().Should().Be("on");
        root.GetProperty("useSpeakerBoost").GetBoolean().Should().BeTrue();
        root.GetProperty("seed").GetInt32().Should().Be(7);
    }

    [TestMethod]
    public async Task TextToSpeech_SeedAudioClonesTheVoiceFromAReferenceClip()
    {
        var request = await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            prompt: "hello there",
            model: "seed_audio",
            voicePreset: "Claudia",
            referenceAudio: AudioUri,
            extras: new RunwayCliAudioExtras
            {
                OutputFormat = "mp3",
                SampleRate = 48000,
                SpeechRate = 20,
                PitchRate = -2,
                LoudnessRate = 10,
            },
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("seed_audio");

        // seed_audio clones from a clip; it does not take a preset id.
        root.GetProperty("voice").GetProperty("type").GetString().Should().Be("reference-audio");
        root.GetProperty("voice").GetProperty("audioUri").GetString().Should().Be(AudioUri);
        root.GetProperty("voice").TryGetProperty("presetId", out _).Should().BeFalse();

        root.GetProperty("outputFormat").GetString().Should().Be("mp3");
        root.GetProperty("sampleRate").GetInt32().Should().Be(48000);
        root.GetProperty("pitchRate").GetInt32().Should().Be(-2);
    }

    [TestMethod]
    public async Task TextToSpeech_CrossModelFlagsAreRefused()
    {
        var stabilityOnDefault = async () => await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", null, "Claudia", null,
            new RunwayCliAudioExtras { Stability = 0.4 }, CancellationToken.None);
        (await stabilityOnDefault.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*eleven_multilingual_v2*does not accept --stability*eleven_v3*");

        var rateOnEleven = async () => await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", "eleven_v3", "Claudia", null,
            new RunwayCliAudioExtras { PitchRate = 3 }, CancellationToken.None);
        (await rateOnEleven.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*does not accept --pitch-rate*seed_audio*");

        // A preset-voice model cannot clone from a clip, and the error names the one that can.
        var cloneOnPresetModel = async () => await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", "eleven_v3", "Claudia", AudioUri, RunwayCliAudioExtras.None, CancellationToken.None);
        (await cloneOnPresetModel.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*speaks with a preset voice*seed_audio*");
    }

    [TestMethod]
    public async Task SoundEffect_SeedAudioTakesReferenceClipsAndTheElevenModelTakesLoop()
    {
        var eleven = await RunwayCliGeneration.CreateSoundEffectRequestAsync(
            prompt: "a door creak",
            model: null,
            duration: 10,
            loop: true,
            extras: RunwayCliAudioExtras.None,
            cancellationToken: CancellationToken.None);

        using var elevenJson = JsonDocument.Parse(eleven.ToJson());
        elevenJson.RootElement.GetProperty("model").GetString().Should().Be("eleven_text_to_sound_v2");
        elevenJson.RootElement.GetProperty("loop").GetBoolean().Should().BeTrue();
        elevenJson.RootElement.GetProperty("duration").GetDouble().Should().Be(10);

        var seed = await RunwayCliGeneration.CreateSoundEffectRequestAsync(
            prompt: "footsteps like @Audio1 over gravel",
            model: "seed_audio",
            duration: null,
            loop: true,
            extras: new RunwayCliAudioExtras { ReferenceAudios = [AudioUri], OutputFormat = "wav" },
            cancellationToken: CancellationToken.None);

        using var seedJson = JsonDocument.Parse(seed.ToJson());
        var root = seedJson.RootElement;
        root.GetProperty("model").GetString().Should().Be("seed_audio");
        root.GetProperty("referenceAudios")[0].GetString().Should().Be(AudioUri);
        root.GetProperty("outputFormat").GetString().Should().Be("wav");
        // seed_audio declares no `loop`, and its schema is additionalProperties:false.
        root.TryGetProperty("loop", out _).Should().BeFalse();
    }

    [TestMethod]
    public async Task SoundEffect_ReferenceClipCapComesFromTheSpec()
    {
        RunwayModelSchema.GetMaxItems("seed_audio", "sound_effect", "referenceAudios").Should().Be(3);

        var act = async () => await RunwayCliGeneration.CreateSoundEffectRequestAsync(
            "too many", "seed_audio", null, false,
            new RunwayCliAudioExtras { ReferenceAudios = [AudioUri, AudioUri, AudioUri, AudioUri] },
            CancellationToken.None);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*up to 3 reference audio clips*");

        var unsupported = async () => await RunwayCliGeneration.CreateSoundEffectRequestAsync(
            "a door creak", null, null, false,
            new RunwayCliAudioExtras { ReferenceAudios = [AudioUri] },
            CancellationToken.None);
        (await unsupported.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*eleven_text_to_sound_v2*does not accept --reference-audio*seed_audio*");
    }

    [TestMethod]
    public async Task VoiceDubbing_TakesTheSpeakerAndBackgroundOptions()
    {
        var request = await RunwayCliGeneration.CreateVoiceDubbingRequestAsync(
            audio: AudioUri,
            targetLanguage: "ru",
            extras: new RunwayCliAudioExtras
            {
                NumSpeakers = 2,
                DisableVoiceCloning = true,
                DropBackgroundAudio = false,
            },
            cancellationToken: CancellationToken.None);

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be("eleven_voice_dubbing");
        root.GetProperty("targetLang").GetString().Should().Be("ru");
        root.GetProperty("numSpeakers").GetInt32().Should().Be(2);
        root.GetProperty("disableVoiceCloning").GetBoolean().Should().BeTrue();
        root.GetProperty("dropBackgroundAudio").GetBoolean().Should().BeFalse();
    }

    [TestMethod]
    public async Task TextToSpeech_PresetVoiceIsValidatedAgainstTheSpec()
    {
        // The ids are proper names and the generated enum silently coerces an unknown value to its first
        // member, so `clara` — the CLI's old default — would have been sent to the API as `Arjun`.
        RunwayModelSchema.GetItemPropertyValues("eleven_multilingual_v2", "text_to_speech", "voice", "presetId")
            .Should().HaveCount(49).And.Contain("Maya").And.Contain("Claudia").And.NotContain("clara");

        var act = async () => await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", null, "clara", null, RunwayCliAudioExtras.None, CancellationToken.None);
        (await act.Should().ThrowAsync<ArgumentException>())
            .WithMessage("*Unknown --voice-preset 'clara'*49 total*");

        // Matching is case-insensitive but the wire value keeps the spec's casing.
        var request = await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", null, "claudia", null, RunwayCliAudioExtras.None, CancellationToken.None);
        using var json = JsonDocument.Parse(request.ToJson());
        json.RootElement.GetProperty("voice").GetProperty("presetId").GetString().Should().Be("Claudia");

        // Omitted falls back to the first id the spec lists rather than a hardcoded guess.
        var defaulted = await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
            "hello", null, null, null, RunwayCliAudioExtras.None, CancellationToken.None);
        using var defaultedJson = JsonDocument.Parse(defaulted.ToJson());
        defaultedJson.RootElement.GetProperty("voice").GetProperty("presetId").GetString().Should().Be("Maya");
    }

    [TestMethod]
    public void ModelSchema_ReadsUnionShapesOfNonArrayParameters()
    {
        // text_to_speech `voice` is a union of object shapes rather than an array, and the CLI needs to
        // know which shape a model takes to pick between a preset id and a cloned clip.
        RunwayModelSchema.SupportsItemProperty("seed_audio", "text_to_speech", "voice", "audioUri").Should().BeTrue();
        RunwayModelSchema.SupportsItemProperty("seed_audio", "text_to_speech", "voice", "presetId").Should().BeFalse();
        RunwayModelSchema.SupportsItemProperty("eleven_v3", "text_to_speech", "voice", "presetId").Should().BeTrue();
        RunwayModelSchema.SupportsItemProperty("eleven_v3", "text_to_speech", "voice", "audioUri").Should().BeFalse();
    }

    [TestMethod]
    public void AvatarAndRealtime_HaveASingleSpecModel()
    {
        // Both avatar surfaces accept only gwm1_avatars today. Asserted so that a second model in a
        // future spec refresh shows up here instead of silently staying unreachable.
        RunwayModelSchema.ModelsForEndpoint("avatar_videos").Should().BeEquivalentTo(["gwm1_avatars"]);
        RunwayModelSchema.ModelsForEndpoint("realtime_sessions").Should().BeEquivalentTo(["gwm1_avatars"]);
        RunwayModelSchema.ModelsForEndpoint("voices/preview")
            .Should().BeEquivalentTo(["eleven_ttv_v3", "eleven_multilingual_ttv_v2"]);
        RunwayModelSchema.ModelsForEndpoint("speech_to_speech").Should().BeEquivalentTo(["eleven_multilingual_sts_v2"]);
        RunwayModelSchema.ModelsForEndpoint("voice_isolation").Should().BeEquivalentTo(["eleven_voice_isolation"]);
    }
}
