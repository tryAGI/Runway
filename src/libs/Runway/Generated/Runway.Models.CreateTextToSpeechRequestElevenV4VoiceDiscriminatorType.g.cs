
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTextToSpeechRequestElevenV4VoiceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        RunwayPreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestElevenV4VoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestElevenV4VoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateTextToSpeechRequestElevenV4VoiceDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestElevenV4VoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "runway-preset" => CreateTextToSpeechRequestElevenV4VoiceDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}