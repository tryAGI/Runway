using System.Net;
using System.Net.Http.Headers;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwaySdkBoundaryTests
{
    [TestMethod]
    public void TextToVideo_Seedance2WrapsGeneratedVariant()
    {
        var request = RunwayTextToVideo.Seedance2(
            "A paper bird glides over a city.",
            audio: false,
            duration: 5,
            ratio: CreateTextToVideoRequestSeedance2Ratio.x1280_720);

        request.IsSeedance2.Should().BeTrue();
        request.Seedance2!.PromptText.Should().Be("A paper bird glides over a city.");
        request.Seedance2.Audio.Should().BeFalse();
        request.Seedance2.Duration.Should().Be(5);
        request.Seedance2.Ratio.Should().Be(CreateTextToVideoRequestSeedance2Ratio.x1280_720);
        request.Seedance2.Model.Should().Be("seedance2");
    }

    [TestMethod]
    public async Task DownloadOutputAsync_ReturnsBytesUrlAndContentType()
    {
        var taskId = Guid.NewGuid();
        var task = new GetTasksResponse(new GetTasksResponseVariant6(
            taskId,
            DateTime.UtcNow,
            ["https://cdn.example.test/output.mp4"],
            new GetTasksResponseVariant6Cost(credits: 1)));
        using var httpClient = new HttpClient(new OutputHandler());

        var output = await task.DownloadOutputAsync(httpClient: httpClient);

        output.Url.Should().Be(new Uri("https://cdn.example.test/output.mp4"));
        output.Data.ToArray().Should().Equal(1, 2, 3, 4);
        output.ContentType.Should().Be("video/mp4");
    }

    private sealed class OutputHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            request.RequestUri.Should().Be(new Uri("https://cdn.example.test/output.mp4"));
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent([1, 2, 3, 4]),
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("video/mp4");
            return Task.FromResult(response);
        }
    }
}
