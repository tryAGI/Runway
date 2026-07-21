
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateVideoResponsePipelineItemFilter
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
    public static class CreateGenerateVideoResponsePipelineItemFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponsePipelineItemFilter value)
        {
            return value switch
            {
                CreateGenerateVideoResponsePipelineItemFilter.AllowDeny => "allow_deny",
                CreateGenerateVideoResponsePipelineItemFilter.Capability => "capability",
                CreateGenerateVideoResponsePipelineItemFilter.InputSupport => "input_support",
                CreateGenerateVideoResponsePipelineItemFilter.Price => "price",
                CreateGenerateVideoResponsePipelineItemFilter.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponsePipelineItemFilter? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateVideoResponsePipelineItemFilter.AllowDeny,
                "capability" => CreateGenerateVideoResponsePipelineItemFilter.Capability,
                "input_support" => CreateGenerateVideoResponsePipelineItemFilter.InputSupport,
                "price" => CreateGenerateVideoResponsePipelineItemFilter.Price,
                "prompt_length" => CreateGenerateVideoResponsePipelineItemFilter.PromptLength,
                _ => null,
            };
        }
    }
}