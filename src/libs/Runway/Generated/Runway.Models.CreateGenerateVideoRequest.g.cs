
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoRequest
    {
        /// <summary>
        /// The slug of a saved Model Router config to route this request with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigId { get; set; }

        /// <summary>
        /// When true, run the full routing pipeline and return the decision and estimated cost without generating. No task is created, nothing is billed, and no asset is produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Model-agnostic video generation input. Fields are optional; the router selects a model and maps these options to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateVideoRequestInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequest" /> class.
        /// </summary>
        /// <param name="configId">
        /// The slug of a saved Model Router config to route this request with.
        /// </param>
        /// <param name="input">
        /// Model-agnostic video generation input. Fields are optional; the router selects a model and maps these options to it.
        /// </param>
        /// <param name="dryRun">
        /// When true, run the full routing pipeline and return the decision and estimated cost without generating. No task is created, nothing is billed, and no asset is produced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoRequest(
            string configId,
            global::Runway.CreateGenerateVideoRequestInput input,
            bool? dryRun)
        {
            this.ConfigId = configId ?? throw new global::System.ArgumentNullException(nameof(configId));
            this.DryRun = dryRun;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequest" /> class.
        /// </summary>
        public CreateGenerateVideoRequest()
        {
        }

    }
}