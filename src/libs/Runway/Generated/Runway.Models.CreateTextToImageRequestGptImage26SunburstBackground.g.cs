
#nullable enable

namespace Runway
{
    /// <summary>
    /// Background treatment. Defaults to `auto`, which lets the model pick. Use `transparent` to generate a PNG with an alpha-channel background.
    /// </summary>
    public enum CreateTextToImageRequestGptImage26SunburstBackground
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
    public static class CreateTextToImageRequestGptImage26SunburstBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26SunburstBackground value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26SunburstBackground.Auto => "auto",
                CreateTextToImageRequestGptImage26SunburstBackground.Opaque => "opaque",
                CreateTextToImageRequestGptImage26SunburstBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26SunburstBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGptImage26SunburstBackground.Auto,
                "opaque" => CreateTextToImageRequestGptImage26SunburstBackground.Opaque,
                "transparent" => CreateTextToImageRequestGptImage26SunburstBackground.Transparent,
                _ => null,
            };
        }
    }
}