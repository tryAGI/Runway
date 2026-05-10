using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

internal static class RunwayCliGeneration
{
    private static readonly string[] TextToVideoModels = ["gen4.5", "veo3.1", "veo3.1_fast", "veo3"];
    private static readonly string[] ImageToVideoModels = ["gen4.5", "gen4_turbo", "veo3.1", "gen3a_turbo", "veo3.1_fast", "veo3"];
    private static readonly string[] TextToImageModels = ["gen4_image_turbo", "gen4_image", "gemini_image3_pro", "gpt_image_2", "gemini_2.5_flash"];

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

    public static CreateTextToVideoRequest CreateTextToVideoRequest(
        string prompt,
        string? model,
        string ratio,
        double? duration,
        int? seed,
        bool audio,
        string? publicFigureThreshold)
    {
        var normalizedModel = NormalizeModel(model, "veo3.1_fast", TextToVideoModels);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptText"] = prompt,
            ["ratio"] = ratio,
        };

        SetIfNotNull(body, "duration", duration);
        SetIfNotNull(body, "seed", seed);

        if (normalizedModel is "veo3.1" or "veo3.1_fast")
        {
            body["audio"] = audio;
        }

        AddContentModeration(body, publicFigureThreshold);
        return ToGenerated<CreateTextToVideoRequest>(body);
    }

    public static async Task<CreateImageToVideoRequest> CreateImageToVideoRequestAsync(
        string? prompt,
        string? model,
        string[]? promptImages,
        string? lastImage,
        string ratio,
        double? duration,
        int? seed,
        bool audio,
        string? publicFigureThreshold,
        CancellationToken cancellationToken)
    {
        var normalizedModel = NormalizeModel(model, "gen4_turbo", ImageToVideoModels);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptImage"] = await CreatePromptImageNodeAsync(promptImages, lastImage, cancellationToken).ConfigureAwait(false),
            ["ratio"] = ratio,
        };

        if (!string.IsNullOrWhiteSpace(prompt))
        {
            body["promptText"] = prompt;
        }

        SetIfNotNull(body, "duration", duration);
        SetIfNotNull(body, "seed", seed);

        if (normalizedModel is "veo3.1" or "veo3.1_fast")
        {
            body["audio"] = audio;
        }

        AddContentModeration(body, publicFigureThreshold);
        return ToGenerated<CreateImageToVideoRequest>(body);
    }

    public static async Task<CreateTextToImageRequest> CreateTextToImageRequestAsync(
        string prompt,
        string? model,
        string ratio,
        string[]? referenceImages,
        string referenceSubject,
        int? seed,
        double? outputCount,
        string? publicFigureThreshold,
        CancellationToken cancellationToken)
    {
        var body = await CreateTextToImageJsonBodyAsync(
            prompt,
            model,
            ratio,
            referenceImages,
            referenceSubject,
            seed,
            outputCount,
            publicFigureThreshold,
            resolution: null,
            quality: null,
            cancellationToken).ConfigureAwait(false);
        return ToGenerated<CreateTextToImageRequest>(body);
    }

    public static async Task<JsonObject> CreateTextToImageJsonBodyAsync(
        string prompt,
        string? model,
        string ratio,
        string[]? referenceImages,
        string referenceSubject,
        int? seed,
        double? outputCount,
        string? publicFigureThreshold,
        string? resolution,
        string? quality,
        CancellationToken cancellationToken)
    {
        var normalizedModel = NormalizeTextToImageModel(model);
        ValidateTextToImageRatio(ratio, normalizedModel);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptText"] = prompt,
            ["ratio"] = ratio,
        };

        SetIfNotNull(body, "seed", seed);
        SetIfNotNull(body, "outputCount", outputCount);
        AddContentModeration(body, publicFigureThreshold);
        if (normalizedModel == "gpt_image_2")
        {
            SetIfNotNull(body, "quality", quality);
        }

        var references = await CreateReferenceImagesNodeAsync(
            referenceImages,
            normalizedModel,
            normalizedModel == "gemini_image3_pro" ? referenceSubject : null,
            cancellationToken).ConfigureAwait(false);

        if (normalizedModel == "gen4_image_turbo" && references.Count == 0)
        {
            throw new ArgumentException("gen4-image-turbo requires at least one --reference-image. Use gpt-image-2 or gemini-2.5-flash for text-only image generation.");
        }

        if (references.Count > 0)
        {
            body["referenceImages"] = references;
        }

        return body;
    }

    public static async Task<CreateGptImage2TextToImageRequest> CreateGptImage2TextToImageRequestAsync(
        string prompt,
        string ratio,
        string[]? referenceImages,
        string? resolution,
        string? quality,
        double? outputCount,
        CancellationToken cancellationToken)
    {
        ValidateTextToImageRatio(ratio, "gpt_image_2");
        var request = new CreateGptImage2TextToImageRequest
        {
            PromptText = prompt,
            Ratio = ratio,
            Quality = ParseGptImage2Quality(quality),
            OutputCount = outputCount,
        };

        foreach (var referenceImage in await CreateGptImage2ReferenceImagesAsync(referenceImages, cancellationToken).ConfigureAwait(false))
        {
            request.ReferenceImages.Add(referenceImage);
        }

        return request;
    }

    public static async Task<CreateVideoToVideoRequest> CreateVideoToVideoRequestAsync(
        string prompt,
        string video,
        string? ratio,
        string[]? references,
        int? seed,
        string? publicFigureThreshold,
        CancellationToken cancellationToken)
    {
        var body = new JsonObject
        {
            ["model"] = "gen4_aleph",
            ["promptText"] = prompt,
            ["videoUri"] = await NormalizeInputAssetAsync(video, cancellationToken).ConfigureAwait(false),
        };

        SetIfNotNull(body, "ratio", ratio);
        SetIfNotNull(body, "seed", seed);
        AddContentModeration(body, publicFigureThreshold);

        if (references is { Length: > 0 })
        {
            var referenceNodes = new JsonArray();
            foreach (var reference in references)
            {
                referenceNodes.Add(new JsonObject
                {
                    ["type"] = "image",
                    ["uri"] = await NormalizeInputAssetAsync(reference, cancellationToken).ConfigureAwait(false),
                });
            }

            body["references"] = referenceNodes;
        }

        return ToGenerated<CreateVideoToVideoRequest>(body);
    }

    public static async Task<CreateCharacterPerformanceRequest> CreateCharacterPerformanceRequestAsync(
        string? characterImage,
        string? characterVideo,
        string referenceVideo,
        string? ratio,
        int? seed,
        bool? bodyControl,
        int? expressionIntensity,
        string? publicFigureThreshold,
        CancellationToken cancellationToken)
    {
        var characterUri = characterVideo is { Length: > 0 } ? characterVideo : characterImage;
        if (characterUri is not { Length: > 0 })
        {
            throw new ArgumentException("Set --character-image or --character-video.");
        }

        var body = new JsonObject
        {
            ["model"] = "act_two",
            ["character"] = new JsonObject
            {
                ["type"] = characterVideo is { Length: > 0 } ? "video" : "image",
                ["uri"] = await NormalizeInputAssetAsync(characterUri, cancellationToken).ConfigureAwait(false),
            },
            ["reference"] = new JsonObject
            {
                ["type"] = "video",
                ["uri"] = await NormalizeInputAssetAsync(referenceVideo, cancellationToken).ConfigureAwait(false),
            },
        };

        SetIfNotNull(body, "ratio", ratio);
        SetIfNotNull(body, "seed", seed);
        SetIfNotNull(body, "bodyControl", bodyControl);
        SetIfNotNull(body, "expressionIntensity", expressionIntensity);
        AddContentModeration(body, publicFigureThreshold);
        return ToGenerated<CreateCharacterPerformanceRequest>(body);
    }

    public static CreateSoundEffectRequest CreateSoundEffectRequest(string prompt, double? duration, bool loop)
    {
        var body = new JsonObject
        {
            ["model"] = "eleven_text_to_sound_v2",
            ["promptText"] = prompt,
            ["loop"] = loop,
        };
        SetIfNotNull(body, "duration", duration);
        return ToGenerated<CreateSoundEffectRequest>(body);
    }

    public static async Task<CreateSpeechToSpeechRequest> CreateSpeechToSpeechRequestAsync(
        string media,
        string mediaType,
        string voicePreset,
        string? runwayVoiceId,
        bool? removeBackgroundNoise,
        CancellationToken cancellationToken)
    {
        var body = new JsonObject
        {
            ["model"] = "eleven_multilingual_sts_v2",
            ["media"] = new JsonObject
            {
                ["type"] = mediaType,
                ["uri"] = await NormalizeInputAssetAsync(media, cancellationToken).ConfigureAwait(false),
            },
            ["voice"] = new JsonObject
            {
                ["type"] = "runway-preset",
                ["presetId"] = voicePreset,
            },
        };
        SetIfNotNull(body, "runwayVoiceId", runwayVoiceId);
        SetIfNotNull(body, "removeBackgroundNoise", removeBackgroundNoise);
        return ToGenerated<CreateSpeechToSpeechRequest>(body);
    }

    public static CreateTextToSpeechRequest CreateTextToSpeechRequest(string prompt, string voicePreset)
    {
        return ToGenerated<CreateTextToSpeechRequest>(new JsonObject
        {
            ["model"] = "eleven_multilingual_v2",
            ["promptText"] = prompt,
            ["voice"] = new JsonObject
            {
                ["type"] = "runway-preset",
                ["presetId"] = voicePreset,
            },
        });
    }

    public static async Task<CreateVoiceDubbingRequest> CreateVoiceDubbingRequestAsync(
        string audio,
        string targetLanguage,
        CancellationToken cancellationToken)
    {
        return ToGenerated<CreateVoiceDubbingRequest>(new JsonObject
        {
            ["model"] = "eleven_voice_dubbing",
            ["audioUri"] = await NormalizeInputAssetAsync(audio, cancellationToken).ConfigureAwait(false),
            ["targetLang"] = targetLanguage,
        });
    }

    public static async Task<CreateVoiceIsolationRequest> CreateVoiceIsolationRequestAsync(
        string audio,
        CancellationToken cancellationToken)
    {
        return ToGenerated<CreateVoiceIsolationRequest>(new JsonObject
        {
            ["model"] = "eleven_voice_isolation",
            ["audioUri"] = await NormalizeInputAssetAsync(audio, cancellationToken).ConfigureAwait(false),
        });
    }

    public static async Task<T> ReadGeneratedJsonAsync<T>(string value, CancellationToken cancellationToken)
    {
        var json = await ReadJsonTextAsync(value, cancellationToken).ConfigureAwait(false);
        return DeserializeGenerated<T>(json);
    }

    public static T ToGenerated<T>(JsonObject body)
    {
        return DeserializeGenerated<T>(body.ToJsonString());
    }

    public static async Task<string> ReadJsonTextAsync(string value, CancellationToken cancellationToken)
    {
        if (value == "-")
        {
            return await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
        }

        var path = value.StartsWith('@') ? value[1..] : value;
        if (File.Exists(path))
        {
            return await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
        }

        return value;
    }

    public static string NormalizeModel(string? value, string fallback, IReadOnlyCollection<string> supported)
    {
        var candidate = string.IsNullOrWhiteSpace(value) ? fallback : value.Trim();
        candidate = candidate switch
        {
            "gen45" or "gen4_5" or "gen4-5" => "gen4.5",
            "gen4-turbo" => "gen4_turbo",
            "gen3a-turbo" => "gen3a_turbo",
            "veo3.1-fast" or "veo3_1_fast" or "veo3-1-fast" => "veo3.1_fast",
            "veo3_1" or "veo3-1" => "veo3.1",
            "gemini-2.5-flash" => "gemini_2.5_flash",
            "gemini-image3-pro" or "gemini-image-3-pro" => "gemini_image3_pro",
            "gpt-image-2" => "gpt_image_2",
            "gen4-image" => "gen4_image",
            "gen4-image-turbo" => "gen4_image_turbo",
            _ => candidate,
        };

        if (supported.Contains(candidate))
        {
            return candidate;
        }

        throw new ArgumentException($"Unsupported model '{value}'. Supported values: {string.Join(", ", supported)}.");
    }

    public static string NormalizeTextToImageModel(string? value)
    {
        return NormalizeModel(value, "gemini_2.5_flash", TextToImageModels);
    }

    public static string ResolveTextToImageRatio(string? value, string normalizedModel)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            return value.Trim();
        }

        return normalizedModel switch
        {
            "gpt_image_2" => "1920:1920",
            _ => "1024:1024",
        };
    }

    /// <summary>
    /// Validates that <paramref name="ratio"/> is on the supported list for the given normalized image model.
    /// Throws <see cref="ArgumentException"/> with the supported list when it isn't — the Runway API is known
    /// to silently fall back to a default resolution when an unsupported ratio is sent (e.g. gemini-image3-pro
    /// returning 1024x1024 for a request asking 768:1344), so we fail fast on the client.
    /// </summary>
    public static void ValidateTextToImageRatio(string ratio, string normalizedModel)
    {
        ValidateRatioAgainstEndpoint(ratio, normalizedModel, RunwayRatioEndpoints.TextToImage, "image");
    }

    public static void ValidateTextToVideoRatio(string ratio, string normalizedModel)
    {
        ValidateRatioAgainstEndpoint(ratio, normalizedModel, RunwayRatioEndpoints.TextToVideo, "text-to-video");
    }

    public static void ValidateImageToVideoRatio(string ratio, string normalizedModel)
    {
        ValidateRatioAgainstEndpoint(ratio, normalizedModel, RunwayRatioEndpoints.ImageToVideo, "image-to-video");
    }

    private static void ValidateRatioAgainstEndpoint(
        string ratio,
        string normalizedModel,
        string endpoint,
        string surfaceLabel)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ratio);
        ArgumentException.ThrowIfNullOrWhiteSpace(normalizedModel);
        var supported = RunwayRatioSupport.GetSupportedRatios(normalizedModel, endpoint);
        // Empty list means the model has no enum-backed ratio set on this endpoint (e.g. unknown
        // model or an audio surface) — skip validation and let the API have the final say.
        if (supported.Count == 0 || supported.Contains(ratio, StringComparer.Ordinal))
        {
            return;
        }

        var trailer = RunwayCliRatioHints.BuildRejectionTrailer(ratio, normalizedModel, supported);
        throw new ArgumentException(
            $"Unsupported --ratio '{ratio}' for {surfaceLabel} model '{normalizedModel}'. {trailer}");
    }

    /// <summary>
    /// Returns the list of supported ratios for the given normalized image model, or <c>null</c> when the
    /// model has no enum-backed ratio set in the generated SDK (in which case validation is skipped and the
    /// API has the final say). Delegates to <see cref="RunwayRatioSupport.GetSupportedRatios(string, string)"/>
    /// with <see cref="RunwayRatioEndpoints.TextToImage"/> as the single source of truth.
    /// </summary>
    public static IReadOnlyList<string>? GetSupportedTextToImageRatios(string normalizedModel)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(normalizedModel);
        var ratios = RunwayRatioSupport.GetSupportedRatios(normalizedModel, RunwayRatioEndpoints.TextToImage);
        return ratios.Count == 0 ? null : ratios;
    }

    public static GptImage2Resolution? ParseGptImage2Resolution(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.Trim().ToLowerInvariant() switch
        {
            "auto" => GptImage2Resolution.Auto,
            "1k" or "x1k" => GptImage2Resolution.x1K,
            "2k" or "x2k" => GptImage2Resolution.x2K,
            "4k" or "x4k" => GptImage2Resolution.x4K,
            _ => throw new ArgumentException("Unsupported GPT Image 2 resolution. Supported values: auto, 1K, 2K, 4K."),
        };
    }

    public static GptImage2Quality? ParseGptImage2Quality(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return value.Trim().ToLowerInvariant() switch
        {
            "low" => GptImage2Quality.Low,
            "medium" => GptImage2Quality.Medium,
            "high" => GptImage2Quality.High,
            _ => throw new ArgumentException("Unsupported GPT Image 2 quality. Supported values: low, medium, high."),
        };
    }

    public static JsonObject? CreateContentModerationNode(string? publicFigureThreshold)
    {
        return string.IsNullOrWhiteSpace(publicFigureThreshold)
            ? null
            : new JsonObject { ["publicFigureThreshold"] = publicFigureThreshold };
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

    public static async Task<IList<CreateGptImage2TextToImageReferenceImage>> CreateGptImage2ReferenceImagesAsync(
        string[]? values,
        CancellationToken cancellationToken)
    {
        if (values is not { Length: > 0 })
        {
            return [];
        }

        if (values.Length > 16)
        {
            throw new ArgumentException("GPT Image 2 accepts up to 16 reference images.");
        }

        var images = new List<CreateGptImage2TextToImageReferenceImage>(values.Length);
        for (var index = 0; index < values.Length; index++)
        {
            images.Add(new CreateGptImage2TextToImageReferenceImage
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
            ".gif" => "image/gif",
            ".webp" => "image/webp",
            ".mp4" => "video/mp4",
            ".mov" => "video/quicktime",
            ".mkv" => "video/x-matroska",
            ".webm" => "video/webm",
            ".3gp" => "video/3gpp",
            ".ogv" => "video/ogg",
            ".avi" => "video/x-msvideo",
            ".flv" => "video/x-flv",
            ".mpg" or ".mpeg" => "video/mpeg",
            ".mp3" => "audio/mpeg",
            ".wav" => "audio/wav",
            ".flac" => "audio/flac",
            ".m4a" => "audio/mp4",
            ".aac" => "audio/aac",
            _ => "application/octet-stream",
        };
    }

    private static T DeserializeGenerated<T>(string json)
    {
        return (T)(JsonSerializer.Deserialize(json, typeof(T), SourceGenerationContext.Default)
            ?? throw new ArgumentException($"JSON did not deserialize to {typeof(T).Name}."));
    }

    private static async Task<JsonNode> CreatePromptImageNodeAsync(
        string[]? promptImages,
        string? lastImage,
        CancellationToken cancellationToken)
    {
        if (promptImages is not { Length: > 0 } && lastImage is not { Length: > 0 })
        {
            throw new ArgumentException("Set --image for image-to-video generation.");
        }

        if (promptImages is { Length: > 1 } || lastImage is { Length: > 0 })
        {
            var images = new JsonArray();
            if (promptImages is { Length: > 0 })
            {
                images.Add(new JsonObject
                {
                    ["uri"] = await NormalizeInputAssetAsync(promptImages[0], cancellationToken).ConfigureAwait(false),
                    ["position"] = "first",
                });
            }

            if (lastImage is { Length: > 0 })
            {
                images.Add(new JsonObject
                {
                    ["uri"] = await NormalizeInputAssetAsync(lastImage, cancellationToken).ConfigureAwait(false),
                    ["position"] = "last",
                });
            }
            else if (promptImages is { Length: > 1 })
            {
                images.Add(new JsonObject
                {
                    ["uri"] = await NormalizeInputAssetAsync(promptImages[1], cancellationToken).ConfigureAwait(false),
                    ["position"] = "last",
                });
            }

            return images;
        }

        return JsonValue.Create(await NormalizeInputAssetAsync(promptImages![0], cancellationToken).ConfigureAwait(false))!;
    }

    private static async Task<JsonArray> CreateReferenceImagesNodeAsync(
        string[]? values,
        string normalizedModel,
        string? subject,
        CancellationToken cancellationToken)
    {
        var images = new JsonArray();
        if (values is not { Length: > 0 })
        {
            return images;
        }

        var maxReferenceImages = normalizedModel switch
        {
            "gemini_image3_pro" => 14,
            "gpt_image_2" => 16,
            _ => 3,
        };

        if (values.Length > maxReferenceImages)
        {
            throw new ArgumentException($"Runway accepts up to {maxReferenceImages} reference images for {normalizedModel}.");
        }

        for (var index = 0; index < values.Length; index++)
        {
            var image = new JsonObject
            {
                ["uri"] = await NormalizeInputAssetAsync(values[index], cancellationToken).ConfigureAwait(false),
                ["tag"] = $"reference{index + 1}",
            };
            if (subject is { Length: > 0 })
            {
                image["subject"] = subject;
            }

            images.Add(image);
        }

        return images;
    }

    private static void AddContentModeration(JsonObject body, string? publicFigureThreshold)
    {
        if (CreateContentModerationNode(publicFigureThreshold) is { } contentModeration)
        {
            body["contentModeration"] = contentModeration;
        }
    }

    private static void SetIfNotNull(JsonObject body, string name, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            body[name] = value;
        }
    }

    private static void SetIfNotNull(JsonObject body, string name, int? value)
    {
        if (value is not null)
        {
            body[name] = value.Value;
        }
    }

    private static void SetIfNotNull(JsonObject body, string name, double? value)
    {
        if (value is not null)
        {
            body[name] = value.Value;
        }
    }

    private static void SetIfNotNull(JsonObject body, string name, bool? value)
    {
        if (value is not null)
        {
            body[name] = value.Value;
        }
    }
}
