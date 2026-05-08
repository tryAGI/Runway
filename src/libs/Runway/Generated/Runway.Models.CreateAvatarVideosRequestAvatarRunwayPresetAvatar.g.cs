
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset avatar from Runway.
    /// </summary>
    public sealed partial class CreateAvatarVideosRequestAvatarRunwayPresetAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"runway-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "runway-preset";

        /// <summary>
        /// ID of a preset avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestAvatarRunwayPresetAvatar" /> class.
        /// </summary>
        /// <param name="presetId">
        /// ID of a preset avatar.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarVideosRequestAvatarRunwayPresetAvatar(
            global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId presetId,
            string type = "runway-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestAvatarRunwayPresetAvatar" /> class.
        /// </summary>
        public CreateAvatarVideosRequestAvatarRunwayPresetAvatar()
        {
        }
    }
}