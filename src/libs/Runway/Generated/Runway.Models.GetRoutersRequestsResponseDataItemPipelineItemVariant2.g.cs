
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRoutersRequestsResponseDataItemPipelineItemVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"capacity"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "capacity";

        /// <summary>
        /// Model IDs that were eligible but passed over because the account was at its concurrency limit for them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Skipped { get; set; }

        /// <summary>
        /// True when every eligible model was at its limit, in which case none was skipped and the selected task queues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allExhausted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllExhausted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersRequestsResponseDataItemPipelineItemVariant2" /> class.
        /// </summary>
        /// <param name="skipped">
        /// Model IDs that were eligible but passed over because the account was at its concurrency limit for them.
        /// </param>
        /// <param name="allExhausted">
        /// True when every eligible model was at its limit, in which case none was skipped and the selected task queues.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersRequestsResponseDataItemPipelineItemVariant2(
            global::System.Collections.Generic.IList<string> skipped,
            bool allExhausted,
            string type = "capacity")
        {
            this.Type = type;
            this.Skipped = skipped ?? throw new global::System.ArgumentNullException(nameof(skipped));
            this.AllExhausted = allExhausted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersRequestsResponseDataItemPipelineItemVariant2" /> class.
        /// </summary>
        public GetRoutersRequestsResponseDataItemPipelineItemVariant2()
        {
        }

    }
}