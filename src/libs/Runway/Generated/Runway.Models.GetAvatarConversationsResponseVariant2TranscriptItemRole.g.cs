
#nullable enable

namespace Runway
{
    /// <summary>
    /// Who produced this transcript entry.
    /// </summary>
    public enum GetAvatarConversationsResponseVariant2TranscriptItemRole
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
    public static class GetAvatarConversationsResponseVariant2TranscriptItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant2TranscriptItemRole value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant2TranscriptItemRole.Assistant => "assistant",
                GetAvatarConversationsResponseVariant2TranscriptItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant2TranscriptItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GetAvatarConversationsResponseVariant2TranscriptItemRole.Assistant,
                "user" => GetAvatarConversationsResponseVariant2TranscriptItemRole.User,
                _ => null,
            };
        }
    }
}