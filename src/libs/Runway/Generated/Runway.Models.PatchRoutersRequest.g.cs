
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchRoutersRequest
    {
        /// <summary>
        /// Display name. The slug is immutable and cannot be changed after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Nested merge: omitted settings fields keep their current values. When models is present, omitted models.mode or models.ids are preserved (sending only optimizeFor does not clear the model allowlist or credit ceiling).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Runway.PatchRoutersRequestSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name. The slug is immutable and cannot be changed after creation.
        /// </param>
        /// <param name="description"></param>
        /// <param name="settings">
        /// Nested merge: omitted settings fields keep their current values. When models is present, omitted models.mode or models.ids are preserved (sending only optimizeFor does not clear the model allowlist or credit ceiling).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRoutersRequest(
            string? name,
            string? description,
            global::Runway.PatchRoutersRequestSettings? settings)
        {
            this.Name = name;
            this.Description = description;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersRequest" /> class.
        /// </summary>
        public PatchRoutersRequest()
        {
        }

    }
}