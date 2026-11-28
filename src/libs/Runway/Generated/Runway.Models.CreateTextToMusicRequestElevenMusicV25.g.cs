
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToMusicRequestElevenMusicV25
    {
        /// <summary>
        /// A description of the track to generate, such as its genre, mood, instruments, and vocals. Prompts that name specific artists or songs are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The length of the track in whole seconds. You are billed for the requested length.<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// When true, the track has no vocals. When omitted, the model decides from the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumental")]
        public bool? Instrumental { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"eleven_music_v2_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "eleven_music_v2_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToMusicRequestElevenMusicV25" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A description of the track to generate, such as its genre, mood, instruments, and vocals. Prompts that name specific artists or songs are rejected.
        /// </param>
        /// <param name="duration">
        /// The length of the track in whole seconds. You are billed for the requested length.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="instrumental">
        /// When true, the track has no vocals. When omitted, the model decides from the prompt.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToMusicRequestElevenMusicV25(
            string promptText,
            int? duration,
            bool? instrumental,
            string model = "eleven_music_v2_5")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Duration = duration;
            this.Instrumental = instrumental;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToMusicRequestElevenMusicV25" /> class.
        /// </summary>
        public CreateTextToMusicRequestElevenMusicV25()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToMusicRequestElevenMusicV25"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToMusicRequestElevenMusicV25 FromPromptText(string promptText)
        {
            return new CreateTextToMusicRequestElevenMusicV25
            {
                PromptText = promptText,
            };
        }

    }
}