
#nullable enable

namespace Runway
{
    /// <summary>
    /// Whether the row is a credit charge for a generation or a task refund (negative credits).
    /// </summary>
    public enum GetOrganizationWebappUsageResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Charge,
        /// <summary>
        ///
        /// </summary>
        Refund,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappUsageResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappUsageResponseDataItemType value)
        {
            return value switch
            {
                GetOrganizationWebappUsageResponseDataItemType.Charge => "charge",
                GetOrganizationWebappUsageResponseDataItemType.Refund => "refund",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappUsageResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "charge" => GetOrganizationWebappUsageResponseDataItemType.Charge,
                "refund" => GetOrganizationWebappUsageResponseDataItemType.Refund,
                _ => null,
            };
        }
    }
}