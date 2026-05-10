
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchVoicesResponseDiscriminatorStatus
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
    public static class PatchVoicesResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchVoicesResponseDiscriminatorStatus value)
        {
            return value switch
            {
                PatchVoicesResponseDiscriminatorStatus.Failed => "FAILED",
                PatchVoicesResponseDiscriminatorStatus.Processing => "PROCESSING",
                PatchVoicesResponseDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchVoicesResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => PatchVoicesResponseDiscriminatorStatus.Failed,
                "PROCESSING" => PatchVoicesResponseDiscriminatorStatus.Processing,
                "READY" => PatchVoicesResponseDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}