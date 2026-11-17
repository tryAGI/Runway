
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the model rewrites the prompt before generating. disabled keeps the prompt as written. balanced (the default) does a short rewrite. quality spends extra time rewriting for a stronger result.
    /// </summary>
    public enum CreateImageToVideoRequestH3MaxPromptExpansionMode
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
    public static class CreateImageToVideoRequestH3MaxPromptExpansionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestH3MaxPromptExpansionMode value)
        {
            return value switch
            {
                CreateImageToVideoRequestH3MaxPromptExpansionMode.Balanced => "balanced",
                CreateImageToVideoRequestH3MaxPromptExpansionMode.Disabled => "disabled",
                CreateImageToVideoRequestH3MaxPromptExpansionMode.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestH3MaxPromptExpansionMode? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => CreateImageToVideoRequestH3MaxPromptExpansionMode.Balanced,
                "disabled" => CreateImageToVideoRequestH3MaxPromptExpansionMode.Disabled,
                "quality" => CreateImageToVideoRequestH3MaxPromptExpansionMode.Quality,
                _ => null,
            };
        }
    }
}