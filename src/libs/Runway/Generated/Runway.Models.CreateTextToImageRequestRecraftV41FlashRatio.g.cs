
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output dimensions, expressed as `&lt;width&gt;:&lt;height&gt;`.
    /// </summary>
    public enum CreateTextToImageRequestRecraftV41FlashRatio
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
        x1216_896,
        /// <summary>
        ///
        /// </summary>
        x1280_832,
        /// <summary>
        ///
        /// </summary>
        x1280_896,
        /// <summary>
        ///
        /// </summary>
        x1344_768,
        /// <summary>
        ///
        /// </summary>
        x1536_768,
        /// <summary>
        ///
        /// </summary>
        x768_1344,
        /// <summary>
        ///
        /// </summary>
        x768_1536,
        /// <summary>
        ///
        /// </summary>
        x832_1280,
        /// <summary>
        ///
        /// </summary>
        x832_1344,
        /// <summary>
        ///
        /// </summary>
        x896_1152,
        /// <summary>
        ///
        /// </summary>
        x896_1216,
        /// <summary>
        ///
        /// </summary>
        x896_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestRecraftV41FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestRecraftV41FlashRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestRecraftV41FlashRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestRecraftV41FlashRatio.x1152_896 => "1152:896",
                CreateTextToImageRequestRecraftV41FlashRatio.x1216_896 => "1216:896",
                CreateTextToImageRequestRecraftV41FlashRatio.x1280_832 => "1280:832",
                CreateTextToImageRequestRecraftV41FlashRatio.x1280_896 => "1280:896",
                CreateTextToImageRequestRecraftV41FlashRatio.x1344_768 => "1344:768",
                CreateTextToImageRequestRecraftV41FlashRatio.x1536_768 => "1536:768",
                CreateTextToImageRequestRecraftV41FlashRatio.x768_1344 => "768:1344",
                CreateTextToImageRequestRecraftV41FlashRatio.x768_1536 => "768:1536",
                CreateTextToImageRequestRecraftV41FlashRatio.x832_1280 => "832:1280",
                CreateTextToImageRequestRecraftV41FlashRatio.x832_1344 => "832:1344",
                CreateTextToImageRequestRecraftV41FlashRatio.x896_1152 => "896:1152",
                CreateTextToImageRequestRecraftV41FlashRatio.x896_1216 => "896:1216",
                CreateTextToImageRequestRecraftV41FlashRatio.x896_1280 => "896:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestRecraftV41FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestRecraftV41FlashRatio.x1024_1024,
                "1152:896" => CreateTextToImageRequestRecraftV41FlashRatio.x1152_896,
                "1216:896" => CreateTextToImageRequestRecraftV41FlashRatio.x1216_896,
                "1280:832" => CreateTextToImageRequestRecraftV41FlashRatio.x1280_832,
                "1280:896" => CreateTextToImageRequestRecraftV41FlashRatio.x1280_896,
                "1344:768" => CreateTextToImageRequestRecraftV41FlashRatio.x1344_768,
                "1536:768" => CreateTextToImageRequestRecraftV41FlashRatio.x1536_768,
                "768:1344" => CreateTextToImageRequestRecraftV41FlashRatio.x768_1344,
                "768:1536" => CreateTextToImageRequestRecraftV41FlashRatio.x768_1536,
                "832:1280" => CreateTextToImageRequestRecraftV41FlashRatio.x832_1280,
                "832:1344" => CreateTextToImageRequestRecraftV41FlashRatio.x832_1344,
                "896:1152" => CreateTextToImageRequestRecraftV41FlashRatio.x896_1152,
                "896:1216" => CreateTextToImageRequestRecraftV41FlashRatio.x896_1216,
                "896:1280" => CreateTextToImageRequestRecraftV41FlashRatio.x896_1280,
                _ => null,
            };
        }
    }
}