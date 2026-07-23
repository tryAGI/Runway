
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateAudioResponseVariant1PipelineItemFilter
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
    public static class CreateGenerateAudioResponseVariant1PipelineItemFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseVariant1PipelineItemFilter value)
        {
            return value switch
            {
                CreateGenerateAudioResponseVariant1PipelineItemFilter.AllowDeny => "allow_deny",
                CreateGenerateAudioResponseVariant1PipelineItemFilter.Capability => "capability",
                CreateGenerateAudioResponseVariant1PipelineItemFilter.InputSupport => "input_support",
                CreateGenerateAudioResponseVariant1PipelineItemFilter.Price => "price",
                CreateGenerateAudioResponseVariant1PipelineItemFilter.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseVariant1PipelineItemFilter? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateAudioResponseVariant1PipelineItemFilter.AllowDeny,
                "capability" => CreateGenerateAudioResponseVariant1PipelineItemFilter.Capability,
                "input_support" => CreateGenerateAudioResponseVariant1PipelineItemFilter.InputSupport,
                "price" => CreateGenerateAudioResponseVariant1PipelineItemFilter.Price,
                "prompt_length" => CreateGenerateAudioResponseVariant1PipelineItemFilter.PromptLength,
                _ => null,
            };
        }
    }
}