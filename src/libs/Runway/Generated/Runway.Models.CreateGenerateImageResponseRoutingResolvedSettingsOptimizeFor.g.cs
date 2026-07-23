
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateImageResponseRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateImageResponseRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}