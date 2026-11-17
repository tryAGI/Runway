
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset avatar from Runway.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar" /> class.
        /// </summary>
        /// <param name="presetId">
        /// ID of a preset avatar.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId presetId,
            string type = "runway-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar FromPresetId(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatarPresetId presetId)
        {
            return new CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar
            {
                PresetId = presetId,
            };
        }

    }
}