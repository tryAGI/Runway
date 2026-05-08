using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;

#pragma warning disable CA1056 // Runway accepts HTTPS, data, and runway: URI strings for assets.

namespace Runway;

/// <summary>
/// Hand-written GPT Image 2 helpers for the text/image-to-image endpoint.
/// </summary>
public static class StartGeneratingClientGptImage2Extensions
{
    /// <summary>
    /// Starts a GPT Image 2 text/image-to-image task.
    /// </summary>
    /// <param name="client">The Runway start-generating client.</param>
    /// <param name="request">The GPT Image 2 request.</param>
    /// <param name="xRunwayVersion">The Runway API version header.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>The created task response.</returns>
    public static async Task<CreateTextToImageResponse> CreateGptImage2TextToImageAsync(
        this StartGeneratingClient client,
        CreateGptImage2TextToImageRequest request,
        string xRunwayVersion = "2024-11-06",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(request);

        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, "v1/text_to_image");
        ApplyBearerAuthorization(client, httpRequest);
        httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion);
        httpRequest.Content = new StringContent(
            request.ToJsonObject().ToJsonString(),
            Encoding.UTF8,
            "application/json");

        using var response = await client.HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseContentRead,
            cancellationToken).ConfigureAwait(false);

        var content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            throw new ApiException(content.Length > 0 ? content : response.ReasonPhrase ?? string.Empty, response.StatusCode)
            {
                ResponseBody = content,
                ResponseHeaders = response.Headers.ToDictionary(header => header.Key, header => header.Value),
            };
        }

        var taskId = JsonNode.Parse(content)?["id"]?.GetValue<Guid>()
            ?? throw new InvalidOperationException($"Response deserialization failed for \"{content}\".");

        return new CreateTextToImageResponse(taskId);
    }

    private static void ApplyBearerAuthorization(StartGeneratingClient client, HttpRequestMessage request)
    {
        var authorization = client.Authorizations.LastOrDefault(static candidate =>
            candidate.Type == "Http" && candidate.Name == "Bearer");

        if (authorization is null)
        {
            throw new InvalidOperationException("Operation 'CreateGptImage2TextToImageAsync' requires Bearer authorization.");
        }

        request.Headers.Authorization = new AuthenticationHeaderValue(
            authorization.Name,
            authorization.Value);
    }
}

/// <summary>
/// GPT Image 2 text/image-to-image request.
/// </summary>
public sealed class CreateGptImage2TextToImageRequest
{
    /// <summary>
    /// A detailed text prompt for the image generation task.
    /// </summary>
    public required string PromptText { get; set; }

    /// <summary>
    /// Output ratio or model-supported width:height value.
    /// </summary>
    public string Ratio { get; set; } = "1920:1920";

    /// <summary>
    /// Deprecated output resolution tier. Current Runway GPT Image 2 uses <see cref="Ratio" /> for output size.
    /// </summary>
    public GptImage2Resolution? Resolution { get; set; }

    /// <summary>
    /// Optional quality tier.
    /// </summary>
    public GptImage2Quality? Quality { get; set; }

    /// <summary>
    /// Optional number of images to generate.
    /// </summary>
    public double? OutputCount { get; set; }

    /// <summary>
    /// Optional image references. GPT Image 2 supports up to 16 references.
    /// </summary>
    public IList<CreateGptImage2TextToImageReferenceImage> ReferenceImages { get; } = [];

    /// <summary>
    /// Additional properties for newly released API parameters.
    /// </summary>
    public IDictionary<string, JsonNode?> AdditionalProperties { get; } = new Dictionary<string, JsonNode?>();

    internal JsonObject ToJsonObject()
    {
        var body = new JsonObject
        {
            ["model"] = "gpt_image_2",
            ["promptText"] = PromptText,
            ["ratio"] = Ratio,
        };

        if (Quality is { } quality)
        {
            body["quality"] = quality.ToValueString();
        }

        if (OutputCount is { } outputCount)
        {
            body["outputCount"] = outputCount;
        }

        if (ReferenceImages.Count > 0)
        {
            if (ReferenceImages.Count > 16)
            {
                throw new ArgumentException("GPT Image 2 accepts up to 16 reference images.", nameof(ReferenceImages));
            }

            var references = new JsonArray();
            foreach (var referenceImage in ReferenceImages)
            {
                var reference = new JsonObject
                {
                    ["uri"] = referenceImage.Uri,
                };
                if (!string.IsNullOrWhiteSpace(referenceImage.Tag))
                {
                    reference["tag"] = referenceImage.Tag;
                }

                references.Add((JsonNode)reference);
            }

            body["referenceImages"] = references;
        }

        foreach (var property in AdditionalProperties)
        {
            body[property.Key] = property.Value?.DeepClone();
        }

        return body;
    }
}

/// <summary>
/// GPT Image 2 reference image.
/// </summary>
public sealed class CreateGptImage2TextToImageReferenceImage
{
    /// <summary>
    /// A HTTPS URL, Runway URI, or data URI containing an encoded image.
    /// </summary>
    public required string Uri { get; set; }

    /// <summary>
    /// Optional prompt-referenceable tag.
    /// </summary>
    public string? Tag { get; set; }
}

/// <summary>
/// GPT Image 2 output resolution tier.
/// </summary>
public enum GptImage2Resolution
{
    /// <summary>
    /// Let Runway choose the resolution.
    /// </summary>
    Auto,

    /// <summary>
    /// 1K resolution tier.
    /// </summary>
    x1K,

    /// <summary>
    /// 2K resolution tier.
    /// </summary>
    x2K,

    /// <summary>
    /// 4K resolution tier.
    /// </summary>
    x4K,
}

/// <summary>
/// GPT Image 2 quality tier.
/// </summary>
public enum GptImage2Quality
{
    /// <summary>
    /// Lowest-cost quality tier.
    /// </summary>
    Low,

    /// <summary>
    /// Balanced quality tier.
    /// </summary>
    Medium,

    /// <summary>
    /// Highest quality tier.
    /// </summary>
    High,
}

/// <summary>
/// String conversions for GPT Image 2 options.
/// </summary>
public static class GptImage2OptionExtensions
{
    /// <summary>
    /// Converts a resolution enum to the API value.
    /// </summary>
    public static string ToValueString(this GptImage2Resolution value)
    {
        return value switch
        {
            GptImage2Resolution.Auto => "auto",
            GptImage2Resolution.x1K => "1K",
            GptImage2Resolution.x2K => "2K",
            GptImage2Resolution.x4K => "4K",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }

    /// <summary>
    /// Converts a quality enum to the API value.
    /// </summary>
    public static string ToValueString(this GptImage2Quality value)
    {
        return value switch
        {
            GptImage2Quality.Low => "low",
            GptImage2Quality.Medium => "medium",
            GptImage2Quality.High => "high",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }
}
