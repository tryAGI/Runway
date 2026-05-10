
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWorkflowInvocationsResponseDiscriminatorStatus
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
    public static class GetWorkflowInvocationsResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowInvocationsResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetWorkflowInvocationsResponseDiscriminatorStatus.Cancelled => "CANCELLED",
                GetWorkflowInvocationsResponseDiscriminatorStatus.Failed => "FAILED",
                GetWorkflowInvocationsResponseDiscriminatorStatus.Pending => "PENDING",
                GetWorkflowInvocationsResponseDiscriminatorStatus.Running => "RUNNING",
                GetWorkflowInvocationsResponseDiscriminatorStatus.Succeeded => "SUCCEEDED",
                GetWorkflowInvocationsResponseDiscriminatorStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowInvocationsResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => GetWorkflowInvocationsResponseDiscriminatorStatus.Cancelled,
                "FAILED" => GetWorkflowInvocationsResponseDiscriminatorStatus.Failed,
                "PENDING" => GetWorkflowInvocationsResponseDiscriminatorStatus.Pending,
                "RUNNING" => GetWorkflowInvocationsResponseDiscriminatorStatus.Running,
                "SUCCEEDED" => GetWorkflowInvocationsResponseDiscriminatorStatus.Succeeded,
                "THROTTLED" => GetWorkflowInvocationsResponseDiscriminatorStatus.Throttled,
                _ => null,
            };
        }
    }
}