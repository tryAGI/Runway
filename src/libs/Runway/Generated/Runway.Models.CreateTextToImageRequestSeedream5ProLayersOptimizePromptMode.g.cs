
#nullable enable

namespace Runway
{
    /// <summary>
    /// Prompt optimization: standard prioritizes quality; fast reduces generation time. Defaults to standard.
    /// </summary>
    public enum CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode
    {
        /// <summary>
        /// standard prioritizes quality; fast reduces generation time. Defaults to standard.
        /// </summary>
        Fast,
        /// <summary>
        /// standard prioritizes quality; fast reduces generation time. Defaults to standard.
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestSeedream5ProLayersOptimizePromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode value)
        {
            return value switch
            {
                CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode.Fast => "fast",
                CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode.Fast,
                "standard" => CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode.Standard,
                _ => null,
            };
        }
    }
}