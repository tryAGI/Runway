
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageToVideoRequestHailuo3LiteRatio
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
        /// <summary>
        ///
        /// </summary>
        Adaptive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestHailuo3LiteRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHailuo3LiteRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestHailuo3LiteRatio.x16_9 => "16:9",
                CreateImageToVideoRequestHailuo3LiteRatio.x1_1 => "1:1",
                CreateImageToVideoRequestHailuo3LiteRatio.x21_9 => "21:9",
                CreateImageToVideoRequestHailuo3LiteRatio.x3_4 => "3:4",
                CreateImageToVideoRequestHailuo3LiteRatio.x4_3 => "4:3",
                CreateImageToVideoRequestHailuo3LiteRatio.x9_16 => "9:16",
                CreateImageToVideoRequestHailuo3LiteRatio.Adaptive => "adaptive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3LiteRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateImageToVideoRequestHailuo3LiteRatio.x16_9,
                "1:1" => CreateImageToVideoRequestHailuo3LiteRatio.x1_1,
                "21:9" => CreateImageToVideoRequestHailuo3LiteRatio.x21_9,
                "3:4" => CreateImageToVideoRequestHailuo3LiteRatio.x3_4,
                "4:3" => CreateImageToVideoRequestHailuo3LiteRatio.x4_3,
                "9:16" => CreateImageToVideoRequestHailuo3LiteRatio.x9_16,
                "adaptive" => CreateImageToVideoRequestHailuo3LiteRatio.Adaptive,
                _ => null,
            };
        }
    }
}