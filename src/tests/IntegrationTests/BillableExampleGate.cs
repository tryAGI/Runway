namespace Runway.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// Opt-in gate for every example that submits a generation and therefore spends Runway credits.
    /// Running the whole set costs roughly 750 credits, which is not something a routine
    /// <c>dotnet test</c> should do by surprise — the three built-in workflow examples alone are ~270,
    /// because each drives a published graph that fans out into several image generations. The examples
    /// are real and stay in the suite and the docs; they run only when
    /// <c>RUNWAY_RUN_BILLABLE_EXAMPLES</c> is set, and each skip message states its own price.
    /// Examples that only list or read (tasks, voices, workflows, conversations) are not gated.
    /// </summary>
    /// <param name="description">What the example generates, used in the skip message.</param>
    /// <param name="approximateCredits">Rough credit cost of one run, used in the skip message.</param>
    private static void RequireBillableExamplesEnabled(string description, int approximateCredits)
    {
        if (Environment.GetEnvironmentVariable("RUNWAY_RUN_BILLABLE_EXAMPLES") is { Length: > 0 } value &&
            value is not ("0" or "false" or "FALSE" or "no" or "NO"))
        {
            return;
        }

        throw new AssertInconclusiveException(
            $"{description} costs roughly {approximateCredits} credits per run. " +
            "Set RUNWAY_RUN_BILLABLE_EXAMPLES=1 to run it.");
    }
}
