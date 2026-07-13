
#nullable enable

namespace Runway
{
    /// <summary>
    /// The file format of the output image. Defaults to png.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5LiteOutputFormat
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
    public static class CreateTextToImageRequestSeedream5LiteOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5LiteOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5LiteOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestSeedream5LiteOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5LiteOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestSeedream5LiteOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestSeedream5LiteOutputFormat.Png,
                _ => null,
            };
        }
    }
}