
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateImageResponseVariant1PipelineItemFilter
    {
        /// <summary>
        /// 
        /// </summary>
        AllowDeny,
        /// <summary>
        /// 
        /// </summary>
        Capability,
        /// <summary>
        /// 
        /// </summary>
        InputSupport,
        /// <summary>
        /// 
        /// </summary>
        Price,
        /// <summary>
        /// 
        /// </summary>
        PromptLength,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateImageResponseVariant1PipelineItemFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageResponseVariant1PipelineItemFilter value)
        {
            return value switch
            {
                CreateGenerateImageResponseVariant1PipelineItemFilter.AllowDeny => "allow_deny",
                CreateGenerateImageResponseVariant1PipelineItemFilter.Capability => "capability",
                CreateGenerateImageResponseVariant1PipelineItemFilter.InputSupport => "input_support",
                CreateGenerateImageResponseVariant1PipelineItemFilter.Price => "price",
                CreateGenerateImageResponseVariant1PipelineItemFilter.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageResponseVariant1PipelineItemFilter? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateImageResponseVariant1PipelineItemFilter.AllowDeny,
                "capability" => CreateGenerateImageResponseVariant1PipelineItemFilter.Capability,
                "input_support" => CreateGenerateImageResponseVariant1PipelineItemFilter.InputSupport,
                "price" => CreateGenerateImageResponseVariant1PipelineItemFilter.Price,
                "prompt_length" => CreateGenerateImageResponseVariant1PipelineItemFilter.PromptLength,
                _ => null,
            };
        }
    }
}