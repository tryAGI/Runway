
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutersRequestsResponseDataItemPipelineItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"rank"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rank";

        /// <summary>
        /// How the router chose among eligible models: cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetRoutersRequestsResponseDataItemPipelineItemVariant3OutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersRequestsResponseDataItemPipelineItemVariant3" /> class.
        /// </summary>
        /// <param name="outcome">
        /// How the router chose among eligible models: cost (sorted by estimated credits), selected (preference ranking chose a model), fallback (preference ranking failed so the eligible models were left in filter order), or single_candidate (only one model remained).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersRequestsResponseDataItemPipelineItemVariant3(
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome outcome,
            string type = "rank")
        {
            this.Type = type;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersRequestsResponseDataItemPipelineItemVariant3" /> class.
        /// </summary>
        public GetRoutersRequestsResponseDataItemPipelineItemVariant3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetRoutersRequestsResponseDataItemPipelineItemVariant3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemPipelineItemVariant3 FromOutcome(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3Outcome outcome)
        {
            return new GetRoutersRequestsResponseDataItemPipelineItemVariant3
            {
                Outcome = outcome,
            };
        }

    }
}