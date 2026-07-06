
#nullable enable

namespace Runway
{
    /// <summary>
    /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
    /// </summary>
    public enum CreateRecipesAdLocalizationRequestVersion
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
    public static class CreateRecipesAdLocalizationRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesAdLocalizationRequestVersion value)
        {
            return value switch
            {
                CreateRecipesAdLocalizationRequestVersion.x202606 => "2026-06",
                CreateRecipesAdLocalizationRequestVersion.UnsafeLatest => "unsafe-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesAdLocalizationRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-06" => CreateRecipesAdLocalizationRequestVersion.x202606,
                "unsafe-latest" => CreateRecipesAdLocalizationRequestVersion.UnsafeLatest,
                _ => null,
            };
        }
    }
}