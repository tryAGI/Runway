
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        RunwayPreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestElevenV3VoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "runway-preset" => CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}