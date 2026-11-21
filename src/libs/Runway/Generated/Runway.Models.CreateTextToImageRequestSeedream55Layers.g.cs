
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestSeedream55Layers
    {
        /// <summary>
        /// The image to split into editable layers. Layer ordering and positioning are returned in the completed task’s layers field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream55LayersReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// Output resolution tier. Defaults to auto, which adapts to the input image. The base image and layers preserve their respective aspect ratios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream55LayersResolutionJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream55LayersResolution? Resolution { get; set; }

        /// <summary>
        /// Base image format; defaults to png. Separated layers always use PNG with transparency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream55LayersOutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream55LayersOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The most images the task may return, counting the base image. Each returned image is billed separately. Defaults to 30.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxImages")]
        public int? MaxImages { get; set; }

        /// <summary>
        /// Optional instructions describing which elements to separate. Omit to split the image automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedream5.5_layers"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedream5.5_layers";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream55Layers" /> class.
        /// </summary>
        /// <param name="referenceImages">
        /// The image to split into editable layers. Layer ordering and positioning are returned in the completed task’s layers field.
        /// </param>
        /// <param name="resolution">
        /// Output resolution tier. Defaults to auto, which adapts to the input image. The base image and layers preserve their respective aspect ratios.
        /// </param>
        /// <param name="outputFormat">
        /// Base image format; defaults to png. Separated layers always use PNG with transparency.
        /// </param>
        /// <param name="maxImages">
        /// The most images the task may return, counting the base image. Each returned image is billed separately. Defaults to 30.
        /// </param>
        /// <param name="promptText">
        /// Optional instructions describing which elements to separate. Omit to split the image automatically.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestSeedream55Layers(
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream55LayersReferenceImage> referenceImages,
            global::Runway.CreateTextToImageRequestSeedream55LayersResolution? resolution,
            global::Runway.CreateTextToImageRequestSeedream55LayersOutputFormat? outputFormat,
            int? maxImages,
            string? promptText,
            string model = "seedream5.5_layers")
        {
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
            this.Resolution = resolution;
            this.OutputFormat = outputFormat;
            this.MaxImages = maxImages;
            this.PromptText = promptText;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream55Layers" /> class.
        /// </summary>
        public CreateTextToImageRequestSeedream55Layers()
        {
        }

    }
}