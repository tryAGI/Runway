
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateVideoResponseDiscriminatorDryRunJsonConverter))]
        public global::Runway.CreateGenerateVideoResponseDiscriminatorDryRun? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="dryRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponseDiscriminator(
            global::Runway.CreateGenerateVideoResponseDiscriminatorDryRun? dryRun)
        {
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseDiscriminator" /> class.
        /// </summary>
        public CreateGenerateVideoResponseDiscriminator()
        {
        }

    }
}