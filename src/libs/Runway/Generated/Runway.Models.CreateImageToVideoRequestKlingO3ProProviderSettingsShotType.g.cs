
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateImageToVideoRequestKlingO3ProProviderSettingsShotType
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
    public static class CreateImageToVideoRequestKlingO3ProProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKlingO3ProProviderSettingsShotType value)
        {
            return value switch
            {
                CreateImageToVideoRequestKlingO3ProProviderSettingsShotType.Customize => "customize",
                CreateImageToVideoRequestKlingO3ProProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKlingO3ProProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateImageToVideoRequestKlingO3ProProviderSettingsShotType.Customize,
                "intelligence" => CreateImageToVideoRequestKlingO3ProProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}