
#nullable enable

namespace Runway
{
    /// <summary>
    /// A preset voice from the Runway API.
    /// </summary>
    public sealed partial class CreateAvatarsRequestVoiceRunwayLivePresetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"runway-live-preset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "runway-live-preset";

        /// <summary>
        /// The ID of a preset voice. Available voices: `victoria` (Victoria), `vincent` (Vincent), `clara` (Clara), `drew` (Drew), `skye` (Skye), `max` (Max), `morgan` (Morgan), `felix` (Felix), `mia` (Mia), `marcus` (Marcus), `summer` (Summer), `ruby` (Ruby), `aurora` (Aurora), `jasper` (Jasper), `leo` (Leo), `adrian` (Adrian), `nina` (Nina), `emma` (Emma), `blake` (Blake), `david` (David), `maya` (Maya), `nathan` (Nathan), `sam` (Sam), `georgia` (Georgia), `petra` (Petra), `adam` (Adam), `zach` (Zach), `violet` (Violet), `roman` (Roman), `luna` (Luna).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsRequestVoiceRunwayLivePresetVoice" /> class.
        /// </summary>
        /// <param name="presetId">
        /// The ID of a preset voice. Available voices: `victoria` (Victoria), `vincent` (Vincent), `clara` (Clara), `drew` (Drew), `skye` (Skye), `max` (Max), `morgan` (Morgan), `felix` (Felix), `mia` (Mia), `marcus` (Marcus), `summer` (Summer), `ruby` (Ruby), `aurora` (Aurora), `jasper` (Jasper), `leo` (Leo), `adrian` (Adrian), `nina` (Nina), `emma` (Emma), `blake` (Blake), `david` (David), `maya` (Maya), `nathan` (Nathan), `sam` (Sam), `georgia` (Georgia), `petra` (Petra), `adam` (Adam), `zach` (Zach), `violet` (Violet), `roman` (Roman), `luna` (Luna).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarsRequestVoiceRunwayLivePresetVoice(
            global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId presetId,
            string type = "runway-live-preset")
        {
            this.Type = type;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsRequestVoiceRunwayLivePresetVoice" /> class.
        /// </summary>
        public CreateAvatarsRequestVoiceRunwayLivePresetVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateAvatarsRequestVoiceRunwayLivePresetVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateAvatarsRequestVoiceRunwayLivePresetVoice FromPresetId(global::Runway.CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId presetId)
        {
            return new CreateAvatarsRequestVoiceRunwayLivePresetVoice
            {
                PresetId = presetId,
            };
        }

    }
}