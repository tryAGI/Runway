
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarConversationsResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarConversationsResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetAvatarConversationsResponseDiscriminatorStatus.Ended => "ended",
                GetAvatarConversationsResponseDiscriminatorStatus.Failed => "failed",
                GetAvatarConversationsResponseDiscriminatorStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => GetAvatarConversationsResponseDiscriminatorStatus.Ended,
                "failed" => GetAvatarConversationsResponseDiscriminatorStatus.Failed,
                "in_progress" => GetAvatarConversationsResponseDiscriminatorStatus.InProgress,
                _ => null,
            };
        }
    }
}