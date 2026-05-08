
#nullable enable

namespace Runway
{
    /// <summary>
    /// Who produced this transcript entry.
    /// </summary>
    public enum GetAvatarConversationsResponseVariant1TranscriptItemRole
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
    public static class GetAvatarConversationsResponseVariant1TranscriptItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant1TranscriptItemRole value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant1TranscriptItemRole.Assistant => "assistant",
                GetAvatarConversationsResponseVariant1TranscriptItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant1TranscriptItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GetAvatarConversationsResponseVariant1TranscriptItemRole.Assistant,
                "user" => GetAvatarConversationsResponseVariant1TranscriptItemRole.User,
                _ => null,
            };
        }
    }
}