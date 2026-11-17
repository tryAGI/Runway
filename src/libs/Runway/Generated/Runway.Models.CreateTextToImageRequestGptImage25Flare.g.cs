
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestGptImage25Flare
    {
        /// <summary>
        /// A non-empty string describing the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage25FlareRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestGptImage25FlareRatio Ratio { get; set; }

        /// <summary>
        /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage25FlareQualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage25FlareQuality? Quality { get; set; }

        /// <summary>
        /// Background treatment. Defaults to `auto`, which lets the model pick.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage25FlareBackgroundJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage25FlareBackground? Background { get; set; }

        /// <summary>
        /// An array of up to 16 images to be used as references for the generated image output. No two images may share the same tag. Each reference image adds 1 credit per generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage25FlareReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate (1-10). Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gpt_image_2_5_flare"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gpt_image_2_5_flare";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage25Flare" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string describing the desired image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
        /// </param>
        /// <param name="quality">
        /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
        /// </param>
        /// <param name="background">
        /// Background treatment. Defaults to `auto`, which lets the model pick.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to 16 images to be used as references for the generated image output. No two images may share the same tag. Each reference image adds 1 credit per generated image.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate (1-10). Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGptImage25Flare(
            string promptText,
            global::Runway.CreateTextToImageRequestGptImage25FlareRatio ratio,
            global::Runway.CreateTextToImageRequestGptImage25FlareQuality? quality,
            global::Runway.CreateTextToImageRequestGptImage25FlareBackground? background,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage25FlareReferenceImage>? referenceImages,
            int? outputCount,
            string model = "gpt_image_2_5_flare")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Quality = quality;
            this.Background = background;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage25Flare" /> class.
        /// </summary>
        public CreateTextToImageRequestGptImage25Flare()
        {
        }

    }
}