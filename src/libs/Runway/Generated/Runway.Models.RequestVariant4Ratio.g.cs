
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum RequestVariant4Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant4RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant4Ratio value)
        {
            return value switch
            {
                RequestVariant4Ratio.x1280_720 => "1280:720",
                RequestVariant4Ratio.x720_1280 => "720:1280",
                RequestVariant4Ratio.x1080_1920 => "1080:1920",
                RequestVariant4Ratio.x1920_1080 => "1920:1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant4Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestVariant4Ratio.x1280_720,
                "720:1280" => RequestVariant4Ratio.x720_1280,
                "1080:1920" => RequestVariant4Ratio.x1080_1920,
                "1920:1080" => RequestVariant4Ratio.x1920_1080,
                _ => null,
            };
        }
    }
}