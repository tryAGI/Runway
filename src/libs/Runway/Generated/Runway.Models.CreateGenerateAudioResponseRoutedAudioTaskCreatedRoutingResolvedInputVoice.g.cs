
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the selected model resolves the voice: the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice
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
    public static class CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.Default => "default",
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.None => "none",
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.Preset => "preset",
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.ReferenceAudio => "reference-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.Default,
                "none" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.None,
                "preset" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.Preset,
                "reference-audio" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputVoice.ReferenceAudio,
                _ => null,
            };
        }
    }
}