
#nullable enable

namespace Runway
{
    /// <summary>
    /// The aspect ratio of the output video. Use adaptive only when image or video references are provided; text-only requests require a concrete ratio.
    /// </summary>
    public enum CreateVideoToVideoRequestHailuo3Ratio
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
    public static class CreateVideoToVideoRequestHailuo3RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestHailuo3Ratio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestHailuo3Ratio.x16_9 => "16:9",
                CreateVideoToVideoRequestHailuo3Ratio.x1_1 => "1:1",
                CreateVideoToVideoRequestHailuo3Ratio.x21_9 => "21:9",
                CreateVideoToVideoRequestHailuo3Ratio.x3_4 => "3:4",
                CreateVideoToVideoRequestHailuo3Ratio.x4_3 => "4:3",
                CreateVideoToVideoRequestHailuo3Ratio.x9_16 => "9:16",
                CreateVideoToVideoRequestHailuo3Ratio.Adaptive => "adaptive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestHailuo3Ratio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateVideoToVideoRequestHailuo3Ratio.x16_9,
                "1:1" => CreateVideoToVideoRequestHailuo3Ratio.x1_1,
                "21:9" => CreateVideoToVideoRequestHailuo3Ratio.x21_9,
                "3:4" => CreateVideoToVideoRequestHailuo3Ratio.x3_4,
                "4:3" => CreateVideoToVideoRequestHailuo3Ratio.x4_3,
                "9:16" => CreateVideoToVideoRequestHailuo3Ratio.x9_16,
                "adaptive" => CreateVideoToVideoRequestHailuo3Ratio.Adaptive,
                _ => null,
            };
        }
    }
}