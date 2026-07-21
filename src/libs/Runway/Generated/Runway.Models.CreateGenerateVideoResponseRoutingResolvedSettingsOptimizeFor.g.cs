
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateVideoResponseRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}