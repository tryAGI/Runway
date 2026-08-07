
#nullable enable

namespace Runway
{
    /// <summary>
    /// Why the model won: lowest_cost, best_latency, best_quality, only_eligible_model, or filter_order_fallback (ranking was unavailable, so hard-filter order stood). Null when the request never reached ranking.
    /// </summary>
    public sealed partial class GetRoutersRequestsResponseDataItemReasonCode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}