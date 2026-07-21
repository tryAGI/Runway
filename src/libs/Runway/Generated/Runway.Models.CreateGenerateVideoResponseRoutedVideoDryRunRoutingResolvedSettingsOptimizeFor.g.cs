
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}