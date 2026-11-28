
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestGemini38FlashTtsTurn
    {
        /// <summary>
        /// The words to speak in this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// How this turn should be delivered, such as "calm and reassuring". It guides the delivery and is not read aloud.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// The position in `voiceIds` of the voice that speaks this turn. Defaults to the first voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestGemini38FlashTtsTurn" /> class.
        /// </summary>
        /// <param name="text">
        /// The words to speak in this turn.
        /// </param>
        /// <param name="style">
        /// How this turn should be delivered, such as "calm and reassuring". It guides the delivery and is not read aloud.
        /// </param>
        /// <param name="speaker">
        /// The position in `voiceIds` of the voice that speaks this turn. Defaults to the first voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestGemini38FlashTtsTurn(
            string text,
            string? style,
            int? speaker)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Style = style;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestGemini38FlashTtsTurn" /> class.
        /// </summary>
        public CreateTextToSpeechRequestGemini38FlashTtsTurn()
        {
        }

    }
}