
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum RequestVariant3PromptImageVariant2ItemPosition
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
    public static class RequestVariant3PromptImageVariant2ItemPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant3PromptImageVariant2ItemPosition value)
        {
            return value switch
            {
                RequestVariant3PromptImageVariant2ItemPosition.First => "first",
                RequestVariant3PromptImageVariant2ItemPosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant3PromptImageVariant2ItemPosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => RequestVariant3PromptImageVariant2ItemPosition.First,
                "last" => RequestVariant3PromptImageVariant2ItemPosition.Last,
                _ => null,
            };
        }
    }
}