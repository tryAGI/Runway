
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateTextToVideoRequestKlingO3ProProviderSettingsShotType
    {
        /// <summary>
        ///
        /// </summary>
        Customize,
        /// <summary>
        ///
        /// </summary>
        Intelligence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestKlingO3ProProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKlingO3ProProviderSettingsShotType value)
        {
            return value switch
            {
                CreateTextToVideoRequestKlingO3ProProviderSettingsShotType.Customize => "customize",
                CreateTextToVideoRequestKlingO3ProProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKlingO3ProProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateTextToVideoRequestKlingO3ProProviderSettingsShotType.Customize,
                "intelligence" => CreateTextToVideoRequestKlingO3ProProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}