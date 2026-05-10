
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentsResponse2
    {
        /// <summary>
        /// The unique identifier of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetDocumentsResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetDocumentsResponseType Type { get; set; }

        /// <summary>
        /// Avatars that use this document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseUsedByItem> UsedBy { get; set; }

        /// <summary>
        /// The full content of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// When the document was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the document was last updated.
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
        /// Initializes a new instance of the <see cref="GetDocumentsResponse2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the document.
        /// </param>
        /// <param name="name">
        /// The name of the document.
        /// </param>
        /// <param name="type">
        /// The type of document.
        /// </param>
        /// <param name="usedBy">
        /// Avatars that use this document.
        /// </param>
        /// <param name="content">
        /// The full content of the document.
        /// </param>
        /// <param name="createdAt">
        /// When the document was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the document was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentsResponse2(
            global::System.Guid id,
            string name,
            global::Runway.GetDocumentsResponseType type,
            global::System.Collections.Generic.IList<global::Runway.GetDocumentsResponseUsedByItem> usedBy,
            string content,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentsResponse2" /> class.
        /// </summary>
        public GetDocumentsResponse2()
        {
        }

    }
}