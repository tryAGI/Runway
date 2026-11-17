
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestGeminiImage31FlashLite
    {
        /// <summary>
        /// This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashLiteRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteRatio Ratio { get; set; }

        /// <summary>
        /// An array of up to 14 images to be used as references for the generated image output. Up to five can pass `subject: "human"` and up to nine can pass `subject: "object"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation. Up to four images can be generated at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public double? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gemini_image3.1_flash_lite"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_image3.1_flash_lite";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGeminiImage31FlashLite" /> class.
        /// </summary>
        /// <param name="promptText">
        /// This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to 14 images to be used as references for the generated image output. Up to five can pass `subject: "human"` and up to nine can pass `subject: "object"`.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation. Up to four images can be generated at once.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGeminiImage31FlashLite(
            string promptText,
            global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteRatio ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGeminiImage31FlashLiteReferenceImage>? referenceImages,
            double? outputCount,
            string model = "gemini_image3.1_flash_lite")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGeminiImage31FlashLite" /> class.
        /// </summary>
        public CreateTextToImageRequestGeminiImage31FlashLite()
        {
        }

    }
}