
#nullable enable

namespace Runway
{
    /// <summary>
    /// The workflow graph definition.
    /// </summary>
    public sealed partial class GetWorkflowsResponseGraph
    {
        /// <summary>
        /// The list of nodes in the workflow graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Nodes { get; set; }

        /// <summary>
        /// The list of edges connecting nodes in the workflow graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Edges { get; set; }

        /// <summary>
        /// The schema version of the workflow graph format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponseGraph" /> class.
        /// </summary>
        /// <param name="nodes">
        /// The list of nodes in the workflow graph.
        /// </param>
        /// <param name="edges">
        /// The list of edges connecting nodes in the workflow graph.
        /// </param>
        /// <param name="version">
        /// The schema version of the workflow graph format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowsResponseGraph(
            global::System.Collections.Generic.IList<object> nodes,
            global::System.Collections.Generic.IList<object> edges,
            int version)
        {
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponseGraph" /> class.
        /// </summary>
        public GetWorkflowsResponseGraph()
        {
        }
    }
}