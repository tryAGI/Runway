
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateTextToVideoRequestKling30ProProviderSettingsShotType
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
    public static class CreateTextToVideoRequestKling30ProProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKling30ProProviderSettingsShotType value)
        {
            return value switch
            {
                CreateTextToVideoRequestKling30ProProviderSettingsShotType.Customize => "customize",
                CreateTextToVideoRequestKling30ProProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKling30ProProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateTextToVideoRequestKling30ProProviderSettingsShotType.Customize,
                "intelligence" => CreateTextToVideoRequestKling30ProProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}