
#nullable enable

namespace Runway
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame, "last" as the last frame. Omit for a reference image.
    /// </summary>
    public enum CreateTextToVideoRequestSeedance2ReferencePosition
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
    public static class CreateTextToVideoRequestSeedance2ReferencePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSeedance2ReferencePosition value)
        {
            return value switch
            {
                CreateTextToVideoRequestSeedance2ReferencePosition.First => "first",
                CreateTextToVideoRequestSeedance2ReferencePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSeedance2ReferencePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateTextToVideoRequestSeedance2ReferencePosition.First,
                "last" => CreateTextToVideoRequestSeedance2ReferencePosition.Last,
                _ => null,
            };
        }
    }
}