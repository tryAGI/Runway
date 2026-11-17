
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateTextToVideoRequestKlingO34kProviderSettingsShotType
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
    public static class CreateTextToVideoRequestKlingO34kProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKlingO34kProviderSettingsShotType value)
        {
            return value switch
            {
                CreateTextToVideoRequestKlingO34kProviderSettingsShotType.Customize => "customize",
                CreateTextToVideoRequestKlingO34kProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKlingO34kProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateTextToVideoRequestKlingO34kProviderSettingsShotType.Customize,
                "intelligence" => CreateTextToVideoRequestKlingO34kProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}