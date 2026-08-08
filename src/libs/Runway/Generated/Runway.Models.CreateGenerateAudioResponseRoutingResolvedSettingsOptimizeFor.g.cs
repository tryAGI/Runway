
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateAudioResponseRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}