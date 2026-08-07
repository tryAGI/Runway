
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateAudioResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateAudioResponseDiscriminatorDryRunJsonConverter))]
        public global::Runway.CreateGenerateAudioResponseDiscriminatorDryRun? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="dryRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioResponseDiscriminator(
            global::Runway.CreateGenerateAudioResponseDiscriminatorDryRun? dryRun)
        {
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioResponseDiscriminator" /> class.
        /// </summary>
        public CreateGenerateAudioResponseDiscriminator()
        {
        }

    }
}