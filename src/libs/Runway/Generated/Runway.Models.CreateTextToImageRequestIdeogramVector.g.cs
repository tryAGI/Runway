
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestIdeogramVector
    {
        /// <summary>
        /// Describe the vector illustration you want to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Rendering quality. Higher quality costs more credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestIdeogramVectorQualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestIdeogramVectorQuality? Quality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Let the model choose the framing of the SVG.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public string? Ratio { get; set; }

        /// <summary>
        /// Images to guide the illustration. To trace a source image, use image_to_vector instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestIdeogramVectorReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"ideogram_vector"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "ideogram_vector";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestIdeogramVector" /> class.
        /// </summary>
        /// <param name="promptText">
        /// Describe the vector illustration you want to generate.
        /// </param>
        /// <param name="quality">
        /// Rendering quality. Higher quality costs more credits.
        /// </param>
        /// <param name="seed"></param>
        /// <param name="ratio">
        /// Let the model choose the framing of the SVG.
        /// </param>
        /// <param name="referenceImages">
        /// Images to guide the illustration. To trace a source image, use image_to_vector instead.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestIdeogramVector(
            string promptText,
            global::Runway.CreateTextToImageRequestIdeogramVectorQuality? quality,
            int? seed,
            string? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestIdeogramVectorReferenceImage>? referenceImages,
            string model = "ideogram_vector")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Quality = quality;
            this.Seed = seed;
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestIdeogramVector" /> class.
        /// </summary>
        public CreateTextToImageRequestIdeogramVector()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToImageRequestIdeogramVector"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToImageRequestIdeogramVector FromPromptText(string promptText)
        {
            return new CreateTextToImageRequestIdeogramVector
            {
                PromptText = promptText,
            };
        }

    }
}