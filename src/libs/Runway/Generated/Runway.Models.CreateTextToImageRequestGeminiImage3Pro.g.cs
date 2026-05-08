
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestGeminiImage3Pro
    {
        /// <summary>
        /// A non-empty string up to 5,500 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage3ProRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestGeminiImage3ProRatio Ratio { get; set; }

        /// <summary>
        /// An array of up to 14 images to be used as references for the generated image output. Up to five of those images can pass `subject: "human"` to maintain character consistency, and up to nine of those images can pass `subject: "object"` with high-fidelity images of objects to include in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation. Up to four images can be generated at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public double? OutputCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gemini_image3_pro"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_image3_pro";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGeminiImage3Pro" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 5,500 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to 14 images to be used as references for the generated image output. Up to five of those images can pass `subject: "human"` to maintain character consistency, and up to nine of those images can pass `subject: "object"` with high-fidelity images of objects to include in the output.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation. Up to four images can be generated at once.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGeminiImage3Pro(
            string promptText,
            global::Runway.CreateTextToImageRequestGeminiImage3ProRatio ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGeminiImage3ProReferenceImage>? referenceImages,
            double? outputCount,
            string model = "gemini_image3_pro")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGeminiImage3Pro" /> class.
        /// </summary>
        public CreateTextToImageRequestGeminiImage3Pro()
        {
        }
    }
}