
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarsResponseDiscriminatorStatus
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
    public static class CreateAvatarsResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseDiscriminatorStatus value)
        {
            return value switch
            {
                CreateAvatarsResponseDiscriminatorStatus.Failed => "FAILED",
                CreateAvatarsResponseDiscriminatorStatus.Processing => "PROCESSING",
                CreateAvatarsResponseDiscriminatorStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => CreateAvatarsResponseDiscriminatorStatus.Failed,
                "PROCESSING" => CreateAvatarsResponseDiscriminatorStatus.Processing,
                "READY" => CreateAvatarsResponseDiscriminatorStatus.Ready,
                _ => null,
            };
        }
    }
}