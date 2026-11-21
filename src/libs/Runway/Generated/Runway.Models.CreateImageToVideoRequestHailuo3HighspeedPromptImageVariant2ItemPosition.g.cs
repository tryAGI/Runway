
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition
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
    public static class CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition.First => "first",
                CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition.First,
                "last" => CreateImageToVideoRequestHailuo3HighspeedPromptImageVariant2ItemPosition.Last,
                _ => null,
            };
        }
    }
}