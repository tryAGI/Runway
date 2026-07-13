
#nullable enable

namespace Runway
{
    /// <summary>
    /// The file format of the output image. Defaults to png.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5ProOutputFormat
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
    public static class CreateTextToImageRequestSeedream5ProOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5ProOutputFormat value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5ProOutputFormat.Jpeg => "jpeg",
                CreateTextToImageRequestSeedream5ProOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5ProOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => CreateTextToImageRequestSeedream5ProOutputFormat.Jpeg,
                "png" => CreateTextToImageRequestSeedream5ProOutputFormat.Png,
                _ => null,
            };
        }
    }
}