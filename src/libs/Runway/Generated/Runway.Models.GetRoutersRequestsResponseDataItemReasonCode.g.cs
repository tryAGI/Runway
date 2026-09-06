
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemReasonCode
    {
        /// <summary>
        ///
        /// </summary>
        BestLatency,
        /// <summary>
        ///
        /// </summary>
        BestQuality,
        /// <summary>
        ///
        /// </summary>
        FilterOrderFallback,
        /// <summary>
        ///
        /// </summary>
        LowestCost,
        /// <summary>
        ///
        /// </summary>
        OnlyEligibleModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutersRequestsResponseDataItemReasonCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemReasonCode value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemReasonCode.BestLatency => "best_latency",
                GetRoutersRequestsResponseDataItemReasonCode.BestQuality => "best_quality",
                GetRoutersRequestsResponseDataItemReasonCode.FilterOrderFallback => "filter_order_fallback",
                GetRoutersRequestsResponseDataItemReasonCode.LowestCost => "lowest_cost",
                GetRoutersRequestsResponseDataItemReasonCode.OnlyEligibleModel => "only_eligible_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemReasonCode? ToEnum(string value)
        {
            return value switch
            {
                "best_latency" => GetRoutersRequestsResponseDataItemReasonCode.BestLatency,
                "best_quality" => GetRoutersRequestsResponseDataItemReasonCode.BestQuality,
                "filter_order_fallback" => GetRoutersRequestsResponseDataItemReasonCode.FilterOrderFallback,
                "lowest_cost" => GetRoutersRequestsResponseDataItemReasonCode.LowestCost,
                "only_eligible_model" => GetRoutersRequestsResponseDataItemReasonCode.OnlyEligibleModel,
                _ => null,
            };
        }
    }
}