
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseRoutedAudioDryRun
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool DryRun { get; set; } = true;

        /// <summary>
        /// Metadata describing which model the router selected and why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRouting Routing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutedAudioDryRun" /> class.
        /// </summary>
        /// <param name="routing">
        /// Metadata describing which model the router selected and why.
        /// </param>
        /// <param name="dryRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseRoutedAudioDryRun(
            global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRouting routing,
            bool dryRun = true)
        {
            this.DryRun = dryRun;
            this.Routing = routing ?? throw new global::System.ArgumentNullException(nameof(routing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseRoutedAudioDryRun" /> class.
        /// </summary>
        public CreateGenerateAudioResponseRoutedAudioDryRun()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateGenerateAudioResponseRoutedAudioDryRun"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioDryRun FromRouting(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRunRouting routing)
        {
            return new CreateGenerateAudioResponseRoutedAudioDryRun
            {
                Routing = routing,
            };
        }

    }
}