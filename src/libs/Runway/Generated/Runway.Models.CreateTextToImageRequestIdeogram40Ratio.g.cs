
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`.
    /// </summary>
    public enum CreateTextToImageRequestIdeogram40Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1280_3072,
        /// <summary>
        ///
        /// </summary>
        x1440_2560,
        /// <summary>
        ///
        /// </summary>
        x1664_2496,
        /// <summary>
        ///
        /// </summary>
        x1728_2304,
        /// <summary>
        ///
        /// </summary>
        x2048_2048,
        /// <summary>
        ///
        /// </summary>
        x2304_1728,
        /// <summary>
        ///
        /// </summary>
        x2496_1664,
        /// <summary>
        ///
        /// </summary>
        x2560_1440,
        /// <summary>
        ///
        /// </summary>
        x3072_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestIdeogram40RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestIdeogram40Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestIdeogram40Ratio.x1280_3072 => "1280:3072",
                CreateTextToImageRequestIdeogram40Ratio.x1440_2560 => "1440:2560",
                CreateTextToImageRequestIdeogram40Ratio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestIdeogram40Ratio.x1728_2304 => "1728:2304",
                CreateTextToImageRequestIdeogram40Ratio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestIdeogram40Ratio.x2304_1728 => "2304:1728",
                CreateTextToImageRequestIdeogram40Ratio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestIdeogram40Ratio.x2560_1440 => "2560:1440",
                CreateTextToImageRequestIdeogram40Ratio.x3072_1280 => "3072:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestIdeogram40Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1280:3072" => CreateTextToImageRequestIdeogram40Ratio.x1280_3072,
                "1440:2560" => CreateTextToImageRequestIdeogram40Ratio.x1440_2560,
                "1664:2496" => CreateTextToImageRequestIdeogram40Ratio.x1664_2496,
                "1728:2304" => CreateTextToImageRequestIdeogram40Ratio.x1728_2304,
                "2048:2048" => CreateTextToImageRequestIdeogram40Ratio.x2048_2048,
                "2304:1728" => CreateTextToImageRequestIdeogram40Ratio.x2304_1728,
                "2496:1664" => CreateTextToImageRequestIdeogram40Ratio.x2496_1664,
                "2560:1440" => CreateTextToImageRequestIdeogram40Ratio.x2560_1440,
                "3072:1280" => CreateTextToImageRequestIdeogram40Ratio.x3072_1280,
                _ => null,
            };
        }
    }
}