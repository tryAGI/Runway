
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestSeedream5Pro
    {
        /// <summary>
        /// A non-empty string up to 4,000 characters describing the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick aspect ratio at a fixed resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestSeedream5ProRatio Ratio { get; set; }

        /// <summary>
        /// The file format of the output image. Defaults to png.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProOutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// An array of reference images for multi-image fusion and interactive editing. Reference by upload order in prompt text (Figure 1, Figure 2, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5ProReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        /// When true, enable live web search so the model can use current brand, trend, or event context. Default false for deterministic output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        public bool? Grounding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"seedream5_pro"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedream5_pro";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream5Pro" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 4,000 characters describing the desired image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick aspect ratio at a fixed resolution tier.
        /// </param>
        /// <param name="outputFormat">
        /// The file format of the output image. Defaults to png.
        /// </param>
        /// <param name="referenceImages">
        /// An array of reference images for multi-image fusion and interactive editing. Reference by upload order in prompt text (Figure 1, Figure 2, etc.).
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="grounding">
        /// When true, enable live web search so the model can use current brand, trend, or event context. Default false for deterministic output.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestSeedream5Pro(
            string promptText,
            global::Runway.CreateTextToImageRequestSeedream5ProRatio ratio,
            global::Runway.CreateTextToImageRequestSeedream5ProOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5ProReferenceImage>? referenceImages,
            int? outputCount,
            bool? grounding,
            string model = "seedream5_pro")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.OutputFormat = outputFormat;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Grounding = grounding;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream5Pro" /> class.
        /// </summary>
        public CreateTextToImageRequestSeedream5Pro()
        {
        }

    }
}