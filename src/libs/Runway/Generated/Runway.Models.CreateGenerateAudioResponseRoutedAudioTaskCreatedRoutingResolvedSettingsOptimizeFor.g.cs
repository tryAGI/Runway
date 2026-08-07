
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}