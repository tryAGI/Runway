using System.Text;
using System.Text.Json.Nodes;

namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateGptImage2TextToImageSendsTypedRequest()
    {
        var taskId = Guid.Parse("550e8400-e29b-41d4-a716-446655440000");
        var handler = new GptImage2CaptureHandler(taskId);
        using var httpClient = new HttpClient(handler);
        using var client = new RunwayClient(
            apiKey: "api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://api.dev.runwayml.com/"));

        var response = await client.StartGenerating.CreateGptImage2TextToImageAsync(
            request: new CreateGptImage2TextToImageRequest
            {
                PromptText = "A poster with readable text",
                Ratio = "1024:1024",
                Resolution = GptImage2Resolution.x1K,
                Quality = GptImage2Quality.Low,
                OutputCount = 1,
                ReferenceImages =
                {
                    new CreateGptImage2TextToImageReferenceImage
                    {
                        Uri = "https://example.com/reference.png",
                        Tag = "reference1",
                    },
                },
            });

        response.Id.Should().Be(taskId);
        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://api.dev.runwayml.com/v1/text_to_image"));
        handler.Authorization.Should().Be("Bearer api-key");
        handler.RunwayVersion.Should().Be("2024-11-06");

        var body = JsonNode.Parse(handler.Body!)!.AsObject();
        body["model"]!.GetValue<string>().Should().Be("gpt_image_2");
        body["promptText"]!.GetValue<string>().Should().Be("A poster with readable text");
        body["ratio"]!.GetValue<string>().Should().Be("1024:1024");
        body["resolution"]!.GetValue<string>().Should().Be("1K");
        body["quality"]!.GetValue<string>().Should().Be("low");
        body["outputCount"]!.GetValue<double>().Should().Be(1);
        body["referenceImages"]!.AsArray()[0]!["tag"]!.GetValue<string>().Should().Be("reference1");
    }

    private sealed class GptImage2CaptureHandler(Guid taskId) : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public string? Authorization { get; private set; }
        public string? RunwayVersion { get; private set; }
        public string? Body { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization?.ToString();
            RunwayVersion = request.Headers.TryGetValues("X-Runway-Version", out var values)
                ? values.SingleOrDefault()
                : null;
            Body = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(
                    $$"""
                    {
                      "id": "{{taskId:D}}"
                    }
                    """,
                    Encoding.UTF8,
                    "application/json"),
            };
        }
    }
}
