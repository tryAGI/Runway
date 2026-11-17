
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKling4Flash
    {
        /// <summary>
        /// A text prompt describing what should happen in the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The target output size. Use a pixel ratio such as `1280:720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKling4FlashRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestKling4FlashRatio? Ratio { get; set; }

        /// <summary>
        /// The duration of the output video in seconds. Defaults to 5.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling4FlashReference>? References { get; set; }

        /// <summary>
        /// Up to 5 videos whose style, motion or camera work should guide the output, together at most 30 seconds long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<object>? ReferenceVideos { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"kling_4_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "kling_4_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling4Flash" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A text prompt describing what should happen in the video.
        /// </param>
        /// <param name="ratio">
        /// The target output size. Use a pixel ratio such as `1280:720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds. Defaults to 5.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="references">
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </param>
        /// <param name="referenceVideos">
        /// Up to 5 videos whose style, motion or camera work should guide the output, together at most 30 seconds long.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestKling4Flash(
            string promptText,
            global::Runway.CreateTextToVideoRequestKling4FlashRatio? ratio,
            int? duration,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling4FlashReference>? references,
            global::System.Collections.Generic.IList<object>? referenceVideos,
            string model = "kling_4_flash")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Duration = duration;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling4Flash" /> class.
        /// </summary>
        public CreateTextToVideoRequestKling4Flash()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestKling4Flash"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestKling4Flash FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestKling4Flash
            {
                PromptText = promptText,
            };
        }

    }
}