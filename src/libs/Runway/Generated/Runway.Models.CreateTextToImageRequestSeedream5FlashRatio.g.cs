
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5FlashRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
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
        x1376_768,
        /// <summary>
        ///
        /// </summary>
        x1568_672,
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
        x2496_1664,
        /// <summary>
        ///
        /// </summary>
        x2848_1600,
        /// <summary>
        ///
        /// </summary>
        x3136_1344,
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
        /// &lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto1k,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream5FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5FlashRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5FlashRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestSeedream5FlashRatio.x1184_896 => "1184:896",
                CreateTextToImageRequestSeedream5FlashRatio.x1248_832 => "1248:832",
                CreateTextToImageRequestSeedream5FlashRatio.x1376_768 => "1376:768",
                CreateTextToImageRequestSeedream5FlashRatio.x1568_672 => "1568:672",
                CreateTextToImageRequestSeedream5FlashRatio.x1600_2848 => "1600:2848",
                CreateTextToImageRequestSeedream5FlashRatio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestSeedream5FlashRatio.x1728_2304 => "1728:2304",
                CreateTextToImageRequestSeedream5FlashRatio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestSeedream5FlashRatio.x2304_1728 => "2304:1728",
                CreateTextToImageRequestSeedream5FlashRatio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestSeedream5FlashRatio.x2848_1600 => "2848:1600",
                CreateTextToImageRequestSeedream5FlashRatio.x3136_1344 => "3136:1344",
                CreateTextToImageRequestSeedream5FlashRatio.x768_1376 => "768:1376",
                CreateTextToImageRequestSeedream5FlashRatio.x832_1248 => "832:1248",
                CreateTextToImageRequestSeedream5FlashRatio.x896_1184 => "896:1184",
                CreateTextToImageRequestSeedream5FlashRatio.Auto1k => "auto_1k",
                CreateTextToImageRequestSeedream5FlashRatio.Auto2k => "auto_2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestSeedream5FlashRatio.x1024_1024,
                "1184:896" => CreateTextToImageRequestSeedream5FlashRatio.x1184_896,
                "1248:832" => CreateTextToImageRequestSeedream5FlashRatio.x1248_832,
                "1376:768" => CreateTextToImageRequestSeedream5FlashRatio.x1376_768,
                "1568:672" => CreateTextToImageRequestSeedream5FlashRatio.x1568_672,
                "1600:2848" => CreateTextToImageRequestSeedream5FlashRatio.x1600_2848,
                "1664:2496" => CreateTextToImageRequestSeedream5FlashRatio.x1664_2496,
                "1728:2304" => CreateTextToImageRequestSeedream5FlashRatio.x1728_2304,
                "2048:2048" => CreateTextToImageRequestSeedream5FlashRatio.x2048_2048,
                "2304:1728" => CreateTextToImageRequestSeedream5FlashRatio.x2304_1728,
                "2496:1664" => CreateTextToImageRequestSeedream5FlashRatio.x2496_1664,
                "2848:1600" => CreateTextToImageRequestSeedream5FlashRatio.x2848_1600,
                "3136:1344" => CreateTextToImageRequestSeedream5FlashRatio.x3136_1344,
                "768:1376" => CreateTextToImageRequestSeedream5FlashRatio.x768_1376,
                "832:1248" => CreateTextToImageRequestSeedream5FlashRatio.x832_1248,
                "896:1184" => CreateTextToImageRequestSeedream5FlashRatio.x896_1184,
                "auto_1k" => CreateTextToImageRequestSeedream5FlashRatio.Auto1k,
                "auto_2k" => CreateTextToImageRequestSeedream5FlashRatio.Auto2k,
                _ => null,
            };
        }
    }
}