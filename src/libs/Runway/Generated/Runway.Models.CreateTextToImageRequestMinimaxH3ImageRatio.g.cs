
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 4K ratios cost more credits per image than 1K and 2K. Use `auto_1k`, `auto_2k` or `auto_4k` to pick a resolution tier and let the model choose the framing from the prompt.
    /// </summary>
    public enum CreateTextToImageRequestMinimaxH3ImageRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
        /// <summary>
        ///
        /// </summary>
        x1152_928,
        /// <summary>
        ///
        /// </summary>
        x1184_3552,
        /// <summary>
        ///
        /// </summary>
        x1184_896,
        /// <summary>
        ///
        /// </summary>
        x1248_832,
        /// <summary>
        ///
        /// </summary>
        x1344_3136,
        /// <summary>
        ///
        /// </summary>
        x1376_768,
        /// <summary>
        ///
        /// </summary>
        x1440_2912,
        /// <summary>
        ///
        /// </summary>
        x1440_736,
        /// <summary>
        ///
        /// </summary>
        x1536_2720,
        /// <summary>
        ///
        /// </summary>
        x1568_672,
        /// <summary>
        ///
        /// </summary>
        x1664_2496,
        /// <summary>
        ///
        /// </summary>
        x1760_2368,
        /// <summary>
        ///
        /// </summary>
        x1760_576,
        /// <summary>
        ///
        /// </summary>
        x1824_2304,
        /// <summary>
        ///
        /// </summary>
        x2048_2048,
        /// <summary>
        ///
        /// </summary>
        x2304_1824,
        /// <summary>
        ///
        /// </summary>
        x2368_1760,
        /// <summary>
        ///
        /// </summary>
        x2368_7104,
        /// <summary>
        ///
        /// </summary>
        x2496_1664,
        /// <summary>
        ///
        /// </summary>
        x2688_6272,
        /// <summary>
        ///
        /// </summary>
        x2720_1536,
        /// <summary>
        ///
        /// </summary>
        x2912_1440,
        /// <summary>
        ///
        /// </summary>
        x2912_5792,
        /// <summary>
        ///
        /// </summary>
        x3072_5472,
        /// <summary>
        ///
        /// </summary>
        x3136_1344,
        /// <summary>
        ///
        /// </summary>
        x3360_5024,
        /// <summary>
        ///
        /// </summary>
        x3552_1184,
        /// <summary>
        ///
        /// </summary>
        x3552_4736,
        /// <summary>
        ///
        /// </summary>
        x3648_4576,
        /// <summary>
        ///
        /// </summary>
        x4096_4096,
        /// <summary>
        ///
        /// </summary>
        x4576_3648,
        /// <summary>
        ///
        /// </summary>
        x4736_3552,
        /// <summary>
        ///
        /// </summary>
        x5024_3360,
        /// <summary>
        ///
        /// </summary>
        x5472_3072,
        /// <summary>
        ///
        /// </summary>
        x576_1760,
        /// <summary>
        ///
        /// </summary>
        x5792_2912,
        /// <summary>
        ///
        /// </summary>
        x6272_2688,
        /// <summary>
        ///
        /// </summary>
        x672_1568,
        /// <summary>
        ///
        /// </summary>
        x7104_2368,
        /// <summary>
        ///
        /// </summary>
        x736_1440,
        /// <summary>
        ///
        /// </summary>
        x768_1376,
        /// <summary>
        ///
        /// </summary>
        x832_1248,
        /// <summary>
        ///
        /// </summary>
        x896_1184,
        /// <summary>
        ///
        /// </summary>
        x928_1152,
        /// <summary>
        /// &lt;height&gt;`. 4K ratios cost more credits per image than 1K and 2K. Use `auto_1k`, `auto_2k` or `auto_4k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        Auto1k,
        /// <summary>
        /// &lt;height&gt;`. 4K ratios cost more credits per image than 1K and 2K. Use `auto_1k`, `auto_2k` or `auto_4k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        Auto2k,
        /// <summary>
        /// &lt;height&gt;`. 4K ratios cost more credits per image than 1K and 2K. Use `auto_1k`, `auto_2k` or `auto_4k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        Auto4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestMinimaxH3ImageRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestMinimaxH3ImageRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestMinimaxH3ImageRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1152_928 => "1152:928",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1184_3552 => "1184:3552",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1184_896 => "1184:896",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1248_832 => "1248:832",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1344_3136 => "1344:3136",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1376_768 => "1376:768",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1440_2912 => "1440:2912",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1440_736 => "1440:736",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1536_2720 => "1536:2720",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1568_672 => "1568:672",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1760_2368 => "1760:2368",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1760_576 => "1760:576",
                CreateTextToImageRequestMinimaxH3ImageRatio.x1824_2304 => "1824:2304",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2304_1824 => "2304:1824",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2368_1760 => "2368:1760",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2368_7104 => "2368:7104",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2688_6272 => "2688:6272",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2720_1536 => "2720:1536",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2912_1440 => "2912:1440",
                CreateTextToImageRequestMinimaxH3ImageRatio.x2912_5792 => "2912:5792",
                CreateTextToImageRequestMinimaxH3ImageRatio.x3072_5472 => "3072:5472",
                CreateTextToImageRequestMinimaxH3ImageRatio.x3136_1344 => "3136:1344",
                CreateTextToImageRequestMinimaxH3ImageRatio.x3360_5024 => "3360:5024",
                CreateTextToImageRequestMinimaxH3ImageRatio.x3552_1184 => "3552:1184",
                CreateTextToImageRequestMinimaxH3ImageRatio.x3552_4736 => "3552:4736",
                CreateTextToImageRequestMinimaxH3ImageRatio.x3648_4576 => "3648:4576",
                CreateTextToImageRequestMinimaxH3ImageRatio.x4096_4096 => "4096:4096",
                CreateTextToImageRequestMinimaxH3ImageRatio.x4576_3648 => "4576:3648",
                CreateTextToImageRequestMinimaxH3ImageRatio.x4736_3552 => "4736:3552",
                CreateTextToImageRequestMinimaxH3ImageRatio.x5024_3360 => "5024:3360",
                CreateTextToImageRequestMinimaxH3ImageRatio.x5472_3072 => "5472:3072",
                CreateTextToImageRequestMinimaxH3ImageRatio.x576_1760 => "576:1760",
                CreateTextToImageRequestMinimaxH3ImageRatio.x5792_2912 => "5792:2912",
                CreateTextToImageRequestMinimaxH3ImageRatio.x6272_2688 => "6272:2688",
                CreateTextToImageRequestMinimaxH3ImageRatio.x672_1568 => "672:1568",
                CreateTextToImageRequestMinimaxH3ImageRatio.x7104_2368 => "7104:2368",
                CreateTextToImageRequestMinimaxH3ImageRatio.x736_1440 => "736:1440",
                CreateTextToImageRequestMinimaxH3ImageRatio.x768_1376 => "768:1376",
                CreateTextToImageRequestMinimaxH3ImageRatio.x832_1248 => "832:1248",
                CreateTextToImageRequestMinimaxH3ImageRatio.x896_1184 => "896:1184",
                CreateTextToImageRequestMinimaxH3ImageRatio.x928_1152 => "928:1152",
                CreateTextToImageRequestMinimaxH3ImageRatio.Auto1k => "auto_1k",
                CreateTextToImageRequestMinimaxH3ImageRatio.Auto2k => "auto_2k",
                CreateTextToImageRequestMinimaxH3ImageRatio.Auto4k => "auto_4k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestMinimaxH3ImageRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestMinimaxH3ImageRatio.x1024_1024,
                "1152:928" => CreateTextToImageRequestMinimaxH3ImageRatio.x1152_928,
                "1184:3552" => CreateTextToImageRequestMinimaxH3ImageRatio.x1184_3552,
                "1184:896" => CreateTextToImageRequestMinimaxH3ImageRatio.x1184_896,
                "1248:832" => CreateTextToImageRequestMinimaxH3ImageRatio.x1248_832,
                "1344:3136" => CreateTextToImageRequestMinimaxH3ImageRatio.x1344_3136,
                "1376:768" => CreateTextToImageRequestMinimaxH3ImageRatio.x1376_768,
                "1440:2912" => CreateTextToImageRequestMinimaxH3ImageRatio.x1440_2912,
                "1440:736" => CreateTextToImageRequestMinimaxH3ImageRatio.x1440_736,
                "1536:2720" => CreateTextToImageRequestMinimaxH3ImageRatio.x1536_2720,
                "1568:672" => CreateTextToImageRequestMinimaxH3ImageRatio.x1568_672,
                "1664:2496" => CreateTextToImageRequestMinimaxH3ImageRatio.x1664_2496,
                "1760:2368" => CreateTextToImageRequestMinimaxH3ImageRatio.x1760_2368,
                "1760:576" => CreateTextToImageRequestMinimaxH3ImageRatio.x1760_576,
                "1824:2304" => CreateTextToImageRequestMinimaxH3ImageRatio.x1824_2304,
                "2048:2048" => CreateTextToImageRequestMinimaxH3ImageRatio.x2048_2048,
                "2304:1824" => CreateTextToImageRequestMinimaxH3ImageRatio.x2304_1824,
                "2368:1760" => CreateTextToImageRequestMinimaxH3ImageRatio.x2368_1760,
                "2368:7104" => CreateTextToImageRequestMinimaxH3ImageRatio.x2368_7104,
                "2496:1664" => CreateTextToImageRequestMinimaxH3ImageRatio.x2496_1664,
                "2688:6272" => CreateTextToImageRequestMinimaxH3ImageRatio.x2688_6272,
                "2720:1536" => CreateTextToImageRequestMinimaxH3ImageRatio.x2720_1536,
                "2912:1440" => CreateTextToImageRequestMinimaxH3ImageRatio.x2912_1440,
                "2912:5792" => CreateTextToImageRequestMinimaxH3ImageRatio.x2912_5792,
                "3072:5472" => CreateTextToImageRequestMinimaxH3ImageRatio.x3072_5472,
                "3136:1344" => CreateTextToImageRequestMinimaxH3ImageRatio.x3136_1344,
                "3360:5024" => CreateTextToImageRequestMinimaxH3ImageRatio.x3360_5024,
                "3552:1184" => CreateTextToImageRequestMinimaxH3ImageRatio.x3552_1184,
                "3552:4736" => CreateTextToImageRequestMinimaxH3ImageRatio.x3552_4736,
                "3648:4576" => CreateTextToImageRequestMinimaxH3ImageRatio.x3648_4576,
                "4096:4096" => CreateTextToImageRequestMinimaxH3ImageRatio.x4096_4096,
                "4576:3648" => CreateTextToImageRequestMinimaxH3ImageRatio.x4576_3648,
                "4736:3552" => CreateTextToImageRequestMinimaxH3ImageRatio.x4736_3552,
                "5024:3360" => CreateTextToImageRequestMinimaxH3ImageRatio.x5024_3360,
                "5472:3072" => CreateTextToImageRequestMinimaxH3ImageRatio.x5472_3072,
                "576:1760" => CreateTextToImageRequestMinimaxH3ImageRatio.x576_1760,
                "5792:2912" => CreateTextToImageRequestMinimaxH3ImageRatio.x5792_2912,
                "6272:2688" => CreateTextToImageRequestMinimaxH3ImageRatio.x6272_2688,
                "672:1568" => CreateTextToImageRequestMinimaxH3ImageRatio.x672_1568,
                "7104:2368" => CreateTextToImageRequestMinimaxH3ImageRatio.x7104_2368,
                "736:1440" => CreateTextToImageRequestMinimaxH3ImageRatio.x736_1440,
                "768:1376" => CreateTextToImageRequestMinimaxH3ImageRatio.x768_1376,
                "832:1248" => CreateTextToImageRequestMinimaxH3ImageRatio.x832_1248,
                "896:1184" => CreateTextToImageRequestMinimaxH3ImageRatio.x896_1184,
                "928:1152" => CreateTextToImageRequestMinimaxH3ImageRatio.x928_1152,
                "auto_1k" => CreateTextToImageRequestMinimaxH3ImageRatio.Auto1k,
                "auto_2k" => CreateTextToImageRequestMinimaxH3ImageRatio.Auto2k,
                "auto_4k" => CreateTextToImageRequestMinimaxH3ImageRatio.Auto4k,
                _ => null,
            };
        }
    }
}