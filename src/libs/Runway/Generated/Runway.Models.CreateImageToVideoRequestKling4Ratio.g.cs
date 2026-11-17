
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output quality tier. The video keeps the input media framing.
    /// </summary>
    public enum CreateImageToVideoRequestKling4Ratio
    {
        /// <summary>
        ///
        /// </summary>
        Auto1080p,
        /// <summary>
        ///
        /// </summary>
        Auto720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestKling4RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKling4Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestKling4Ratio.Auto1080p => "auto_1080p",
                CreateImageToVideoRequestKling4Ratio.Auto720p => "auto_720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKling4Ratio? ToEnum(string value)
        {
            return value switch
            {
                "auto_1080p" => CreateImageToVideoRequestKling4Ratio.Auto1080p,
                "auto_720p" => CreateImageToVideoRequestKling4Ratio.Auto720p,
                _ => null,
            };
        }
    }
}