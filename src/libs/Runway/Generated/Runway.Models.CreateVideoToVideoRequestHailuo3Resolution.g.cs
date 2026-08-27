
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution. MiniMax H3 supports 768P and 2K.
    /// </summary>
    public enum CreateVideoToVideoRequestHailuo3Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x2k,
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
                CreateVideoToVideoRequestHailuo3Resolution.x2k => "2K",
                CreateVideoToVideoRequestHailuo3Resolution.x768p => "768P",
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
                "2K" => CreateVideoToVideoRequestHailuo3Resolution.x2k,
                "768P" => CreateVideoToVideoRequestHailuo3Resolution.x768p,
                _ => null,
            };
        }
    }
}