
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestHailuo3Lite
    {
        /// <summary>
        /// The text prompt describing the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output video resolution.<br/>
        /// Default Value: 768p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHailuo3LiteResolutionJsonConverter))]
        public global::Runway.CreateImageToVideoRequestHailuo3LiteResolution? Resolution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LitePromptImageVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LitePromptImageVariant2Item>> PromptImage { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHailuo3LiteRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestHailuo3LiteRatio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LiteReference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LiteReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LiteReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"hailuo3_lite"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "hailuo3_lite";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestHailuo3Lite" /> class.
        /// </summary>
        /// <param name="promptText">
        /// The text prompt describing the output video.
        /// </param>
        /// <param name="promptImage"></param>
        /// <param name="resolution">
        /// The output video resolution.<br/>
        /// Default Value: 768p
        /// </param>
        /// <param name="duration">
        /// Default Value: 5
        /// </param>
        /// <param name="ratio"></param>
        /// <param name="references"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="referenceAudio"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestHailuo3Lite(
            string promptText,
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LitePromptImageVariant2Item>> promptImage,
            global::Runway.CreateImageToVideoRequestHailuo3LiteResolution? resolution,
            int? duration,
            global::Runway.CreateImageToVideoRequestHailuo3LiteRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LiteReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LiteReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHailuo3LiteReferenceAudioItem>? referenceAudio,
            string model = "hailuo3_lite")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.PromptImage = promptImage;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestHailuo3Lite" /> class.
        /// </summary>
        public CreateImageToVideoRequestHailuo3Lite()
        {
        }

    }
}