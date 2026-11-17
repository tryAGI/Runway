
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition
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
    public static class CreateVideoToVideoRequestKlingO34kReferencesPromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition.First => "first",
                CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition.First,
                "last" => CreateVideoToVideoRequestKlingO34kReferencesPromptImagePosition.Last,
                _ => null,
            };
        }
    }
}