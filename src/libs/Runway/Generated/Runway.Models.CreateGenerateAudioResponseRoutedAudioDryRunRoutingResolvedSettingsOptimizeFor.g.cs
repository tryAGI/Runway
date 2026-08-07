
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}