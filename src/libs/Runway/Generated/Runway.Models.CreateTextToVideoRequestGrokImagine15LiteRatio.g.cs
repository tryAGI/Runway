
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output video. The 1080p sizes are rendered at 720p and upscaled.
    /// </summary>
    public enum CreateTextToVideoRequestGrokImagine15LiteRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1072_1904,
        /// <summary>
        ///
        /// </summary>
        x1088_720,
        /// <summary>
        ///
        /// </summary>
        x1152_1744,
        /// <summary>
        ///
        /// </summary>
        x1232_1648,
        /// <summary>
        ///
        /// </summary>
        x1280_720,
        /// <summary>
        ///
        /// </summary>
        x1424_1424,
        /// <summary>
        ///
        /// </summary>
        x1648_1232,
        /// <summary>
        ///
        /// </summary>
        x1744_1152,
        /// <summary>
        ///
        /// </summary>
        x1904_1072,
        /// <summary>
        ///
        /// </summary>
        x480_480,
        /// <summary>
        ///
        /// </summary>
        x480_640,
        /// <summary>
        ///
        /// </summary>
        x480_720,
        /// <summary>
        ///
        /// </summary>
        x480_848,
        /// <summary>
        ///
        /// </summary>
        x640_480,
        /// <summary>
        ///
        /// </summary>
        x720_1088,
        /// <summary>
        ///
        /// </summary>
        x720_1280,
        /// <summary>
        ///
        /// </summary>
        x720_480,
        /// <summary>
        ///
        /// </summary>
        x720_720,
        /// <summary>
        ///
        /// </summary>
        x720_960,
        /// <summary>
        ///
        /// </summary>
        x848_480,
        /// <summary>
        ///
        /// </summary>
        x960_720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestGrokImagine15LiteRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestGrokImagine15LiteRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1072_1904 => "1072:1904",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1088_720 => "1088:720",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1152_1744 => "1152:1744",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1232_1648 => "1232:1648",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1280_720 => "1280:720",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1424_1424 => "1424:1424",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1648_1232 => "1648:1232",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1744_1152 => "1744:1152",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x1904_1072 => "1904:1072",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x480_480 => "480:480",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x480_640 => "480:640",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x480_720 => "480:720",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x480_848 => "480:848",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x640_480 => "640:480",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x720_1088 => "720:1088",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x720_1280 => "720:1280",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x720_480 => "720:480",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x720_720 => "720:720",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x720_960 => "720:960",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x848_480 => "848:480",
                CreateTextToVideoRequestGrokImagine15LiteRatio.x960_720 => "960:720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestGrokImagine15LiteRatio? ToEnum(string value)
        {
            return value switch
            {
                "1072:1904" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1072_1904,
                "1088:720" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1088_720,
                "1152:1744" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1152_1744,
                "1232:1648" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1232_1648,
                "1280:720" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1280_720,
                "1424:1424" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1424_1424,
                "1648:1232" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1648_1232,
                "1744:1152" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1744_1152,
                "1904:1072" => CreateTextToVideoRequestGrokImagine15LiteRatio.x1904_1072,
                "480:480" => CreateTextToVideoRequestGrokImagine15LiteRatio.x480_480,
                "480:640" => CreateTextToVideoRequestGrokImagine15LiteRatio.x480_640,
                "480:720" => CreateTextToVideoRequestGrokImagine15LiteRatio.x480_720,
                "480:848" => CreateTextToVideoRequestGrokImagine15LiteRatio.x480_848,
                "640:480" => CreateTextToVideoRequestGrokImagine15LiteRatio.x640_480,
                "720:1088" => CreateTextToVideoRequestGrokImagine15LiteRatio.x720_1088,
                "720:1280" => CreateTextToVideoRequestGrokImagine15LiteRatio.x720_1280,
                "720:480" => CreateTextToVideoRequestGrokImagine15LiteRatio.x720_480,
                "720:720" => CreateTextToVideoRequestGrokImagine15LiteRatio.x720_720,
                "720:960" => CreateTextToVideoRequestGrokImagine15LiteRatio.x720_960,
                "848:480" => CreateTextToVideoRequestGrokImagine15LiteRatio.x848_480,
                "960:720" => CreateTextToVideoRequestGrokImagine15LiteRatio.x960_720,
                _ => null,
            };
        }
    }
}