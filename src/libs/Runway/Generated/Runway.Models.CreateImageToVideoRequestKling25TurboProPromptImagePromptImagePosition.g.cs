
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition
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
    public static class CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestKling25TurboProPromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}