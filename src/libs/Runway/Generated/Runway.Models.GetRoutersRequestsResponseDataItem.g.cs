
#nullable enable

namespace Runway
{
    /// <summary>
    /// A recorded Model Router routing decision.
    /// </summary>
    public sealed partial class GetRoutersRequestsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// How the routing attempt ended: routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetRoutersRequestsResponseDataItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Free-text explanation of the pick. Written by the ranker, so treat it as prose for humans and group on reasonCode instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Why the model won: lowest_cost, best_latency, best_quality, only_eligible_model, or filter_order_fallback (ranking was unavailable, so hard-filter order stood). Null when the request never reached ranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasonCode")]
        public global::Runway.GetRoutersRequestsResponseDataItemReasonCode2? ReasonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedCredits")]
        public double? EstimatedCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public global::System.Guid? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Ordered routing story: hard-filter stages with surviving model ids, a capacity step when concurrency limits affected the pool, then rank step when selection reached ranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.PipelineItem> Pipeline { get; set; }

        /// <summary>
        /// The filter(s) that reduced the eligible pool to zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptiedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem> EmptiedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersRequestsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="status">
        /// How the routing attempt ended: routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="pipeline">
        /// Ordered routing story: hard-filter stages with surviving model ids, a capacity step when concurrency limits affected the pool, then rank step when selection reached ranking.
        /// </param>
        /// <param name="emptiedBy">
        /// The filter(s) that reduced the eligible pool to zero.
        /// </param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="reason">
        /// Free-text explanation of the pick. Written by the ranker, so treat it as prose for humans and group on reasonCode instead.
        /// </param>
        /// <param name="reasonCode">
        /// Why the model won: lowest_cost, best_latency, best_quality, only_eligible_model, or filter_order_fallback (ranking was unavailable, so hard-filter order stood). Null when the request never reached ranking.
        /// </param>
        /// <param name="estimatedCredits"></param>
        /// <param name="taskId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersRequestsResponseDataItem(
            global::System.Guid id,
            string requestId,
            global::Runway.GetRoutersRequestsResponseDataItemStatus status,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Runway.PipelineItem> pipeline,
            global::System.Collections.Generic.IList<global::Runway.GetRoutersRequestsResponseDataItemEmptiedByItem> emptiedBy,
            string? model,
            string? provider,
            string? reason,
            global::Runway.GetRoutersRequestsResponseDataItemReasonCode2? reasonCode,
            double? estimatedCredits,
            global::System.Guid? taskId)
        {
            this.Id = id;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Status = status;
            this.Model = model;
            this.Provider = provider;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.EstimatedCredits = estimatedCredits;
            this.TaskId = taskId;
            this.CreatedAt = createdAt;
            this.Pipeline = pipeline ?? throw new global::System.ArgumentNullException(nameof(pipeline));
            this.EmptiedBy = emptiedBy ?? throw new global::System.ArgumentNullException(nameof(emptiedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersRequestsResponseDataItem" /> class.
        /// </summary>
        public GetRoutersRequestsResponseDataItem()
        {
        }

    }
}