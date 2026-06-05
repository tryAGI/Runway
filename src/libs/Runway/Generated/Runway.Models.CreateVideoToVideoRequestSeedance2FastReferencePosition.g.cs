
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateVideoToVideoRequestSeedance2FastReferencePosition
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
    public static class CreateVideoToVideoRequestSeedance2FastReferencePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestSeedance2FastReferencePosition value)
        {
            return value switch
            {
                CreateVideoToVideoRequestSeedance2FastReferencePosition.First => "first",
                CreateVideoToVideoRequestSeedance2FastReferencePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestSeedance2FastReferencePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateVideoToVideoRequestSeedance2FastReferencePosition.First,
                "last" => CreateVideoToVideoRequestSeedance2FastReferencePosition.Last,
                _ => null,
            };
        }
    }
}