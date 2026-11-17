
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition
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
    public static class CreateImageToVideoRequestKlingO34kReferencesReferenceImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition.First => "first",
                CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition.First,
                "last" => CreateImageToVideoRequestKlingO34kReferencesReferenceImagePosition.Last,
                _ => null,
            };
        }
    }
}