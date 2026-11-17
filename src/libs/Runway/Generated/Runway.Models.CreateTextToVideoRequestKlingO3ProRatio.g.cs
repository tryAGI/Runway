
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestKlingO3ProRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1920,
        /// <summary>
        ///
        /// </summary>
        x1440_1440,
        /// <summary>
        ///
        /// </summary>
        x1920_1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestKlingO3ProRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKlingO3ProRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKlingO3ProRatio.x1080_1920 => "1080:1920",
                CreateTextToVideoRequestKlingO3ProRatio.x1440_1440 => "1440:1440",
                CreateTextToVideoRequestKlingO3ProRatio.x1920_1080 => "1920:1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKlingO3ProRatio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateTextToVideoRequestKlingO3ProRatio.x1080_1920,
                "1440:1440" => CreateTextToVideoRequestKlingO3ProRatio.x1440_1440,
                "1920:1080" => CreateTextToVideoRequestKlingO3ProRatio.x1920_1080,
                _ => null,
            };
        }
    }
}