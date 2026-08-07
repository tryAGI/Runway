
#nullable enable

namespace Runway
{
    /// <summary>
    /// Opt-in behavior for what routing should do when the preferred model cannot start immediately.
    /// </summary>
    public sealed partial class GetRoutersResponseSettingsFallback
    {
        /// <summary>
        /// When true, if the account is at its concurrency limit on the preferred model, routing skips it and picks the next-best eligible model instead of queueing. If every eligible model is at its limit, the original best-ranked model is used and the task queues as usual.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onCapacity")]
        public bool? OnCapacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponseSettingsFallback" /> class.
        /// </summary>
        /// <param name="onCapacity">
        /// When true, if the account is at its concurrency limit on the preferred model, routing skips it and picks the next-best eligible model instead of queueing. If every eligible model is at its limit, the original best-ranked model is used and the task queues as usual.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersResponseSettingsFallback(
            bool? onCapacity)
        {
            this.OnCapacity = onCapacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponseSettingsFallback" /> class.
        /// </summary>
        public GetRoutersResponseSettingsFallback()
        {
        }

    }
}