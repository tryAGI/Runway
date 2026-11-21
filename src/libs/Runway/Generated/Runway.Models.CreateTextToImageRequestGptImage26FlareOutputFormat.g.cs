
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output format. Defaults to PNG. JPEG and WebP produce smaller files; JPEG cannot have a transparent background. GIF and SVG cannot use reference images; GIF requires ratio auto.<br/>
    /// Default Value: png
    /// </summary>
    public enum CreateTextToImageRequestGptImage26FlareOutputFormat
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
    public static class CreateTextToImageRequestGptImage26FlareOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26FlareOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26FlareOutputFormat.Gif => "gif",
                CreateTextToImageRequestGptImage26FlareOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestGptImage26FlareOutputFormat.Png => "png",
                CreateTextToImageRequestGptImage26FlareOutputFormat.Svg => "svg",
                CreateTextToImageRequestGptImage26FlareOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26FlareOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => CreateTextToImageRequestGptImage26FlareOutputFormat.Gif,
                "jpeg" => CreateTextToImageRequestGptImage26FlareOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestGptImage26FlareOutputFormat.Png,
                "svg" => CreateTextToImageRequestGptImage26FlareOutputFormat.Svg,
                "webp" => CreateTextToImageRequestGptImage26FlareOutputFormat.Webp,
                _ => null,
            };
        }
    }
}