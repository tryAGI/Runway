
#nullable enable

namespace Runway
{
    /// <summary>
    /// Metadata describing which model the router selected and why.
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseRouting
    {
        /// <summary>
        /// The public name of the model the router selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The provider of the selected model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The slug of the router config that was applied to this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigId { get; set; }

        /// <summary>
        /// The resolved config settings the router used for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutingResolvedSettings ResolvedSettings { get; set; }

        /// <summary>
        /// Request-side defaults resolved for the routing response. Not necessarily identical to prepared model options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutingResolvedInput ResolvedInput { get; set; }

        /// <summary>
        /// Estimated cost, computed against current pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutingEstimatedCost EstimatedCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRouting" /> class.
        /// </summary>
        /// <param name="model">
        /// The public name of the model the router selected.
        /// </param>
        /// <param name="provider">
        /// The provider of the selected model.
        /// </param>
        /// <param name="configId">
        /// The slug of the router config that was applied to this request.
        /// </param>
        /// <param name="resolvedSettings">
        /// The resolved config settings the router used for this request.
        /// </param>
        /// <param name="resolvedInput">
        /// Request-side defaults resolved for the routing response. Not necessarily identical to prepared model options.
        /// </param>
        /// <param name="estimatedCost">
        /// Estimated cost, computed against current pricing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseRouting(
            string model,
            string provider,
            string configId,
            global::Runway.CreateGenerateAudioResponseRoutingResolvedSettings resolvedSettings,
            global::Runway.CreateGenerateAudioResponseRoutingResolvedInput resolvedInput,
            global::Runway.CreateGenerateAudioResponseRoutingEstimatedCost estimatedCost)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ConfigId = configId ?? throw new global::System.ArgumentNullException(nameof(configId));
            this.ResolvedSettings = resolvedSettings ?? throw new global::System.ArgumentNullException(nameof(resolvedSettings));
            this.ResolvedInput = resolvedInput ?? throw new global::System.ArgumentNullException(nameof(resolvedInput));
            this.EstimatedCost = estimatedCost ?? throw new global::System.ArgumentNullException(nameof(estimatedCost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRouting" /> class.
        /// </summary>
        public CreateGenerateAudioResponseRouting()
        {
        }

    }
}