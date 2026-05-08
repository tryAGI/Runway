
#nullable enable

namespace Runway
{
    /// <summary>
    /// A custom avatar created by the user.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary
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
        /// The avatar's configured name, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The custom avatar ID, or null if deleted.
        /// </param>
        /// <param name="name">
        /// The avatar's configured name, or null if unavailable.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary(
            global::System.Guid? id,
            string? name,
            string type = "custom")
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary" /> class.
        /// </summary>
        public GetAvatarConversationsResponseDataItemAvatarVariant1CustomAvatarSummary()
        {
        }
    }
}