
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the model rewrites the prompt before generating. disabled keeps the prompt as written. balanced (the default) does a short rewrite. quality spends extra time rewriting for a stronger result.
    /// </summary>
    public enum CreateTextToVideoRequestH3MaxPromptExpansionMode
    {
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestH3MaxPromptExpansionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestH3MaxPromptExpansionMode value)
        {
            return value switch
            {
                CreateTextToVideoRequestH3MaxPromptExpansionMode.Balanced => "balanced",
                CreateTextToVideoRequestH3MaxPromptExpansionMode.Disabled => "disabled",
                CreateTextToVideoRequestH3MaxPromptExpansionMode.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestH3MaxPromptExpansionMode? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => CreateTextToVideoRequestH3MaxPromptExpansionMode.Balanced,
                "disabled" => CreateTextToVideoRequestH3MaxPromptExpansionMode.Disabled,
                "quality" => CreateTextToVideoRequestH3MaxPromptExpansionMode.Quality,
                _ => null,
            };
        }
    }
}