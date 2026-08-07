
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the router chose among eligible models: cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome
    {
        /// <summary>
        /// cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
        /// </summary>
        Cost,
        /// <summary>
        /// cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
        /// </summary>
        Fallback,
        /// <summary>
        /// cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
        /// </summary>
        Selected,
        /// <summary>
        /// cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
        /// </summary>
        SingleCandidate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutersRequestsResponseDataItemPipelineItemVariant3OutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.Cost => "cost",
                GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.Fallback => "fallback",
                GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.Selected => "selected",
                GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.SingleCandidate => "single_candidate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.Cost,
                "fallback" => GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.Fallback,
                "selected" => GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.Selected,
                "single_candidate" => GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome.SingleCandidate,
                _ => null,
            };
        }
    }
}