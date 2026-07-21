
#nullable enable

namespace Runway
{
    /// <summary>
    /// Soft preference among eligible models: cost, latency, or quality.
    /// </summary>
    public enum CreateRoutersResponseSettingsOptimizeFor
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
    public static class CreateRoutersResponseSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRoutersResponseSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateRoutersResponseSettingsOptimizeFor.Cost => "cost",
                CreateRoutersResponseSettingsOptimizeFor.Latency => "latency",
                CreateRoutersResponseSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRoutersResponseSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateRoutersResponseSettingsOptimizeFor.Cost,
                "latency" => CreateRoutersResponseSettingsOptimizeFor.Latency,
                "quality" => CreateRoutersResponseSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}