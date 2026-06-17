
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesMultiShotVideoRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter))]
        public global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMultiShotVideoRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesMultiShotVideoRequestDiscriminator(
            global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMultiShotVideoRequestDiscriminator" /> class.
        /// </summary>
        public CreateRecipesMultiShotVideoRequestDiscriminator()
        {
        }

    }
}