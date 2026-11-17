
#nullable enable

namespace Runway
{
    /// <summary>
    /// A voice preset from the RunwayML API.
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"runway-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "runway-preset";

        /// <summary>
        /// The preset voice ID to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The preset voice ID to use for the generated speech.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice(
            global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId presetId,
            string type = "runway-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice FromPresetId(global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoicePresetId presetId)
        {
            return new CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice
            {
                PresetId = presetId,
            };
        }

    }
}