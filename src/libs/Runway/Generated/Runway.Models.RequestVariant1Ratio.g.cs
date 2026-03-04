
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum RequestVariant1Ratio
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
        x1104_832,
        /// <summary>
        /// 
        /// </summary>
        x832_1104,
        /// <summary>
        /// 
        /// </summary>
        x960_960,
        /// <summary>
        /// 
        /// </summary>
        x1584_672,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant1RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant1Ratio value)
        {
            return value switch
            {
                RequestVariant1Ratio.x1280_720 => "1280:720",
                RequestVariant1Ratio.x720_1280 => "720:1280",
                RequestVariant1Ratio.x1104_832 => "1104:832",
                RequestVariant1Ratio.x832_1104 => "832:1104",
                RequestVariant1Ratio.x960_960 => "960:960",
                RequestVariant1Ratio.x1584_672 => "1584:672",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant1Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestVariant1Ratio.x1280_720,
                "720:1280" => RequestVariant1Ratio.x720_1280,
                "1104:832" => RequestVariant1Ratio.x1104_832,
                "832:1104" => RequestVariant1Ratio.x832_1104,
                "960:960" => RequestVariant1Ratio.x960_960,
                "1584:672" => RequestVariant1Ratio.x1584_672,
                _ => null,
            };
        }
    }
}