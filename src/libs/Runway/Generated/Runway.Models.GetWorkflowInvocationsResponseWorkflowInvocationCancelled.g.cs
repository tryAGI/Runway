
#nullable enable

namespace Runway
{
    /// <summary>
    /// A cancelled or deleted workflow invocation
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationCancelled
    {
        /// <summary>
        /// The ID of the workflow invocation being returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The timestamp that the workflow invocation was submitted at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"CANCELLED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "CANCELLED";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationCancelled" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the workflow invocation being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the workflow invocation was submitted at.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowInvocationsResponseWorkflowInvocationCancelled(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string status = "CANCELLED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationCancelled" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationCancelled()
        {
        }
    }
}