
#nullable enable

namespace Runway
{
    /// <summary>
    /// A record mapping workflow node IDs to arrays of output URLs for nodes that have already completed. This allows streaming partial results while the workflow is still running.
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationRunningOutput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}