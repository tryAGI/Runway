
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution. Hailuo 3.0 supports 768p and 2k.<br/>
    /// Example: 2k
    /// </summary>
    public enum CreateVideoToVideoRequestHailuo3Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x2k2,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x768p2,
        /// <summary>
        ///
        /// </summary>
        x768p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestHailuo3ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestHailuo3Resolution value)
        {
            return value switch
            {
                CreateVideoToVideoRequestHailuo3Resolution.x2k2 => "2K",
                CreateVideoToVideoRequestHailuo3Resolution.x2k => "2k",
                CreateVideoToVideoRequestHailuo3Resolution.x768p2 => "768P",
                CreateVideoToVideoRequestHailuo3Resolution.x768p => "768p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestHailuo3Resolution? ToEnum(string value)
        {
            return value switch
            {
                "2K" => CreateVideoToVideoRequestHailuo3Resolution.x2k2,
                "2k" => CreateVideoToVideoRequestHailuo3Resolution.x2k,
                "768P" => CreateVideoToVideoRequestHailuo3Resolution.x768p2,
                "768p" => CreateVideoToVideoRequestHailuo3Resolution.x768p,
                _ => null,
            };
        }
    }
}