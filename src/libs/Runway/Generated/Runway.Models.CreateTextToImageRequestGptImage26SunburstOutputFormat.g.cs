
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output format. Defaults to PNG. JPEG and WebP produce smaller files; JPEG cannot have a transparent background. GIF and SVG cannot use reference images; GIF requires ratio auto.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateTextToImageRequestGptImage26SunburstOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Gif,
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Svg,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGptImage26SunburstOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26SunburstOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26SunburstOutputFormat.Gif => "gif",
                CreateTextToImageRequestGptImage26SunburstOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestGptImage26SunburstOutputFormat.Png => "png",
                CreateTextToImageRequestGptImage26SunburstOutputFormat.Svg => "svg",
                CreateTextToImageRequestGptImage26SunburstOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26SunburstOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => CreateTextToImageRequestGptImage26SunburstOutputFormat.Gif,
                "jpeg" => CreateTextToImageRequestGptImage26SunburstOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestGptImage26SunburstOutputFormat.Png,
                "svg" => CreateTextToImageRequestGptImage26SunburstOutputFormat.Svg,
                "webp" => CreateTextToImageRequestGptImage26SunburstOutputFormat.Webp,
                _ => null,
            };
        }
    }
}