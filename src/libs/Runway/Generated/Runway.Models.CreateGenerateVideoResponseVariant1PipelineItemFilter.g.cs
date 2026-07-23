
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateVideoResponseVariant1PipelineItemFilter
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
    public static class CreateGenerateVideoResponseVariant1PipelineItemFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseVariant1PipelineItemFilter value)
        {
            return value switch
            {
                CreateGenerateVideoResponseVariant1PipelineItemFilter.AllowDeny => "allow_deny",
                CreateGenerateVideoResponseVariant1PipelineItemFilter.Capability => "capability",
                CreateGenerateVideoResponseVariant1PipelineItemFilter.InputSupport => "input_support",
                CreateGenerateVideoResponseVariant1PipelineItemFilter.Price => "price",
                CreateGenerateVideoResponseVariant1PipelineItemFilter.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseVariant1PipelineItemFilter? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateVideoResponseVariant1PipelineItemFilter.AllowDeny,
                "capability" => CreateGenerateVideoResponseVariant1PipelineItemFilter.Capability,
                "input_support" => CreateGenerateVideoResponseVariant1PipelineItemFilter.InputSupport,
                "price" => CreateGenerateVideoResponseVariant1PipelineItemFilter.Price,
                "prompt_length" => CreateGenerateVideoResponseVariant1PipelineItemFilter.PromptLength,
                _ => null,
            };
        }
    }
}