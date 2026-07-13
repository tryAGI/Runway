
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick aspect ratio at a fixed resolution tier.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5ProRatio
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
        x1296_864,
        /// <summary>
        /// 
        /// </summary>
        x1376_768,
        /// <summary>
        /// 
        /// </summary>
        x1530_2720,
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
        x2720_1530,
        /// <summary>
        /// 
        /// </summary>
        x768_1376,
        /// <summary>
        /// 
        /// </summary>
        x864_1296,
        /// <summary>
        /// 
        /// </summary>
        x896_1184,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto1k,
        /// <summary>
        /// &lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick aspect ratio at a fixed resolution tier.
        /// </summary>
        Auto2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream5ProRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5ProRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5ProRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestSeedream5ProRatio.x1184_896 => "1184:896",
                CreateTextToImageRequestSeedream5ProRatio.x1296_864 => "1296:864",
                CreateTextToImageRequestSeedream5ProRatio.x1376_768 => "1376:768",
                CreateTextToImageRequestSeedream5ProRatio.x1530_2720 => "1530:2720",
                CreateTextToImageRequestSeedream5ProRatio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestSeedream5ProRatio.x1728_2304 => "1728:2304",
                CreateTextToImageRequestSeedream5ProRatio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestSeedream5ProRatio.x2304_1728 => "2304:1728",
                CreateTextToImageRequestSeedream5ProRatio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestSeedream5ProRatio.x2720_1530 => "2720:1530",
                CreateTextToImageRequestSeedream5ProRatio.x768_1376 => "768:1376",
                CreateTextToImageRequestSeedream5ProRatio.x864_1296 => "864:1296",
                CreateTextToImageRequestSeedream5ProRatio.x896_1184 => "896:1184",
                CreateTextToImageRequestSeedream5ProRatio.Auto1k => "auto_1k",
                CreateTextToImageRequestSeedream5ProRatio.Auto2k => "auto_2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5ProRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestSeedream5ProRatio.x1024_1024,
                "1184:896" => CreateTextToImageRequestSeedream5ProRatio.x1184_896,
                "1296:864" => CreateTextToImageRequestSeedream5ProRatio.x1296_864,
                "1376:768" => CreateTextToImageRequestSeedream5ProRatio.x1376_768,
                "1530:2720" => CreateTextToImageRequestSeedream5ProRatio.x1530_2720,
                "1664:2496" => CreateTextToImageRequestSeedream5ProRatio.x1664_2496,
                "1728:2304" => CreateTextToImageRequestSeedream5ProRatio.x1728_2304,
                "2048:2048" => CreateTextToImageRequestSeedream5ProRatio.x2048_2048,
                "2304:1728" => CreateTextToImageRequestSeedream5ProRatio.x2304_1728,
                "2496:1664" => CreateTextToImageRequestSeedream5ProRatio.x2496_1664,
                "2720:1530" => CreateTextToImageRequestSeedream5ProRatio.x2720_1530,
                "768:1376" => CreateTextToImageRequestSeedream5ProRatio.x768_1376,
                "864:1296" => CreateTextToImageRequestSeedream5ProRatio.x864_1296,
                "896:1184" => CreateTextToImageRequestSeedream5ProRatio.x896_1184,
                "auto_1k" => CreateTextToImageRequestSeedream5ProRatio.Auto1k,
                "auto_2k" => CreateTextToImageRequestSeedream5ProRatio.Auto2k,
                _ => null,
            };
        }
    }
}