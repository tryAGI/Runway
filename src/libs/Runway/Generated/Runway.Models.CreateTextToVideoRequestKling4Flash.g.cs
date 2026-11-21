
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
        /// The duration of the output video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling4FlashReference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling4FlashReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// The output size, or auto_720p for adaptive framing. Legacy values 940:940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKling4FlashRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestKling4FlashRatio? Ratio { get; set; }

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
        /// <param name="duration">
        /// The duration of the output video in seconds.
        /// </param>
        /// <param name="references"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="ratio">
        /// The output size, or auto_720p for adaptive framing. Legacy values 940:940 and 1460:624 are accepted as aliases for 960:960 and 1464:628, respectively.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestKling4Flash(
            string promptText,
            int? duration,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling4FlashReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestKling4FlashReferenceVideo>? referenceVideos,
            global::Runway.CreateTextToVideoRequestKling4FlashRatio? ratio,
            string model = "kling_4_flash")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Duration = duration;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.Ratio = ratio;
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