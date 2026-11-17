
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestNanoBanana21
    {
        /// <summary>
        /// A description of the image you want to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestNanoBanana21RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestNanoBanana21Ratio Ratio { get; set; }

        /// <summary>
        /// How much the model reasons about the prompt before generating. Defaults to medium.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinkingLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestNanoBanana21ThinkingLevelJsonConverter))]
        public global::Runway.CreateTextToImageRequestNanoBanana21ThinkingLevel? ThinkingLevel { get; set; }

        /// <summary>
        /// Up to 14 images to edit, combine, or use as references for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestNanoBanana21ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"nano_banana_2.1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "nano_banana_2.1";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestNanoBanana21" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A description of the image you want to generate.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image.
        /// </param>
        /// <param name="thinkingLevel">
        /// How much the model reasons about the prompt before generating. Defaults to medium.
        /// </param>
        /// <param name="referenceImages">
        /// Up to 14 images to edit, combine, or use as references for the output.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestNanoBanana21(
            string promptText,
            global::Runway.CreateTextToImageRequestNanoBanana21Ratio ratio,
            global::Runway.CreateTextToImageRequestNanoBanana21ThinkingLevel? thinkingLevel,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestNanoBanana21ReferenceImage>? referenceImages,
            int? outputCount,
            string model = "nano_banana_2.1")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.ThinkingLevel = thinkingLevel;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestNanoBanana21" /> class.
        /// </summary>
        public CreateTextToImageRequestNanoBanana21()
        {
        }

    }
}