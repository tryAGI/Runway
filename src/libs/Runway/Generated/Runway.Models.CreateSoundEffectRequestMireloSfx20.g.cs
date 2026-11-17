
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSoundEffectRequestMireloSfx20
    {
        /// <summary>
        /// The duration of the generated audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Sounds to avoid in the generated audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The number of audio variations to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numVariants")]
        public int? NumVariants { get; set; }

        /// <summary>
        /// The format of the generated audio.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateSoundEffectRequestMireloSfx20FormatJsonConverter))]
        public global::Runway.CreateSoundEffectRequestMireloSfx20Format? Format { get; set; }

        /// <summary>
        /// A seed for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A description of the sound effects to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"mirelo_sfx_2_0"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "mirelo_sfx_2_0";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSoundEffectRequestMireloSfx20" /> class.
        /// </summary>
        /// <param name="duration">
        /// The duration of the generated audio in seconds.
        /// </param>
        /// <param name="promptText">
        /// A description of the sound effects to generate.
        /// </param>
        /// <param name="negativePrompt">
        /// Sounds to avoid in the generated audio.
        /// </param>
        /// <param name="numVariants">
        /// The number of audio variations to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="format">
        /// The format of the generated audio.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="seed">
        /// A seed for reproducible generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSoundEffectRequestMireloSfx20(
            double duration,
            string promptText,
            string? negativePrompt,
            int? numVariants,
            global::Runway.CreateSoundEffectRequestMireloSfx20Format? format,
            int? seed,
            string model = "mirelo_sfx_2_0")
        {
            this.Duration = duration;
            this.NegativePrompt = negativePrompt;
            this.NumVariants = numVariants;
            this.Format = format;
            this.Seed = seed;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSoundEffectRequestMireloSfx20" /> class.
        /// </summary>
        public CreateSoundEffectRequestMireloSfx20()
        {
        }

    }
}