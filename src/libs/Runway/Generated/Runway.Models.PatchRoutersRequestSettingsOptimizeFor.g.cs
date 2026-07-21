
#nullable enable

namespace Runway
{
    /// <summary>
    /// Soft preference among eligible models: cost, latency, or quality.
    /// </summary>
    public enum PatchRoutersRequestSettingsOptimizeFor
    {
        /// <summary>
        /// cost, latency, or quality.
        /// </summary>
        Cost,
        /// <summary>
        /// cost, latency, or quality.
        /// </summary>
        Latency,
        /// <summary>
        /// cost, latency, or quality.
        /// </summary>
        Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchRoutersRequestSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchRoutersRequestSettingsOptimizeFor value)
        {
            return value switch
            {
                PatchRoutersRequestSettingsOptimizeFor.Cost => "cost",
                PatchRoutersRequestSettingsOptimizeFor.Latency => "latency",
                PatchRoutersRequestSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchRoutersRequestSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => PatchRoutersRequestSettingsOptimizeFor.Cost,
                "latency" => PatchRoutersRequestSettingsOptimizeFor.Latency,
                "quality" => PatchRoutersRequestSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}