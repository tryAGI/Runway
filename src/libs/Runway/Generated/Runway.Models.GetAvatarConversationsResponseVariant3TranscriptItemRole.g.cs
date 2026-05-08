
#nullable enable

namespace Runway
{
    /// <summary>
    /// Who produced this transcript entry.
    /// </summary>
    public enum GetAvatarConversationsResponseVariant3TranscriptItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarConversationsResponseVariant3TranscriptItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant3TranscriptItemRole value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant3TranscriptItemRole.Assistant => "assistant",
                GetAvatarConversationsResponseVariant3TranscriptItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant3TranscriptItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GetAvatarConversationsResponseVariant3TranscriptItemRole.Assistant,
                "user" => GetAvatarConversationsResponseVariant3TranscriptItemRole.User,
                _ => null,
            };
        }
    }
}