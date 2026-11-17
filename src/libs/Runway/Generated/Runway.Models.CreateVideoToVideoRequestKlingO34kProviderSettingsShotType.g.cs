
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateVideoToVideoRequestKlingO34kProviderSettingsShotType
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
    public static class CreateVideoToVideoRequestKlingO34kProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestKlingO34kProviderSettingsShotType value)
        {
            return value switch
            {
                CreateVideoToVideoRequestKlingO34kProviderSettingsShotType.Customize => "customize",
                CreateVideoToVideoRequestKlingO34kProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestKlingO34kProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateVideoToVideoRequestKlingO34kProviderSettingsShotType.Customize,
                "intelligence" => CreateVideoToVideoRequestKlingO34kProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}