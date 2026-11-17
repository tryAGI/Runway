
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
    /// </summary>
    public enum CreateTextToImageRequestGptImage26SunburstRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1088_1920,
        /// <summary>
        ///
        /// </summary>
        x1280_1920,
        /// <summary>
        ///
        /// </summary>
        x1440_1920,
        /// <summary>
        ///
        /// </summary>
        x1440_2560,
        /// <summary>
        ///
        /// </summary>
        x1536_1920,
        /// <summary>
        ///
        /// </summary>
        x1712_2560,
        /// <summary>
        ///
        /// </summary>
        x1920_1088,
        /// <summary>
        ///
        /// </summary>
        x1920_1280,
        /// <summary>
        ///
        /// </summary>
        x1920_1440,
        /// <summary>
        ///
        /// </summary>
        x1920_1536,
        /// <summary>
        ///
        /// </summary>
        x1920_1920,
        /// <summary>
        ///
        /// </summary>
        x1920_2560,
        /// <summary>
        ///
        /// </summary>
        x2048_2560,
        /// <summary>
        ///
        /// </summary>
        x2048_880,
        /// <summary>
        ///
        /// </summary>
        x2160_3840,
        /// <summary>
        ///
        /// </summary>
        x2336_3504,
        /// <summary>
        ///
        /// </summary>
        x2448_3264,
        /// <summary>
        ///
        /// </summary>
        x2560_1440,
        /// <summary>
        ///
        /// </summary>
        x2560_1712,
        /// <summary>
        ///
        /// </summary>
        x2560_1920,
        /// <summary>
        ///
        /// </summary>
        x2560_2048,
        /// <summary>
        ///
        /// </summary>
        x2560_2560,
        /// <summary>
        ///
        /// </summary>
        x2560_3200,
        /// <summary>
        ///
        /// </summary>
        x2880_2880,
        /// <summary>
        ///
        /// </summary>
        x2912_1248,
        /// <summary>
        ///
        /// </summary>
        x3200_2560,
        /// <summary>
        ///
        /// </summary>
        x3264_2448,
        /// <summary>
        ///
        /// </summary>
        x3504_2336,
        /// <summary>
        ///
        /// </summary>
        x3840_1648,
        /// <summary>
        ///
        /// </summary>
        x3840_2160,
        /// <summary>
        /// &lt;height&gt;`. Use `auto` to let the model choose.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGptImage26SunburstRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26SunburstRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26SunburstRatio.x1088_1920 => "1088:1920",
                CreateTextToImageRequestGptImage26SunburstRatio.x1280_1920 => "1280:1920",
                CreateTextToImageRequestGptImage26SunburstRatio.x1440_1920 => "1440:1920",
                CreateTextToImageRequestGptImage26SunburstRatio.x1440_2560 => "1440:2560",
                CreateTextToImageRequestGptImage26SunburstRatio.x1536_1920 => "1536:1920",
                CreateTextToImageRequestGptImage26SunburstRatio.x1712_2560 => "1712:2560",
                CreateTextToImageRequestGptImage26SunburstRatio.x1920_1088 => "1920:1088",
                CreateTextToImageRequestGptImage26SunburstRatio.x1920_1280 => "1920:1280",
                CreateTextToImageRequestGptImage26SunburstRatio.x1920_1440 => "1920:1440",
                CreateTextToImageRequestGptImage26SunburstRatio.x1920_1536 => "1920:1536",
                CreateTextToImageRequestGptImage26SunburstRatio.x1920_1920 => "1920:1920",
                CreateTextToImageRequestGptImage26SunburstRatio.x1920_2560 => "1920:2560",
                CreateTextToImageRequestGptImage26SunburstRatio.x2048_2560 => "2048:2560",
                CreateTextToImageRequestGptImage26SunburstRatio.x2048_880 => "2048:880",
                CreateTextToImageRequestGptImage26SunburstRatio.x2160_3840 => "2160:3840",
                CreateTextToImageRequestGptImage26SunburstRatio.x2336_3504 => "2336:3504",
                CreateTextToImageRequestGptImage26SunburstRatio.x2448_3264 => "2448:3264",
                CreateTextToImageRequestGptImage26SunburstRatio.x2560_1440 => "2560:1440",
                CreateTextToImageRequestGptImage26SunburstRatio.x2560_1712 => "2560:1712",
                CreateTextToImageRequestGptImage26SunburstRatio.x2560_1920 => "2560:1920",
                CreateTextToImageRequestGptImage26SunburstRatio.x2560_2048 => "2560:2048",
                CreateTextToImageRequestGptImage26SunburstRatio.x2560_2560 => "2560:2560",
                CreateTextToImageRequestGptImage26SunburstRatio.x2560_3200 => "2560:3200",
                CreateTextToImageRequestGptImage26SunburstRatio.x2880_2880 => "2880:2880",
                CreateTextToImageRequestGptImage26SunburstRatio.x2912_1248 => "2912:1248",
                CreateTextToImageRequestGptImage26SunburstRatio.x3200_2560 => "3200:2560",
                CreateTextToImageRequestGptImage26SunburstRatio.x3264_2448 => "3264:2448",
                CreateTextToImageRequestGptImage26SunburstRatio.x3504_2336 => "3504:2336",
                CreateTextToImageRequestGptImage26SunburstRatio.x3840_1648 => "3840:1648",
                CreateTextToImageRequestGptImage26SunburstRatio.x3840_2160 => "3840:2160",
                CreateTextToImageRequestGptImage26SunburstRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26SunburstRatio? ToEnum(string value)
        {
            return value switch
            {
                "1088:1920" => CreateTextToImageRequestGptImage26SunburstRatio.x1088_1920,
                "1280:1920" => CreateTextToImageRequestGptImage26SunburstRatio.x1280_1920,
                "1440:1920" => CreateTextToImageRequestGptImage26SunburstRatio.x1440_1920,
                "1440:2560" => CreateTextToImageRequestGptImage26SunburstRatio.x1440_2560,
                "1536:1920" => CreateTextToImageRequestGptImage26SunburstRatio.x1536_1920,
                "1712:2560" => CreateTextToImageRequestGptImage26SunburstRatio.x1712_2560,
                "1920:1088" => CreateTextToImageRequestGptImage26SunburstRatio.x1920_1088,
                "1920:1280" => CreateTextToImageRequestGptImage26SunburstRatio.x1920_1280,
                "1920:1440" => CreateTextToImageRequestGptImage26SunburstRatio.x1920_1440,
                "1920:1536" => CreateTextToImageRequestGptImage26SunburstRatio.x1920_1536,
                "1920:1920" => CreateTextToImageRequestGptImage26SunburstRatio.x1920_1920,
                "1920:2560" => CreateTextToImageRequestGptImage26SunburstRatio.x1920_2560,
                "2048:2560" => CreateTextToImageRequestGptImage26SunburstRatio.x2048_2560,
                "2048:880" => CreateTextToImageRequestGptImage26SunburstRatio.x2048_880,
                "2160:3840" => CreateTextToImageRequestGptImage26SunburstRatio.x2160_3840,
                "2336:3504" => CreateTextToImageRequestGptImage26SunburstRatio.x2336_3504,
                "2448:3264" => CreateTextToImageRequestGptImage26SunburstRatio.x2448_3264,
                "2560:1440" => CreateTextToImageRequestGptImage26SunburstRatio.x2560_1440,
                "2560:1712" => CreateTextToImageRequestGptImage26SunburstRatio.x2560_1712,
                "2560:1920" => CreateTextToImageRequestGptImage26SunburstRatio.x2560_1920,
                "2560:2048" => CreateTextToImageRequestGptImage26SunburstRatio.x2560_2048,
                "2560:2560" => CreateTextToImageRequestGptImage26SunburstRatio.x2560_2560,
                "2560:3200" => CreateTextToImageRequestGptImage26SunburstRatio.x2560_3200,
                "2880:2880" => CreateTextToImageRequestGptImage26SunburstRatio.x2880_2880,
                "2912:1248" => CreateTextToImageRequestGptImage26SunburstRatio.x2912_1248,
                "3200:2560" => CreateTextToImageRequestGptImage26SunburstRatio.x3200_2560,
                "3264:2448" => CreateTextToImageRequestGptImage26SunburstRatio.x3264_2448,
                "3504:2336" => CreateTextToImageRequestGptImage26SunburstRatio.x3504_2336,
                "3840:1648" => CreateTextToImageRequestGptImage26SunburstRatio.x3840_1648,
                "3840:2160" => CreateTextToImageRequestGptImage26SunburstRatio.x3840_2160,
                "auto" => CreateTextToImageRequestGptImage26SunburstRatio.Auto,
                _ => null,
            };
        }
    }
}