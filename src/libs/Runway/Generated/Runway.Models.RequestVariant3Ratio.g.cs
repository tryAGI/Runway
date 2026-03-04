
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Example: 1280:768
    /// </summary>
    public enum RequestVariant3Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x768_1280,
        /// <summary>
        /// 
        /// </summary>
        x1280_768,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant3RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant3Ratio value)
        {
            return value switch
            {
                RequestVariant3Ratio.x768_1280 => "768:1280",
                RequestVariant3Ratio.x1280_768 => "1280:768",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant3Ratio? ToEnum(string value)
        {
            return value switch
            {
                "768:1280" => RequestVariant3Ratio.x768_1280,
                "1280:768" => RequestVariant3Ratio.x1280_768,
                _ => null,
            };
        }
    }
}