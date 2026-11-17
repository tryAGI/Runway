
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition
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
    public static class CreateImageToVideoRequestKlingO34kPromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestKlingO34kPromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}