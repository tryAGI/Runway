
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateRecipesProductAdRequestRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x1248_1664,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1440_1440,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x834_1112,
        /// <summary>
        /// 
        /// </summary>
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesProductAdRequestRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductAdRequestRatio value)
        {
            return value switch
            {
                CreateRecipesProductAdRequestRatio.x1080_1920 => "1080:1920",
                CreateRecipesProductAdRequestRatio.x1248_1664 => "1248:1664",
                CreateRecipesProductAdRequestRatio.x1280_720 => "1280:720",
                CreateRecipesProductAdRequestRatio.x1440_1440 => "1440:1440",
                CreateRecipesProductAdRequestRatio.x1920_1080 => "1920:1080",
                CreateRecipesProductAdRequestRatio.x720_1280 => "720:1280",
                CreateRecipesProductAdRequestRatio.x834_1112 => "834:1112",
                CreateRecipesProductAdRequestRatio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductAdRequestRatio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateRecipesProductAdRequestRatio.x1080_1920,
                "1248:1664" => CreateRecipesProductAdRequestRatio.x1248_1664,
                "1280:720" => CreateRecipesProductAdRequestRatio.x1280_720,
                "1440:1440" => CreateRecipesProductAdRequestRatio.x1440_1440,
                "1920:1080" => CreateRecipesProductAdRequestRatio.x1920_1080,
                "720:1280" => CreateRecipesProductAdRequestRatio.x720_1280,
                "834:1112" => CreateRecipesProductAdRequestRatio.x834_1112,
                "960:960" => CreateRecipesProductAdRequestRatio.x960_960,
                _ => null,
            };
        }
    }
}