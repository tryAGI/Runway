
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition
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
    public static class CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestSeedance2MiniPromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}