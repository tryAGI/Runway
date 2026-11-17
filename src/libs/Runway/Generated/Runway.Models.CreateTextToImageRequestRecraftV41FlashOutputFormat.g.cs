
#nullable enable

namespace Runway
{
    /// <summary>
    /// The output file format. Defaults to webp.
    /// </summary>
    public enum CreateTextToImageRequestRecraftV41FlashOutputFormat
    {
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
    public static class CreateTextToImageRequestRecraftV41FlashOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestRecraftV41FlashOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestRecraftV41FlashOutputFormat.Png => "png",
                CreateTextToImageRequestRecraftV41FlashOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestRecraftV41FlashOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => CreateTextToImageRequestRecraftV41FlashOutputFormat.Png,
                "webp" => CreateTextToImageRequestRecraftV41FlashOutputFormat.Webp,
                _ => null,
            };
        }
    }
}