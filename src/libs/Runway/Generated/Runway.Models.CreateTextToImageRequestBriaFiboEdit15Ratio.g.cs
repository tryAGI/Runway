
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Omit it or use `auto` to keep the framing of the first reference image. Choosing a size requires at least 2 reference images; a single image always keeps its own framing.
    /// </summary>
    public enum CreateTextToImageRequestBriaFiboEdit15Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
        /// <summary>
        ///
        /// </summary>
        x1024_576,
        /// <summary>
        ///
        /// </summary>
        x1024_768,
        /// <summary>
        ///
        /// </summary>
        x1152_768,
        /// <summary>
        ///
        /// </summary>
        x576_1024,
        /// <summary>
        ///
        /// </summary>
        x768_1024,
        /// <summary>
        ///
        /// </summary>
        x768_1152,
        /// <summary>
        ///
        /// </summary>
        x768_960,
        /// <summary>
        ///
        /// </summary>
        x960_768,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to keep the framing of the first reference image. Choosing a size requires at least 2 reference images; a single image always keeps its own framing.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestBriaFiboEdit15RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestBriaFiboEdit15Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestBriaFiboEdit15Ratio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x1024_576 => "1024:576",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x1024_768 => "1024:768",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x1152_768 => "1152:768",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x576_1024 => "576:1024",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x768_1024 => "768:1024",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x768_1152 => "768:1152",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x768_960 => "768:960",
                CreateTextToImageRequestBriaFiboEdit15Ratio.x960_768 => "960:768",
                CreateTextToImageRequestBriaFiboEdit15Ratio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestBriaFiboEdit15Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestBriaFiboEdit15Ratio.x1024_1024,
                "1024:576" => CreateTextToImageRequestBriaFiboEdit15Ratio.x1024_576,
                "1024:768" => CreateTextToImageRequestBriaFiboEdit15Ratio.x1024_768,
                "1152:768" => CreateTextToImageRequestBriaFiboEdit15Ratio.x1152_768,
                "576:1024" => CreateTextToImageRequestBriaFiboEdit15Ratio.x576_1024,
                "768:1024" => CreateTextToImageRequestBriaFiboEdit15Ratio.x768_1024,
                "768:1152" => CreateTextToImageRequestBriaFiboEdit15Ratio.x768_1152,
                "768:960" => CreateTextToImageRequestBriaFiboEdit15Ratio.x768_960,
                "960:768" => CreateTextToImageRequestBriaFiboEdit15Ratio.x960_768,
                "auto" => CreateTextToImageRequestBriaFiboEdit15Ratio.Auto,
                _ => null,
            };
        }
    }
}