
#nullable enable

namespace Runway
{
    /// <summary>
    /// Model-agnostic video generation input. Fields are optional; the router selects a model and maps these options to it.
    /// </summary>
    public sealed partial class CreateGenerateVideoRequestInput
    {
        /// <summary>
        /// A text prompt describing the desired video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// A text description of what to avoid in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Optional image inputs. Each entry requires a `role`. At most one `first` and one `last` are allowed; multiple `reference` images are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Optional video inputs. Each entry requires a `role`. Use `source` for video-to-video; use `reference` for additional context videos (only models that support them remain eligible). At most one `source` is allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// Optional audio inputs for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        /// Timed guidance images for video restyle. Requires a source video; unsupported models are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        public global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>>? Keyframes { get; set; }

        /// <summary>
        /// Desired duration of the output video, in seconds. Unsupported values exclude models; with a source video, V2V duration support applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Desired aspect ratio. Models that do not support the requested aspect are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateVideoRequestInputAspectRatioJsonConverter))]
        public global::Runway.CreateGenerateVideoRequestInputAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Desired output resolution tier. Models that do not support the requested tier are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateVideoRequestInputResolutionJsonConverter))]
        public global::Runway.CreateGenerateVideoRequestInputResolution? Resolution { get; set; }

        /// <summary>
        /// Whether to generate native audio with the video. When true, only models that output audio remain eligible; when false, silent models and models with an audio toggle remain eligible (always-on native-audio models are excluded). When omitted, the selected model’s default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// A seed for reproducible generation. Random if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.CreateGenerateVideoRequestInputContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInput" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A text prompt describing the desired video.
        /// </param>
        /// <param name="negativePrompt">
        /// A text description of what to avoid in the output.
        /// </param>
        /// <param name="referenceImages">
        /// Optional image inputs. Each entry requires a `role`. At most one `first` and one `last` are allowed; multiple `reference` images are allowed.
        /// </param>
        /// <param name="referenceVideos">
        /// Optional video inputs. Each entry requires a `role`. Use `source` for video-to-video; use `reference` for additional context videos (only models that support them remain eligible). At most one `source` is allowed.
        /// </param>
        /// <param name="referenceAudio">
        /// Optional audio inputs for the generation.
        /// </param>
        /// <param name="keyframes">
        /// Timed guidance images for video restyle. Requires a source video; unsupported models are excluded.
        /// </param>
        /// <param name="duration">
        /// Desired duration of the output video, in seconds. Unsupported values exclude models; with a source video, V2V duration support applies.
        /// </param>
        /// <param name="aspectRatio">
        /// Desired aspect ratio. Models that do not support the requested aspect are excluded.
        /// </param>
        /// <param name="resolution">
        /// Desired output resolution tier. Models that do not support the requested tier are excluded.
        /// </param>
        /// <param name="audio">
        /// Whether to generate native audio with the video. When true, only models that output audio remain eligible; when false, silent models and models with an audio toggle remain eligible (always-on native-audio models are excluded). When omitted, the selected model’s default applies.
        /// </param>
        /// <param name="seed">
        /// A seed for reproducible generation. Random if omitted.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoRequestInput(
            string? promptText,
            string? negativePrompt,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceImage>? referenceImages,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateVideoRequestInputReferenceAudioItem>? referenceAudio,
            global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateGenerateVideoRequestInputKeyframeVariant1, global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2>>? keyframes,
            int? duration,
            global::Runway.CreateGenerateVideoRequestInputAspectRatio? aspectRatio,
            global::Runway.CreateGenerateVideoRequestInputResolution? resolution,
            bool? audio,
            int? seed,
            global::Runway.CreateGenerateVideoRequestInputContentModeration? contentModeration)
        {
            this.PromptText = promptText;
            this.NegativePrompt = negativePrompt;
            this.ReferenceImages = referenceImages;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Keyframes = keyframes;
            this.Duration = duration;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Audio = audio;
            this.Seed = seed;
            this.ContentModeration = contentModeration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInput" /> class.
        /// </summary>
        public CreateGenerateVideoRequestInput()
        {
        }

    }
}