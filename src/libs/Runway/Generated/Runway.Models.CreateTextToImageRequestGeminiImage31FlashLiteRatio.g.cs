
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum CreateTextToImageRequestGeminiImage31FlashLiteRatio
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
        x1200_896,
        /// <summary>
        ///
        /// </summary>
        x1264_848,
        /// <summary>
        ///
        /// </summary>
        x1376_768,
        /// <summary>
        ///
        /// </summary>
        x1584_672,
        /// <summary>
        ///
        /// </summary>
        x768_1376,
        /// <summary>
        ///
        /// </summary>
        x848_1264,
        /// <summary>
        ///
        /// </summary>
        x896_1200,
        /// <summary>
        ///
        /// </summary>
        x928_1152,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGeminiImage31FlashLiteRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGeminiImage31FlashLiteRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1152_928 => "1152:928",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1200_896 => "1200:896",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1264_848 => "1264:848",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1376_768 => "1376:768",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1584_672 => "1584:672",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x768_1376 => "768:1376",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x848_1264 => "848:1264",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x896_1200 => "896:1200",
                CreateTextToImageRequestGeminiImage31FlashLiteRatio.x928_1152 => "928:1152",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGeminiImage31FlashLiteRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1024_1024,
                "1152:928" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1152_928,
                "1200:896" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1200_896,
                "1264:848" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1264_848,
                "1376:768" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1376_768,
                "1584:672" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x1584_672,
                "768:1376" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x768_1376,
                "848:1264" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x848_1264,
                "896:1200" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x896_1200,
                "928:1152" => CreateTextToImageRequestGeminiImage31FlashLiteRatio.x928_1152,
                _ => null,
            };
        }
    }
}