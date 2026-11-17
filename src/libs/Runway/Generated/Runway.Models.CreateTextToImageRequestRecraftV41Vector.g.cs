
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestRecraftV41Vector
    {
        /// <summary>
        /// Describe the vector illustration you want to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Preferred colors as six-digit hex values, such as #FF8800.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        public global::System.Collections.Generic.IList<string>? Colors { get; set; }

        /// <summary>
        /// The preferred background color as a six-digit hex value. This is a generation hint, not an exact color constraint; the generated background may use a different shade.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// The width and height declared by the output SVG. Vector artwork can be scaled after generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestRecraftV41VectorRatioJsonConverter))]
        public global::Runway.CreateTextToImageRequestRecraftV41VectorRatio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"recraft_v4_1_vector"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "recraft_v4_1_vector";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestRecraftV41Vector" /> class.
        /// </summary>
        /// <param name="promptText">
        /// Describe the vector illustration you want to generate.
        /// </param>
        /// <param name="colors">
        /// Preferred colors as six-digit hex values, such as #FF8800.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="backgroundColor">
        /// The preferred background color as a six-digit hex value. This is a generation hint, not an exact color constraint; the generated background may use a different shade.
        /// </param>
        /// <param name="ratio">
        /// The width and height declared by the output SVG. Vector artwork can be scaled after generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestRecraftV41Vector(
            string promptText,
            global::System.Collections.Generic.IList<string>? colors,
            string? backgroundColor,
            global::Runway.CreateTextToImageRequestRecraftV41VectorRatio? ratio,
            string model = "recraft_v4_1_vector")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Colors = colors;
            this.BackgroundColor = backgroundColor;
            this.Ratio = ratio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestRecraftV41Vector" /> class.
        /// </summary>
        public CreateTextToImageRequestRecraftV41Vector()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToImageRequestRecraftV41Vector"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToImageRequestRecraftV41Vector FromPromptText(string promptText)
        {
            return new CreateTextToImageRequestRecraftV41Vector
            {
                PromptText = promptText,
            };
        }

    }
}