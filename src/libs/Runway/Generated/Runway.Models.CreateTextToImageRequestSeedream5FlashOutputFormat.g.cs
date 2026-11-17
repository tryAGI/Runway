
#nullable enable

namespace Runway
{
    /// <summary>
    /// The file format of the output image. Defaults to png.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5FlashOutputFormat
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
    public static class CreateTextToImageRequestSeedream5FlashOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5FlashOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5FlashOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestSeedream5FlashOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5FlashOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestSeedream5FlashOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestSeedream5FlashOutputFormat.Png,
                _ => null,
            };
        }
    }
}