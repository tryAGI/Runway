
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestGptImage2
    {
        /// <summary>
        /// A non-empty string up to 32,000 characters describing the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestGptImage2Ratio Ratio { get; set; }

        /// <summary>
        /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2QualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage2Quality? Quality { get; set; }

        /// <summary>
        /// Background treatment. Defaults to `auto`, which lets the model pick. `transparent` is not supported by this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage2BackgroundJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage2Background? Background { get; set; }

        /// <summary>
        /// An array of up to 16 images to be used as references for the generated image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage2ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate (1-10). Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gpt_image_2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gpt_image_2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage2" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 32,000 characters describing the desired image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
        /// </param>
        /// <param name="quality">
        /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.
        /// </param>
        /// <param name="background">
        /// Background treatment. Defaults to `auto`, which lets the model pick. `transparent` is not supported by this model.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to 16 images to be used as references for the generated image output.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate (1-10). Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGptImage2(
            string promptText,
            global::Runway.CreateTextToImageRequestGptImage2Ratio ratio,
            global::Runway.CreateTextToImageRequestGptImage2Quality? quality,
            global::Runway.CreateTextToImageRequestGptImage2Background? background,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage2ReferenceImage>? referenceImages,
            int? outputCount,
            string model = "gpt_image_2")
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
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage2" /> class.
        /// </summary>
        public CreateTextToImageRequestGptImage2()
        {
        }

    }
}