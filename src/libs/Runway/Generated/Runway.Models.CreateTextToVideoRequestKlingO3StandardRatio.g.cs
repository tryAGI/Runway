
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateTextToVideoRequestKlingO3StandardRatio
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
    public static class CreateTextToVideoRequestKlingO3StandardRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKlingO3StandardRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKlingO3StandardRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestKlingO3StandardRatio.x720_1280 => "720:1280",
                CreateTextToVideoRequestKlingO3StandardRatio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKlingO3StandardRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateTextToVideoRequestKlingO3StandardRatio.x1280_720,
                "720:1280" => CreateTextToVideoRequestKlingO3StandardRatio.x720_1280,
                "960:960" => CreateTextToVideoRequestKlingO3StandardRatio.x960_960,
                _ => null,
            };
        }
    }
}