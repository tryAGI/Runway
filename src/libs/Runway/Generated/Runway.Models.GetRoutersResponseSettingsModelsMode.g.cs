
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutersResponseSettingsModelsMode
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
    public static class GetRoutersResponseSettingsModelsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersResponseSettingsModelsMode value)
        {
            return value switch
            {
                GetRoutersResponseSettingsModelsMode.AllowNewExcept => "allow_new_except",
                GetRoutersResponseSettingsModelsMode.AllowlistOnly => "allowlist_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersResponseSettingsModelsMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_new_except" => GetRoutersResponseSettingsModelsMode.AllowNewExcept,
                "allowlist_only" => GetRoutersResponseSettingsModelsMode.AllowlistOnly,
                _ => null,
            };
        }
    }
}