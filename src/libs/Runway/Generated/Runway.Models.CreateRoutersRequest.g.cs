
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRoutersRequest
    {
        /// <summary>
        /// Immutable slug used to reference this Model Router in generation requests (for example, production-video). Unique within the API project. The UUID id remains the canonical management identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Optional human-readable display name for this router. Defaults to the slug when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An optional Model Router description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Model Router routing preferences. Defaults to cost-optimized allow-all when omitted. Modality is implied by the generate endpoint used with this Model Router.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Runway.CreateRoutersRequestSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoutersRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// Immutable slug used to reference this Model Router in generation requests (for example, production-video). Unique within the API project. The UUID id remains the canonical management identifier.
        /// </param>
        /// <param name="name">
        /// Optional human-readable display name for this router. Defaults to the slug when omitted.
        /// </param>
        /// <param name="description">
        /// An optional Model Router description.
        /// </param>
        /// <param name="settings">
        /// Model Router routing preferences. Defaults to cost-optimized allow-all when omitted. Modality is implied by the generate endpoint used with this Model Router.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRoutersRequest(
            string slug,
            string? name,
            string? description,
            global::Runway.CreateRoutersRequestSettings? settings)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name;
            this.Description = description;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoutersRequest" /> class.
        /// </summary>
        public CreateRoutersRequest()
        {
        }

    }
}