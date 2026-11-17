
#nullable enable

namespace Runway
{
    /// <summary>
    /// How much reasoning the model spends on the image. Defaults to `high`.<br/>
    /// Default Value: high
    /// </summary>
    public enum CreateTextToImageRequestGptImage26SunburstReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGptImage26SunburstReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26SunburstReasoningEffort value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26SunburstReasoningEffort.High => "high",
                CreateTextToImageRequestGptImage26SunburstReasoningEffort.Low => "low",
                CreateTextToImageRequestGptImage26SunburstReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26SunburstReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestGptImage26SunburstReasoningEffort.High,
                "low" => CreateTextToImageRequestGptImage26SunburstReasoningEffort.Low,
                "medium" => CreateTextToImageRequestGptImage26SunburstReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}