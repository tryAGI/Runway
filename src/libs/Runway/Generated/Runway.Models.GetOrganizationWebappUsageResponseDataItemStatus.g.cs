
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationWebappUsageResponseDataItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
        /// <summary>
        ///
        /// </summary>
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappUsageResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappUsageResponseDataItemStatus value)
        {
            return value switch
            {
                GetOrganizationWebappUsageResponseDataItemStatus.Cancelled => "CANCELLED",
                GetOrganizationWebappUsageResponseDataItemStatus.Failed => "FAILED",
                GetOrganizationWebappUsageResponseDataItemStatus.Pending => "PENDING",
                GetOrganizationWebappUsageResponseDataItemStatus.Running => "RUNNING",
                GetOrganizationWebappUsageResponseDataItemStatus.Succeeded => "SUCCEEDED",
                GetOrganizationWebappUsageResponseDataItemStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappUsageResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => GetOrganizationWebappUsageResponseDataItemStatus.Cancelled,
                "FAILED" => GetOrganizationWebappUsageResponseDataItemStatus.Failed,
                "PENDING" => GetOrganizationWebappUsageResponseDataItemStatus.Pending,
                "RUNNING" => GetOrganizationWebappUsageResponseDataItemStatus.Running,
                "SUCCEEDED" => GetOrganizationWebappUsageResponseDataItemStatus.Succeeded,
                "THROTTLED" => GetOrganizationWebappUsageResponseDataItemStatus.Throttled,
                _ => null,
            };
        }
    }
}