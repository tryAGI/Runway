
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchRoutersRequestSettingsModelsMode
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
    public static class PatchRoutersRequestSettingsModelsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchRoutersRequestSettingsModelsMode value)
        {
            return value switch
            {
                PatchRoutersRequestSettingsModelsMode.AllowNewExcept => "allow_new_except",
                PatchRoutersRequestSettingsModelsMode.AllowlistOnly => "allowlist_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchRoutersRequestSettingsModelsMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_new_except" => PatchRoutersRequestSettingsModelsMode.AllowNewExcept,
                "allowlist_only" => PatchRoutersRequestSettingsModelsMode.AllowlistOnly,
                _ => null,
            };
        }
    }
}