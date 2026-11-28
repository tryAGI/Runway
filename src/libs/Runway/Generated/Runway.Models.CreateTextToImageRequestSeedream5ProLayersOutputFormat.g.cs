
#nullable enable

namespace Runway
{
    /// <summary>
    /// Base image format; defaults to png. Separated layers always use PNG with transparency.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5ProLayersOutputFormat
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
    public static class CreateTextToImageRequestSeedream5ProLayersOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5ProLayersOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5ProLayersOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestSeedream5ProLayersOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5ProLayersOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestSeedream5ProLayersOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestSeedream5ProLayersOutputFormat.Png,
                _ => null,
            };
        }
    }
}