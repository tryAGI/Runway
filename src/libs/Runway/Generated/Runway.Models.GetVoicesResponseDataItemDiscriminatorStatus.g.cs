
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoicesResponseDataItemDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVoicesResponseDataItemDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoicesResponseDataItemDiscriminatorStatus value)
        {
            return value switch
            {
                GetVoicesResponseDataItemDiscriminatorStatus.Failed => "FAILED",
                GetVoicesResponseDataItemDiscriminatorStatus.Processing => "PROCESSING",
                GetVoicesResponseDataItemDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoicesResponseDataItemDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetVoicesResponseDataItemDiscriminatorStatus.Failed,
                "PROCESSING" => GetVoicesResponseDataItemDiscriminatorStatus.Processing,
                "READY" => GetVoicesResponseDataItemDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}