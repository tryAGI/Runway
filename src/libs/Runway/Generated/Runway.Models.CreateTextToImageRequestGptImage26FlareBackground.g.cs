
#nullable enable

namespace Runway
{
    /// <summary>
    /// Background treatment. Defaults to `auto`, which lets the model pick. Use `transparent` for an alpha-channel background, which `jpeg` output does not support.
    /// </summary>
    public enum CreateTextToImageRequestGptImage26FlareBackground
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
    public static class CreateTextToImageRequestGptImage26FlareBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26FlareBackground value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26FlareBackground.Auto => "auto",
                CreateTextToImageRequestGptImage26FlareBackground.Opaque => "opaque",
                CreateTextToImageRequestGptImage26FlareBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26FlareBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGptImage26FlareBackground.Auto,
                "opaque" => CreateTextToImageRequestGptImage26FlareBackground.Opaque,
                "transparent" => CreateTextToImageRequestGptImage26FlareBackground.Transparent,
                _ => null,
            };
        }
    }
}