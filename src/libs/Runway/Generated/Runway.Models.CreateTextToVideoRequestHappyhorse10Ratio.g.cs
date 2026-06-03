
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestHappyhorse10Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x1108_832,
        /// <summary>
        /// 
        /// </summary>
        x1248_1662,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1440_1440,
        /// <summary>
        /// 
        /// </summary>
        x1662_1248,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x832_1108,
        /// <summary>
        /// 
        /// </summary>
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestHappyhorse10RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestHappyhorse10Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestHappyhorse10Ratio.x1080_1920 => "1080:1920",
                CreateTextToVideoRequestHappyhorse10Ratio.x1108_832 => "1108:832",
                CreateTextToVideoRequestHappyhorse10Ratio.x1248_1662 => "1248:1662",
                CreateTextToVideoRequestHappyhorse10Ratio.x1280_720 => "1280:720",
                CreateTextToVideoRequestHappyhorse10Ratio.x1440_1440 => "1440:1440",
                CreateTextToVideoRequestHappyhorse10Ratio.x1662_1248 => "1662:1248",
                CreateTextToVideoRequestHappyhorse10Ratio.x1920_1080 => "1920:1080",
                CreateTextToVideoRequestHappyhorse10Ratio.x720_1280 => "720:1280",
                CreateTextToVideoRequestHappyhorse10Ratio.x832_1108 => "832:1108",
                CreateTextToVideoRequestHappyhorse10Ratio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestHappyhorse10Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateTextToVideoRequestHappyhorse10Ratio.x1080_1920,
                "1108:832" => CreateTextToVideoRequestHappyhorse10Ratio.x1108_832,
                "1248:1662" => CreateTextToVideoRequestHappyhorse10Ratio.x1248_1662,
                "1280:720" => CreateTextToVideoRequestHappyhorse10Ratio.x1280_720,
                "1440:1440" => CreateTextToVideoRequestHappyhorse10Ratio.x1440_1440,
                "1662:1248" => CreateTextToVideoRequestHappyhorse10Ratio.x1662_1248,
                "1920:1080" => CreateTextToVideoRequestHappyhorse10Ratio.x1920_1080,
                "720:1280" => CreateTextToVideoRequestHappyhorse10Ratio.x720_1280,
                "832:1108" => CreateTextToVideoRequestHappyhorse10Ratio.x832_1108,
                "960:960" => CreateTextToVideoRequestHappyhorse10Ratio.x960_960,
                _ => null,
            };
        }
    }
}