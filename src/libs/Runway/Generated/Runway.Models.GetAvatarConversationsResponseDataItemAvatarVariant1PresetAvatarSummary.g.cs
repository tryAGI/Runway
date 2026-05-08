
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset avatar.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"runway-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "runway-preset";

        /// <summary>
        /// The preset avatar ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresetId { get; set; }

        /// <summary>
        /// The preset avatar's display name (e.g. "Mina").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The preset avatar ID.
        /// </param>
        /// <param name="name">
        /// The preset avatar's display name (e.g. "Mina").
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary(
            string presetId,
            string name,
            string type = "runway-preset")
        {
            this.Type = type;
            this.PresetId = presetId ?? throw new global::System.ArgumentNullException(nameof(presetId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary" /> class.
        /// </summary>
        public GetAvatarConversationsResponseDataItemAvatarVariant1PresetAvatarSummary()
        {
        }
    }
}