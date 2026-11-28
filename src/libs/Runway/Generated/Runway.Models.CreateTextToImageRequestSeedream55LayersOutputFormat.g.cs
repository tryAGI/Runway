
#nullable enable

namespace Runway
{
    /// <summary>
    /// Base image format; defaults to png. Separated layers always use PNG with transparency.
    /// </summary>
    public enum CreateTextToImageRequestSeedream55LayersOutputFormat
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
    public static class CreateTextToImageRequestSeedream55LayersOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream55LayersOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream55LayersOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestSeedream55LayersOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream55LayersOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestSeedream55LayersOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestSeedream55LayersOutputFormat.Png,
                _ => null,
            };
        }
    }
}