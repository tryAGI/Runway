
#nullable enable

namespace Runway
{
    /// <summary>
    /// Present only when the config enables fallback.onCapacity and capacity affected this request.
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingCapacityFallback
    {
        /// <summary>
        /// Eligible models that were considered for this request but not selected because this account is at its concurrency limit for them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Skipped { get; set; }

        /// <summary>
        /// True when every eligible model was at its concurrency limit, so the best-ranked model was used and the task will queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allExhausted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllExhausted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingCapacityFallback" /> class.
        /// </summary>
        /// <param name="skipped">
        /// Eligible models that were considered for this request but not selected because this account is at its concurrency limit for them.
        /// </param>
        /// <param name="allExhausted">
        /// True when every eligible model was at its concurrency limit, so the best-ranked model was used and the task will queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingCapacityFallback(
            global::System.Collections.Generic.IList<string> skipped,
            bool allExhausted)
        {
            this.Skipped = skipped ?? throw new global::System.ArgumentNullException(nameof(skipped));
            this.AllExhausted = allExhausted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingCapacityFallback" /> class.
        /// </summary>
        public CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingCapacityFallback()
        {
        }

    }
}