
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType
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
    public static class CreateTextToVideoRequestKlingO3StandardProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType value)
        {
            return value switch
            {
                CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType.Customize => "customize",
                CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType.Customize,
                "intelligence" => CreateTextToVideoRequestKlingO3StandardProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}