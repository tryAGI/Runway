
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGenerateImageResponse4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"router_config_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = "router_config_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageResponse4" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateImageResponse4(
            string error,
            string code = "router_config_not_found")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageResponse4" /> class.
        /// </summary>
        public CreateGenerateImageResponse4()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateGenerateImageResponse4"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateGenerateImageResponse4 FromError(string error)
        {
            return new CreateGenerateImageResponse4
            {
                Error = error,
            };
        }

    }
}