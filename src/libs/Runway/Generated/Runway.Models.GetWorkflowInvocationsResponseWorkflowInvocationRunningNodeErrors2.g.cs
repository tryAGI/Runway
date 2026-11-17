
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2
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
        /// A machine-readable error code for the node failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information. Absent for nodes that failed before generation began, such as an input validation error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCode")]
        public string? FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the node error.
        /// </param>
        /// <param name="nodeName">
        /// The human-readable name of the node that errored.
        /// </param>
        /// <param name="failureCode">
        /// A machine-readable error code for the node failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information. Absent for nodes that failed before generation began, such as an input validation error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2(
            string message,
            string? nodeName,
            string? failureCode)
        {
            this.NodeName = nodeName;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FailureCode = failureCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2" /> class.
        /// </summary>
        public GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2()
        {
        }

    }
}