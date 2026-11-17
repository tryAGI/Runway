
#nullable enable

namespace Runway
{
    /// <summary>
    /// How much reasoning the model spends on the image. Defaults to `high`.<br/>
    /// Default Value: high
    /// </summary>
    public enum CreateTextToImageRequestGptImage26FlareReasoningEffort
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
    public static class CreateTextToImageRequestGptImage26FlareReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGptImage26FlareReasoningEffort value)
        {
            return value switch
            {
                CreateTextToImageRequestGptImage26FlareReasoningEffort.High => "high",
                CreateTextToImageRequestGptImage26FlareReasoningEffort.Low => "low",
                CreateTextToImageRequestGptImage26FlareReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGptImage26FlareReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateTextToImageRequestGptImage26FlareReasoningEffort.High,
                "low" => CreateTextToImageRequestGptImage26FlareReasoningEffort.Low,
                "medium" => CreateTextToImageRequestGptImage26FlareReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}