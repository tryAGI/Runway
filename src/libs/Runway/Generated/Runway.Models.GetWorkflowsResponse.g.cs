
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowsResponse
    {
        /// <summary>
        /// The globally unique ID of the published workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the published workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the published workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A monotonically increasing version number. Each workflow version for the same published workflow has a unique version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// When this version was published
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When this version was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The workflow graph definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetWorkflowsResponseGraph Graph { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The globally unique ID of the published workflow.
        /// </param>
        /// <param name="name">
        /// The name of the published workflow.
        /// </param>
        /// <param name="version">
        /// A monotonically increasing version number. Each workflow version for the same published workflow has a unique version number.
        /// </param>
        /// <param name="createdAt">
        /// When this version was published
        /// </param>
        /// <param name="updatedAt">
        /// When this version was last updated
        /// </param>
        /// <param name="graph">
        /// The workflow graph definition.
        /// </param>
        /// <param name="description">
        /// The description of the published workflow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowsResponse(
            global::System.Guid id,
            string name,
            int version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Runway.GetWorkflowsResponseGraph graph,
            string? description)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Version = version;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Graph = graph ?? throw new global::System.ArgumentNullException(nameof(graph));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponse" /> class.
        /// </summary>
        public GetWorkflowsResponse()
        {
        }
    }
}