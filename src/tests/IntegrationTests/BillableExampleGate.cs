namespace Runway.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// Opt-in gate for examples whose single run costs a meaningful number of credits. The built-in
    /// workflow examples each drive a published Runway graph that fans out into several image
    /// generations — around 90 credits per test, so one unguarded `dotnet test` of this project burns
    /// roughly 270. They are real, useful examples, so they stay in the suite and in the docs, but they
    /// run only when <c>RUNWAY_RUN_BILLABLE_EXAMPLES</c> is set.
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
