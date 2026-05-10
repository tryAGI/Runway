namespace Runway;

/// <summary>
/// Short-named factory helpers for the verbose discriminated-union request shapes used by
/// <c>POST /v1/avatar_videos</c>. Lets consumers write
/// <c>RunwayAvatars.Preset(AvatarPreset.Influencer)</c> instead of constructing the full
/// <c>CreateAvatarVideosRequestAvatarRunwayPresetAvatar</c> + <c>Avatar</c> wrapping by hand.
/// </summary>
public static class RunwayAvatars
{
    /// <summary>
    /// Wraps a preset avatar id into the <see cref="Avatar"/> union.
    /// </summary>
    public static Avatar Preset(CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId presetId)
    {
        return new Avatar(new CreateAvatarVideosRequestAvatarRunwayPresetAvatar
        {
            PresetId = presetId,
        });
    }

    /// <summary>
    /// Wraps a custom-avatar id into the <see cref="Avatar"/> union.
    /// </summary>
    public static Avatar Custom(Guid avatarId)
    {
        return new Avatar(new CreateAvatarVideosRequestAvatarCustomAvatar
        {
            AvatarId = avatarId,
        });
    }
}

/// <summary>
/// Short-named factory helpers for the avatar-video <c>Voice3</c> union.
/// </summary>
public static class RunwayVoices
{
    /// <summary>
    /// Wraps a preset voice id into the avatar-video <see cref="Voice3"/> union.
    /// </summary>
    public static Voice3 Preset(CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId presetId)
    {
        return new Voice3(new CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice
        {
            PresetId = presetId,
        });
    }

    /// <summary>
    /// Wraps a custom voice id (from the Voices API) into the avatar-video <see cref="Voice3"/> union.
    /// </summary>
    public static Voice3 Custom(Guid voiceId)
    {
        return new Voice3(new CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice
        {
            Id = voiceId,
        });
    }
}

/// <summary>
/// Short-named factory helpers for the avatar-video <c>Speech</c> union.
/// </summary>
public static class RunwaySpeeches
{
    /// <summary>
    /// Builds a text-input speech with the supplied voice.
    /// </summary>
    public static Speech FromText(string text, Voice3 voice)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        return new Speech(new CreateAvatarVideosRequestSpeechTextInput
        {
            Text = text,
            Voice = voice,
        });
    }

    /// <summary>
    /// Builds a text-input speech using a preset voice id (shorthand for <see cref="FromText(string, Voice3)"/>
    /// + <see cref="RunwayVoices.Preset"/>).
    /// </summary>
    public static Speech FromText(
        string text,
        CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId presetId)
    {
        return FromText(text, RunwayVoices.Preset(presetId));
    }

    /// <summary>
    /// Builds a text-input speech using a custom voice id (shorthand for <see cref="FromText(string, Voice3)"/>
    /// + <see cref="RunwayVoices.Custom"/>).
    /// </summary>
    public static Speech FromText(string text, Guid customVoiceId)
    {
        return FromText(text, RunwayVoices.Custom(customVoiceId));
    }

    /// <summary>
    /// Builds an audio-input speech (no TTS): the avatar lip-syncs to the supplied
    /// HTTPS URL, Runway URI, or data URI.
    /// </summary>
#pragma warning disable CA1054 // The Runway API accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static Speech FromAudio(string audioUriOrUrl)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(audioUriOrUrl);

        return new Speech(new CreateAvatarVideosRequestSpeechAudioInput
        {
            Audio = audioUriOrUrl,
        });
    }
}
