
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestMuseImage
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose the framing from the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestMuseImageRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestMuseImageRatio Ratio { get; set; }

        /// <summary>
        /// Up to 10 images to guide the generation. When provided, the model edits and combines them as your prompt describes instead of generating from the prompt alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestMuseImageReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Each image costs 1 credit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"muse_image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "muse_image";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestMuseImage" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose the framing from the prompt.
        /// </param>
        /// <param name="referenceImages">
        /// Up to 10 images to guide the generation. When provided, the model edits and combines them as your prompt describes instead of generating from the prompt alone.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Each image costs 1 credit.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestMuseImage(
            string promptText,
            global::Runway.CreateTextToImageRequestMuseImageRatio ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestMuseImageReferenceImage>? referenceImages,
            int? outputCount,
            string model = "muse_image")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestMuseImage" /> class.
        /// </summary>
        public CreateTextToImageRequestMuseImage()
        {
        }

    }
}