
#nullable enable

namespace Runway
{
    /// <summary>
    /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
    /// </summary>
    public enum CreateRecipesProductSwapRequestVersion
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
    public static class CreateRecipesProductSwapRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductSwapRequestVersion value)
        {
            return value switch
            {
                CreateRecipesProductSwapRequestVersion.x202606 => "2026-06",
                CreateRecipesProductSwapRequestVersion.UnsafeLatest => "unsafe-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductSwapRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-06" => CreateRecipesProductSwapRequestVersion.x202606,
                "unsafe-latest" => CreateRecipesProductSwapRequestVersion.UnsafeLatest,
                _ => null,
            };
        }
    }
}