
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoicesResponseDiscriminatorStatus
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
    public static class GetVoicesResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoicesResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetVoicesResponseDiscriminatorStatus.Failed => "FAILED",
                GetVoicesResponseDiscriminatorStatus.Processing => "PROCESSING",
                GetVoicesResponseDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoicesResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetVoicesResponseDiscriminatorStatus.Failed,
                "PROCESSING" => GetVoicesResponseDiscriminatorStatus.Processing,
                "READY" => GetVoicesResponseDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}