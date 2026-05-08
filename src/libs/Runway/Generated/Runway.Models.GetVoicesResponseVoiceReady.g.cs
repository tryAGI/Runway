
#nullable enable

namespace Runway
{
    /// <summary>
    /// A voice that is ready for use.
    /// </summary>
    public sealed partial class GetVoicesResponseVoiceReady
    {
        /// <summary>
        /// The unique identifier of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the voice, or null if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the voice was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"READY"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "READY";

        /// <summary>
        /// A signed URL to an MP3 audio sample of the voice, or null if no sample is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewUrl")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseVoiceReady" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the voice.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="createdAt">
        /// When the voice was created.
        /// </param>
        /// <param name="description">
        /// A description of the voice, or null if not set.
        /// </param>
        /// <param name="previewUrl">
        /// A signed URL to an MP3 audio sample of the voice, or null if no sample is available.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesResponseVoiceReady(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            string? description,
            string? previewUrl,
            string status = "READY")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseVoiceReady" /> class.
        /// </summary>
        public GetVoicesResponseVoiceReady()
        {
        }
    }
}