
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition
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
    public static class CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition.First => "first",
                CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition.First,
                "last" => CreateImageToVideoRequestKlingO3StandardReferencesReferenceImagePosition.Last,
                _ => null,
            };
        }
    }
}