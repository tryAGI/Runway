
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAvatarsResponseDiscriminatorStatus
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
    public static class PatchAvatarsResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseDiscriminatorStatus value)
        {
            return value switch
            {
                PatchAvatarsResponseDiscriminatorStatus.Failed => "FAILED",
                PatchAvatarsResponseDiscriminatorStatus.Processing => "PROCESSING",
                PatchAvatarsResponseDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => PatchAvatarsResponseDiscriminatorStatus.Failed,
                "PROCESSING" => PatchAvatarsResponseDiscriminatorStatus.Processing,
                "READY" => PatchAvatarsResponseDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}