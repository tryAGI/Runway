
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestVariant16
    {
        /// <summary>
        /// A text description of the sound effect to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The duration of the sound effect in seconds, between 0.5 and 30 seconds. If not provided, the duration will be determined automatically based on the text description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Whether the output sound effect should be designed to loop seamlessly.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant16" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A text description of the sound effect to generate.
        /// </param>
        /// <param name="duration">
        /// The duration of the sound effect in seconds, between 0.5 and 30 seconds. If not provided, the duration will be determined automatically based on the text description.
        /// </param>
        /// <param name="loop">
        /// Whether the output sound effect should be designed to loop seamlessly.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestVariant16(
            string promptText,
            string model,
            double? duration,
            bool? loop)
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Duration = duration;
            this.Loop = loop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant16" /> class.
        /// </summary>
        public RequestVariant16()
        {
        }
    }
}