
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenV4
    {
        /// <summary>
        /// The text to convert to speech. You can include expressive audio tags like [laughs], [whispers], or [pause] in the script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The voice to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice Voice { get; set; }

        /// <summary>
        /// Voice stability. Lower values allow broader emotional range; higher values are steadier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// How closely the output tracks the original speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityBoost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Style exaggeration. Higher values amplify the speaker style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Speech speed multiplier. Values below 1 slow the speech down, and values above 1 speed it up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Boost similarity to the original speaker at a small latency cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useSpeakerBoost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// Language code to enforce pronunciation, such as "en" or "pt". A regional code such as "pt-BR" is read as its language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Text that comes before this request, so the speech can continue from an earlier generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousText")]
        public string? PreviousText { get; set; }

        /// <summary>
        /// Text that comes after this request, so the speech can lead into a later generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextText")]
        public string? NextText { get; set; }

        /// <summary>
        /// Optional seed for more consistent output. The same seed and settings tend to sound alike, but it is not guaranteed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"eleven_v4"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "eleven_v4";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV4" /> class.
        /// </summary>
        /// <param name="promptText">
        /// The text to convert to speech. You can include expressive audio tags like [laughs], [whispers], or [pause] in the script.
        /// </param>
        /// <param name="voice">
        /// The voice to use for the generated speech.
        /// </param>
        /// <param name="stability">
        /// Voice stability. Lower values allow broader emotional range; higher values are steadier.
        /// </param>
        /// <param name="similarityBoost">
        /// How closely the output tracks the original speaker.
        /// </param>
        /// <param name="style">
        /// Style exaggeration. Higher values amplify the speaker style.
        /// </param>
        /// <param name="speed">
        /// Speech speed multiplier. Values below 1 slow the speech down, and values above 1 speed it up.
        /// </param>
        /// <param name="useSpeakerBoost">
        /// Boost similarity to the original speaker at a small latency cost.
        /// </param>
        /// <param name="languageCode">
        /// Language code to enforce pronunciation, such as "en" or "pt". A regional code such as "pt-BR" is read as its language.
        /// </param>
        /// <param name="previousText">
        /// Text that comes before this request, so the speech can continue from an earlier generation.
        /// </param>
        /// <param name="nextText">
        /// Text that comes after this request, so the speech can lead into a later generation.
        /// </param>
        /// <param name="seed">
        /// Optional seed for more consistent output. The same seed and settings tend to sound alike, but it is not guaranteed.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestElevenV4(
            string promptText,
            global::Runway.CreateTextToSpeechRequestElevenV4VoiceRunwayPresetVoice voice,
            double? stability,
            double? similarityBoost,
            double? style,
            double? speed,
            bool? useSpeakerBoost,
            string? languageCode,
            string? previousText,
            string? nextText,
            int? seed,
            string model = "eleven_v4")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.Speed = speed;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.LanguageCode = languageCode;
            this.PreviousText = previousText;
            this.NextText = nextText;
            this.Seed = seed;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV4" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenV4()
        {
        }

    }
}