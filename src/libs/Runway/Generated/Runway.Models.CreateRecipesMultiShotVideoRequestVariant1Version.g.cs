
#nullable enable

namespace Runway
{
    /// <summary>
    /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
    /// </summary>
    public enum CreateRecipesMultiShotVideoRequestVariant1Version
    {
        /// <summary>
        /// 
        /// </summary>
        x202606,
        /// <summary>
        /// 
        /// </summary>
        UnsafeLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesMultiShotVideoRequestVariant1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesMultiShotVideoRequestVariant1Version value)
        {
            return value switch
            {
                CreateRecipesMultiShotVideoRequestVariant1Version.x202606 => "2026-06",
                CreateRecipesMultiShotVideoRequestVariant1Version.UnsafeLatest => "unsafe-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesMultiShotVideoRequestVariant1Version? ToEnum(string value)
        {
            return value switch
            {
                "2026-06" => CreateRecipesMultiShotVideoRequestVariant1Version.x202606,
                "unsafe-latest" => CreateRecipesMultiShotVideoRequestVariant1Version.UnsafeLatest,
                _ => null,
            };
        }
    }
}