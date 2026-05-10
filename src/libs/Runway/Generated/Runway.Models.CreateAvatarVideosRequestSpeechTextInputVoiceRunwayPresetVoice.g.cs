
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset voice from the Runway API.
    /// </summary>
    public sealed partial class CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "preset";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice" /> class.
        /// </summary>
        /// <param name="presetId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice(
            global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId presetId,
            string type = "preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice" /> class.
        /// </summary>
        public CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice FromPresetId(global::Runway.CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId presetId)
        {
            return new CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice
            {
                PresetId = presetId,
            };
        }

    }
}