
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k`, `auto_1.5k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
    /// </summary>
    public enum CreateTextToImageRequestSeedream55Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
        /// <summary>
        ///
        /// </summary>
        x1152_2048,
        /// <summary>
        ///
        /// </summary>
        x1152_864,
        /// <summary>
        ///
        /// </summary>
        x1248_1872,
        /// <summary>
        ///
        /// </summary>
        x1248_832,
        /// <summary>
        ///
        /// </summary>
        x1344_1792,
        /// <summary>
        ///
        /// </summary>
        x1424_800,
        /// <summary>
        ///
        /// </summary>
        x1536_1536,
        /// <summary>
        ///
        /// </summary>
        x1568_672,
        /// <summary>
        ///
        /// </summary>
        x1584_2816,
        /// <summary>
        ///
        /// </summary>
        x1664_2496,
        /// <summary>
        ///
        /// </summary>
        x1776_2368,
        /// <summary>
        ///
        /// </summary>
        x1792_1344,
        /// <summary>
        ///
        /// </summary>
        x1872_1248,
        /// <summary>
        ///
        /// </summary>
        x2048_1152,
        /// <summary>
        ///
        /// </summary>
        x2048_2048,
        /// <summary>
        ///
        /// </summary>
        x2352_1008,
        /// <summary>
        ///
        /// </summary>
        x2368_1776,
        /// <summary>
        ///
        /// </summary>
        x2496_1664,
        /// <summary>
        ///
        /// </summary>
        x2816_1584,
        /// <summary>
        ///
        /// </summary>
        x3136_1344,
        /// <summary>
        ///
        /// </summary>
        x800_1424,
        /// <summary>
        ///
        /// </summary>
        x832_1248,
        /// <summary>
        ///
        /// </summary>
        x864_1152,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_1k`, `auto_1.5k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto15k,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_1k`, `auto_1.5k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto1k,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_1k`, `auto_1.5k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream55RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream55Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream55Ratio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestSeedream55Ratio.x1152_2048 => "1152:2048",
                CreateTextToImageRequestSeedream55Ratio.x1152_864 => "1152:864",
                CreateTextToImageRequestSeedream55Ratio.x1248_1872 => "1248:1872",
                CreateTextToImageRequestSeedream55Ratio.x1248_832 => "1248:832",
                CreateTextToImageRequestSeedream55Ratio.x1344_1792 => "1344:1792",
                CreateTextToImageRequestSeedream55Ratio.x1424_800 => "1424:800",
                CreateTextToImageRequestSeedream55Ratio.x1536_1536 => "1536:1536",
                CreateTextToImageRequestSeedream55Ratio.x1568_672 => "1568:672",
                CreateTextToImageRequestSeedream55Ratio.x1584_2816 => "1584:2816",
                CreateTextToImageRequestSeedream55Ratio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestSeedream55Ratio.x1776_2368 => "1776:2368",
                CreateTextToImageRequestSeedream55Ratio.x1792_1344 => "1792:1344",
                CreateTextToImageRequestSeedream55Ratio.x1872_1248 => "1872:1248",
                CreateTextToImageRequestSeedream55Ratio.x2048_1152 => "2048:1152",
                CreateTextToImageRequestSeedream55Ratio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestSeedream55Ratio.x2352_1008 => "2352:1008",
                CreateTextToImageRequestSeedream55Ratio.x2368_1776 => "2368:1776",
                CreateTextToImageRequestSeedream55Ratio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestSeedream55Ratio.x2816_1584 => "2816:1584",
                CreateTextToImageRequestSeedream55Ratio.x3136_1344 => "3136:1344",
                CreateTextToImageRequestSeedream55Ratio.x800_1424 => "800:1424",
                CreateTextToImageRequestSeedream55Ratio.x832_1248 => "832:1248",
                CreateTextToImageRequestSeedream55Ratio.x864_1152 => "864:1152",
                CreateTextToImageRequestSeedream55Ratio.Auto15k => "auto_1.5k",
                CreateTextToImageRequestSeedream55Ratio.Auto1k => "auto_1k",
                CreateTextToImageRequestSeedream55Ratio.Auto2k => "auto_2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream55Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestSeedream55Ratio.x1024_1024,
                "1152:2048" => CreateTextToImageRequestSeedream55Ratio.x1152_2048,
                "1152:864" => CreateTextToImageRequestSeedream55Ratio.x1152_864,
                "1248:1872" => CreateTextToImageRequestSeedream55Ratio.x1248_1872,
                "1248:832" => CreateTextToImageRequestSeedream55Ratio.x1248_832,
                "1344:1792" => CreateTextToImageRequestSeedream55Ratio.x1344_1792,
                "1424:800" => CreateTextToImageRequestSeedream55Ratio.x1424_800,
                "1536:1536" => CreateTextToImageRequestSeedream55Ratio.x1536_1536,
                "1568:672" => CreateTextToImageRequestSeedream55Ratio.x1568_672,
                "1584:2816" => CreateTextToImageRequestSeedream55Ratio.x1584_2816,
                "1664:2496" => CreateTextToImageRequestSeedream55Ratio.x1664_2496,
                "1776:2368" => CreateTextToImageRequestSeedream55Ratio.x1776_2368,
                "1792:1344" => CreateTextToImageRequestSeedream55Ratio.x1792_1344,
                "1872:1248" => CreateTextToImageRequestSeedream55Ratio.x1872_1248,
                "2048:1152" => CreateTextToImageRequestSeedream55Ratio.x2048_1152,
                "2048:2048" => CreateTextToImageRequestSeedream55Ratio.x2048_2048,
                "2352:1008" => CreateTextToImageRequestSeedream55Ratio.x2352_1008,
                "2368:1776" => CreateTextToImageRequestSeedream55Ratio.x2368_1776,
                "2496:1664" => CreateTextToImageRequestSeedream55Ratio.x2496_1664,
                "2816:1584" => CreateTextToImageRequestSeedream55Ratio.x2816_1584,
                "3136:1344" => CreateTextToImageRequestSeedream55Ratio.x3136_1344,
                "800:1424" => CreateTextToImageRequestSeedream55Ratio.x800_1424,
                "832:1248" => CreateTextToImageRequestSeedream55Ratio.x832_1248,
                "864:1152" => CreateTextToImageRequestSeedream55Ratio.x864_1152,
                "auto_1.5k" => CreateTextToImageRequestSeedream55Ratio.Auto15k,
                "auto_1k" => CreateTextToImageRequestSeedream55Ratio.Auto1k,
                "auto_2k" => CreateTextToImageRequestSeedream55Ratio.Auto2k,
                _ => null,
            };
        }
    }
}