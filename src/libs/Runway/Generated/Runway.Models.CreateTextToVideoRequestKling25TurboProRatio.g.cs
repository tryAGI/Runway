
#nullable enable

namespace Runway
{
    /// <summary>
    /// Default Value: 1920:1080
    /// </summary>
    public enum CreateTextToVideoRequestKling25TurboProRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1080_1920,
        /// <summary>
        ///
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x1440_1440,
        /// <summary>
        ///
        /// </summary>
        x1920_1080,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x720_720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestKling25TurboProRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKling25TurboProRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestKling25TurboProRatio.x1080_1920 => "1080:1920",
                CreateTextToVideoRequestKling25TurboProRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestKling25TurboProRatio.x1440_1440 => "1440:1440",
                CreateTextToVideoRequestKling25TurboProRatio.x1920_1080 => "1920:1080",
                CreateTextToVideoRequestKling25TurboProRatio.x720_1280 => "720:1280",
                CreateTextToVideoRequestKling25TurboProRatio.x720_720 => "720:720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKling25TurboProRatio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateTextToVideoRequestKling25TurboProRatio.x1080_1920,
                "1280:720" => CreateTextToVideoRequestKling25TurboProRatio.x1280_720,
                "1440:1440" => CreateTextToVideoRequestKling25TurboProRatio.x1440_1440,
                "1920:1080" => CreateTextToVideoRequestKling25TurboProRatio.x1920_1080,
                "720:1280" => CreateTextToVideoRequestKling25TurboProRatio.x720_1280,
                "720:720" => CreateTextToVideoRequestKling25TurboProRatio.x720_720,
                _ => null,
            };
        }
    }
}