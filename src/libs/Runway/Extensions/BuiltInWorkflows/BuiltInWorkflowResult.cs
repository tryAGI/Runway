namespace Runway;

/// <summary>
/// Status of a workflow invocation. Mirrors the Runway server-side status values.
/// </summary>
public enum BuiltInWorkflowStatus
{
    /// <summary>Submitted and queued, not yet running.</summary>
    Pending,
    /// <summary>Running but throttled (waiting on capacity).</summary>
    Throttled,
    /// <summary>Currently executing.</summary>
    Running,
    /// <summary>Cancelled / deleted by user or platform.</summary>
    Cancelled,
    /// <summary>Failed terminally; <see cref="BuiltInWorkflowResult.Failure"/> carries the reason.</summary>
    Failed,
    /// <summary>Succeeded; <see cref="BuiltInWorkflowResult.NodeOutputs"/> has the per-node URLs.</summary>
    Succeeded,
}

/// <summary>
/// Result of a built-in workflow invocation, returned by <c>RunBuiltInWorkflowAsync</c>.
/// </summary>
/// <param name="InvocationId">Server-assigned invocation ID. Use it to re-poll later if needed.</param>
/// <param name="Status">Current invocation status. When the caller passed <c>waitForCompletion: true</c> this is always terminal.</param>
/// <param name="NodeOutputs">For <c>SUCCEEDED</c> invocations, a per-node-id list of result URIs (CDN-signed, expire in 24-48h).</param>
/// <param name="Failure">Human-readable failure reason when <see cref="Status"/> is <c>Failed</c>.</param>
/// <param name="FailureCode">Machine-readable failure code when <see cref="Status"/> is <c>Failed</c>.</param>
/// <param name="Progress">Last-observed progress fraction in <c>[0,1]</c> when running.</param>
public sealed record BuiltInWorkflowResult(
    Guid InvocationId,
    BuiltInWorkflowStatus Status,
    IReadOnlyDictionary<Guid, IReadOnlyList<Uri>> NodeOutputs,
    string? Failure = null,
    string? FailureCode = null,
    double? Progress = null)
{
    /// <summary>True when the result is in a terminal state (Succeeded / Failed / Cancelled).</summary>
    public bool IsTerminal => Status is BuiltInWorkflowStatus.Succeeded or BuiltInWorkflowStatus.Failed or BuiltInWorkflowStatus.Cancelled;

    /// <summary>Flat list of every output URI across all nodes. Empty for non-Succeeded results.</summary>
    public IEnumerable<Uri> AllOutputUris => NodeOutputs.Values.SelectMany(static u => u);
}
