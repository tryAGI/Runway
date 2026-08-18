
#nullable enable

namespace Runway
{
    /// <summary>
    /// The aspect ratio of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestGrokImagine15Ratio
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
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
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
    public static class CreateTextToVideoRequestGrokImagine15RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGrokImagine15Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestGrokImagine15Ratio.x16_9 => "16:9",
                CreateTextToVideoRequestGrokImagine15Ratio.x1_1 => "1:1",
                CreateTextToVideoRequestGrokImagine15Ratio.x2_3 => "2:3",
                CreateTextToVideoRequestGrokImagine15Ratio.x3_2 => "3:2",
                CreateTextToVideoRequestGrokImagine15Ratio.x3_4 => "3:4",
                CreateTextToVideoRequestGrokImagine15Ratio.x4_3 => "4:3",
                CreateTextToVideoRequestGrokImagine15Ratio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGrokImagine15Ratio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateTextToVideoRequestGrokImagine15Ratio.x16_9,
                "1:1" => CreateTextToVideoRequestGrokImagine15Ratio.x1_1,
                "2:3" => CreateTextToVideoRequestGrokImagine15Ratio.x2_3,
                "3:2" => CreateTextToVideoRequestGrokImagine15Ratio.x3_2,
                "3:4" => CreateTextToVideoRequestGrokImagine15Ratio.x3_4,
                "4:3" => CreateTextToVideoRequestGrokImagine15Ratio.x4_3,
                "9:16" => CreateTextToVideoRequestGrokImagine15Ratio.x9_16,
                _ => null,
            };
        }
    }
}