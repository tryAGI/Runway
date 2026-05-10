
#nullable enable

namespace Runway
{
    /// <summary>
    /// A custom avatar created by the user.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// The custom avatar ID, or null if deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The avatar name, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL to the avatar image, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar" /> class.
        /// </summary>
        /// <param name="id">
        /// The custom avatar ID, or null if deleted.
        /// </param>
        /// <param name="name">
        /// The avatar name, or null if unavailable.
        /// </param>
        /// <param name="imageUrl">
        /// URL to the avatar image, or null if unavailable.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar(
            global::System.Guid? id,
            string? name,
            string? imageUrl,
            string type = "custom")
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant2AvatarVariant1CustomAvatar()
        {
        }

    }
}