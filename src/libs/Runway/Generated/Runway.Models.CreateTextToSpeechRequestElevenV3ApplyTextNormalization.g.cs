
#nullable enable

namespace Runway
{
    /// <summary>
    /// Text normalization mode: 'auto', 'on', or 'off' (e.g. spelling out numbers).
    /// </summary>
    public enum CreateTextToSpeechRequestElevenV3ApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', or 'off' (e.g. spelling out numbers).
        /// </summary>
        Auto,
        /// <summary>
        /// 'auto', 'on', or 'off' (e.g. spelling out numbers).
        /// </summary>
        Off,
        /// <summary>
        /// 'auto', 'on', or 'off' (e.g. spelling out numbers).
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestElevenV3ApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestElevenV3ApplyTextNormalization value)
        {
            return value switch
            {
                CreateTextToSpeechRequestElevenV3ApplyTextNormalization.Auto => "auto",
                CreateTextToSpeechRequestElevenV3ApplyTextNormalization.Off => "off",
                CreateTextToSpeechRequestElevenV3ApplyTextNormalization.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestElevenV3ApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToSpeechRequestElevenV3ApplyTextNormalization.Auto,
                "off" => CreateTextToSpeechRequestElevenV3ApplyTextNormalization.Off,
                "on" => CreateTextToSpeechRequestElevenV3ApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}