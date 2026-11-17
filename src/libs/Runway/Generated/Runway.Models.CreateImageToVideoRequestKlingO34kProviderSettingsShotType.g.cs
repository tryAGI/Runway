
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateImageToVideoRequestKlingO34kProviderSettingsShotType
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
    public static class CreateImageToVideoRequestKlingO34kProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKlingO34kProviderSettingsShotType value)
        {
            return value switch
            {
                CreateImageToVideoRequestKlingO34kProviderSettingsShotType.Customize => "customize",
                CreateImageToVideoRequestKlingO34kProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKlingO34kProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateImageToVideoRequestKlingO34kProviderSettingsShotType.Customize,
                "intelligence" => CreateImageToVideoRequestKlingO34kProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}