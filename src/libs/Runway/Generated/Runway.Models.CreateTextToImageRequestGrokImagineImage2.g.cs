
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestGrokImagineImage2
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 2K ratios cost 2 additional credits per image. Use `auto_1k` or `auto_2k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGrokImagineImage2RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio Ratio { get; set; }

        /// <summary>
        /// How much rendering effort the model spends on the output. Defaults to `medium`; `low` is faster and costs 2 fewer credits per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGrokImagineImage2QualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestGrokImagineImage2Quality? Quality { get; set; }

        /// <summary>
        /// When true with exactly one reference image, edit that image directly instead of using it as a loose visual reference. With several reference images the prompt describes how they should be edited or combined. Requires at least one reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit")]
        public bool? Edit { get; set; }

        /// <summary>
        /// Up to 3 images to guide the generation. Reference them from `promptText` to describe how each should be used. Each adds 1 credit to the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGrokImagineImage2ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"grok_imagine_image_2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "grok_imagine_image_2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGrokImagineImage2" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 2K ratios cost 2 additional credits per image. Use `auto_1k` or `auto_2k` to pick a resolution tier and let the model choose the framing from the prompt.
        /// </param>
        /// <param name="quality">
        /// How much rendering effort the model spends on the output. Defaults to `medium`; `low` is faster and costs 2 fewer credits per image.
        /// </param>
        /// <param name="edit">
        /// When true with exactly one reference image, edit that image directly instead of using it as a loose visual reference. With several reference images the prompt describes how they should be edited or combined. Requires at least one reference image.
        /// </param>
        /// <param name="referenceImages">
        /// Up to 3 images to guide the generation. Reference them from `promptText` to describe how each should be used. Each adds 1 credit to the generation.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGrokImagineImage2(
            string promptText,
            global::Runway.CreateTextToImageRequestGrokImagineImage2Ratio ratio,
            global::Runway.CreateTextToImageRequestGrokImagineImage2Quality? quality,
            bool? edit,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGrokImagineImage2ReferenceImage>? referenceImages,
            int? outputCount,
            string model = "grok_imagine_image_2")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Quality = quality;
            this.Edit = edit;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGrokImagineImage2" /> class.
        /// </summary>
        public CreateTextToImageRequestGrokImagineImage2()
        {
        }

    }
}