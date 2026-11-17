
#nullable enable

namespace Runway
{
    /// <summary>
    /// The file format of the output image. Defaults to png.
    /// </summary>
    public enum CreateTextToImageRequestBriaFibo15OutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestBriaFibo15OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestBriaFibo15OutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestBriaFibo15OutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestBriaFibo15OutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestBriaFibo15OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestBriaFibo15OutputFormat.Jpeg,
                "png" => CreateTextToImageRequestBriaFibo15OutputFormat.Png,
                _ => null,
            };
        }
    }
}