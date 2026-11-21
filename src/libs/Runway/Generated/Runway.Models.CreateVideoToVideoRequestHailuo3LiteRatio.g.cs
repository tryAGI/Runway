
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVideoToVideoRequestHailuo3LiteRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x21_9,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestHailuo3LiteRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestHailuo3LiteRatio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestHailuo3LiteRatio.x16_9 => "16:9",
                CreateVideoToVideoRequestHailuo3LiteRatio.x1_1 => "1:1",
                CreateVideoToVideoRequestHailuo3LiteRatio.x21_9 => "21:9",
                CreateVideoToVideoRequestHailuo3LiteRatio.x3_4 => "3:4",
                CreateVideoToVideoRequestHailuo3LiteRatio.x4_3 => "4:3",
                CreateVideoToVideoRequestHailuo3LiteRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestHailuo3LiteRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateVideoToVideoRequestHailuo3LiteRatio.x16_9,
                "1:1" => CreateVideoToVideoRequestHailuo3LiteRatio.x1_1,
                "21:9" => CreateVideoToVideoRequestHailuo3LiteRatio.x21_9,
                "3:4" => CreateVideoToVideoRequestHailuo3LiteRatio.x3_4,
                "4:3" => CreateVideoToVideoRequestHailuo3LiteRatio.x4_3,
                "9:16" => CreateVideoToVideoRequestHailuo3LiteRatio.x9_16,
                _ => null,
            };
        }
    }
}