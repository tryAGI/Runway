
#nullable enable

namespace Runway
{
    /// <summary>
    /// Request-side defaults resolved for the routing response. Not necessarily identical to prepared model options.
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseRoutingResolvedInput
    {
        /// <summary>
        /// The prompt mode the router routed for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType Type { get; set; }

        /// <summary>
        /// How the selected model resolves the voice: the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioResponseRoutingResolvedInputVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutingResolvedInput" /> class.
        /// </summary>
        /// <param name="type">
        /// The prompt mode the router routed for.
        /// </param>
        /// <param name="voice">
        /// How the selected model resolves the voice: the requested preset or reference-audio clone, the model default for voiceless speech, or none for general audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseRoutingResolvedInput(
            global::Runway.CreateGenerateAudioResponseRoutingResolvedInputType type,
            global::Runway.CreateGenerateAudioResponseRoutingResolvedInputVoice voice)
        {
            this.Type = type;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutingResolvedInput" /> class.
        /// </summary>
        public CreateGenerateAudioResponseRoutingResolvedInput()
        {
        }

    }
}