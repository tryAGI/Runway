
#nullable enable

namespace Runway
{
    /// <summary>
    /// A record mapping workflow node IDs to arrays of output URLs. Each key is the UUID of a workflow node that produced output, and each value is an array of URLs for that node's artifacts. These URLs will expire within 24-48 hours; fetch the invocation again to get fresh URLs. It is expected that you download the assets at these URLs and store them in your own storage system.
    /// </summary>
    public sealed partial class GetWorkflowInvocationsResponseWorkflowInvocationSucceededOutput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}