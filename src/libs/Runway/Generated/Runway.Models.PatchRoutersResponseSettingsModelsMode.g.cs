
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchRoutersResponseSettingsModelsMode
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
    public static class PatchRoutersResponseSettingsModelsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchRoutersResponseSettingsModelsMode value)
        {
            return value switch
            {
                PatchRoutersResponseSettingsModelsMode.AllowNewExcept => "allow_new_except",
                PatchRoutersResponseSettingsModelsMode.AllowlistOnly => "allowlist_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchRoutersResponseSettingsModelsMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_new_except" => PatchRoutersResponseSettingsModelsMode.AllowNewExcept,
                "allowlist_only" => PatchRoutersResponseSettingsModelsMode.AllowlistOnly,
                _ => null,
            };
        }
    }
}