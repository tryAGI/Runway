
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationWebappMembersResponseDataItemDeactivationReason
    {
        /// <summary>
        ///
        /// </summary>
        InviteEnded,
        /// <summary>
        ///
        /// </summary>
        Removed,
        /// <summary>
        ///
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappMembersResponseDataItemDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappMembersResponseDataItemDeactivationReason value)
        {
            return value switch
            {
                GetOrganizationWebappMembersResponseDataItemDeactivationReason.InviteEnded => "invite_ended",
                GetOrganizationWebappMembersResponseDataItemDeactivationReason.Removed => "removed",
                GetOrganizationWebappMembersResponseDataItemDeactivationReason.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappMembersResponseDataItemDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "invite_ended" => GetOrganizationWebappMembersResponseDataItemDeactivationReason.InviteEnded,
                "removed" => GetOrganizationWebappMembersResponseDataItemDeactivationReason.Removed,
                "suspended" => GetOrganizationWebappMembersResponseDataItemDeactivationReason.Suspended,
                _ => null,
            };
        }
    }
}