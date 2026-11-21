
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVectorRequestIdeogramVector
    {
        /// <summary>
        /// The source image to convert to SVG.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUri { get; set; }

        /// <summary>
        /// Use simple for fewer shapes, or default to retain more detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizationMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVectorRequestIdeogramVectorVectorizationModeJsonConverter))]
        public global::Runway.CreateImageToVectorRequestIdeogramVectorVectorizationMode? VectorizationMode { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateImageToVectorRequestIdeogramVector" /> class.
        /// </summary>
        /// <param name="imageUri">
        /// The source image to convert to SVG.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="vectorizationMode">
        /// Use simple for fewer shapes, or default to retain more detail.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVectorRequestIdeogramVector(
            string imageUri,
            global::Runway.CreateImageToVectorRequestIdeogramVectorVectorizationMode? vectorizationMode,
            string model = "ideogram_vector")
        {
            this.ImageUri = imageUri;
            this.VectorizationMode = vectorizationMode;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVectorRequestIdeogramVector" /> class.
        /// </summary>
        public CreateImageToVectorRequestIdeogramVector()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateImageToVectorRequestIdeogramVector"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateImageToVectorRequestIdeogramVector FromImageUri(string imageUri)
        {
            return new CreateImageToVectorRequestIdeogramVector
            {
                ImageUri = imageUri,
            };
        }

    }
}