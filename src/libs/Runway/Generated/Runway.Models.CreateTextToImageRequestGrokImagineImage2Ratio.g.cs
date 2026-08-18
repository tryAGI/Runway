
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 2K ratios cost 2 additional credits per image. Use `auto_1k` or `auto_2k` to pick a resolution tier and let the model choose the framing from the prompt.
    /// </summary>
    public enum CreateTextToImageRequestGrokImagineImage2Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1152_864,
        /// <summary>
        /// 
        /// </summary>
        x1248_576,
        /// <summary>
        /// 
        /// </summary>
        x1248_832,
        /// <summary>
        /// 
        /// </summary>
        x1280_576,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1344_2912,
        /// <summary>
        /// 
        /// </summary>
        x1408_704,
        /// <summary>
        /// 
        /// </summary>
        x1440_3200,
        /// <summary>
        /// 
        /// </summary>
        x1456_2912,
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
        x2048_2048,
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
        x2912_1344,
        /// <summary>
        /// 
        /// </summary>
        x2912_1456,
        /// <summary>
        /// 
        /// </summary>
        x3200_1440,
        /// <summary>
        /// 
        /// </summary>
        x576_1248,
        /// <summary>
        /// 
        /// </summary>
        x576_1280,
        /// <summary>
        /// 
        /// </summary>
        x704_1408,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x832_1248,
        /// <summary>
        /// 
        /// </summary>
        x864_1152,
        /// <summary>
        /// &lt;height&gt;`. 2K ratios cost 2 additional credits per image. Use `auto_1k` or `auto_2k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        Auto1k,
        /// <summary>
        /// &lt;height&gt;`. 2K ratios cost 2 additional credits per image. Use `auto_1k` or `auto_2k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        Auto2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGrokImagineImage2RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGrokImagineImage2Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestGrokImagineImage2Ratio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1152_864 => "1152:864",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1248_576 => "1248:576",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1248_832 => "1248:832",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1280_576 => "1280:576",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1280_720 => "1280:720",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1344_2912 => "1344:2912",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1408_704 => "1408:704",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1440_3200 => "1440:3200",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1456_2912 => "1456:2912",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1584_2816 => "1584:2816",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestGrokImagineImage2Ratio.x1776_2368 => "1776:2368",
                CreateTextToImageRequestGrokImagineImage2Ratio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestGrokImagineImage2Ratio.x2368_1776 => "2368:1776",
                CreateTextToImageRequestGrokImagineImage2Ratio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestGrokImagineImage2Ratio.x2816_1584 => "2816:1584",
                CreateTextToImageRequestGrokImagineImage2Ratio.x2912_1344 => "2912:1344",
                CreateTextToImageRequestGrokImagineImage2Ratio.x2912_1456 => "2912:1456",
                CreateTextToImageRequestGrokImagineImage2Ratio.x3200_1440 => "3200:1440",
                CreateTextToImageRequestGrokImagineImage2Ratio.x576_1248 => "576:1248",
                CreateTextToImageRequestGrokImagineImage2Ratio.x576_1280 => "576:1280",
                CreateTextToImageRequestGrokImagineImage2Ratio.x704_1408 => "704:1408",
                CreateTextToImageRequestGrokImagineImage2Ratio.x720_1280 => "720:1280",
                CreateTextToImageRequestGrokImagineImage2Ratio.x832_1248 => "832:1248",
                CreateTextToImageRequestGrokImagineImage2Ratio.x864_1152 => "864:1152",
                CreateTextToImageRequestGrokImagineImage2Ratio.Auto1k => "auto_1k",
                CreateTextToImageRequestGrokImagineImage2Ratio.Auto2k => "auto_2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGrokImagineImage2Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGrokImagineImage2Ratio.x1024_1024,
                "1152:864" => CreateTextToImageRequestGrokImagineImage2Ratio.x1152_864,
                "1248:576" => CreateTextToImageRequestGrokImagineImage2Ratio.x1248_576,
                "1248:832" => CreateTextToImageRequestGrokImagineImage2Ratio.x1248_832,
                "1280:576" => CreateTextToImageRequestGrokImagineImage2Ratio.x1280_576,
                "1280:720" => CreateTextToImageRequestGrokImagineImage2Ratio.x1280_720,
                "1344:2912" => CreateTextToImageRequestGrokImagineImage2Ratio.x1344_2912,
                "1408:704" => CreateTextToImageRequestGrokImagineImage2Ratio.x1408_704,
                "1440:3200" => CreateTextToImageRequestGrokImagineImage2Ratio.x1440_3200,
                "1456:2912" => CreateTextToImageRequestGrokImagineImage2Ratio.x1456_2912,
                "1584:2816" => CreateTextToImageRequestGrokImagineImage2Ratio.x1584_2816,
                "1664:2496" => CreateTextToImageRequestGrokImagineImage2Ratio.x1664_2496,
                "1776:2368" => CreateTextToImageRequestGrokImagineImage2Ratio.x1776_2368,
                "2048:2048" => CreateTextToImageRequestGrokImagineImage2Ratio.x2048_2048,
                "2368:1776" => CreateTextToImageRequestGrokImagineImage2Ratio.x2368_1776,
                "2496:1664" => CreateTextToImageRequestGrokImagineImage2Ratio.x2496_1664,
                "2816:1584" => CreateTextToImageRequestGrokImagineImage2Ratio.x2816_1584,
                "2912:1344" => CreateTextToImageRequestGrokImagineImage2Ratio.x2912_1344,
                "2912:1456" => CreateTextToImageRequestGrokImagineImage2Ratio.x2912_1456,
                "3200:1440" => CreateTextToImageRequestGrokImagineImage2Ratio.x3200_1440,
                "576:1248" => CreateTextToImageRequestGrokImagineImage2Ratio.x576_1248,
                "576:1280" => CreateTextToImageRequestGrokImagineImage2Ratio.x576_1280,
                "704:1408" => CreateTextToImageRequestGrokImagineImage2Ratio.x704_1408,
                "720:1280" => CreateTextToImageRequestGrokImagineImage2Ratio.x720_1280,
                "832:1248" => CreateTextToImageRequestGrokImagineImage2Ratio.x832_1248,
                "864:1152" => CreateTextToImageRequestGrokImagineImage2Ratio.x864_1152,
                "auto_1k" => CreateTextToImageRequestGrokImagineImage2Ratio.Auto1k,
                "auto_2k" => CreateTextToImageRequestGrokImagineImage2Ratio.Auto2k,
                _ => null,
            };
        }
    }
}