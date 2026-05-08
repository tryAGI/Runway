
#nullable enable

namespace Runway
{
    /// <summary>
    /// A record mapping workflow node IDs to their error details. Only present when one or more nodes have errored.
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationFailedNodeErrors
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}