
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSoundEffectRequestSeedAudio
    {
        /// <summary>
        /// A non-empty text prompt. For text-to-speech, the words to speak. For text-to-audio, a scene description that can include voice direction, dialogue, music, and sound effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Up to three reference audio clips. When provided, reference them in promptText as @Audio1, @Audio2, and @Audio3 in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudios")]
        public global::System.Collections.Generic.IList<string>? ReferenceAudios { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateSoundEffectRequestSeedAudioOutputFormatJsonConverter))]
        public global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat? OutputFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSoundEffectRequestSeedAudio" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt. For text-to-speech, the words to speak. For text-to-audio, a scene description that can include voice direction, dialogue, music, and sound effects.
        /// </param>
        /// <param name="referenceAudios">
        /// Up to three reference audio clips. When provided, reference them in promptText as @Audio1, @Audio2, and @Audio3 in order.
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
        public CreateSoundEffectRequestSeedAudio(
            string promptText,
            global::System.Collections.Generic.IList<string>? referenceAudios,
            int? speechRate,
            int? loudnessRate,
            int? pitchRate,
            double? sampleRate,
            global::Runway.CreateSoundEffectRequestSeedAudioOutputFormat? outputFormat,
            string model = "seed_audio")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.ReferenceAudios = referenceAudios;
            this.SpeechRate = speechRate;
            this.LoudnessRate = loudnessRate;
            this.PitchRate = pitchRate;
            this.SampleRate = sampleRate;
            this.OutputFormat = outputFormat;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSoundEffectRequestSeedAudio" /> class.
        /// </summary>
        public CreateSoundEffectRequestSeedAudio()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateSoundEffectRequestSeedAudio"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateSoundEffectRequestSeedAudio FromPromptText(string promptText)
        {
            return new CreateSoundEffectRequestSeedAudio
            {
                PromptText = promptText,
            };
        }

    }
}