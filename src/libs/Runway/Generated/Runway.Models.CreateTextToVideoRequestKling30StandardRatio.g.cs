
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestKling30StandardRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestKling30StandardRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKling30StandardRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKling30StandardRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestKling30StandardRatio.x720_1280 => "720:1280",
                CreateTextToVideoRequestKling30StandardRatio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKling30StandardRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateTextToVideoRequestKling30StandardRatio.x1280_720,
                "720:1280" => CreateTextToVideoRequestKling30StandardRatio.x720_1280,
                "960:960" => CreateTextToVideoRequestKling30StandardRatio.x960_960,
                _ => null,
            };
        }
    }
}