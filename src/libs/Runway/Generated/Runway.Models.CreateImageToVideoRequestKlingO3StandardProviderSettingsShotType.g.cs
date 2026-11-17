
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType
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
    public static class CreateImageToVideoRequestKlingO3StandardProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType value)
        {
            return value switch
            {
                CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType.Customize => "customize",
                CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType.Customize,
                "intelligence" => CreateImageToVideoRequestKlingO3StandardProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}