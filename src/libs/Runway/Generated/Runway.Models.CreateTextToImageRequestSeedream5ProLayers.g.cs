
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestSeedream5ProLayers
    {
        /// <summary>
        /// The image to split into editable layers. Layer ordering and positioning are returned in the completed task’s layers field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5ProLayersReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// Output resolution tier. Defaults to auto, which adapts to the input image. The base image and layers preserve their respective aspect ratios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProLayersResolutionJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream5ProLayersResolution? Resolution { get; set; }

        /// <summary>
        /// Base image format; defaults to png. Separated layers always use PNG with transparency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProLayersOutputFormatJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream5ProLayersOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Prompt optimization: standard prioritizes quality; fast reduces generation time. Defaults to standard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizePromptMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestSeedream5ProLayersOptimizePromptModeJsonConverter))]
        public global::Runway.CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode? OptimizePromptMode { get; set; }

        /// <summary>
        /// Optional instructions describing which elements to separate. Omit to split the image automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"seedream5_pro_layers"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "seedream5_pro_layers";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream5ProLayers" /> class.
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
        /// <param name="optimizePromptMode">
        /// Prompt optimization: standard prioritizes quality; fast reduces generation time. Defaults to standard.
        /// </param>
        /// <param name="promptText">
        /// Optional instructions describing which elements to separate. Omit to split the image automatically.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestSeedream5ProLayers(
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestSeedream5ProLayersReferenceImage> referenceImages,
            global::Runway.CreateTextToImageRequestSeedream5ProLayersResolution? resolution,
            global::Runway.CreateTextToImageRequestSeedream5ProLayersOutputFormat? outputFormat,
            global::Runway.CreateTextToImageRequestSeedream5ProLayersOptimizePromptMode? optimizePromptMode,
            string? promptText,
            string model = "seedream5_pro_layers")
        {
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
            this.Resolution = resolution;
            this.OutputFormat = outputFormat;
            this.OptimizePromptMode = optimizePromptMode;
            this.PromptText = promptText;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestSeedream5ProLayers" /> class.
        /// </summary>
        public CreateTextToImageRequestSeedream5ProLayers()
        {
        }

    }
}