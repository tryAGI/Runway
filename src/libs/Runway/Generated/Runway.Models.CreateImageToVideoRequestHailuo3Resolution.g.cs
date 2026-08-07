
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output resolution. Hailuo 3.0 supports 768P and 2K.
    /// </summary>
    public enum CreateImageToVideoRequestHailuo3Resolution
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
    public static class CreateImageToVideoRequestHailuo3ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHailuo3Resolution value)
        {
            return value switch
            {
                CreateImageToVideoRequestHailuo3Resolution.x2k => "2K",
                CreateImageToVideoRequestHailuo3Resolution.x768p => "768P",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3Resolution? ToEnum(string value)
        {
            return value switch
            {
                "2K" => CreateImageToVideoRequestHailuo3Resolution.x2k,
                "768P" => CreateImageToVideoRequestHailuo3Resolution.x768p,
                _ => null,
            };
        }
    }
}