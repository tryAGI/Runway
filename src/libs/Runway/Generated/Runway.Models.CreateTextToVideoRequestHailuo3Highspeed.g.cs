
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestHailuo3Highspeed
    {
        /// <summary>
        /// The text prompt describing the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output video resolution.<br/>
        /// Default Value: 768p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3HighspeedResolutionJsonConverter))]
        public global::Runway.CreateTextToVideoRequestHailuo3HighspeedResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHailuo3HighspeedRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestHailuo3HighspeedRatio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3HighspeedReference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3HighspeedReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3HighspeedReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"hailuo3_highspeed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "hailuo3_highspeed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestHailuo3Highspeed" /> class.
        /// </summary>
        /// <param name="promptText">
        /// The text prompt describing the output video.
        /// </param>
        /// <param name="resolution">
        /// The output video resolution.<br/>
        /// Default Value: 768p
        /// </param>
        /// <param name="duration">
        /// Default Value: 5
        /// </param>
        /// <param name="ratio"></param>
        /// <param name="references"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="referenceAudio"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestHailuo3Highspeed(
            string promptText,
            global::Runway.CreateTextToVideoRequestHailuo3HighspeedResolution? resolution,
            int? duration,
            global::Runway.CreateTextToVideoRequestHailuo3HighspeedRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3HighspeedReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3HighspeedReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToVideoRequestHailuo3HighspeedReferenceAudioItem>? referenceAudio,
            string model = "hailuo3_highspeed")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestHailuo3Highspeed" /> class.
        /// </summary>
        public CreateTextToVideoRequestHailuo3Highspeed()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestHailuo3Highspeed"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestHailuo3Highspeed FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestHailuo3Highspeed
            {
                PromptText = promptText,
            };
        }

    }
}