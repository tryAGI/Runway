
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum CreateTextToImageRequestGeminiImage3ProRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1152_896,
        /// <summary>
        /// 
        /// </summary>
        x1184_864,
        /// <summary>
        /// 
        /// </summary>
        x1248_832,
        /// <summary>
        /// 
        /// </summary>
        x1344_768,
        /// <summary>
        /// 
        /// </summary>
        x1536_2752,
        /// <summary>
        /// 
        /// </summary>
        x1536_672,
        /// <summary>
        /// 
        /// </summary>
        x1696_2528,
        /// <summary>
        /// 
        /// </summary>
        x1792_2400,
        /// <summary>
        /// 
        /// </summary>
        x1856_2304,
        /// <summary>
        /// 
        /// </summary>
        x2048_2048,
        /// <summary>
        /// 
        /// </summary>
        x2304_1856,
        /// <summary>
        /// 
        /// </summary>
        x2400_1792,
        /// <summary>
        /// 
        /// </summary>
        x2528_1696,
        /// <summary>
        /// 
        /// </summary>
        x2752_1536,
        /// <summary>
        /// 
        /// </summary>
        x3072_5504,
        /// <summary>
        /// 
        /// </summary>
        x3168_1344,
        /// <summary>
        /// 
        /// </summary>
        x3392_5056,
        /// <summary>
        /// 
        /// </summary>
        x3584_4800,
        /// <summary>
        /// 
        /// </summary>
        x3712_4608,
        /// <summary>
        /// 
        /// </summary>
        x4096_4096,
        /// <summary>
        /// 
        /// </summary>
        x4608_3712,
        /// <summary>
        /// 
        /// </summary>
        x4800_3584,
        /// <summary>
        /// 
        /// </summary>
        x5056_3392,
        /// <summary>
        /// 
        /// </summary>
        x5504_3072,
        /// <summary>
        /// 
        /// </summary>
        x6336_2688,
        /// <summary>
        /// 
        /// </summary>
        x768_1344,
        /// <summary>
        /// 
        /// </summary>
        x832_1248,
        /// <summary>
        /// 
        /// </summary>
        x864_1184,
        /// <summary>
        /// 
        /// </summary>
        x896_1152,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGeminiImage3ProRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGeminiImage3ProRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGeminiImage3ProRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGeminiImage3ProRatio.x1152_896 => "1152:896",
                CreateTextToImageRequestGeminiImage3ProRatio.x1184_864 => "1184:864",
                CreateTextToImageRequestGeminiImage3ProRatio.x1248_832 => "1248:832",
                CreateTextToImageRequestGeminiImage3ProRatio.x1344_768 => "1344:768",
                CreateTextToImageRequestGeminiImage3ProRatio.x1536_2752 => "1536:2752",
                CreateTextToImageRequestGeminiImage3ProRatio.x1536_672 => "1536:672",
                CreateTextToImageRequestGeminiImage3ProRatio.x1696_2528 => "1696:2528",
                CreateTextToImageRequestGeminiImage3ProRatio.x1792_2400 => "1792:2400",
                CreateTextToImageRequestGeminiImage3ProRatio.x1856_2304 => "1856:2304",
                CreateTextToImageRequestGeminiImage3ProRatio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestGeminiImage3ProRatio.x2304_1856 => "2304:1856",
                CreateTextToImageRequestGeminiImage3ProRatio.x2400_1792 => "2400:1792",
                CreateTextToImageRequestGeminiImage3ProRatio.x2528_1696 => "2528:1696",
                CreateTextToImageRequestGeminiImage3ProRatio.x2752_1536 => "2752:1536",
                CreateTextToImageRequestGeminiImage3ProRatio.x3072_5504 => "3072:5504",
                CreateTextToImageRequestGeminiImage3ProRatio.x3168_1344 => "3168:1344",
                CreateTextToImageRequestGeminiImage3ProRatio.x3392_5056 => "3392:5056",
                CreateTextToImageRequestGeminiImage3ProRatio.x3584_4800 => "3584:4800",
                CreateTextToImageRequestGeminiImage3ProRatio.x3712_4608 => "3712:4608",
                CreateTextToImageRequestGeminiImage3ProRatio.x4096_4096 => "4096:4096",
                CreateTextToImageRequestGeminiImage3ProRatio.x4608_3712 => "4608:3712",
                CreateTextToImageRequestGeminiImage3ProRatio.x4800_3584 => "4800:3584",
                CreateTextToImageRequestGeminiImage3ProRatio.x5056_3392 => "5056:3392",
                CreateTextToImageRequestGeminiImage3ProRatio.x5504_3072 => "5504:3072",
                CreateTextToImageRequestGeminiImage3ProRatio.x6336_2688 => "6336:2688",
                CreateTextToImageRequestGeminiImage3ProRatio.x768_1344 => "768:1344",
                CreateTextToImageRequestGeminiImage3ProRatio.x832_1248 => "832:1248",
                CreateTextToImageRequestGeminiImage3ProRatio.x864_1184 => "864:1184",
                CreateTextToImageRequestGeminiImage3ProRatio.x896_1152 => "896:1152",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGeminiImage3ProRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGeminiImage3ProRatio.x1024_1024,
                "1152:896" => CreateTextToImageRequestGeminiImage3ProRatio.x1152_896,
                "1184:864" => CreateTextToImageRequestGeminiImage3ProRatio.x1184_864,
                "1248:832" => CreateTextToImageRequestGeminiImage3ProRatio.x1248_832,
                "1344:768" => CreateTextToImageRequestGeminiImage3ProRatio.x1344_768,
                "1536:2752" => CreateTextToImageRequestGeminiImage3ProRatio.x1536_2752,
                "1536:672" => CreateTextToImageRequestGeminiImage3ProRatio.x1536_672,
                "1696:2528" => CreateTextToImageRequestGeminiImage3ProRatio.x1696_2528,
                "1792:2400" => CreateTextToImageRequestGeminiImage3ProRatio.x1792_2400,
                "1856:2304" => CreateTextToImageRequestGeminiImage3ProRatio.x1856_2304,
                "2048:2048" => CreateTextToImageRequestGeminiImage3ProRatio.x2048_2048,
                "2304:1856" => CreateTextToImageRequestGeminiImage3ProRatio.x2304_1856,
                "2400:1792" => CreateTextToImageRequestGeminiImage3ProRatio.x2400_1792,
                "2528:1696" => CreateTextToImageRequestGeminiImage3ProRatio.x2528_1696,
                "2752:1536" => CreateTextToImageRequestGeminiImage3ProRatio.x2752_1536,
                "3072:5504" => CreateTextToImageRequestGeminiImage3ProRatio.x3072_5504,
                "3168:1344" => CreateTextToImageRequestGeminiImage3ProRatio.x3168_1344,
                "3392:5056" => CreateTextToImageRequestGeminiImage3ProRatio.x3392_5056,
                "3584:4800" => CreateTextToImageRequestGeminiImage3ProRatio.x3584_4800,
                "3712:4608" => CreateTextToImageRequestGeminiImage3ProRatio.x3712_4608,
                "4096:4096" => CreateTextToImageRequestGeminiImage3ProRatio.x4096_4096,
                "4608:3712" => CreateTextToImageRequestGeminiImage3ProRatio.x4608_3712,
                "4800:3584" => CreateTextToImageRequestGeminiImage3ProRatio.x4800_3584,
                "5056:3392" => CreateTextToImageRequestGeminiImage3ProRatio.x5056_3392,
                "5504:3072" => CreateTextToImageRequestGeminiImage3ProRatio.x5504_3072,
                "6336:2688" => CreateTextToImageRequestGeminiImage3ProRatio.x6336_2688,
                "768:1344" => CreateTextToImageRequestGeminiImage3ProRatio.x768_1344,
                "832:1248" => CreateTextToImageRequestGeminiImage3ProRatio.x832_1248,
                "864:1184" => CreateTextToImageRequestGeminiImage3ProRatio.x864_1184,
                "896:1152" => CreateTextToImageRequestGeminiImage3ProRatio.x896_1152,
                _ => null,
            };
        }
    }
}