
#nullable enable

namespace Runway
{
    /// <summary>
    /// A user-created avatar.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestAvatarCustomAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// ID of a user-created avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AvatarId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestAvatarCustomAvatar" /> class.
        /// </summary>
        /// <param name="avatarId">
        /// ID of a user-created avatar.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestAvatarCustomAvatar(
            global::System.Guid avatarId,
            string type = "custom")
        {
            this.Type = type;
            this.AvatarId = avatarId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestAvatarCustomAvatar" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestAvatarCustomAvatar()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateRealtimeSessionsRequestAvatarCustomAvatar"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateRealtimeSessionsRequestAvatarCustomAvatar FromAvatarId(global::System.Guid avatarId)
        {
            return new CreateRealtimeSessionsRequestAvatarCustomAvatar
            {
                AvatarId = avatarId,
            };
        }

    }
}