
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestGemini38FlashLiteTts
    {
        /// <summary>
        /// The Google voice for each speaker, such as "Kore" or "Puck". Pass one voice for a single speaker, or two for a dialogue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VoiceIds { get; set; }

        /// <summary>
        /// The script, in the order it is spoken. Use one turn for a single speaker, or alternate speakers across turns for a dialogue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTtsTurn> Turns { get; set; }

        /// <summary>
        /// The language of the script, such as "en-US". When omitted, the model detects it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gemini_3.8_flash_lite_tts"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_3.8_flash_lite_tts";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestGemini38FlashLiteTts" /> class.
        /// </summary>
        /// <param name="voiceIds">
        /// The Google voice for each speaker, such as "Kore" or "Puck". Pass one voice for a single speaker, or two for a dialogue.
        /// </param>
        /// <param name="turns">
        /// The script, in the order it is spoken. Use one turn for a single speaker, or alternate speakers across turns for a dialogue.
        /// </param>
        /// <param name="languageCode">
        /// The language of the script, such as "en-US". When omitted, the model detects it.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestGemini38FlashLiteTts(
            global::System.Collections.Generic.IList<string> voiceIds,
            global::System.Collections.Generic.IList<global::Runway.CreateTextToSpeechRequestGemini38FlashLiteTtsTurn> turns,
            string? languageCode,
            string model = "gemini_3.8_flash_lite_tts")
        {
            this.VoiceIds = voiceIds ?? throw new global::System.ArgumentNullException(nameof(voiceIds));
            this.Turns = turns ?? throw new global::System.ArgumentNullException(nameof(turns));
            this.LanguageCode = languageCode;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestGemini38FlashLiteTts" /> class.
        /// </summary>
        public CreateTextToSpeechRequestGemini38FlashLiteTts()
        {
        }

    }
}