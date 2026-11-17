
#nullable enable

namespace Runway
{
    /// <summary>
    /// Background treatment. Defaults to `auto`, which lets the model pick.
    /// </summary>
    public enum CreateTextToImageRequestGptImage25FlareBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGptImage25FlareBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage25FlareBackground value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage25FlareBackground.Auto => "auto",
                CreateTextToImageRequestGptImage25FlareBackground.Opaque => "opaque",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage25FlareBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGptImage25FlareBackground.Auto,
                "opaque" => CreateTextToImageRequestGptImage25FlareBackground.Opaque,
                _ => null,
            };
        }
    }
}