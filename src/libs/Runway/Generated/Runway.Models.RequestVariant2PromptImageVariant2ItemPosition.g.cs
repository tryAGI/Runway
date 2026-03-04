
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum RequestVariant2PromptImageVariant2ItemPosition
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
    public static class RequestVariant2PromptImageVariant2ItemPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant2PromptImageVariant2ItemPosition value)
        {
            return value switch
            {
                RequestVariant2PromptImageVariant2ItemPosition.First => "first",
                RequestVariant2PromptImageVariant2ItemPosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant2PromptImageVariant2ItemPosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => RequestVariant2PromptImageVariant2ItemPosition.First,
                "last" => RequestVariant2PromptImageVariant2ItemPosition.Last,
                _ => null,
            };
        }
    }
}