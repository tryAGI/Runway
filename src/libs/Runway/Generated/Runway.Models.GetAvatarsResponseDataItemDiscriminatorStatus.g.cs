
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseDataItemDiscriminatorStatus
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
    public static class GetAvatarsResponseDataItemDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDataItemDiscriminatorStatus value)
        {
            return value switch
            {
                GetAvatarsResponseDataItemDiscriminatorStatus.Failed => "FAILED",
                GetAvatarsResponseDataItemDiscriminatorStatus.Processing => "PROCESSING",
                GetAvatarsResponseDataItemDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDataItemDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetAvatarsResponseDataItemDiscriminatorStatus.Failed,
                "PROCESSING" => GetAvatarsResponseDataItemDiscriminatorStatus.Processing,
                "READY" => GetAvatarsResponseDataItemDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}