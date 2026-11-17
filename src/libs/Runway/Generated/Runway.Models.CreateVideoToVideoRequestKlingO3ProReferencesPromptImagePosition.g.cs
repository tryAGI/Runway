
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition
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
    public static class CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition.First => "first",
                CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition.First,
                "last" => CreateVideoToVideoRequestKlingO3ProReferencesPromptImagePosition.Last,
                _ => null,
            };
        }
    }
}