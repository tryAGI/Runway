
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum RequestVariant1Ratio3
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
        x960_960,
        /// <summary>
        /// 
        /// </summary>
        x832_1104,
        /// <summary>
        /// 
        /// </summary>
        x1584_672,
        /// <summary>
        /// 
        /// </summary>
        x848_480,
        /// <summary>
        /// 
        /// </summary>
        x640_480,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVariant1Ratio3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVariant1Ratio3 value)
        {
            return value switch
            {
                RequestVariant1Ratio3.x1280_720 => "1280:720",
                RequestVariant1Ratio3.x720_1280 => "720:1280",
                RequestVariant1Ratio3.x1104_832 => "1104:832",
                RequestVariant1Ratio3.x960_960 => "960:960",
                RequestVariant1Ratio3.x832_1104 => "832:1104",
                RequestVariant1Ratio3.x1584_672 => "1584:672",
                RequestVariant1Ratio3.x848_480 => "848:480",
                RequestVariant1Ratio3.x640_480 => "640:480",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVariant1Ratio3? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestVariant1Ratio3.x1280_720,
                "720:1280" => RequestVariant1Ratio3.x720_1280,
                "1104:832" => RequestVariant1Ratio3.x1104_832,
                "960:960" => RequestVariant1Ratio3.x960_960,
                "832:1104" => RequestVariant1Ratio3.x832_1104,
                "1584:672" => RequestVariant1Ratio3.x1584_672,
                "848:480" => RequestVariant1Ratio3.x848_480,
                "640:480" => RequestVariant1Ratio3.x640_480,
                _ => null,
            };
        }
    }
}