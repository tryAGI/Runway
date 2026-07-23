
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateAudioRequestInputVoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Preset,
        /// <summary>
        /// 
        /// </summary>
        ReferenceAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateAudioRequestInputVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioRequestInputVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateGenerateAudioRequestInputVoiceDiscriminatorType.Preset => "preset",
                CreateGenerateAudioRequestInputVoiceDiscriminatorType.ReferenceAudio => "reference-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioRequestInputVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "preset" => CreateGenerateAudioRequestInputVoiceDiscriminatorType.Preset,
                "reference-audio" => CreateGenerateAudioRequestInputVoiceDiscriminatorType.ReferenceAudio,
                _ => null,
            };
        }
    }
}