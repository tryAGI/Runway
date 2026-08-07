
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset voice for Seed Audio text-to-speech.
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"seed-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "seed-preset";

        /// <summary>
        /// A Seed Audio preset voice id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice" /> class.
        /// </summary>
        /// <param name="presetId">
        /// A Seed Audio preset voice id.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice(
            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId presetId,
            string type = "seed-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice" /> class.
        /// </summary>
        public CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice FromPresetId(global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoicePresetId presetId)
        {
            return new CreateTextToSpeechRequestSeedAudioVoiceSeedPresetVoice
            {
                PresetId = presetId,
            };
        }

    }
}