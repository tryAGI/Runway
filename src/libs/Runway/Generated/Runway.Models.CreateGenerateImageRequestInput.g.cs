
#nullable enable

namespace Runway
{
    /// <summary>
    /// Model-agnostic image generation input. The router selects a model and maps these options to it.
    /// </summary>
    public sealed partial class CreateGenerateImageRequestInput
    {
        /// <summary>
        /// A text prompt describing the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Optional reference images for models that support them. Tags are assigned per model when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateGenerateImageRequestInputReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Desired aspect ratio. Models that do not support the requested aspect are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateImageRequestInputAspectRatioJsonConverter))]
        public global::Runway.CreateGenerateImageRequestInputAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Desired megapixel tier. Models that do not support the requested tier are excluded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateImageRequestInputResolutionJsonConverter))]
        public global::Runway.CreateGenerateImageRequestInputResolution? Resolution { get; set; }

        /// <summary>
        /// Number of images to generate (1–10). Models that cannot produce the exact count are excluded and cost scales with this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        /// A seed for reproducible generation. Only gen4_image and gen4_image_turbo accept this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.CreateGenerateImageRequestInputContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageRequestInput" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A text prompt describing the desired image.
        /// </param>
        /// <param name="referenceImages">
        /// Optional reference images for models that support them. Tags are assigned per model when omitted.
        /// </param>
        /// <param name="aspectRatio">
        /// Desired aspect ratio. Models that do not support the requested aspect are excluded.
        /// </param>
        /// <param name="resolution">
        /// Desired megapixel tier. Models that do not support the requested tier are excluded.
        /// </param>
        /// <param name="outputCount">
        /// Number of images to generate (1–10). Models that cannot produce the exact count are excluded and cost scales with this value.
        /// </param>
        /// <param name="seed">
        /// A seed for reproducible generation. Only gen4_image and gen4_image_turbo accept this field.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateImageRequestInput(
            string promptText,
            global::System.Collections.Generic.IList<global::Runway.CreateGenerateImageRequestInputReferenceImage>? referenceImages,
            global::Runway.CreateGenerateImageRequestInputAspectRatio? aspectRatio,
            global::Runway.CreateGenerateImageRequestInputResolution? resolution,
            int? outputCount,
            int? seed,
            global::Runway.CreateGenerateImageRequestInputContentModeration? contentModeration)
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.ReferenceImages = referenceImages;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.OutputCount = outputCount;
            this.Seed = seed;
            this.ContentModeration = contentModeration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageRequestInput" /> class.
        /// </summary>
        public CreateGenerateImageRequestInput()
        {
        }

    }
}