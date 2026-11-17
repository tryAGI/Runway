
#nullable enable

namespace Runway
{
    /// <summary>
    /// The file format of the output image. Defaults to png.
    /// </summary>
    public enum CreateTextToImageRequestMuseImageOutputFormat
    {
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
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestMuseImageOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestMuseImageOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestMuseImageOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestMuseImageOutputFormat.Png => "png",
                CreateTextToImageRequestMuseImageOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestMuseImageOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestMuseImageOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestMuseImageOutputFormat.Png,
                "webp" => CreateTextToImageRequestMuseImageOutputFormat.Webp,
                _ => null,
            };
        }
    }
}