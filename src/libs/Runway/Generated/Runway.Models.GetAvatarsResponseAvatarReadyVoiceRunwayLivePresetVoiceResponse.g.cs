
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset voice from the Runway API.
    /// </summary>
    public sealed partial class GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"runway-live-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "runway-live-preset";

        /// <summary>
        /// The preset voice identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId PresetId { get; set; }

        /// <summary>
        /// The display name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A brief description of the voice characteristics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The preset voice identifier.
        /// </param>
        /// <param name="name">
        /// The display name of the voice.
        /// </param>
        /// <param name="description">
        /// A brief description of the voice characteristics.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse(
            global::Runway.GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponsePresetId presetId,
            string name,
            string description,
            string type = "runway-live-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse" /> class.
        /// </summary>
        public GetAvatarsResponseAvatarReadyVoiceRunwayLivePresetVoiceResponse()
        {
        }

    }
}