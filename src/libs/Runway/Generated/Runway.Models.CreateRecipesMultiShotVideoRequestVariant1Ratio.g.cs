
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output dimensions as width:height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
    /// </summary>
    public enum CreateRecipesMultiShotVideoRequestVariant1Ratio
    {
        /// <summary>
        /// height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        x1080_1920,
        /// <summary>
        /// height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        x1280_720,
        /// <summary>
        /// height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        x1440_1440,
        /// <summary>
        /// height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        x1920_1080,
        /// <summary>
        /// height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        x720_1280,
        /// <summary>
        /// height. 720p ratios (`1280:720`, `720:1280`, `960:960`) use the standard tier; 1080p ratios (`1920:1080`, `1080:1920`, `1440:1440`) use the pro tier. Defaults to `1280:720`.
        /// </summary>
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesMultiShotVideoRequestVariant1RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesMultiShotVideoRequestVariant1Ratio value)
        {
            return value switch
            {
                CreateRecipesMultiShotVideoRequestVariant1Ratio.x1080_1920 => "1080:1920",
                CreateRecipesMultiShotVideoRequestVariant1Ratio.x1280_720 => "1280:720",
                CreateRecipesMultiShotVideoRequestVariant1Ratio.x1440_1440 => "1440:1440",
                CreateRecipesMultiShotVideoRequestVariant1Ratio.x1920_1080 => "1920:1080",
                CreateRecipesMultiShotVideoRequestVariant1Ratio.x720_1280 => "720:1280",
                CreateRecipesMultiShotVideoRequestVariant1Ratio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesMultiShotVideoRequestVariant1Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateRecipesMultiShotVideoRequestVariant1Ratio.x1080_1920,
                "1280:720" => CreateRecipesMultiShotVideoRequestVariant1Ratio.x1280_720,
                "1440:1440" => CreateRecipesMultiShotVideoRequestVariant1Ratio.x1440_1440,
                "1920:1080" => CreateRecipesMultiShotVideoRequestVariant1Ratio.x1920_1080,
                "720:1280" => CreateRecipesMultiShotVideoRequestVariant1Ratio.x720_1280,
                "960:960" => CreateRecipesMultiShotVideoRequestVariant1Ratio.x960_960,
                _ => null,
            };
        }
    }
}