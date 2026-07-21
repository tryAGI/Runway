
#nullable enable

namespace Runway
{
    /// <summary>
    /// Soft preference among eligible models: cost, latency, or quality.
    /// </summary>
    public enum CreateRoutersRequestSettingsOptimizeFor
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
    public static class CreateRoutersRequestSettingsOptimizeForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRoutersRequestSettingsOptimizeFor value)
        {
            return value switch
            {
                CreateRoutersRequestSettingsOptimizeFor.Cost => "cost",
                CreateRoutersRequestSettingsOptimizeFor.Latency => "latency",
                CreateRoutersRequestSettingsOptimizeFor.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRoutersRequestSettingsOptimizeFor? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateRoutersRequestSettingsOptimizeFor.Cost,
                "latency" => CreateRoutersRequestSettingsOptimizeFor.Latency,
                "quality" => CreateRoutersRequestSettingsOptimizeFor.Quality,
                _ => null,
            };
        }
    }
}