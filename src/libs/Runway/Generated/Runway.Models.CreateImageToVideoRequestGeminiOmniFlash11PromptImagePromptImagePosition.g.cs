
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition
    {
        /// <summary>
        ///
        /// </summary>
        First,
        /// <summary>
        ///
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestGeminiOmniFlash11PromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}