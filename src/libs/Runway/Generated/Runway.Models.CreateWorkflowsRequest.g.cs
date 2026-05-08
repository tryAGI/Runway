
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkflowsRequest
    {
        /// <summary>
        /// Optional node outputs to override default values. Keys are node IDs from the workflow graph, values are objects mapping output keys to typed values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeOutputs")]
        public global::System.Collections.Generic.Dictionary<string, object>? NodeOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowsRequest" /> class.
        /// </summary>
        /// <param name="nodeOutputs">
        /// Optional node outputs to override default values. Keys are node IDs from the workflow graph, values are objects mapping output keys to typed values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowsRequest(
            global::System.Collections.Generic.Dictionary<string, object>? nodeOutputs)
        {
            this.NodeOutputs = nodeOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowsRequest" /> class.
        /// </summary>
        public CreateWorkflowsRequest()
        {
        }
    }
}