
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition
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
    public static class CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition.First => "first",
                CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition.First,
                "last" => CreateImageToVideoRequestHailuo3LitePromptImageVariant2ItemPosition.Last,
                _ => null,
            };
        }
    }
}