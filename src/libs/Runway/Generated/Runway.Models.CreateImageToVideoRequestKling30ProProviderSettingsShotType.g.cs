
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateImageToVideoRequestKling30ProProviderSettingsShotType
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
    public static class CreateImageToVideoRequestKling30ProProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKling30ProProviderSettingsShotType value)
        {
            return value switch
            {
                CreateImageToVideoRequestKling30ProProviderSettingsShotType.Customize => "customize",
                CreateImageToVideoRequestKling30ProProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKling30ProProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateImageToVideoRequestKling30ProProviderSettingsShotType.Customize,
                "intelligence" => CreateImageToVideoRequestKling30ProProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}