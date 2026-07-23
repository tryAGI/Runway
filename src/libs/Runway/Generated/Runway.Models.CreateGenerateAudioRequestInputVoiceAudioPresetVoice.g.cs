
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset voice.
    /// </summary>
    public sealed partial class CreateGenerateAudioRequestInputVoiceAudioPresetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "preset";

        /// <summary>
        /// A Runway preset voice id. Choosing a preset routes only to models that support preset voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInputVoiceAudioPresetVoice" /> class.
        /// </summary>
        /// <param name="presetId">
        /// A Runway preset voice id. Choosing a preset routes only to models that support preset voices.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioRequestInputVoiceAudioPresetVoice(
            global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId presetId,
            string type = "preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInputVoiceAudioPresetVoice" /> class.
        /// </summary>
        public CreateGenerateAudioRequestInputVoiceAudioPresetVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateGenerateAudioRequestInputVoiceAudioPresetVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateGenerateAudioRequestInputVoiceAudioPresetVoice FromPresetId(global::Runway.CreateGenerateAudioRequestInputVoiceAudioPresetVoicePresetId presetId)
        {
            return new CreateGenerateAudioRequestInputVoiceAudioPresetVoice
            {
                PresetId = presetId,
            };
        }

    }
}