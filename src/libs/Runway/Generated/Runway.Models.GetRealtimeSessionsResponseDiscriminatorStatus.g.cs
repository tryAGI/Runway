
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRealtimeSessionsResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NotReady,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRealtimeSessionsResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRealtimeSessionsResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetRealtimeSessionsResponseDiscriminatorStatus.Cancelled => "CANCELLED",
                GetRealtimeSessionsResponseDiscriminatorStatus.Completed => "COMPLETED",
                GetRealtimeSessionsResponseDiscriminatorStatus.Failed => "FAILED",
                GetRealtimeSessionsResponseDiscriminatorStatus.NotReady => "NOT_READY",
                GetRealtimeSessionsResponseDiscriminatorStatus.Ready => "READY",
                GetRealtimeSessionsResponseDiscriminatorStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRealtimeSessionsResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => GetRealtimeSessionsResponseDiscriminatorStatus.Cancelled,
                "COMPLETED" => GetRealtimeSessionsResponseDiscriminatorStatus.Completed,
                "FAILED" => GetRealtimeSessionsResponseDiscriminatorStatus.Failed,
                "NOT_READY" => GetRealtimeSessionsResponseDiscriminatorStatus.NotReady,
                "READY" => GetRealtimeSessionsResponseDiscriminatorStatus.Ready,
                "RUNNING" => GetRealtimeSessionsResponseDiscriminatorStatus.Running,
                _ => null,
            };
        }
    }
}