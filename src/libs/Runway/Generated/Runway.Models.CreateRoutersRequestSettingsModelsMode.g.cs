
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRoutersRequestSettingsModelsMode
    {
        /// <summary>
        /// 
        /// </summary>
        AllowNewExcept,
        /// <summary>
        /// 
        /// </summary>
        AllowlistOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRoutersRequestSettingsModelsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRoutersRequestSettingsModelsMode value)
        {
            return value switch
            {
                CreateRoutersRequestSettingsModelsMode.AllowNewExcept => "allow_new_except",
                CreateRoutersRequestSettingsModelsMode.AllowlistOnly => "allowlist_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRoutersRequestSettingsModelsMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_new_except" => CreateRoutersRequestSettingsModelsMode.AllowNewExcept,
                "allowlist_only" => CreateRoutersRequestSettingsModelsMode.AllowlistOnly,
                _ => null,
            };
        }
    }
}