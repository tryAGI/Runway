
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateImageRequest
    {
        /// <summary>
        /// The slug of a saved Model Router config to route this request with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigId { get; set; }

        /// <summary>
        /// Model-agnostic image generation input. The router selects a model and maps these options to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateImageRequestInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageRequest" /> class.
        /// </summary>
        /// <param name="configId">
        /// The slug of a saved Model Router config to route this request with.
        /// </param>
        /// <param name="input">
        /// Model-agnostic image generation input. The router selects a model and maps these options to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateImageRequest(
            string configId,
            global::Runway.CreateGenerateImageRequestInput input)
        {
            this.ConfigId = configId ?? throw new global::System.ArgumentNullException(nameof(configId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageRequest" /> class.
        /// </summary>
        public CreateGenerateImageRequest()
        {
        }

    }
}