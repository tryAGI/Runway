
#nullable enable

namespace Runway
{
    /// <summary>
    /// Role in the workspace. `non-generating-admin` is a Billing Admin.
    /// </summary>
    public enum GetOrganizationWebappMembersResponseDataItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        NonGeneratingAdmin,
        /// <summary>
        ///
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappMembersResponseDataItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappMembersResponseDataItemRole value)
        {
            return value switch
            {
                GetOrganizationWebappMembersResponseDataItemRole.Admin => "admin",
                GetOrganizationWebappMembersResponseDataItemRole.Editor => "editor",
                GetOrganizationWebappMembersResponseDataItemRole.NonGeneratingAdmin => "non-generating-admin",
                GetOrganizationWebappMembersResponseDataItemRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappMembersResponseDataItemRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationWebappMembersResponseDataItemRole.Admin,
                "editor" => GetOrganizationWebappMembersResponseDataItemRole.Editor,
                "non-generating-admin" => GetOrganizationWebappMembersResponseDataItemRole.NonGeneratingAdmin,
                "viewer" => GetOrganizationWebappMembersResponseDataItemRole.Viewer,
                _ => null,
            };
        }
    }
}