
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5LiteRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1600_2848,
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
        x2304_4096,
        /// <summary>
        /// 
        /// </summary>
        x2496_1664,
        /// <summary>
        /// 
        /// </summary>
        x2496_3744,
        /// <summary>
        /// 
        /// </summary>
        x2592_3456,
        /// <summary>
        /// 
        /// </summary>
        x2848_1600,
        /// <summary>
        /// 
        /// </summary>
        x3072_3072,
        /// <summary>
        /// 
        /// </summary>
        x3136_1344,
        /// <summary>
        /// 
        /// </summary>
        x3456_2592,
        /// <summary>
        /// 
        /// </summary>
        x3744_2496,
        /// <summary>
        /// 
        /// </summary>
        x4096_2304,
        /// <summary>
        /// 
        /// </summary>
        x4704_2016,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream5LiteRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5LiteRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5LiteRatio.x1600_2848 => "1600:2848",
                CreateTextToImageRequestSeedream5LiteRatio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestSeedream5LiteRatio.x1728_2304 => "1728:2304",
                CreateTextToImageRequestSeedream5LiteRatio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestSeedream5LiteRatio.x2304_1728 => "2304:1728",
                CreateTextToImageRequestSeedream5LiteRatio.x2304_4096 => "2304:4096",
                CreateTextToImageRequestSeedream5LiteRatio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestSeedream5LiteRatio.x2496_3744 => "2496:3744",
                CreateTextToImageRequestSeedream5LiteRatio.x2592_3456 => "2592:3456",
                CreateTextToImageRequestSeedream5LiteRatio.x2848_1600 => "2848:1600",
                CreateTextToImageRequestSeedream5LiteRatio.x3072_3072 => "3072:3072",
                CreateTextToImageRequestSeedream5LiteRatio.x3136_1344 => "3136:1344",
                CreateTextToImageRequestSeedream5LiteRatio.x3456_2592 => "3456:2592",
                CreateTextToImageRequestSeedream5LiteRatio.x3744_2496 => "3744:2496",
                CreateTextToImageRequestSeedream5LiteRatio.x4096_2304 => "4096:2304",
                CreateTextToImageRequestSeedream5LiteRatio.x4704_2016 => "4704:2016",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5LiteRatio? ToEnum(string value)
        {
            return value switch
            {
                "1600:2848" => CreateTextToImageRequestSeedream5LiteRatio.x1600_2848,
                "1664:2496" => CreateTextToImageRequestSeedream5LiteRatio.x1664_2496,
                "1728:2304" => CreateTextToImageRequestSeedream5LiteRatio.x1728_2304,
                "2048:2048" => CreateTextToImageRequestSeedream5LiteRatio.x2048_2048,
                "2304:1728" => CreateTextToImageRequestSeedream5LiteRatio.x2304_1728,
                "2304:4096" => CreateTextToImageRequestSeedream5LiteRatio.x2304_4096,
                "2496:1664" => CreateTextToImageRequestSeedream5LiteRatio.x2496_1664,
                "2496:3744" => CreateTextToImageRequestSeedream5LiteRatio.x2496_3744,
                "2592:3456" => CreateTextToImageRequestSeedream5LiteRatio.x2592_3456,
                "2848:1600" => CreateTextToImageRequestSeedream5LiteRatio.x2848_1600,
                "3072:3072" => CreateTextToImageRequestSeedream5LiteRatio.x3072_3072,
                "3136:1344" => CreateTextToImageRequestSeedream5LiteRatio.x3136_1344,
                "3456:2592" => CreateTextToImageRequestSeedream5LiteRatio.x3456_2592,
                "3744:2496" => CreateTextToImageRequestSeedream5LiteRatio.x3744_2496,
                "4096:2304" => CreateTextToImageRequestSeedream5LiteRatio.x4096_2304,
                "4704:2016" => CreateTextToImageRequestSeedream5LiteRatio.x4704_2016,
                _ => null,
            };
        }
    }
}