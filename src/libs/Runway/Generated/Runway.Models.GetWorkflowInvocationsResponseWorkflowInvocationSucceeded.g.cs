
#nullable enable

namespace Runway
{
    /// <summary>
    /// A succeeded workflow invocation
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationSucceeded
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
        /// <default>"SUCCEEDED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "SUCCEEDED";

        /// <summary>
        /// A record mapping workflow node IDs to arrays of output URLs. Each key is the UUID of a workflow node that produced output, and each value is an array of URLs for that node's artifacts. These URLs will expire within 24-48 hours; fetch the invocation again to get fresh URLs. It is expected that you download the assets at these URLs and store them in your own storage system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Output { get; set; }

        /// <summary>
        /// A record mapping workflow node IDs to their error details. Even when the overall workflow succeeds, individual nodes may have encountered non-fatal errors. Only present when one or more nodes have errored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeErrors")]
        public global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2>? NodeErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationSucceeded" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the workflow invocation being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the workflow invocation was submitted at.
        /// </param>
        /// <param name="output">
        /// A record mapping workflow node IDs to arrays of output URLs. Each key is the UUID of a workflow node that produced output, and each value is an array of URLs for that node's artifacts. These URLs will expire within 24-48 hours; fetch the invocation again to get fresh URLs. It is expected that you download the assets at these URLs and store them in your own storage system.
        /// </param>
        /// <param name="nodeErrors">
        /// A record mapping workflow node IDs to their error details. Even when the overall workflow succeeds, individual nodes may have encountered non-fatal errors. Only present when one or more nodes have errored.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowInvocationsResponseWorkflowInvocationSucceeded(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> output,
            global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2>? nodeErrors,
            string status = "SUCCEEDED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.NodeErrors = nodeErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationSucceeded" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationSucceeded()
        {
        }

    }
}