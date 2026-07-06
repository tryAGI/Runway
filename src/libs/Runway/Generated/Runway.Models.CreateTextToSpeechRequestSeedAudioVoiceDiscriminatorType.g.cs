
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ReferenceAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType.ReferenceAudio => "reference-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "reference-audio" => CreateTextToSpeechRequestSeedAudioVoiceDiscriminatorType.ReferenceAudio,
                _ => null,
            };
        }
    }
}