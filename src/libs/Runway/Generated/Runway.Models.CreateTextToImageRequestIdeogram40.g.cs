
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestIdeogram40
    {
        /// <summary>
        /// Describe the image to generate, or how to remix the reference image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// How much rendering effort the model spends on each image. `low` costs 4 credits per image, `medium` 7 and `high` 11.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestIdeogram40QualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestIdeogram40Quality? Quality { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestIdeogram40RatioJsonConverter))]
        public global::Runway.CreateTextToImageRequestIdeogram40Ratio? Ratio { get; set; }

        /// <summary>
        /// An image to remix. The prompt describes how the output should differ from it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestIdeogram40ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"ideogram_4_0"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "ideogram_4_0";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestIdeogram40" /> class.
        /// </summary>
        /// <param name="promptText">
        /// Describe the image to generate, or how to remix the reference image.
        /// </param>
        /// <param name="quality">
        /// How much rendering effort the model spends on each image. `low` costs 4 credits per image, `medium` 7 and `high` 11.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`.
        /// </param>
        /// <param name="referenceImages">
        /// An image to remix. The prompt describes how the output should differ from it.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestIdeogram40(
            string promptText,
            global::Runway.CreateTextToImageRequestIdeogram40Quality? quality,
            global::Runway.CreateTextToImageRequestIdeogram40Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestIdeogram40ReferenceImage>? referenceImages,
            int? outputCount,
            string model = "ideogram_4_0")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Quality = quality;
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestIdeogram40" /> class.
        /// </summary>
        public CreateTextToImageRequestIdeogram40()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToImageRequestIdeogram40"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToImageRequestIdeogram40 FromPromptText(string promptText)
        {
            return new CreateTextToImageRequestIdeogram40
            {
                PromptText = promptText,
            };
        }

    }
}