
#nullable enable

namespace Runway
{
    /// <summary>
    /// The file format of the output image. Defaults to png.
    /// </summary>
    public enum CreateTextToImageRequestBriaFiboEdit15OutputFormat
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
    public static class CreateTextToImageRequestBriaFiboEdit15OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestBriaFiboEdit15OutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestBriaFiboEdit15OutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestBriaFiboEdit15OutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestBriaFiboEdit15OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestBriaFiboEdit15OutputFormat.Jpeg,
                "png" => CreateTextToImageRequestBriaFiboEdit15OutputFormat.Png,
                _ => null,
            };
        }
    }
}