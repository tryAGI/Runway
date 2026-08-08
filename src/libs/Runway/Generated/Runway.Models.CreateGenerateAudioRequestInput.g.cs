
#nullable enable

namespace Runway
{
    /// <summary>
    /// Model-agnostic audio generation input. The router selects a model and maps these options to it.
    /// </summary>
    public sealed partial class CreateGenerateAudioRequestInput
    {
        /// <summary>
        /// How promptText is interpreted: `speech` speaks it verbatim as a script; `audio` treats it as a description of the desired audio, which may combine speech, music, ambience, and sound effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioRequestInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioRequestInputType Type { get; set; }

        /// <summary>
        /// For `speech`, the words to speak. For `audio`, a description of the desired output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The voice to speak with. When omitted, models that support a default voice remain eligible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.Voice4JsonConverter))]
        public global::Runway.Voice4? Voice { get; set; }

        /// <summary>
        /// Optional reference audio clips guiding `audio` generation, for models that support them. Reference each clip in promptText as @Audio1, @Audio2, and @Audio3 in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudios")]
        public global::System.Collections.Generic.IList<global::Runway.CreateGenerateAudioRequestInputReferenceAudio>? ReferenceAudios { get; set; }

        /// <summary>
        /// Desired output duration in seconds for `audio` generation. Models that cannot honor an explicit duration are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// When true, the `audio` output is designed to loop seamlessly. Models without loop support are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInput" /> class.
        /// </summary>
        /// <param name="type">
        /// How promptText is interpreted: `speech` speaks it verbatim as a script; `audio` treats it as a description of the desired audio, which may combine speech, music, ambience, and sound effects.
        /// </param>
        /// <param name="promptText">
        /// For `speech`, the words to speak. For `audio`, a description of the desired output.
        /// </param>
        /// <param name="voice">
        /// The voice to speak with. When omitted, models that support a default voice remain eligible.
        /// </param>
        /// <param name="referenceAudios">
        /// Optional reference audio clips guiding `audio` generation, for models that support them. Reference each clip in promptText as @Audio1, @Audio2, and @Audio3 in order.
        /// </param>
        /// <param name="duration">
        /// Desired output duration in seconds for `audio` generation. Models that cannot honor an explicit duration are excluded.
        /// </param>
        /// <param name="loop">
        /// When true, the `audio` output is designed to loop seamlessly. Models without loop support are excluded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioRequestInput(
            global::Runway.CreateGenerateAudioRequestInputType type,
            string promptText,
            global::Runway.Voice4? voice,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateAudioRequestInputReferenceAudio>? referenceAudios,
            double? duration,
            bool? loop)
        {
            this.Type = type;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Voice = voice;
            this.ReferenceAudios = referenceAudios;
            this.Duration = duration;
            this.Loop = loop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInput" /> class.
        /// </summary>
        public CreateGenerateAudioRequestInput()
        {
        }

    }
}