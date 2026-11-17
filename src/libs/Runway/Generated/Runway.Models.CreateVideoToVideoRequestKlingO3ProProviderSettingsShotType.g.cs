
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType
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
    public static class CreateVideoToVideoRequestKlingO3ProProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType.Customize => "customize",
                CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType.Customize,
                "intelligence" => CreateVideoToVideoRequestKlingO3ProProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}