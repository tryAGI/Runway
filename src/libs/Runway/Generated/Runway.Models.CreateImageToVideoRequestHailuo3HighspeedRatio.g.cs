
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageToVideoRequestHailuo3HighspeedRatio
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
    public static class CreateImageToVideoRequestHailuo3HighspeedRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestHailuo3HighspeedRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestHailuo3HighspeedRatio.x16_9 => "16:9",
                CreateImageToVideoRequestHailuo3HighspeedRatio.x1_1 => "1:1",
                CreateImageToVideoRequestHailuo3HighspeedRatio.x21_9 => "21:9",
                CreateImageToVideoRequestHailuo3HighspeedRatio.x3_4 => "3:4",
                CreateImageToVideoRequestHailuo3HighspeedRatio.x4_3 => "4:3",
                CreateImageToVideoRequestHailuo3HighspeedRatio.x9_16 => "9:16",
                CreateImageToVideoRequestHailuo3HighspeedRatio.Adaptive => "adaptive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestHailuo3HighspeedRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateImageToVideoRequestHailuo3HighspeedRatio.x16_9,
                "1:1" => CreateImageToVideoRequestHailuo3HighspeedRatio.x1_1,
                "21:9" => CreateImageToVideoRequestHailuo3HighspeedRatio.x21_9,
                "3:4" => CreateImageToVideoRequestHailuo3HighspeedRatio.x3_4,
                "4:3" => CreateImageToVideoRequestHailuo3HighspeedRatio.x4_3,
                "9:16" => CreateImageToVideoRequestHailuo3HighspeedRatio.x9_16,
                "adaptive" => CreateImageToVideoRequestHailuo3HighspeedRatio.Adaptive,
                _ => null,
            };
        }
    }
}