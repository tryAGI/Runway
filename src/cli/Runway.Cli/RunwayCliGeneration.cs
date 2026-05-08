using System.Globalization;
using Runway;

internal static class RunwayCliGeneration
{
    public static string JoinPrompt(string[]? values)
    {
        return values is { Length: > 0 }
            ? string.Join(' ', values).Trim()
            : throw new ArgumentException("Prompt is required.");
    }

    public static CreateTextToVideoRequestVeo31FastRatio ParseTextToVideoRatio(string value)
    {
        return CreateTextToVideoRequestVeo31FastRatioExtensions.ToEnum(value)
            ?? throw new ArgumentException("Unsupported video ratio. Supported values: 1080:1920, 1280:720, 1920:1080, 720:1280.");
    }

    public static CreateImageToVideoRequestGen4TurboRatio ParseImageToVideoRatio(string value)
    {
        return CreateImageToVideoRequestGen4TurboRatioExtensions.ToEnum(value)
            ?? throw new ArgumentException("Unsupported image-to-video ratio. Supported values: 1104:832, 1280:720, 1584:672, 720:1280, 832:1104, 960:960.");
    }

    public static CreateTextToImageRequestGemini25FlashRatio ParseGemini25FlashImageRatio(string value)
    {
        return CreateTextToImageRequestGemini25FlashRatioExtensions.ToEnum(value)
            ?? throw new ArgumentException("Unsupported gemini-2.5-flash image ratio. Supported values: 1024:1024, 1152:896, 1184:864, 1248:832, 1344:768, 1536:672, 768:1344, 832:1248, 864:1184, 896:1152.");
    }

    public static CreateTextToImageRequestGen4ImageTurboRatio ParseGen4ImageTurboRatio(string value)
    {
        return CreateTextToImageRequestGen4ImageTurboRatioExtensions.ToEnum(value)
            ?? throw new ArgumentException("Unsupported gen4-image-turbo image ratio. Common supported values include 1024:1024, 1280:720, 1920:1080, and 720:1280.");
    }

    public static int? ToWholeSeconds(double? value)
    {
        if (value is null)
        {
            return null;
        }

        if (value.Value % 1 != 0)
        {
            throw new ArgumentException("Image-to-video duration must be a whole number of seconds.");
        }

        return checked((int)value.Value);
    }

    public static async Task<IList<CreateTextToImageRequestGemini25FlashReferenceImage>> CreateGemini25FlashReferenceImagesAsync(
        string[]? values,
        CancellationToken cancellationToken)
    {
        if (values is not { Length: > 0 })
        {
            return [];
        }

        if (values.Length > 3)
        {
            throw new ArgumentException("Runway accepts up to three reference images.");
        }

        var images = new List<CreateTextToImageRequestGemini25FlashReferenceImage>(values.Length);
        for (var index = 0; index < values.Length; index++)
        {
            images.Add(new CreateTextToImageRequestGemini25FlashReferenceImage
            {
                Uri = await NormalizeInputAssetAsync(values[index], cancellationToken).ConfigureAwait(false),
                Tag = $"reference{index + 1}",
            });
        }

        return images;
    }

    public static async Task<IList<CreateTextToImageRequestGen4ImageTurboReferenceImage>> CreateGen4ImageTurboReferenceImagesAsync(
        string[]? values,
        CancellationToken cancellationToken)
    {
        if (values is not { Length: > 0 })
        {
            return [];
        }

        if (values.Length > 3)
        {
            throw new ArgumentException("Runway accepts up to three reference images.");
        }

        var images = new List<CreateTextToImageRequestGen4ImageTurboReferenceImage>(values.Length);
        for (var index = 0; index < values.Length; index++)
        {
            images.Add(new CreateTextToImageRequestGen4ImageTurboReferenceImage
            {
                Uri = await NormalizeInputAssetAsync(values[index], cancellationToken).ConfigureAwait(false),
                Tag = $"reference{index + 1}",
            });
        }

        return images;
    }

    public static async Task<string> NormalizeInputAssetAsync(string value, CancellationToken cancellationToken)
    {
        if (IsRunwayAssetReference(value))
        {
            return value;
        }

        var path = Path.GetFullPath(value);
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Input asset file was not found: {path}", path);
        }

        var bytes = await File.ReadAllBytesAsync(path, cancellationToken).ConfigureAwait(false);
        return string.Create(
            CultureInfo.InvariantCulture,
            $"data:{GetMediaType(path)};base64,{Convert.ToBase64String(bytes)}");
    }

    public static bool IsRunwayAssetReference(string value)
    {
        if (value.StartsWith("data:", StringComparison.OrdinalIgnoreCase) ||
            value.StartsWith("runway:", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        return Uri.TryCreate(value, UriKind.Absolute, out var uri) &&
               (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
    }

    public static string GetMediaType(string path)
    {
        return Path.GetExtension(path).ToLowerInvariant() switch
        {
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".webp" => "image/webp",
            ".gif" => "image/gif",
            ".mp4" => "video/mp4",
            ".mov" => "video/quicktime",
            ".webm" => "video/webm",
            _ => "application/octet-stream",
        };
    }
}
