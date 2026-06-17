
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateRecipesProductUgcRequestRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesProductUgcRequestRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductUgcRequestRatio value)
        {
            return value switch
            {
                CreateRecipesProductUgcRequestRatio.x1080_1920 => "1080:1920",
                CreateRecipesProductUgcRequestRatio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductUgcRequestRatio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateRecipesProductUgcRequestRatio.x1080_1920,
                "720:1280" => CreateRecipesProductUgcRequestRatio.x720_1280,
                _ => null,
            };
        }
    }
}