
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateTextToVideoRequestKling30StandardProviderSettingsShotType
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
    public static class CreateTextToVideoRequestKling30StandardProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestKling30StandardProviderSettingsShotType value)
        {
            return value switch
            {
                CreateTextToVideoRequestKling30StandardProviderSettingsShotType.Customize => "customize",
                CreateTextToVideoRequestKling30StandardProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestKling30StandardProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateTextToVideoRequestKling30StandardProviderSettingsShotType.Customize,
                "intelligence" => CreateTextToVideoRequestKling30StandardProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}