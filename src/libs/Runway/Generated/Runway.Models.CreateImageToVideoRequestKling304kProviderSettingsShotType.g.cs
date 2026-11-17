
#nullable enable

namespace Runway
{
    /// <summary>
    /// Shot transition type for multishot videos. Defaults to "customize" when multiPrompt is provided.
    /// </summary>
    public enum CreateImageToVideoRequestKling304kProviderSettingsShotType
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
    public static class CreateImageToVideoRequestKling304kProviderSettingsShotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestKling304kProviderSettingsShotType value)
        {
            return value switch
            {
                CreateImageToVideoRequestKling304kProviderSettingsShotType.Customize => "customize",
                CreateImageToVideoRequestKling304kProviderSettingsShotType.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestKling304kProviderSettingsShotType? ToEnum(string value)
        {
            return value switch
            {
                "customize" => CreateImageToVideoRequestKling304kProviderSettingsShotType.Customize,
                "intelligence" => CreateImageToVideoRequestKling304kProviderSettingsShotType.Intelligence,
                _ => null,
            };
        }
    }
}