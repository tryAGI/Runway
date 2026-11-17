
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToAudioRequestMireloSfx20
    {
        /// <summary>
        ///
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToAudioRequestMireloSfx20FormatJsonConverter))]
        public global::Runway.CreateVideoToAudioRequestMireloSfx20Format? Format { get; set; }

        /// <summary>
        /// A seed for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A description of the sound effects to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// The video to generate synchronized sound effects for. The output is audio only.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// Whether to preserve dialogue from the input video. Disabling this does not guarantee speech-free output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserveSpeech")]
        public bool? PreserveSpeech { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoToAudioRequestMireloSfx20" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="videoUri">
        /// The video to generate synchronized sound effects for. The output is audio only.<br/>
        /// Example: https://example.com/video.mp4
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
        /// <param name="promptText">
        /// A description of the sound effects to generate.
        /// </param>
        /// <param name="preserveSpeech">
        /// Whether to preserve dialogue from the input video. Disabling this does not guarantee speech-free output.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToAudioRequestMireloSfx20(
            double duration,
            string videoUri,
            string? negativePrompt,
            int? numVariants,
            global::Runway.CreateVideoToAudioRequestMireloSfx20Format? format,
            int? seed,
            string? promptText,
            bool? preserveSpeech,
            string model = "mirelo_sfx_2_0")
        {
            this.Duration = duration;
            this.NegativePrompt = negativePrompt;
            this.NumVariants = numVariants;
            this.Format = format;
            this.Seed = seed;
            this.PromptText = promptText;
            this.VideoUri = videoUri;
            this.PreserveSpeech = preserveSpeech;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToAudioRequestMireloSfx20" /> class.
        /// </summary>
        public CreateVideoToAudioRequestMireloSfx20()
        {
        }

    }
}