
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestGptImage26Flare
    {
        /// <summary>
        /// A non-empty string describing the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage26FlareRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateTextToImageRequestGptImage26FlareRatio Ratio { get; set; }

        /// <summary>
        /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage26FlareQualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage26FlareQuality? Quality { get; set; }

        /// <summary>
        /// Background treatment. Defaults to `auto`, which lets the model pick.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage26FlareBackgroundJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage26FlareBackground? Background { get; set; }

        /// <summary>
        /// An array of up to 16 images to be used as references for the generated image output. No two images may share the same tag. Each reference image adds 1 credit per generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage26FlareReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// The number of images to generate (1-10). Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gpt_image_2_6_flare"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gpt_image_2_6_flare";

        /// <summary>
        /// How much reasoning the model spends on the image. Defaults to `high`.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGptImage26FlareReasoningEffortJsonConverter))]
        public global::Runway.CreateTextToImageRequestGptImage26FlareReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage26Flare" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string describing the desired image.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Use `auto` to let the model choose.
        /// </param>
        /// <param name="quality">
        /// Rendering quality. Higher qualities consume more credits. Defaults to `high`.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="background">
        /// Background treatment. Defaults to `auto`, which lets the model pick.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to 16 images to be used as references for the generated image output. No two images may share the same tag. Each reference image adds 1 credit per generated image.
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate (1-10). Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="reasoningEffort">
        /// How much reasoning the model spends on the image. Defaults to `high`.<br/>
        /// Default Value: high
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGptImage26Flare(
            string promptText,
            global::Runway.CreateTextToImageRequestGptImage26FlareRatio ratio,
            global::Runway.CreateTextToImageRequestGptImage26FlareQuality? quality,
            global::Runway.CreateTextToImageRequestGptImage26FlareBackground? background,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestGptImage26FlareReferenceImage>? referenceImages,
            int? outputCount,
            global::Runway.CreateTextToImageRequestGptImage26FlareReasoningEffort? reasoningEffort,
            string model = "gpt_image_2_6_flare")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Quality = quality;
            this.Background = background;
            this.ReferenceImages = referenceImages;
            this.OutputCount = outputCount;
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage26Flare" /> class.
        /// </summary>
        public CreateTextToImageRequestGptImage26Flare()
        {
        }

    }
}