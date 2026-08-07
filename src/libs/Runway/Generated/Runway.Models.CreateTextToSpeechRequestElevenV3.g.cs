
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenV3
    {
        /// <summary>
        /// The text to convert to speech. You can include expressive audio tags like [laughs] or [whispers] in the script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The voice to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice Voice { get; set; }

        /// <summary>
        /// Voice stability (0–1). Lower values allow broader emotional range; higher values are steadier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// How closely the output tracks the original speaker (0–1). Maps to ElevenLabs similarity_boost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityBoost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Style exaggeration (0–1). Higher values amplify the speaker style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Speech speed multiplier (0.7–1.2). 1.0 is default; values below slow down and above speed up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Boost similarity to the original speaker at a small latency cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useSpeakerBoost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// ISO 639-1 language code to enforce pronunciation and normalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Text normalization mode: 'auto', 'on', or 'off' (e.g. spelling out numbers).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyTextNormalization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3ApplyTextNormalizationJsonConverter))]
        public global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Optional seed for more deterministic output (0–4294967295). Not guaranteed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_v3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "eleven_v3";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV3" /> class.
        /// </summary>
        /// <param name="promptText">
        /// The text to convert to speech. You can include expressive audio tags like [laughs] or [whispers] in the script.
        /// </param>
        /// <param name="voice">
        /// The voice to use for the generated speech.
        /// </param>
        /// <param name="stability">
        /// Voice stability (0–1). Lower values allow broader emotional range; higher values are steadier.
        /// </param>
        /// <param name="similarityBoost">
        /// How closely the output tracks the original speaker (0–1). Maps to ElevenLabs similarity_boost.
        /// </param>
        /// <param name="style">
        /// Style exaggeration (0–1). Higher values amplify the speaker style.
        /// </param>
        /// <param name="speed">
        /// Speech speed multiplier (0.7–1.2). 1.0 is default; values below slow down and above speed up.
        /// </param>
        /// <param name="useSpeakerBoost">
        /// Boost similarity to the original speaker at a small latency cost.
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1 language code to enforce pronunciation and normalization.
        /// </param>
        /// <param name="applyTextNormalization">
        /// Text normalization mode: 'auto', 'on', or 'off' (e.g. spelling out numbers).
        /// </param>
        /// <param name="seed">
        /// Optional seed for more deterministic output (0–4294967295). Not guaranteed.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestElevenV3(
            string promptText,
            global::Runway.CreateTextToSpeechRequestElevenV3VoiceRunwayPresetVoice voice,
            double? stability,
            double? similarityBoost,
            double? style,
            double? speed,
            bool? useSpeakerBoost,
            string? languageCode,
            global::Runway.CreateTextToSpeechRequestElevenV3ApplyTextNormalization? applyTextNormalization,
            int? seed,
            string model = "eleven_v3")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.Speed = speed;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.LanguageCode = languageCode;
            this.ApplyTextNormalization = applyTextNormalization;
            this.Seed = seed;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV3" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenV3()
        {
        }

    }
}