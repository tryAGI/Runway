
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGen45
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45RatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateImageToVideoRequestGen45Ratio Ratio { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video. Must be an integer from 2 to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.CreateImageToVideoRequestGen45ContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames (plus a separate .wav artifact when the output has audio). Non-mp4 formats incur an additional surcharge of 5 credits per second of output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45OutputFormatJsonConverter))]
        public global::Runway.CreateImageToVideoRequestGen45OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The ProRes profile to use. Only valid when `outputFormat` is `prores`. Defaults to `4444`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proresProfile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGen45ProresProfileJsonConverter))]
        public global::Runway.CreateImageToVideoRequestGen45ProresProfile? ProresProfile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gen4.5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gen4.5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen45" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="promptImage"></param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video. Must be an integer from 2 to 10.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="outputFormat">
        /// The container/encoding of the output. `mp4` (default) returns an H.264 .mp4. `prores` returns a ProRes .mov. `png_sequence` returns a .zip of PNG frames (plus a separate .wav artifact when the output has audio). Non-mp4 formats incur an additional surcharge of 5 credits per second of output.
        /// </param>
        /// <param name="proresProfile">
        /// The ProRes profile to use. Only valid when `outputFormat` is `prores`. Defaults to `4444`.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestGen45(
            string promptText,
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGen45PromptImagePromptImage>> promptImage,
            global::Runway.CreateImageToVideoRequestGen45Ratio ratio,
            int duration,
            int? seed,
            global::Runway.CreateImageToVideoRequestGen45ContentModeration? contentModeration,
            global::Runway.CreateImageToVideoRequestGen45OutputFormat? outputFormat,
            global::Runway.CreateImageToVideoRequestGen45ProresProfile? proresProfile,
            string model = "gen4.5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.PromptImage = promptImage;
            this.Seed = seed;
            this.Ratio = ratio;
            this.Duration = duration;
            this.ContentModeration = contentModeration;
            this.OutputFormat = outputFormat;
            this.ProresProfile = proresProfile;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGen45" /> class.
        /// </summary>
        public CreateImageToVideoRequestGen45()
        {
        }

    }
}