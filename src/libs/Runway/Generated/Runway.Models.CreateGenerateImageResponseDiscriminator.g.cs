
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateImageResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateGenerateImageResponseDiscriminatorDryRunJsonConverter))]
        public global::Runway.CreateGenerateImageResponseDiscriminatorDryRun? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="dryRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateImageResponseDiscriminator(
            global::Runway.CreateGenerateImageResponseDiscriminatorDryRun? dryRun)
        {
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageResponseDiscriminator" /> class.
        /// </summary>
        public CreateGenerateImageResponseDiscriminator()
        {
        }

    }
}