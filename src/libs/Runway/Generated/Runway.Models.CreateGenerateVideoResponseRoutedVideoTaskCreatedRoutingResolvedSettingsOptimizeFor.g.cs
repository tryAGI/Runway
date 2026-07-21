
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}