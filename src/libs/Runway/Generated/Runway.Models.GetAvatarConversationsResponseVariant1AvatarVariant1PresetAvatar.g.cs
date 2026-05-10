
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset avatar.
    /// </summary>
    public sealed partial class GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The preset avatar ID.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar(
            string presetId,
            string type = "runway-preset")
        {
            this.Type = type;
            this.PresetId = presetId ?? throw new global::System.ArgumentNullException(nameof(presetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar" /> class.
        /// </summary>
        public GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar FromPresetId(string presetId)
        {
            return new GetAvatarConversationsResponseVariant1AvatarVariant1PresetAvatar
            {
                PresetId = presetId,
            };
        }

    }
}