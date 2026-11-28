
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestMinimaxH3Image
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 4K ratios cost more credits per image than 1K and 2K. Use `auto_1k`, `auto_2k` or `auto_4k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestMinimaxH3ImageRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestMinimaxH3ImageRatio Ratio { get; set; }

        /// <summary>
        /// When true, generate with the faster MiniMax H3 Image Highspeed model, which costs more credits per image. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highspeed")]
        public bool? Highspeed { get; set; }

        /// <summary>
        /// Up to 16 images to edit or combine. Refer to them in the prompt by upload order (image 1, image 2, and so on). Each reference image adds to the credits per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestMinimaxH3ImageReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"minimax_h3_image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "minimax_h3_image";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestMinimaxH3Image" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 4K ratios cost more credits per image than 1K and 2K. Use `auto_1k`, `auto_2k` or `auto_4k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </param>
        /// <param name="highspeed">
        /// When true, generate with the faster MiniMax H3 Image Highspeed model, which costs more credits per image. Defaults to false.
        /// </param>
        /// <param name="referenceImages">
        /// Up to 16 images to edit or combine. Refer to them in the prompt by upload order (image 1, image 2, and so on). Each reference image adds to the credits per image.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestMinimaxH3Image(
            string promptText,
            global::Runway.CreateTextToImageRequestMinimaxH3ImageRatio ratio,
            bool? highspeed,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestMinimaxH3ImageReferenceImage>? referenceImages,
            int? outputCount,
            string model = "minimax_h3_image")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Highspeed = highspeed;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestMinimaxH3Image" /> class.
        /// </summary>
        public CreateTextToImageRequestMinimaxH3Image()
        {
        }

    }
}