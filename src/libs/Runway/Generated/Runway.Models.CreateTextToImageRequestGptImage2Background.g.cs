
#nullable enable

namespace Runway
{
    /// <summary>
    /// Background treatment. Defaults to `auto`, which lets the model pick. Use `transparent` to generate a PNG with an alpha-channel background.
    /// </summary>
    public enum CreateTextToImageRequestGptImage2Background
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
    public static class CreateTextToImageRequestGptImage2BackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage2Background value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage2Background.Auto => "auto",
                CreateTextToImageRequestGptImage2Background.Opaque => "opaque",
                CreateTextToImageRequestGptImage2Background.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage2Background? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGptImage2Background.Auto,
                "opaque" => CreateTextToImageRequestGptImage2Background.Opaque,
                "transparent" => CreateTextToImageRequestGptImage2Background.Transparent,
                _ => null,
            };
        }
    }
}