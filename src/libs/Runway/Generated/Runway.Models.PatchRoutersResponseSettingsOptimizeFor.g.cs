
#nullable enable

namespace Runway
{
    /// <summary>
    /// Soft preference among eligible models: cost, latency, or quality.
    /// </summary>
    public enum PatchRoutersResponseSettingsOptimizeFor
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
    public static class PatchRoutersResponseSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchRoutersResponseSettingsOptimizeFor value)
        {
            return value switch
            {
                PatchRoutersResponseSettingsOptimizeFor.Cost => "cost",
                PatchRoutersResponseSettingsOptimizeFor.Latency => "latency",
                PatchRoutersResponseSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchRoutersResponseSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => PatchRoutersResponseSettingsOptimizeFor.Cost,
                "latency" => PatchRoutersResponseSettingsOptimizeFor.Latency,
                "quality" => PatchRoutersResponseSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}