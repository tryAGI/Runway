
#nullable enable

namespace Runway
{
    /// <summary>
    /// The status of the conversation. `in_progress` means the session is active, `ended` means it completed successfully, `failed` means it ended due to an error.
    /// </summary>
    public enum GetAvatarConversationsResponseDataItemStatus
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
    public static class GetAvatarConversationsResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseDataItemStatus value)
        {
            return value switch
            {
                GetAvatarConversationsResponseDataItemStatus.Ended => "ended",
                GetAvatarConversationsResponseDataItemStatus.Failed => "failed",
                GetAvatarConversationsResponseDataItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => GetAvatarConversationsResponseDataItemStatus.Ended,
                "failed" => GetAvatarConversationsResponseDataItemStatus.Failed,
                "in_progress" => GetAvatarConversationsResponseDataItemStatus.InProgress,
                _ => null,
            };
        }
    }
}