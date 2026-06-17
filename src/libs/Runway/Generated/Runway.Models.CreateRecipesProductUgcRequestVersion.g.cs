
#nullable enable

namespace Runway
{
    /// <summary>
    /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
    /// </summary>
    public enum CreateRecipesProductUgcRequestVersion
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
    public static class CreateRecipesProductUgcRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductUgcRequestVersion value)
        {
            return value switch
            {
                CreateRecipesProductUgcRequestVersion.x202606 => "2026-06",
                CreateRecipesProductUgcRequestVersion.UnsafeLatest => "unsafe-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductUgcRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-06" => CreateRecipesProductUgcRequestVersion.x202606,
                "unsafe-latest" => CreateRecipesProductUgcRequestVersion.UnsafeLatest,
                _ => null,
            };
        }
    }
}