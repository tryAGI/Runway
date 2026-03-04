
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum RequestVariant1Ratio4
    {
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1080_1080,
        /// <summary>
        /// 
        /// </summary>
        x1168_880,
        /// <summary>
        /// 
        /// </summary>
        x1360_768,
        /// <summary>
        /// 
        /// </summary>
        x1440_1080,
        /// <summary>
        /// 
        /// </summary>
        x1080_1440,
        /// <summary>
        /// 
        /// </summary>
        x1808_768,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x2112_912,
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
        x720_720,
        /// <summary>
        /// 
        /// </summary>
        x960_720,
        /// <summary>
        /// 
        /// </summary>
        x720_960,
        /// <summary>
        /// 
        /// </summary>
        x1680_720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant1Ratio4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant1Ratio4 value)
        {
            return value switch
            {
                RequestVariant1Ratio4.x1024_1024 => "1024:1024",
                RequestVariant1Ratio4.x1080_1080 => "1080:1080",
                RequestVariant1Ratio4.x1168_880 => "1168:880",
                RequestVariant1Ratio4.x1360_768 => "1360:768",
                RequestVariant1Ratio4.x1440_1080 => "1440:1080",
                RequestVariant1Ratio4.x1080_1440 => "1080:1440",
                RequestVariant1Ratio4.x1808_768 => "1808:768",
                RequestVariant1Ratio4.x1920_1080 => "1920:1080",
                RequestVariant1Ratio4.x1080_1920 => "1080:1920",
                RequestVariant1Ratio4.x2112_912 => "2112:912",
                RequestVariant1Ratio4.x1280_720 => "1280:720",
                RequestVariant1Ratio4.x720_1280 => "720:1280",
                RequestVariant1Ratio4.x720_720 => "720:720",
                RequestVariant1Ratio4.x960_720 => "960:720",
                RequestVariant1Ratio4.x720_960 => "720:960",
                RequestVariant1Ratio4.x1680_720 => "1680:720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant1Ratio4? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => RequestVariant1Ratio4.x1024_1024,
                "1080:1080" => RequestVariant1Ratio4.x1080_1080,
                "1168:880" => RequestVariant1Ratio4.x1168_880,
                "1360:768" => RequestVariant1Ratio4.x1360_768,
                "1440:1080" => RequestVariant1Ratio4.x1440_1080,
                "1080:1440" => RequestVariant1Ratio4.x1080_1440,
                "1808:768" => RequestVariant1Ratio4.x1808_768,
                "1920:1080" => RequestVariant1Ratio4.x1920_1080,
                "1080:1920" => RequestVariant1Ratio4.x1080_1920,
                "2112:912" => RequestVariant1Ratio4.x2112_912,
                "1280:720" => RequestVariant1Ratio4.x1280_720,
                "720:1280" => RequestVariant1Ratio4.x720_1280,
                "720:720" => RequestVariant1Ratio4.x720_720,
                "960:720" => RequestVariant1Ratio4.x960_720,
                "720:960" => RequestVariant1Ratio4.x720_960,
                "1680:720" => RequestVariant1Ratio4.x1680_720,
                _ => null,
            };
        }
    }
}