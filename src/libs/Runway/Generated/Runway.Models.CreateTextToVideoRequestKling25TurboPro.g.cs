
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToVideoRequestKling25TurboPro
    {
        /// <summary>
        /// A text prompt describing what should appear in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Default Value: 1920:1080
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestKling25TurboProRatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestKling25TurboProRatio? Ratio { get; set; }

        /// <summary>
        /// Creativity/freedom scale for generation. 0 gives the model maximum creative freedom, 1 makes it follow the prompt most strictly. Defaults to 0.5.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfgScale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// The duration of the output video in seconds. Defaults to 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"kling2.5_turbo_pro"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "kling2.5_turbo_pro";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling25TurboPro" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A text prompt describing what should appear in the output video.
        /// </param>
        /// <param name="ratio">
        /// Default Value: 1920:1080
        /// </param>
        /// <param name="cfgScale">
        /// Creativity/freedom scale for generation. 0 gives the model maximum creative freedom, 1 makes it follow the prompt most strictly. Defaults to 0.5.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds. Defaults to 5.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestKling25TurboPro(
            string promptText,
            global::Runway.CreateTextToVideoRequestKling25TurboProRatio? ratio,
            double? cfgScale,
            double? duration,
            string model = "kling2.5_turbo_pro")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.CfgScale = cfgScale;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestKling25TurboPro" /> class.
        /// </summary>
        public CreateTextToVideoRequestKling25TurboPro()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestKling25TurboPro"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestKling25TurboPro FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestKling25TurboPro
            {
                PromptText = promptText,
            };
        }

    }
}