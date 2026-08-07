
#nullable enable

namespace Runway
{
    /// <summary>
    /// Hard-filter stage that ran: capability (modality/feature fit), prompt_length (prompt within model limits), input_support (requested inputs/assets), allow_deny (router model allowlist/denylist), or price (credit ceiling).
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter
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
    public static class GetRoutersRequestsResponseDataItemPipelineItemVariant1FilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.AllowDeny => "allow_deny",
                GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.Capability => "capability",
                GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.InputSupport => "input_support",
                GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.Price => "price",
                GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.AllowDeny,
                "capability" => GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.Capability,
                "input_support" => GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.InputSupport,
                "price" => GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.Price,
                "prompt_length" => GetRoutersRequestsResponseDataItemPipelineItemVariant1Filter.PromptLength,
                _ => null,
            };
        }
    }
}