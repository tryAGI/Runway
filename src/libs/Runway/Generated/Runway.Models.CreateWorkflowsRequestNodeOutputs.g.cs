
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional node outputs to override default values. Keys are node IDs from the workflow graph, values are objects mapping output keys to typed values.
    /// </summary>
    public sealed partial class CreateWorkflowsRequestNodeOutputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}