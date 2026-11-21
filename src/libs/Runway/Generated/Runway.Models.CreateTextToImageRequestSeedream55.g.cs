
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestSeedream55
    {
        /// <summary>
        /// A description of the image you want to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k`, `auto_1.5k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream55RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestSeedream55Ratio Ratio { get; set; }

        /// <summary>
        /// The file format of the output image. Defaults to png.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream55OutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream55OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Whether the image has a transparent or an opaque background. A transparent background needs the png output format. Omit to let the model decide from the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream55BackgroundJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream55Background? Background { get; set; }

        /// <summary>
        /// Images to edit or combine. Refer to them in the prompt by upload order (Figure 1, Figure 2, and so on).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream55ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedream5.5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedream5.5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream55" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A description of the image you want to generate.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k`, `auto_1.5k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </param>
        /// <param name="outputFormat">
        /// The file format of the output image. Defaults to png.
        /// </param>
        /// <param name="background">
        /// Whether the image has a transparent or an opaque background. A transparent background needs the png output format. Omit to let the model decide from the prompt.
        /// </param>
        /// <param name="referenceImages">
        /// Images to edit or combine. Refer to them in the prompt by upload order (Figure 1, Figure 2, and so on).
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestSeedream55(
            string promptText,
            global::Runway.CreateTextToImageRequestSeedream55Ratio ratio,
            global::Runway.CreateTextToImageRequestSeedream55OutputFormat? outputFormat,
            global::Runway.CreateTextToImageRequestSeedream55Background? background,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream55ReferenceImage>? referenceImages,
            int? outputCount,
            string model = "seedream5.5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.OutputFormat = outputFormat;
            this.Background = background;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream55" /> class.
        /// </summary>
        public CreateTextToImageRequestSeedream55()
        {
        }

    }
}