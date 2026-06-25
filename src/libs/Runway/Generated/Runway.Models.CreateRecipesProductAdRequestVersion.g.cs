
#nullable enable

namespace Runway
{
    /// <summary>
    /// Workflow version. Use a dated version (e.g. "2026-07") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
    /// </summary>
    public enum CreateRecipesProductAdRequestVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x202606,
        /// <summary>
        /// 
        /// </summary>
        x202607,
        /// <summary>
        /// 
        /// </summary>
        UnsafeLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesProductAdRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductAdRequestVersion value)
        {
            return value switch
            {
                CreateRecipesProductAdRequestVersion.x202606 => "2026-06",
                CreateRecipesProductAdRequestVersion.x202607 => "2026-07",
                CreateRecipesProductAdRequestVersion.UnsafeLatest => "unsafe-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductAdRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-06" => CreateRecipesProductAdRequestVersion.x202606,
                "2026-07" => CreateRecipesProductAdRequestVersion.x202607,
                "unsafe-latest" => CreateRecipesProductAdRequestVersion.UnsafeLatest,
                _ => null,
            };
        }
    }
}