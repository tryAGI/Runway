
#nullable enable

namespace Runway
{
    /// <summary>
    /// A voice preset from the RunwayML API.
    /// </summary>
    public sealed partial class RequestElevenMultilingualStsV2VoiceRunwayPresetVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The preset voice ID to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="presetId">
        /// The preset voice ID to use for the generated speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestElevenMultilingualStsV2VoiceRunwayPresetVoice(
            string type,
            global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId presetId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2VoiceRunwayPresetVoice" /> class.
        /// </summary>
        public RequestElevenMultilingualStsV2VoiceRunwayPresetVoice()
        {
        }
    }
}