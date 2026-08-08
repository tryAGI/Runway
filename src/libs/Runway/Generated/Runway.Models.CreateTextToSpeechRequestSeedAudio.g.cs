
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestSeedAudio
    {
        /// <summary>
        /// A non-empty text prompt. For text-to-speech, the words to speak. For text-to-audio, a scene description that can include voice direction, dialogue, music, and sound effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The voice to use for text-to-speech generation. If omitted, a default voice is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? Voice { get; set; }

        /// <summary>
        /// Relative speech speed. Negative is slower, positive is faster; 0 is normal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speechRate")]
        public int? SpeechRate { get; set; }

        /// <summary>
        /// Relative output loudness. Negative is quieter, positive is louder; 0 is normal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudnessRate")]
        public int? LoudnessRate { get; set; }

        /// <summary>
        /// Pitch shift in semitones. Negative lowers, positive raises; 0 is unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitchRate")]
        public int? PitchRate { get; set; }

        /// <summary>
        /// Output sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// Output audio container/format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestSeedAudioOutputFormatJsonConverter))]
        public global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"seed_audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seed_audio";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestSeedAudio" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt. For text-to-speech, the words to speak. For text-to-audio, a scene description that can include voice direction, dialogue, music, and sound effects.
        /// </param>
        /// <param name="voice">
        /// The voice to use for text-to-speech generation. If omitted, a default voice is used.
        /// </param>
        /// <param name="speechRate">
        /// Relative speech speed. Negative is slower, positive is faster; 0 is normal.
        /// </param>
        /// <param name="loudnessRate">
        /// Relative output loudness. Negative is quieter, positive is louder; 0 is normal.
        /// </param>
        /// <param name="pitchRate">
        /// Pitch shift in semitones. Negative lowers, positive raises; 0 is unchanged.
        /// </param>
        /// <param name="sampleRate">
        /// Output sample rate in Hz.
        /// </param>
        /// <param name="outputFormat">
        /// Output audio container/format.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestSeedAudio(
            string promptText,
            global::Runway.CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice? voice,
            int? speechRate,
            int? loudnessRate,
            int? pitchRate,
            double? sampleRate,
            global::Runway.CreateTextToSpeechRequestSeedAudioOutputFormat? outputFormat,
            string model = "seed_audio")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Voice = voice;
            this.SpeechRate = speechRate;
            this.LoudnessRate = loudnessRate;
            this.PitchRate = pitchRate;
            this.SampleRate = sampleRate;
            this.OutputFormat = outputFormat;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestSeedAudio" /> class.
        /// </summary>
        public CreateTextToSpeechRequestSeedAudio()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToSpeechRequestSeedAudio"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToSpeechRequestSeedAudio FromPromptText(string promptText)
        {
            return new CreateTextToSpeechRequestSeedAudio
            {
                PromptText = promptText,
            };
        }

    }
}