
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestIdeogram45
    {
        /// <summary>
        /// Describe the image to generate, or the changes to make to the reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// How much rendering effort the model spends on each image. Defaults to `medium` (8 credits per image) when generating from reference images and `high` (25 credits) otherwise, including `preciseEdit`. `low` costs 4 credits and `very_low` 1; `very_low` requires reference images and is not available with `preciseEdit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestIdeogram45QualityJsonConverter))]
        public global::Runway.CreateTextToImageRequestIdeogram45Quality? Quality { get; set; }

        /// <summary>
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestIdeogram45RatioJsonConverter))]
        public global::Runway.CreateTextToImageRequestIdeogram45Ratio? Ratio { get; set; }

        /// <summary>
        /// Up to 5 images to guide the generation. With `maskUri` or `preciseEdit`, the first image is the one being edited and the rest are references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestIdeogram45ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// When true, edit the first reference image. Requires at least one reference image. Whole-image edits above 4,194,304 pixels are scaled down. Set contextWindow to edit a region at full source resolution; auto-fit may still scale down if the mask cannot fit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preciseEdit")]
        public bool? PreciseEdit { get; set; }

        /// <summary>
        /// Precise-edit region: none, auto (requires maskUri), or top,left,bottom,right in original-image pixels, with exclusive maximum edges. A manual region preserves full resolution and all pixels outside it. All masked edit pixels must lie inside a manual region. Auto-fit may fall back to downscaling if the mask is too large. Requires edit-window access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextWindow")]
        public string? ContextWindow { get; set; }

        /// <summary>
        /// A black-and-white mask the same size as the first reference image. Black areas are edited and white areas are preserved. Supports up to 3 additional reference images.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskUri")]
        public string? MaskUri { get; set; }

        /// <summary>
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"ideogram_4_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "ideogram_4_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestIdeogram45" /> class.
        /// </summary>
        /// <param name="promptText">
        /// Describe the image to generate, or the changes to make to the reference images.
        /// </param>
        /// <param name="quality">
        /// How much rendering effort the model spends on each image. Defaults to `medium` (8 credits per image) when generating from reference images and `high` (25 credits) otherwise, including `preciseEdit`. `low` costs 4 credits and `very_low` 1; `very_low` requires reference images and is not available with `preciseEdit`.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </param>
        /// <param name="referenceImages">
        /// Up to 5 images to guide the generation. With `maskUri` or `preciseEdit`, the first image is the one being edited and the rest are references.
        /// </param>
        /// <param name="preciseEdit">
        /// When true, edit the first reference image. Requires at least one reference image. Whole-image edits above 4,194,304 pixels are scaled down. Set contextWindow to edit a region at full source resolution; auto-fit may still scale down if the mask cannot fit.
        /// </param>
        /// <param name="contextWindow">
        /// Precise-edit region: none, auto (requires maskUri), or top,left,bottom,right in original-image pixels, with exclusive maximum edges. A manual region preserves full resolution and all pixels outside it. All masked edit pixels must lie inside a manual region. Auto-fit may fall back to downscaling if the mask is too large. Requires edit-window access.
        /// </param>
        /// <param name="maskUri">
        /// A black-and-white mask the same size as the first reference image. Black areas are edited and white areas are preserved. Supports up to 3 additional reference images.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="outputCount">
        /// The number of images to generate. Increasing this number will affect the number of credits consumed by the generation.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestIdeogram45(
            string promptText,
            global::Runway.CreateTextToImageRequestIdeogram45Quality? quality,
            global::Runway.CreateTextToImageRequestIdeogram45Ratio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToImageRequestIdeogram45ReferenceImage>? referenceImages,
            bool? preciseEdit,
            string? contextWindow,
            string? maskUri,
            int? outputCount,
            string model = "ideogram_4_5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Quality = quality;
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.PreciseEdit = preciseEdit;
            this.ContextWindow = contextWindow;
            this.MaskUri = maskUri;
            this.OutputCount = outputCount;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestIdeogram45" /> class.
        /// </summary>
        public CreateTextToImageRequestIdeogram45()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToImageRequestIdeogram45"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToImageRequestIdeogram45 FromPromptText(string promptText)
        {
            return new CreateTextToImageRequestIdeogram45
            {
                PromptText = promptText,
            };
        }

    }
}