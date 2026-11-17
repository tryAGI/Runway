
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestBriaFibo15
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 1MP sizes cost 5 credits per image and 4MP sizes 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestBriaFibo15RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestBriaFibo15Ratio Ratio { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Using the same seed with an identical request reproduces the same image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The file format of the output image. Defaults to png.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestBriaFibo15OutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestBriaFibo15OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Up to 1 image to guide the generation. The prompt describes how the output should build on it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestBriaFibo15ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"bria_fibo_1_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "bria_fibo_1_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestBriaFibo15" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. 1MP sizes cost 5 credits per image and 4MP sizes 10.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Using the same seed with an identical request reproduces the same image.
        /// </param>
        /// <param name="outputFormat">
        /// The file format of the output image. Defaults to png.
        /// </param>
        /// <param name="referenceImages">
        /// Up to 1 image to guide the generation. The prompt describes how the output should build on it.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestBriaFibo15(
            string promptText,
            global::Runway.CreateTextToImageRequestBriaFibo15Ratio ratio,
            int? seed,
            global::Runway.CreateTextToImageRequestBriaFibo15OutputFormat? outputFormat,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestBriaFibo15ReferenceImage>? referenceImages,
            string model = "bria_fibo_1_5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.ReferenceImages = referenceImages;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestBriaFibo15" /> class.
        /// </summary>
        public CreateTextToImageRequestBriaFibo15()
        {
        }

    }
}