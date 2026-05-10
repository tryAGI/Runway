
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2
    {
        /// <summary>
        /// The human-readable name of the node that errored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeName")]
        public string? NodeName { get; set; }

        /// <summary>
        /// A human-readable description of the node error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the node error.
        /// </param>
        /// <param name="nodeName">
        /// The human-readable name of the node that errored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2(
            string message,
            string? nodeName)
        {
            this.NodeName = nodeName;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2()
        {
        }

    }
}