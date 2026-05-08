
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestGen45Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestGen45RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGen45Ratio value)
        {
            return value switch
            {
                CreateTextToVideoRequestGen45Ratio.x1280_720 => "1280:720",
                CreateTextToVideoRequestGen45Ratio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGen45Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateTextToVideoRequestGen45Ratio.x1280_720,
                "720:1280" => CreateTextToVideoRequestGen45Ratio.x720_1280,
                _ => null,
            };
        }
    }
}