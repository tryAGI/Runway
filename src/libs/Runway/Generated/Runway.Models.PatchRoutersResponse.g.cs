
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchRoutersResponse
    {
        /// <summary>
        /// The Model Router's primary key ID (UUID). Use it to manage this router via the API; use the slug to reference the router in generation requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Immutable slug used to reference this Model Router in generation requests (for example, production-video). Unique within the API project. The UUID id remains the canonical management identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-friendly Model Router display name shown in the dev portal. Mutable, and not used to reference the router in requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional Model Router description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Current settings version. Increments when settings change; name and description updates do not create a new version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.PatchRoutersResponseSettings Settings { get; set; }

        /// <summary>
        /// When the Model Router was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the Model Router was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The Model Router's primary key ID (UUID). Use it to manage this router via the API; use the slug to reference the router in generation requests.
        /// </param>
        /// <param name="slug">
        /// Immutable slug used to reference this Model Router in generation requests (for example, production-video). Unique within the API project. The UUID id remains the canonical management identifier.
        /// </param>
        /// <param name="name">
        /// Human-friendly Model Router display name shown in the dev portal. Mutable, and not used to reference the router in requests.
        /// </param>
        /// <param name="version">
        /// Current settings version. Increments when settings change; name and description updates do not create a new version.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="createdAt">
        /// When the Model Router was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the Model Router was last updated.
        /// </param>
        /// <param name="description">
        /// An optional Model Router description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRoutersResponse(
            global::System.Guid id,
            string slug,
            string name,
            int version,
            global::Runway.PatchRoutersResponseSettings settings,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Version = version;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRoutersResponse" /> class.
        /// </summary>
        public PatchRoutersResponse()
        {
        }

    }
}