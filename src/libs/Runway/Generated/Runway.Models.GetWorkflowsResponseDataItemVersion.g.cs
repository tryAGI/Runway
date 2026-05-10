
#nullable enable

namespace Runway
{
    /// <summary>
    /// A specific published version of a workflow.
    /// </summary>
    public sealed partial class GetWorkflowsResponseDataItemVersion
    {
        /// <summary>
        /// The globally unique ID of this published workflow version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponseDataItemVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// The globally unique ID of this published workflow version.
        /// </param>
        /// <param name="version">
        /// A monotonically increasing version number. Each workflow version for the same published workflow has a unique version number.
        /// </param>
        /// <param name="createdAt">
        /// When this version was published
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowsResponseDataItemVersion(
            global::System.Guid id,
            int version,
            global::System.DateTime createdAt)
        {
            this.Id = id;
            this.Version = version;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowsResponseDataItemVersion" /> class.
        /// </summary>
        public GetWorkflowsResponseDataItemVersion()
        {
        }

    }
}