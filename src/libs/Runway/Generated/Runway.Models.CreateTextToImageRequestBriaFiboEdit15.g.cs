
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestBriaFiboEdit15
    {
        /// <summary>
        /// An instruction describing how to edit the reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Using the same seed with an identical request reproduces the same image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The file format of the output image. Defaults to png.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestBriaFiboEdit15OutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestBriaFiboEdit15OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 1 to 4 images to edit. With several, the instruction describes how to combine them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestBriaFiboEdit15ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Omit it or use `auto` to keep the framing of the first reference image. Choosing a size requires at least 2 reference images; a single image always keeps its own framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestBriaFiboEdit15RatioJsonConverter))]
        public global::Runway.CreateTextToImageRequestBriaFiboEdit15Ratio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"bria_fibo_edit_1_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "bria_fibo_edit_1_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestBriaFiboEdit15" /> class.
        /// </summary>
        /// <param name="promptText">
        /// An instruction describing how to edit the reference images.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Using the same seed with an identical request reproduces the same image.
        /// </param>
        /// <param name="outputFormat">
        /// The file format of the output image. Defaults to png.
        /// </param>
        /// <param name="referenceImages">
        /// 1 to 4 images to edit. With several, the instruction describes how to combine them.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Omit it or use `auto` to keep the framing of the first reference image. Choosing a size requires at least 2 reference images; a single image always keeps its own framing.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestBriaFiboEdit15(
            string promptText,
            int? seed,
            global::Runway.CreateTextToImageRequestBriaFiboEdit15OutputFormat? outputFormat,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestBriaFiboEdit15ReferenceImage>? referenceImages,
            global::Runway.CreateTextToImageRequestBriaFiboEdit15Ratio? ratio,
            string model = "bria_fibo_edit_1_5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.ReferenceImages = referenceImages;
            this.Ratio = ratio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestBriaFiboEdit15" /> class.
        /// </summary>
        public CreateTextToImageRequestBriaFiboEdit15()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToImageRequestBriaFiboEdit15"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToImageRequestBriaFiboEdit15 FromPromptText(string promptText)
        {
            return new CreateTextToImageRequestBriaFiboEdit15
            {
                PromptText = promptText,
            };
        }

    }
}