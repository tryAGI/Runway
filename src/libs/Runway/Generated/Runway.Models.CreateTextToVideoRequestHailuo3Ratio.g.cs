
#nullable enable

namespace Runway
{
    /// <summary>
    /// The aspect ratio of the output video. Use adaptive only when image or video references are provided; text-only requests require a concrete ratio.
    /// </summary>
    public enum CreateTextToVideoRequestHailuo3Ratio
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
    public static class CreateTextToVideoRequestHailuo3RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestHailuo3Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestHailuo3Ratio.x16_9 => "16:9",
                CreateTextToVideoRequestHailuo3Ratio.x1_1 => "1:1",
                CreateTextToVideoRequestHailuo3Ratio.x21_9 => "21:9",
                CreateTextToVideoRequestHailuo3Ratio.x3_4 => "3:4",
                CreateTextToVideoRequestHailuo3Ratio.x4_3 => "4:3",
                CreateTextToVideoRequestHailuo3Ratio.x9_16 => "9:16",
                CreateTextToVideoRequestHailuo3Ratio.Adaptive => "adaptive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestHailuo3Ratio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateTextToVideoRequestHailuo3Ratio.x16_9,
                "1:1" => CreateTextToVideoRequestHailuo3Ratio.x1_1,
                "21:9" => CreateTextToVideoRequestHailuo3Ratio.x21_9,
                "3:4" => CreateTextToVideoRequestHailuo3Ratio.x3_4,
                "4:3" => CreateTextToVideoRequestHailuo3Ratio.x4_3,
                "9:16" => CreateTextToVideoRequestHailuo3Ratio.x9_16,
                "adaptive" => CreateTextToVideoRequestHailuo3Ratio.Adaptive,
                _ => null,
            };
        }
    }
}