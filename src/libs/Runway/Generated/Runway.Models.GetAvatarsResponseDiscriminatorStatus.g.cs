
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseDiscriminatorStatus
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
    public static class GetAvatarsResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetAvatarsResponseDiscriminatorStatus.Failed => "FAILED",
                GetAvatarsResponseDiscriminatorStatus.Processing => "PROCESSING",
                GetAvatarsResponseDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetAvatarsResponseDiscriminatorStatus.Failed,
                "PROCESSING" => GetAvatarsResponseDiscriminatorStatus.Processing,
                "READY" => GetAvatarsResponseDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}