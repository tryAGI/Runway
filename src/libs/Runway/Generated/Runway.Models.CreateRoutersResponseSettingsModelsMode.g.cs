
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRoutersResponseSettingsModelsMode
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
    public static class CreateRoutersResponseSettingsModelsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRoutersResponseSettingsModelsMode value)
        {
            return value switch
            {
                CreateRoutersResponseSettingsModelsMode.AllowNewExcept => "allow_new_except",
                CreateRoutersResponseSettingsModelsMode.AllowlistOnly => "allowlist_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRoutersResponseSettingsModelsMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_new_except" => CreateRoutersResponseSettingsModelsMode.AllowNewExcept,
                "allowlist_only" => CreateRoutersResponseSettingsModelsMode.AllowlistOnly,
                _ => null,
            };
        }
    }
}