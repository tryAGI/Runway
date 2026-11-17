
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestGrokImagine15Lite
    {
        /// <summary>
        /// A non-empty text prompt describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. The 1080p sizes are rendered at 720p and upscaled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestGrokImagine15LiteRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"grok_imagine_1_5_lite"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "grok_imagine_1_5_lite";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGrokImagine15Lite" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty text prompt describing what should appear in the output.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. The 1080p sizes are rendered at 720p and upscaled.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestGrokImagine15Lite(
            string promptText,
            int? duration,
            global::Runway.CreateTextToVideoRequestGrokImagine15LiteRatio? ratio,
            string model = "grok_imagine_1_5_lite")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Duration = duration;
            this.Ratio = ratio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestGrokImagine15Lite" /> class.
        /// </summary>
        public CreateTextToVideoRequestGrokImagine15Lite()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestGrokImagine15Lite"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestGrokImagine15Lite FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestGrokImagine15Lite
            {
                PromptText = promptText,
            };
        }

    }
}