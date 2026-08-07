
#nullable enable

namespace Runway
{
    /// <summary>
    /// The single optimization preference the config selected, used as the soft weighting when scoring eligible models.
    /// </summary>
    public enum CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor
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
    public static class CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor.Cost => "cost",
                CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor.Latency => "latency",
                CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor.Cost,
                "latency" => CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor.Latency,
                "quality" => CreateGenerateImageResponseRoutedImageDryRunRoutingResolvedSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}