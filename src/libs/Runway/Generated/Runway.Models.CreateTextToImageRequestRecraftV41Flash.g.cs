
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestRecraftV41Flash
    {
        /// <summary>
        /// A description of the image you want to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output dimensions, expressed as `&lt;width&gt;:&lt;height&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestRecraftV41FlashRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestRecraftV41FlashRatio Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The output file format. Defaults to webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestRecraftV41FlashOutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestRecraftV41FlashOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Preferred colors as six-digit hex strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        public global::System.Collections.Generic.IList<string>? Colors { get; set; }

        /// <summary>
        /// A preferred background color as a six-digit hex string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// The number of images to generate. Each image is billed separately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"recraft_v4_1_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "recraft_v4_1_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestRecraftV41Flash" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A description of the image you want to generate.
        /// </param>
        /// <param name="ratio">
        /// The output dimensions, expressed as `&lt;width&gt;:&lt;height&gt;`.
        /// </param>
        /// <param name="seed"></param>
        /// <param name="outputFormat">
        /// The output file format. Defaults to webp.
        /// </param>
        /// <param name="colors">
        /// Preferred colors as six-digit hex strings.
        /// </param>
        /// <param name="backgroundColor">
        /// A preferred background color as a six-digit hex string.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Each image is billed separately.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestRecraftV41Flash(
            string promptText,
            global::Runway.CreateTextToImageRequestRecraftV41FlashRatio ratio,
            int? seed,
            global::Runway.CreateTextToImageRequestRecraftV41FlashOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<string>? colors,
            string? backgroundColor,
            int? outputCount,
            string model = "recraft_v4_1_flash")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
            this.Colors = colors;
            this.BackgroundColor = backgroundColor;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestRecraftV41Flash" /> class.
        /// </summary>
        public CreateTextToImageRequestRecraftV41Flash()
        {
        }

    }
}