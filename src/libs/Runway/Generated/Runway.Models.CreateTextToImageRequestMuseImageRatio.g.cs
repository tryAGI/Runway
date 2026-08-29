
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose the framing from the prompt.
    /// </summary>
    public enum CreateTextToImageRequestMuseImageRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1152_2016,
        /// <summary>
        ///
        /// </summary>
        x1280_1920,
        /// <summary>
        ///
        /// </summary>
        x1344_1792,
        /// <summary>
        ///
        /// </summary>
        x1600_1600,
        /// <summary>
        ///
        /// </summary>
        x1792_1344,
        /// <summary>
        ///
        /// </summary>
        x1920_1280,
        /// <summary>
        ///
        /// </summary>
        x2016_1152,
        /// <summary>
        ///
        /// </summary>
        x2352_1008,
        /// <summary>
        /// &lt;height&gt;`. Use `auto` to let the model choose the framing from the prompt.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestMuseImageRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestMuseImageRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestMuseImageRatio.x1152_2016 => "1152:2016",
                CreateTextToImageRequestMuseImageRatio.x1280_1920 => "1280:1920",
                CreateTextToImageRequestMuseImageRatio.x1344_1792 => "1344:1792",
                CreateTextToImageRequestMuseImageRatio.x1600_1600 => "1600:1600",
                CreateTextToImageRequestMuseImageRatio.x1792_1344 => "1792:1344",
                CreateTextToImageRequestMuseImageRatio.x1920_1280 => "1920:1280",
                CreateTextToImageRequestMuseImageRatio.x2016_1152 => "2016:1152",
                CreateTextToImageRequestMuseImageRatio.x2352_1008 => "2352:1008",
                CreateTextToImageRequestMuseImageRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestMuseImageRatio? ToEnum(string value)
        {
            return value switch
            {
                "1152:2016" => CreateTextToImageRequestMuseImageRatio.x1152_2016,
                "1280:1920" => CreateTextToImageRequestMuseImageRatio.x1280_1920,
                "1344:1792" => CreateTextToImageRequestMuseImageRatio.x1344_1792,
                "1600:1600" => CreateTextToImageRequestMuseImageRatio.x1600_1600,
                "1792:1344" => CreateTextToImageRequestMuseImageRatio.x1792_1344,
                "1920:1280" => CreateTextToImageRequestMuseImageRatio.x1920_1280,
                "2016:1152" => CreateTextToImageRequestMuseImageRatio.x2016_1152,
                "2352:1008" => CreateTextToImageRequestMuseImageRatio.x2352_1008,
                "auto" => CreateTextToImageRequestMuseImageRatio.Auto,
                _ => null,
            };
        }
    }
}