
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the selected model resolves the voice: the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutingResolvedInputVoice
    {
        /// <summary>
        /// the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
        /// </summary>
        Default,
        /// <summary>
        /// the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
        /// </summary>
        None,
        /// <summary>
        /// the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
        /// </summary>
        Preset,
        /// <summary>
        /// the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
        /// </summary>
        ReferenceAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateAudioResponseRoutingResolvedInputVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutingResolvedInputVoice value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutingResolvedInputVoice.Default => "default",
                CreateGenerateAudioResponseRoutingResolvedInputVoice.None => "none",
                CreateGenerateAudioResponseRoutingResolvedInputVoice.Preset => "preset",
                CreateGenerateAudioResponseRoutingResolvedInputVoice.ReferenceAudio => "reference-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutingResolvedInputVoice? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateGenerateAudioResponseRoutingResolvedInputVoice.Default,
                "none" => CreateGenerateAudioResponseRoutingResolvedInputVoice.None,
                "preset" => CreateGenerateAudioResponseRoutingResolvedInputVoice.Preset,
                "reference-audio" => CreateGenerateAudioResponseRoutingResolvedInputVoice.ReferenceAudio,
                _ => null,
            };
        }
    }
}