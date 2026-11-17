
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestSeedream5Flash
    {
        /// <summary>
        /// A description of the image you want to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5FlashRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestSeedream5FlashRatio Ratio { get; set; }

        /// <summary>
        /// The file format of the output image. Defaults to png.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5FlashOutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream5FlashOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Images to edit or combine. Refer to them in the prompt by upload order (Figure 1, Figure 2, and so on).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5FlashReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedream5_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedream5_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream5Flash" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A description of the image you want to generate.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto_1k` or `auto_2k` to let the model pick the aspect ratio at a fixed resolution tier.
        /// </param>
        /// <param name="outputFormat">
        /// The file format of the output image. Defaults to png.
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
        public CreateTextToImageRequestSeedream5Flash(
            string promptText,
            global::Runway.CreateTextToImageRequestSeedream5FlashRatio ratio,
            global::Runway.CreateTextToImageRequestSeedream5FlashOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5FlashReferenceImage>? referenceImages,
            int? outputCount,
            string model = "seedream5_flash")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.OutputFormat = outputFormat;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream5Flash" /> class.
        /// </summary>
        public CreateTextToImageRequestSeedream5Flash()
        {
        }

    }
}