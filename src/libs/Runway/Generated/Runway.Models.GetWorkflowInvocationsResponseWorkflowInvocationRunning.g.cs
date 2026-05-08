
#nullable enable

namespace Runway
{
    /// <summary>
    /// A running workflow invocation
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationRunning
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
        /// <default>"RUNNING"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "RUNNING";

        /// <summary>
        /// A number between 0 and 1 representing the overall workflow execution progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// A record mapping workflow node IDs to arrays of output URLs for nodes that have already completed. This allows streaming partial results while the workflow is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Output { get; set; }

        /// <summary>
        /// A record mapping workflow node IDs to their error details. Only present when one or more nodes have errored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeErrors")]
        public global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2>? NodeErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationRunning" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the workflow invocation being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the workflow invocation was submitted at.
        /// </param>
        /// <param name="progress">
        /// A number between 0 and 1 representing the overall workflow execution progress.
        /// </param>
        /// <param name="output">
        /// A record mapping workflow node IDs to arrays of output URLs for nodes that have already completed. This allows streaming partial results while the workflow is still running.
        /// </param>
        /// <param name="nodeErrors">
        /// A record mapping workflow node IDs to their error details. Only present when one or more nodes have errored.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowInvocationsResponseWorkflowInvocationRunning(
            global::System.Guid id,
            global::System.DateTime createdAt,
            double progress,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> output,
            global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2>? nodeErrors,
            string status = "RUNNING")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Progress = progress;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.NodeErrors = nodeErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationRunning" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationRunning()
        {
        }
    }
}