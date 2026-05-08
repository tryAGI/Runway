
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
    /// </summary>
    public enum CreateTextToImageRequestGptImage2Ratio
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
    public static class CreateTextToImageRequestGptImage2RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage2Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage2Ratio.x1088_1920 => "1088:1920",
                CreateTextToImageRequestGptImage2Ratio.x1280_1920 => "1280:1920",
                CreateTextToImageRequestGptImage2Ratio.x1440_1920 => "1440:1920",
                CreateTextToImageRequestGptImage2Ratio.x1440_2560 => "1440:2560",
                CreateTextToImageRequestGptImage2Ratio.x1536_1920 => "1536:1920",
                CreateTextToImageRequestGptImage2Ratio.x1712_2560 => "1712:2560",
                CreateTextToImageRequestGptImage2Ratio.x1920_1088 => "1920:1088",
                CreateTextToImageRequestGptImage2Ratio.x1920_1280 => "1920:1280",
                CreateTextToImageRequestGptImage2Ratio.x1920_1440 => "1920:1440",
                CreateTextToImageRequestGptImage2Ratio.x1920_1536 => "1920:1536",
                CreateTextToImageRequestGptImage2Ratio.x1920_1920 => "1920:1920",
                CreateTextToImageRequestGptImage2Ratio.x1920_2560 => "1920:2560",
                CreateTextToImageRequestGptImage2Ratio.x2048_2560 => "2048:2560",
                CreateTextToImageRequestGptImage2Ratio.x2048_880 => "2048:880",
                CreateTextToImageRequestGptImage2Ratio.x2160_3840 => "2160:3840",
                CreateTextToImageRequestGptImage2Ratio.x2336_3504 => "2336:3504",
                CreateTextToImageRequestGptImage2Ratio.x2448_3264 => "2448:3264",
                CreateTextToImageRequestGptImage2Ratio.x2560_1440 => "2560:1440",
                CreateTextToImageRequestGptImage2Ratio.x2560_1712 => "2560:1712",
                CreateTextToImageRequestGptImage2Ratio.x2560_1920 => "2560:1920",
                CreateTextToImageRequestGptImage2Ratio.x2560_2048 => "2560:2048",
                CreateTextToImageRequestGptImage2Ratio.x2560_2560 => "2560:2560",
                CreateTextToImageRequestGptImage2Ratio.x2560_3200 => "2560:3200",
                CreateTextToImageRequestGptImage2Ratio.x2880_2880 => "2880:2880",
                CreateTextToImageRequestGptImage2Ratio.x2912_1248 => "2912:1248",
                CreateTextToImageRequestGptImage2Ratio.x3200_2560 => "3200:2560",
                CreateTextToImageRequestGptImage2Ratio.x3264_2448 => "3264:2448",
                CreateTextToImageRequestGptImage2Ratio.x3504_2336 => "3504:2336",
                CreateTextToImageRequestGptImage2Ratio.x3840_1648 => "3840:1648",
                CreateTextToImageRequestGptImage2Ratio.x3840_2160 => "3840:2160",
                CreateTextToImageRequestGptImage2Ratio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage2Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1088:1920" => CreateTextToImageRequestGptImage2Ratio.x1088_1920,
                "1280:1920" => CreateTextToImageRequestGptImage2Ratio.x1280_1920,
                "1440:1920" => CreateTextToImageRequestGptImage2Ratio.x1440_1920,
                "1440:2560" => CreateTextToImageRequestGptImage2Ratio.x1440_2560,
                "1536:1920" => CreateTextToImageRequestGptImage2Ratio.x1536_1920,
                "1712:2560" => CreateTextToImageRequestGptImage2Ratio.x1712_2560,
                "1920:1088" => CreateTextToImageRequestGptImage2Ratio.x1920_1088,
                "1920:1280" => CreateTextToImageRequestGptImage2Ratio.x1920_1280,
                "1920:1440" => CreateTextToImageRequestGptImage2Ratio.x1920_1440,
                "1920:1536" => CreateTextToImageRequestGptImage2Ratio.x1920_1536,
                "1920:1920" => CreateTextToImageRequestGptImage2Ratio.x1920_1920,
                "1920:2560" => CreateTextToImageRequestGptImage2Ratio.x1920_2560,
                "2048:2560" => CreateTextToImageRequestGptImage2Ratio.x2048_2560,
                "2048:880" => CreateTextToImageRequestGptImage2Ratio.x2048_880,
                "2160:3840" => CreateTextToImageRequestGptImage2Ratio.x2160_3840,
                "2336:3504" => CreateTextToImageRequestGptImage2Ratio.x2336_3504,
                "2448:3264" => CreateTextToImageRequestGptImage2Ratio.x2448_3264,
                "2560:1440" => CreateTextToImageRequestGptImage2Ratio.x2560_1440,
                "2560:1712" => CreateTextToImageRequestGptImage2Ratio.x2560_1712,
                "2560:1920" => CreateTextToImageRequestGptImage2Ratio.x2560_1920,
                "2560:2048" => CreateTextToImageRequestGptImage2Ratio.x2560_2048,
                "2560:2560" => CreateTextToImageRequestGptImage2Ratio.x2560_2560,
                "2560:3200" => CreateTextToImageRequestGptImage2Ratio.x2560_3200,
                "2880:2880" => CreateTextToImageRequestGptImage2Ratio.x2880_2880,
                "2912:1248" => CreateTextToImageRequestGptImage2Ratio.x2912_1248,
                "3200:2560" => CreateTextToImageRequestGptImage2Ratio.x3200_2560,
                "3264:2448" => CreateTextToImageRequestGptImage2Ratio.x3264_2448,
                "3504:2336" => CreateTextToImageRequestGptImage2Ratio.x3504_2336,
                "3840:1648" => CreateTextToImageRequestGptImage2Ratio.x3840_1648,
                "3840:2160" => CreateTextToImageRequestGptImage2Ratio.x3840_2160,
                "auto" => CreateTextToImageRequestGptImage2Ratio.Auto,
                _ => null,
            };
        }
    }
}