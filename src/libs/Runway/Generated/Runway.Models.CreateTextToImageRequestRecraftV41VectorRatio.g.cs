
#nullable enable

namespace Runway
{
    /// <summary>
    /// The width and height declared by the output SVG. Vector artwork can be scaled after generation.
    /// </summary>
    public enum CreateTextToImageRequestRecraftV41VectorRatio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
        /// <summary>
        ///
        /// </summary>
        x1216_896,
        /// <summary>
        ///
        /// </summary>
        x1344_768,
        /// <summary>
        ///
        /// </summary>
        x768_1344,
        /// <summary>
        ///
        /// </summary>
        x896_1216,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestRecraftV41VectorRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestRecraftV41VectorRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestRecraftV41VectorRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestRecraftV41VectorRatio.x1216_896 => "1216:896",
                CreateTextToImageRequestRecraftV41VectorRatio.x1344_768 => "1344:768",
                CreateTextToImageRequestRecraftV41VectorRatio.x768_1344 => "768:1344",
                CreateTextToImageRequestRecraftV41VectorRatio.x896_1216 => "896:1216",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestRecraftV41VectorRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestRecraftV41VectorRatio.x1024_1024,
                "1216:896" => CreateTextToImageRequestRecraftV41VectorRatio.x1216_896,
                "1344:768" => CreateTextToImageRequestRecraftV41VectorRatio.x1344_768,
                "768:1344" => CreateTextToImageRequestRecraftV41VectorRatio.x768_1344,
                "896:1216" => CreateTextToImageRequestRecraftV41VectorRatio.x896_1216,
                _ => null,
            };
        }
    }
}