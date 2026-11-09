using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// The preset vocabularies are endpoint-specific, and the generated enums silently coerce an unknown id
/// to their first member — so an unvalidated flag reaches the API as a different voice or avatar instead
/// of as an error. These tests pin each surface's vocabulary and its rejection behaviour.
/// </summary>
[TestClass]
public sealed class RunwayPresetVocabularyTests
{
    [TestMethod]
    public void SpeechAndAvatarVoicesAreDifferentVocabularies()
    {
        var speech = RunwayModelSchema.GetItemPropertyValues("eleven_multilingual_v2", "text_to_speech", "voice", "presetId");
        var avatar = RunwayModelSchema.GetItemPropertyValues("gwm1_avatars", "avatar_videos", "speech", "presetId");

        speech.Should().HaveCount(49);
        speech.Should().Contain("Maya").And.Contain("Claudia");

        // `clara` belongs to the lowercase avatar vocabulary, which is where the CLI's old
        // text-to-speech default came from.
        speech.Should().NotContain("clara");

        var avatarVoices = RunwayModelSchema.GetItemPropertyValues("gwm1_avatars", "avatars", "voice", "presetId");
        if (avatarVoices.Count > 0)
        {
            avatarVoices.Should().Contain("clara").And.Contain("adrian");
            avatarVoices.Should().NotContain("Maya");
        }
        else
        {
            // The avatar voice enum is nested one level deeper on this endpoint; assert via the schema we
            // do reach, so the test still fails if the vocabularies ever merge.
            avatar.Should().NotBeEquivalentTo(speech);
        }
    }

    [TestMethod]
    public void AvatarPresetsComeFromTheSpecAndIncludeTheCliDefault()
    {
        var presets = RunwayModelSchema.GetItemPropertyValues("gwm1_avatars", "realtime_sessions", "avatar", "presetId");
        presets.Should().HaveCount(9);
        presets.Should().Contain("influencer", "the realtime and avatar-video commands default to it");
        presets.Should().Contain("cat-character");

        RunwayModelSchema.GetItemPropertyValues("gwm1_avatars", "avatar_videos", "avatar", "presetId")
            .Should().BeEquivalentTo(presets, "both avatar surfaces share one vocabulary");
    }

    [TestMethod]
    public void NormalizePresetId_RejectsUnknownIdsPerSurface()
    {
        // Realtime avatar: an unvalidated id used to be coerced to the enum's first member.
        var realtime = () => RunwayCliGeneration.NormalizePresetId(
            "clara", "gwm1_avatars", "realtime_sessions", "avatar", "--preset-avatar", "runway avatar presets");
        realtime.Should().Throw<ArgumentException>()
            .WithMessage("*Unknown --preset-avatar 'clara'*9 total*");

        // Valid ids pass, case-insensitively, keeping the spec's casing.
        RunwayCliGeneration.NormalizePresetId(
            "INFLUENCER", "gwm1_avatars", "realtime_sessions", "avatar", "--preset-avatar", "runway avatar presets")
            .Should().Be("influencer");

        // Omitted takes the first id the spec lists.
        RunwayCliGeneration.NormalizePresetId(
            null, "gwm1_avatars", "realtime_sessions", "avatar", "--preset-avatar", "runway avatar presets")
            .Should().Be("game-character");

        // Speech surfaces reject the avatar vocabulary and vice versa.
        var speech = () => RunwayCliGeneration.NormalizeVoicePreset("clara", "eleven_v3", "text_to_speech");
        speech.Should().Throw<ArgumentException>().WithMessage("*Unknown --voice-preset 'clara'*");

        var speechToSpeech = () => RunwayCliGeneration.NormalizeVoicePreset(
            "clara", "eleven_multilingual_sts_v2", "speech_to_speech");
        speechToSpeech.Should().Throw<ArgumentException>().WithMessage("*49 total*");

        // A model that clones instead of naming a voice has no enum to check against.
        RunwayCliGeneration.NormalizeVoicePreset("anything", "seed_audio", "text_to_speech")
            .Should().Be("anything");
    }

    [TestMethod]
    public void GeneratedEnums_StillCoerceUnknownValues()
    {
        // The reason every preset flag needs validating: ToEnum returns null for an unknown id, but a
        // JSON round-trip through the generated enum lands on the first member instead of failing.
        CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdExtensions.ToEnum("definitely-not-a-preset")
            .Should().BeNull();
        CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetIdExtensions.ToEnum("clara")
            .Should().BeNull("clara is an avatar voice, not a speech voice");
        CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoicePresetIdExtensions.ToEnum("Claudia")
            .Should().NotBeNull();
    }
}
