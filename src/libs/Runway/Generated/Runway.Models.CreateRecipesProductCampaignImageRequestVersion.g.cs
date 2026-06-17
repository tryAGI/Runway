
#nullable enable

namespace Runway
{
    /// <summary>
    /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
    /// </summary>
    public enum CreateRecipesProductCampaignImageRequestVersion
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
    public static class CreateRecipesProductCampaignImageRequestVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductCampaignImageRequestVersion value)
        {
            return value switch
            {
                CreateRecipesProductCampaignImageRequestVersion.x202606 => "2026-06",
                CreateRecipesProductCampaignImageRequestVersion.UnsafeLatest => "unsafe-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductCampaignImageRequestVersion? ToEnum(string value)
        {
            return value switch
            {
                "2026-06" => CreateRecipesProductCampaignImageRequestVersion.x202606,
                "unsafe-latest" => CreateRecipesProductCampaignImageRequestVersion.UnsafeLatest,
                _ => null,
            };
        }
    }
}