
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType
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
    public static class CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType.Customize => "customize",
                CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType.Customize,
                "intelligence" => CreateVideoToVideoRequestKlingO3StandardProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}