using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwaySdkBoundaryTests
{
    [TestMethod]
    public void EnhanceFrameRate_SerializesAllSupportedRates()
    {
        var rates = new (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate Rate, string WireValue)[]
        {
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x24, "24"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x25, "25"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x30, "30"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x48, "48"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x50, "50"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x60, "60"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x120, "120"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x2398, "23_98"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x2997, "29_97"),
            (CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate.x5994, "59_94"),
        };

        foreach (var (rate, wireValue) in rates)
        {
            CreateVideoUpscaleRequest request = new CreateVideoUpscaleRequestEnhanceFrameRate(
                "https://example.com/source.mov", rate);
            request.IsEnhanceFrameRate.Should().BeTrue();
            using var json = JsonDocument.Parse(request.ToJson());
            json.RootElement.GetProperty("model").GetString().Should().Be("enhance_frame_rate");
            json.RootElement.GetProperty("videoUri").GetString().Should().Be("https://example.com/source.mov");
            json.RootElement.GetProperty("targetFramerate").GetString().Should().Be(wireValue);
        }
    }

    [TestMethod]
    public void Ruby_AlphaCapableFormats_SerializeWithoutAnAlphaFlag()
    {
        foreach (var (format, wireValue) in new[]
                 {
                     (CreateVideoToHdrRequestRubyOutputFormat.HdrProres, "hdr_prores"),
                     (CreateVideoToHdrRequestRubyOutputFormat.HdrExrSequence, "hdr_exr_sequence"),
                     (CreateVideoToHdrRequestRubyOutputFormat.HdrExrAcescgSequence13, "hdr_exr_acescg_sequence_1_3"),
                     (CreateVideoToHdrRequestRubyOutputFormat.HdrExrAcescgSequence20, "hdr_exr_acescg_sequence_2_0"),
                 })
        {
            var request = new CreateVideoToHdrRequestRuby
            {
                VideoUri = "https://example.com/alpha.mov",
                OutputFormat = format,
            };
            using var json = JsonDocument.Parse(request.ToJson());
            json.RootElement.GetProperty("model").GetString().Should().Be("ruby");
            json.RootElement.GetProperty("outputFormat").GetString().Should().Be(wireValue);
            json.RootElement.TryGetProperty("alpha", out _).Should().BeFalse();
        }
    }

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
