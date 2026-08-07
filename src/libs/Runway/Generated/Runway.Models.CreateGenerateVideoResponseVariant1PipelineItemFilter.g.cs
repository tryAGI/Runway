
#nullable enable

namespace Runway
{
    /// <summary>
    /// Hard-filter stage that ran: capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
    /// </summary>
    public enum CreateGenerateVideoResponseVariant1PipelineItemFilter
    {
        /// <summary>
        /// capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
        /// </summary>
        AllowDeny,
        /// <summary>
        /// capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
        /// </summary>
        Capability,
        /// <summary>
        /// capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
        /// </summary>
        InputSupport,
        /// <summary>
        /// capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
        /// </summary>
        Price,
        /// <summary>
        /// capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
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