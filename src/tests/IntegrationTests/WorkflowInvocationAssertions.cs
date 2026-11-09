using AwesomeAssertions;

namespace Runway.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// A published workflow lives in the Runway account, not in this repository, and the API exposes only
    /// list/get/run for workflows — there is no endpoint to edit or re-publish a graph. So when a workflow
    /// a test runs references a model Runway has since retired, or its graph produces no output, the suite
    /// cannot repair it: it reports inconclusive with the fix to apply in the Runway app instead of failing
    /// as though the SDK were broken.
    /// </summary>
    private static void EnsureWorkflowInvocationUsable(
        GetWorkflowInvocationsResponse invocation,
        Guid workflowId,
        string workflowName)
    {
        if (invocation.IsFailed)
        {
            var failure = invocation.Failed!.Failure ?? string.Empty;
            var failureCode = invocation.Failed.FailureCode?.ToString() ?? string.Empty;
            if (failure.Contains("deprecated", StringComparison.OrdinalIgnoreCase) ||
                failureCode.Contains("DEPRECATED", StringComparison.OrdinalIgnoreCase))
            {
                throw new AssertInconclusiveException(
                    $"Published workflow '{workflowName}' ({workflowId}) references a model Runway has deprecated: {failure}. " +
                    "Open it in the Runway app, replace the deprecated node with a current model, and re-publish — " +
                    "the API has no workflow create/update endpoint, so this cannot be fixed from the SDK.");
            }
        }

        if (invocation.IsSucceeded && invocation.Succeeded!.Output.Count == 0)
        {
            throw new AssertInconclusiveException(
                $"Published workflow '{workflowName}' ({workflowId}) succeeded with no output. Its graph needs to be " +
                "re-published in the Runway app; the API exposes only list/get/run for workflows.");
        }
    }
}
