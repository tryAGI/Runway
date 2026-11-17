
#nullable enable

namespace Runway
{
    /// <summary>
    /// Background treatment. Defaults to `auto`, which lets the model pick. Use `transparent` to generate a PNG with an alpha-channel background.
    /// </summary>
    public enum CreateTextToImageRequestGptImage25SunburstBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGptImage25SunburstBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage25SunburstBackground value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage25SunburstBackground.Auto => "auto",
                CreateTextToImageRequestGptImage25SunburstBackground.Opaque => "opaque",
                CreateTextToImageRequestGptImage25SunburstBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage25SunburstBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGptImage25SunburstBackground.Auto,
                "opaque" => CreateTextToImageRequestGptImage25SunburstBackground.Opaque,
                "transparent" => CreateTextToImageRequestGptImage25SunburstBackground.Transparent,
                _ => null,
            };
        }
    }
}