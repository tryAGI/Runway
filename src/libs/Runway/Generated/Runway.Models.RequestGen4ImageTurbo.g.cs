
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestGen4ImageTurbo
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The resolution of the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.RequestGen4ImageTurboRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.RequestGen4ImageTurboRatio Ratio { get; set; }

        /// <summary>
        /// An array of one to three images to be used as references for the generated image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.RequestGen4ImageTurboReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.RequestGen4ImageTurboContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen4ImageTurbo" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image.
        /// </param>
        /// <param name="referenceImages">
        /// An array of one to three images to be used as references for the generated image output.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestGen4ImageTurbo(
            string promptText,
            global::Runway.RequestGen4ImageTurboRatio ratio,
            global::System.Collections.Generic.IList<global::Runway.RequestGen4ImageTurboReferenceImage> referenceImages,
            string model,
            int? seed,
            global::Runway.RequestGen4ImageTurboContentModeration? contentModeration)
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Seed = seed;
            this.ContentModeration = contentModeration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen4ImageTurbo" /> class.
        /// </summary>
        public RequestGen4ImageTurbo()
        {
        }
    }
}