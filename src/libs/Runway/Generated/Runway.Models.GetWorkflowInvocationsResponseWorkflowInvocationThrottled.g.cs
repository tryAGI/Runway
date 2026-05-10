
#nullable enable

namespace Runway
{
    /// <summary>
    /// A throttled workflow invocation
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationThrottled
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
        /// <default>"THROTTLED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "THROTTLED";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationThrottled" /> class.
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
        public GetWorkflowInvocationsResponseWorkflowInvocationThrottled(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string status = "THROTTLED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationThrottled" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationThrottled()
        {
        }

    }
}