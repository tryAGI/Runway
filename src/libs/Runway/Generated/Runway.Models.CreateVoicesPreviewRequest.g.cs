
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoicesPreviewRequest
    {
        /// <summary>
        /// A text description of the desired voice characteristics. Must be at least 20 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The voice design model to use. Prefer eleven_ttv_v3 (latest); eleven_multilingual_ttv_v2 is the previous generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVoicesPreviewRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateVoicesPreviewRequestModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesPreviewRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired voice characteristics. Must be at least 20 characters.
        /// </param>
        /// <param name="model">
        /// The voice design model to use. Prefer eleven_ttv_v3 (latest); eleven_multilingual_ttv_v2 is the previous generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoicesPreviewRequest(
            string prompt,
            global::Runway.CreateVoicesPreviewRequestModel model)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesPreviewRequest" /> class.
        /// </summary>
        public CreateVoicesPreviewRequest()
        {
        }
    }
}