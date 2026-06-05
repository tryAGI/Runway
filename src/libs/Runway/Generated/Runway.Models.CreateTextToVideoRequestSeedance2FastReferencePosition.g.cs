
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateTextToVideoRequestSeedance2FastReferencePosition
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
    public static class CreateTextToVideoRequestSeedance2FastReferencePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance2FastReferencePosition value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance2FastReferencePosition.First => "first",
                CreateTextToVideoRequestSeedance2FastReferencePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance2FastReferencePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateTextToVideoRequestSeedance2FastReferencePosition.First,
                "last" => CreateTextToVideoRequestSeedance2FastReferencePosition.Last,
                _ => null,
            };
        }
    }
}