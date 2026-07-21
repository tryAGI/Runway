
#nullable enable

namespace Runway
{
    /// <summary>
    /// Soft preference among eligible models: cost, latency, or quality.
    /// </summary>
    public enum GetRoutersResponseSettingsOptimizeFor
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
    public static class GetRoutersResponseSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersResponseSettingsOptimizeFor value)
        {
            return value switch
            {
                GetRoutersResponseSettingsOptimizeFor.Cost => "cost",
                GetRoutersResponseSettingsOptimizeFor.Latency => "latency",
                GetRoutersResponseSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersResponseSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetRoutersResponseSettingsOptimizeFor.Cost,
                "latency" => GetRoutersResponseSettingsOptimizeFor.Latency,
                "quality" => GetRoutersResponseSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}