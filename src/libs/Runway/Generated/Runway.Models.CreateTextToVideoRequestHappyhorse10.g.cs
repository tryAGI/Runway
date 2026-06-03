
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoRequestHappyhorse10
    {
        /// <summary>
        /// A non-empty string up to 2500 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
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
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToVideoRequestHappyhorse10RatioJsonConverter))]
        public global::Runway.CreateTextToVideoRequestHappyhorse10Ratio? Ratio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"happyhorse_1_0"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "happyhorse_1_0";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestHappyhorse10" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 2500 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToVideoRequestHappyhorse10(
            string promptText,
            int? duration,
            global::Runway.CreateTextToVideoRequestHappyhorse10Ratio? ratio,
            string model = "happyhorse_1_0")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Duration = duration;
            this.Ratio = ratio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequestHappyhorse10" /> class.
        /// </summary>
        public CreateTextToVideoRequestHappyhorse10()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToVideoRequestHappyhorse10"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToVideoRequestHappyhorse10 FromPromptText(string promptText)
        {
            return new CreateTextToVideoRequestHappyhorse10
            {
                PromptText = promptText,
            };
        }

    }
}