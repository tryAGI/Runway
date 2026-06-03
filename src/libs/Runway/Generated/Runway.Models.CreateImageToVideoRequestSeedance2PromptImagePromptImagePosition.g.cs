
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition
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
    public static class CreateImageToVideoRequestSeedance2PromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestSeedance2PromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}