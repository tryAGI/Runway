
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the selected model resolves the voice: the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice
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
    public static class CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.Default => "default",
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.None => "none",
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.Preset => "preset",
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.ReferenceAudio => "reference-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.Default,
                "none" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.None,
                "preset" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.Preset,
                "reference-audio" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputVoice.ReferenceAudio,
                _ => null,
            };
        }
    }
}