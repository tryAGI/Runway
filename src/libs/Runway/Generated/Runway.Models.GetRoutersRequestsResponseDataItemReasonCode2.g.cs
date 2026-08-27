
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemReasonCode2
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
    public static class GetRoutersRequestsResponseDataItemReasonCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemReasonCode2 value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemReasonCode2.BestLatency => "best_latency",
                GetRoutersRequestsResponseDataItemReasonCode2.BestQuality => "best_quality",
                GetRoutersRequestsResponseDataItemReasonCode2.FilterOrderFallback => "filter_order_fallback",
                GetRoutersRequestsResponseDataItemReasonCode2.LowestCost => "lowest_cost",
                GetRoutersRequestsResponseDataItemReasonCode2.OnlyEligibleModel => "only_eligible_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemReasonCode2? ToEnum(string value)
        {
            return value switch
            {
                "best_latency" => GetRoutersRequestsResponseDataItemReasonCode2.BestLatency,
                "best_quality" => GetRoutersRequestsResponseDataItemReasonCode2.BestQuality,
                "filter_order_fallback" => GetRoutersRequestsResponseDataItemReasonCode2.FilterOrderFallback,
                "lowest_cost" => GetRoutersRequestsResponseDataItemReasonCode2.LowestCost,
                "only_eligible_model" => GetRoutersRequestsResponseDataItemReasonCode2.OnlyEligibleModel,
                _ => null,
            };
        }
    }
}