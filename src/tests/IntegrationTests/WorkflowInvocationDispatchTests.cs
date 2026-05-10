namespace Runway.IntegrationTests;

/// <summary>
/// Regression coverage for tryAGI/AutoSDK#315 at the Runway-SDK level.
///
/// Before the fix, the generated <c>GetWorkflowInvocationsResponseJsonConverter</c> scored
/// oneOf variants by required-field overlap and silently populated multiple variants for the
/// same payload — a real SUCCEEDED workflow invocation deserialized with
/// <c>IsPending</c>, <c>IsThrottled</c>, <c>IsCancelled</c>, AND <c>IsSucceeded</c> all true.
///
/// After the fix the converter dispatches on <c>discriminator?.Status</c> and exactly one
/// <c>IsX</c> flag is set per response. These tests stub <c>HttpClient</c> with the JSON shapes
/// from the AutoSDK#315 issue and confirm the dispatch lands on the correct variant.
/// </summary>
public partial class Tests
{
    private const string SucceededInvocationBody = """
        {
          "id": "2f61eaf0-f7f1-4b79-aaee-f001a6dffe21",
          "createdAt": "2026-05-09T21:33:00Z",
          "status": "SUCCEEDED",
          "output": {
            "323d95c0-5cab-4127-b3c7-5fec5d40a7e3": ["https://cdn.example/file.png"]
          }
        }
        """;

    private const string CancelledInvocationBody = """
        {
          "id": "8f6acc9a-9bce-4d33-9f97-7c7d1c8c1234",
          "createdAt": "2026-05-09T21:34:00Z",
          "status": "CANCELLED"
        }
        """;

    private const string PendingInvocationBody = """
        {
          "id": "abcdc3a4-5566-4778-89ab-cd9012345678",
          "createdAt": "2026-05-09T21:35:00Z",
          "status": "PENDING"
        }
        """;

    private const string FailedInvocationBody = """
        {
          "id": "11112222-3333-4444-5555-666677778888",
          "createdAt": "2026-05-09T21:36:00Z",
          "status": "FAILED",
          "failure": "Workflow rejected by safety filter."
        }
        """;

    [TestMethod]
    public async Task GetWorkflowInvocations_Succeeded_PopulatesOnlyIsSucceeded()
    {
        var response = await PollWorkflowInvocationAsync(SucceededInvocationBody).ConfigureAwait(false);

        response.Status.Should().Be(GetWorkflowInvocationsResponseDiscriminatorStatus.Succeeded);
        response.IsSucceeded.Should().BeTrue();
        response.IsPending.Should().BeFalse();
        response.IsThrottled.Should().BeFalse();
        response.IsCancelled.Should().BeFalse();
        response.IsRunning.Should().BeFalse();
        response.IsFailed.Should().BeFalse();

        response.Succeeded.Should().NotBeNull();
        response.Succeeded!.Output.Should().ContainKey("323d95c0-5cab-4127-b3c7-5fec5d40a7e3");
        response.Succeeded.Output["323d95c0-5cab-4127-b3c7-5fec5d40a7e3"].Should()
            .ContainSingle().Which.Should().Be("https://cdn.example/file.png");
    }

    [TestMethod]
    public async Task GetWorkflowInvocations_Cancelled_PopulatesOnlyIsCancelled()
    {
        var response = await PollWorkflowInvocationAsync(CancelledInvocationBody).ConfigureAwait(false);

        response.Status.Should().Be(GetWorkflowInvocationsResponseDiscriminatorStatus.Cancelled);
        response.IsCancelled.Should().BeTrue();
        response.IsPending.Should().BeFalse();
        response.IsThrottled.Should().BeFalse();
        response.IsRunning.Should().BeFalse();
        response.IsFailed.Should().BeFalse();
        response.IsSucceeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task GetWorkflowInvocations_Pending_PopulatesOnlyIsPending()
    {
        var response = await PollWorkflowInvocationAsync(PendingInvocationBody).ConfigureAwait(false);

        response.Status.Should().Be(GetWorkflowInvocationsResponseDiscriminatorStatus.Pending);
        response.IsPending.Should().BeTrue();
        response.IsThrottled.Should().BeFalse();
        response.IsCancelled.Should().BeFalse();
        response.IsRunning.Should().BeFalse();
        response.IsFailed.Should().BeFalse();
        response.IsSucceeded.Should().BeFalse();
    }

    [TestMethod]
    public async Task GetWorkflowInvocations_Failed_PopulatesOnlyIsFailed()
    {
        var response = await PollWorkflowInvocationAsync(FailedInvocationBody).ConfigureAwait(false);

        response.Status.Should().Be(GetWorkflowInvocationsResponseDiscriminatorStatus.Failed);
        response.IsFailed.Should().BeTrue();
        response.IsPending.Should().BeFalse();
        response.IsThrottled.Should().BeFalse();
        response.IsCancelled.Should().BeFalse();
        response.IsRunning.Should().BeFalse();
        response.IsSucceeded.Should().BeFalse();

        response.Failed.Should().NotBeNull();
        response.Failed!.Failure.Should().Be("Workflow rejected by safety filter.");
    }

    private static async Task<GetWorkflowInvocationsResponse> PollWorkflowInvocationAsync(string body)
    {
        var handler = new StubInvocationHandler(body);
        using var httpClient = new HttpClient(handler);
        using var client = new RunwayClient(
            apiKey: "api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://api.dev.runwayml.com/"));

        return await client.Workflows.GetWorkflowInvocationsByIdAsync(
            id: Guid.NewGuid()).ConfigureAwait(false);
    }

    private sealed class StubInvocationHandler(string responseBody) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(
                    responseBody,
                    System.Text.Encoding.UTF8,
                    "application/json"),
            };
            return Task.FromResult(response);
        }
    }
}
