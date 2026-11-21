
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTextToSpeechRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        ElevenMultilingualV2,
        /// <summary>
        ///
        /// </summary>
        ElevenV3,
        /// <summary>
        ///
        /// </summary>
        ElevenV4,
        /// <summary>
        ///
        /// </summary>
        Gemini38FlashLiteTts,
        /// <summary>
        ///
        /// </summary>
        Gemini38FlashTts,
        /// <summary>
        ///
        /// </summary>
        SeedAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToSpeechRequestDiscriminatorModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                CreateTextToSpeechRequestDiscriminatorModel.ElevenV3 => "eleven_v3",
                CreateTextToSpeechRequestDiscriminatorModel.ElevenV4 => "eleven_v4",
                CreateTextToSpeechRequestDiscriminatorModel.Gemini38FlashLiteTts => "gemini_3.8_flash_lite_tts",
                CreateTextToSpeechRequestDiscriminatorModel.Gemini38FlashTts => "gemini_3.8_flash_tts",
                CreateTextToSpeechRequestDiscriminatorModel.SeedAudio => "seed_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_multilingual_v2" => CreateTextToSpeechRequestDiscriminatorModel.ElevenMultilingualV2,
                "eleven_v3" => CreateTextToSpeechRequestDiscriminatorModel.ElevenV3,
                "eleven_v4" => CreateTextToSpeechRequestDiscriminatorModel.ElevenV4,
                "gemini_3.8_flash_lite_tts" => CreateTextToSpeechRequestDiscriminatorModel.Gemini38FlashLiteTts,
                "gemini_3.8_flash_tts" => CreateTextToSpeechRequestDiscriminatorModel.Gemini38FlashTts,
                "seed_audio" => CreateTextToSpeechRequestDiscriminatorModel.SeedAudio,
                _ => null,
            };
        }
    }
}