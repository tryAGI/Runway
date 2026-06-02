
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum CreateTextToImageRequestGeminiImage31FlashRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1024_256,
        /// <summary>
        /// 
        /// </summary>
        x1024_4096,
        /// <summary>
        /// 
        /// </summary>
        x11264_1408,
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
        x1408_11264,
        /// <summary>
        /// 
        /// </summary>
        x1408_176,
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
        x176_1408,
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
        x2048_512,
        /// <summary>
        /// 
        /// </summary>
        x2048_8192,
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
        x256_1024,
        /// <summary>
        /// 
        /// </summary>
        x2752_1536,
        /// <summary>
        /// 
        /// </summary>
        x2816_352,
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
        x352_2816,
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
        x384_672,
        /// <summary>
        /// 
        /// </summary>
        x4096_1024,
        /// <summary>
        /// 
        /// </summary>
        x4096_4096,
        /// <summary>
        /// 
        /// </summary>
        x416_624,
        /// <summary>
        /// 
        /// </summary>
        x432_592,
        /// <summary>
        /// 
        /// </summary>
        x448_576,
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
        x512_2048,
        /// <summary>
        /// 
        /// </summary>
        x512_512,
        /// <summary>
        /// 
        /// </summary>
        x5504_3072,
        /// <summary>
        /// 
        /// </summary>
        x5632_704,
        /// <summary>
        /// 
        /// </summary>
        x576_448,
        /// <summary>
        /// 
        /// </summary>
        x592_432,
        /// <summary>
        /// 
        /// </summary>
        x624_416,
        /// <summary>
        /// 
        /// </summary>
        x6336_2688,
        /// <summary>
        /// 
        /// </summary>
        x672_384,
        /// <summary>
        /// 
        /// </summary>
        x704_5632,
        /// <summary>
        /// 
        /// </summary>
        x768_1344,
        /// <summary>
        /// 
        /// </summary>
        x768_336,
        /// <summary>
        /// 
        /// </summary>
        x8192_2048,
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
    public static class CreateTextToImageRequestGeminiImage31FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGeminiImage31FlashRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGeminiImage31FlashRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1024_256 => "1024:256",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1024_4096 => "1024:4096",
                CreateTextToImageRequestGeminiImage31FlashRatio.x11264_1408 => "11264:1408",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1152_896 => "1152:896",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1184_864 => "1184:864",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1248_832 => "1248:832",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1344_768 => "1344:768",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1408_11264 => "1408:11264",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1408_176 => "1408:176",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1536_2752 => "1536:2752",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1536_672 => "1536:672",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1696_2528 => "1696:2528",
                CreateTextToImageRequestGeminiImage31FlashRatio.x176_1408 => "176:1408",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1792_2400 => "1792:2400",
                CreateTextToImageRequestGeminiImage31FlashRatio.x1856_2304 => "1856:2304",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2048_512 => "2048:512",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2048_8192 => "2048:8192",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2304_1856 => "2304:1856",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2400_1792 => "2400:1792",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2528_1696 => "2528:1696",
                CreateTextToImageRequestGeminiImage31FlashRatio.x256_1024 => "256:1024",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2752_1536 => "2752:1536",
                CreateTextToImageRequestGeminiImage31FlashRatio.x2816_352 => "2816:352",
                CreateTextToImageRequestGeminiImage31FlashRatio.x3072_5504 => "3072:5504",
                CreateTextToImageRequestGeminiImage31FlashRatio.x3168_1344 => "3168:1344",
                CreateTextToImageRequestGeminiImage31FlashRatio.x3392_5056 => "3392:5056",
                CreateTextToImageRequestGeminiImage31FlashRatio.x352_2816 => "352:2816",
                CreateTextToImageRequestGeminiImage31FlashRatio.x3584_4800 => "3584:4800",
                CreateTextToImageRequestGeminiImage31FlashRatio.x3712_4608 => "3712:4608",
                CreateTextToImageRequestGeminiImage31FlashRatio.x384_672 => "384:672",
                CreateTextToImageRequestGeminiImage31FlashRatio.x4096_1024 => "4096:1024",
                CreateTextToImageRequestGeminiImage31FlashRatio.x4096_4096 => "4096:4096",
                CreateTextToImageRequestGeminiImage31FlashRatio.x416_624 => "416:624",
                CreateTextToImageRequestGeminiImage31FlashRatio.x432_592 => "432:592",
                CreateTextToImageRequestGeminiImage31FlashRatio.x448_576 => "448:576",
                CreateTextToImageRequestGeminiImage31FlashRatio.x4608_3712 => "4608:3712",
                CreateTextToImageRequestGeminiImage31FlashRatio.x4800_3584 => "4800:3584",
                CreateTextToImageRequestGeminiImage31FlashRatio.x5056_3392 => "5056:3392",
                CreateTextToImageRequestGeminiImage31FlashRatio.x512_2048 => "512:2048",
                CreateTextToImageRequestGeminiImage31FlashRatio.x512_512 => "512:512",
                CreateTextToImageRequestGeminiImage31FlashRatio.x5504_3072 => "5504:3072",
                CreateTextToImageRequestGeminiImage31FlashRatio.x5632_704 => "5632:704",
                CreateTextToImageRequestGeminiImage31FlashRatio.x576_448 => "576:448",
                CreateTextToImageRequestGeminiImage31FlashRatio.x592_432 => "592:432",
                CreateTextToImageRequestGeminiImage31FlashRatio.x624_416 => "624:416",
                CreateTextToImageRequestGeminiImage31FlashRatio.x6336_2688 => "6336:2688",
                CreateTextToImageRequestGeminiImage31FlashRatio.x672_384 => "672:384",
                CreateTextToImageRequestGeminiImage31FlashRatio.x704_5632 => "704:5632",
                CreateTextToImageRequestGeminiImage31FlashRatio.x768_1344 => "768:1344",
                CreateTextToImageRequestGeminiImage31FlashRatio.x768_336 => "768:336",
                CreateTextToImageRequestGeminiImage31FlashRatio.x8192_2048 => "8192:2048",
                CreateTextToImageRequestGeminiImage31FlashRatio.x832_1248 => "832:1248",
                CreateTextToImageRequestGeminiImage31FlashRatio.x864_1184 => "864:1184",
                CreateTextToImageRequestGeminiImage31FlashRatio.x896_1152 => "896:1152",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGeminiImage31FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGeminiImage31FlashRatio.x1024_1024,
                "1024:256" => CreateTextToImageRequestGeminiImage31FlashRatio.x1024_256,
                "1024:4096" => CreateTextToImageRequestGeminiImage31FlashRatio.x1024_4096,
                "11264:1408" => CreateTextToImageRequestGeminiImage31FlashRatio.x11264_1408,
                "1152:896" => CreateTextToImageRequestGeminiImage31FlashRatio.x1152_896,
                "1184:864" => CreateTextToImageRequestGeminiImage31FlashRatio.x1184_864,
                "1248:832" => CreateTextToImageRequestGeminiImage31FlashRatio.x1248_832,
                "1344:768" => CreateTextToImageRequestGeminiImage31FlashRatio.x1344_768,
                "1408:11264" => CreateTextToImageRequestGeminiImage31FlashRatio.x1408_11264,
                "1408:176" => CreateTextToImageRequestGeminiImage31FlashRatio.x1408_176,
                "1536:2752" => CreateTextToImageRequestGeminiImage31FlashRatio.x1536_2752,
                "1536:672" => CreateTextToImageRequestGeminiImage31FlashRatio.x1536_672,
                "1696:2528" => CreateTextToImageRequestGeminiImage31FlashRatio.x1696_2528,
                "176:1408" => CreateTextToImageRequestGeminiImage31FlashRatio.x176_1408,
                "1792:2400" => CreateTextToImageRequestGeminiImage31FlashRatio.x1792_2400,
                "1856:2304" => CreateTextToImageRequestGeminiImage31FlashRatio.x1856_2304,
                "2048:2048" => CreateTextToImageRequestGeminiImage31FlashRatio.x2048_2048,
                "2048:512" => CreateTextToImageRequestGeminiImage31FlashRatio.x2048_512,
                "2048:8192" => CreateTextToImageRequestGeminiImage31FlashRatio.x2048_8192,
                "2304:1856" => CreateTextToImageRequestGeminiImage31FlashRatio.x2304_1856,
                "2400:1792" => CreateTextToImageRequestGeminiImage31FlashRatio.x2400_1792,
                "2528:1696" => CreateTextToImageRequestGeminiImage31FlashRatio.x2528_1696,
                "256:1024" => CreateTextToImageRequestGeminiImage31FlashRatio.x256_1024,
                "2752:1536" => CreateTextToImageRequestGeminiImage31FlashRatio.x2752_1536,
                "2816:352" => CreateTextToImageRequestGeminiImage31FlashRatio.x2816_352,
                "3072:5504" => CreateTextToImageRequestGeminiImage31FlashRatio.x3072_5504,
                "3168:1344" => CreateTextToImageRequestGeminiImage31FlashRatio.x3168_1344,
                "3392:5056" => CreateTextToImageRequestGeminiImage31FlashRatio.x3392_5056,
                "352:2816" => CreateTextToImageRequestGeminiImage31FlashRatio.x352_2816,
                "3584:4800" => CreateTextToImageRequestGeminiImage31FlashRatio.x3584_4800,
                "3712:4608" => CreateTextToImageRequestGeminiImage31FlashRatio.x3712_4608,
                "384:672" => CreateTextToImageRequestGeminiImage31FlashRatio.x384_672,
                "4096:1024" => CreateTextToImageRequestGeminiImage31FlashRatio.x4096_1024,
                "4096:4096" => CreateTextToImageRequestGeminiImage31FlashRatio.x4096_4096,
                "416:624" => CreateTextToImageRequestGeminiImage31FlashRatio.x416_624,
                "432:592" => CreateTextToImageRequestGeminiImage31FlashRatio.x432_592,
                "448:576" => CreateTextToImageRequestGeminiImage31FlashRatio.x448_576,
                "4608:3712" => CreateTextToImageRequestGeminiImage31FlashRatio.x4608_3712,
                "4800:3584" => CreateTextToImageRequestGeminiImage31FlashRatio.x4800_3584,
                "5056:3392" => CreateTextToImageRequestGeminiImage31FlashRatio.x5056_3392,
                "512:2048" => CreateTextToImageRequestGeminiImage31FlashRatio.x512_2048,
                "512:512" => CreateTextToImageRequestGeminiImage31FlashRatio.x512_512,
                "5504:3072" => CreateTextToImageRequestGeminiImage31FlashRatio.x5504_3072,
                "5632:704" => CreateTextToImageRequestGeminiImage31FlashRatio.x5632_704,
                "576:448" => CreateTextToImageRequestGeminiImage31FlashRatio.x576_448,
                "592:432" => CreateTextToImageRequestGeminiImage31FlashRatio.x592_432,
                "624:416" => CreateTextToImageRequestGeminiImage31FlashRatio.x624_416,
                "6336:2688" => CreateTextToImageRequestGeminiImage31FlashRatio.x6336_2688,
                "672:384" => CreateTextToImageRequestGeminiImage31FlashRatio.x672_384,
                "704:5632" => CreateTextToImageRequestGeminiImage31FlashRatio.x704_5632,
                "768:1344" => CreateTextToImageRequestGeminiImage31FlashRatio.x768_1344,
                "768:336" => CreateTextToImageRequestGeminiImage31FlashRatio.x768_336,
                "8192:2048" => CreateTextToImageRequestGeminiImage31FlashRatio.x8192_2048,
                "832:1248" => CreateTextToImageRequestGeminiImage31FlashRatio.x832_1248,
                "864:1184" => CreateTextToImageRequestGeminiImage31FlashRatio.x864_1184,
                "896:1152" => CreateTextToImageRequestGeminiImage31FlashRatio.x896_1152,
                _ => null,
            };
        }
    }
}