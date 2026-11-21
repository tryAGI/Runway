
#nullable enable

namespace Runway
{
    /// <summary>
    /// `active`: a member of the workspace. `invited`: invited, and the invite is not accepted yet. `deactivated`: no longer a member; `deactivationReason` says why.
    /// </summary>
    public enum GetOrganizationWebappMembersResponseDataItemStatus
    {
        /// <summary>
        /// a member of the workspace. `invited`: invited, and the invite is not accepted yet. `deactivated`: no longer a member; `deactivationReason` says why.
        /// </summary>
        Active,
        /// <summary>
        /// a member of the workspace. `invited`: invited, and the invite is not accepted yet. `deactivated`: no longer a member; `deactivationReason` says why.
        /// </summary>
        Deactivated,
        /// <summary>
        /// a member of the workspace. `invited`: invited, and the invite is not accepted yet. `deactivated`: no longer a member; `deactivationReason` says why.
        /// </summary>
        Invited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappMembersResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappMembersResponseDataItemStatus value)
        {
            return value switch
            {
                GetOrganizationWebappMembersResponseDataItemStatus.Active => "active",
                GetOrganizationWebappMembersResponseDataItemStatus.Deactivated => "deactivated",
                GetOrganizationWebappMembersResponseDataItemStatus.Invited => "invited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappMembersResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetOrganizationWebappMembersResponseDataItemStatus.Active,
                "deactivated" => GetOrganizationWebappMembersResponseDataItemStatus.Deactivated,
                "invited" => GetOrganizationWebappMembersResponseDataItemStatus.Invited,
                _ => null,
            };
        }
    }
}