using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

internal static class RunwayCliGeneration
{
    // Video model allow-lists are read from the embedded OpenAPI spec (see NormalizeVideoModel) so that
    // every model Runway ships becomes available on the next spec refresh without a CLI code change.
    public const string TextToVideoEndpoint = "text_to_video";
    public const string ImageToVideoEndpoint = "image_to_video";
    public const string VideoToVideoEndpoint = "video_to_video";

    /// <summary>Model used when <c>--model</c> is omitted, per video endpoint.</summary>
    public const string DefaultTextToVideoModel = "veo3.1_fast";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultImageToVideoModel = "gen4_turbo";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultVideoToVideoModel = "aleph2";

    public const string TextToImageEndpoint = "text_to_image";
    public const string CharacterPerformanceEndpoint = "character_performance";
    public const string VideoUpscaleEndpoint = "video_upscale";
    public const string TextToSpeechEndpoint = "text_to_speech";
    public const string SoundEffectEndpoint = "sound_effect";
    public const string VoiceDubbingEndpoint = "voice_dubbing";
    public const string SpeechToSpeechEndpoint = "speech_to_speech";
    public const string AvatarVideosEndpoint = "avatar_videos";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultTextToSpeechModel = "eleven_multilingual_v2";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultSoundEffectModel = "eleven_text_to_sound_v2";
    public const string ImageUpscaleEndpoint = "image_upscale";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultCharacterPerformanceModel = "act_two";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultVideoUpscaleModel = "magnific_video_upscaler_creative";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultImageUpscaleModel = "magnific_precision_upscaler_v2";

    /// <inheritdoc cref="DefaultTextToVideoModel"/>
    public const string DefaultTextToImageModel = "gemini_2.5_flash";

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

    public static async Task<CreateTextToVideoRequest> CreateTextToVideoRequestAsync(
        string prompt,
        string? model,
        string ratio,
        double? duration,
        int? seed,
        bool audio,
        string? publicFigureThreshold,
        RunwayCliVideoExtras extras,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(extras);

        var normalizedModel = NormalizeVideoModel(model, DefaultTextToVideoModel, TextToVideoEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptText"] = prompt,
        };

        SetIfSupported(body, normalizedModel, TextToVideoEndpoint, "ratio", ratio);
        SetIfSupported(body, normalizedModel, TextToVideoEndpoint, "duration", duration);
        RequireAndSet(body, normalizedModel, TextToVideoEndpoint, "seed", "--seed", seed);
        SetIfSupported(body, normalizedModel, TextToVideoEndpoint, "audio", audio);

        await ApplyVideoExtrasAsync(body, normalizedModel, TextToVideoEndpoint, extras, cancellationToken).ConfigureAwait(false);
        AddContentModeration(body, normalizedModel, TextToVideoEndpoint, publicFigureThreshold);
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
        RunwayCliVideoExtras extras,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(extras);

        var normalizedModel = NormalizeVideoModel(model, DefaultImageToVideoModel, ImageToVideoEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptImage"] = await CreatePromptImageNodeAsync(promptImages, lastImage, cancellationToken).ConfigureAwait(false),
        };

        if (!string.IsNullOrWhiteSpace(prompt))
        {
            body["promptText"] = prompt;
        }

        SetIfSupported(body, normalizedModel, ImageToVideoEndpoint, "ratio", ratio);
        SetIfSupported(body, normalizedModel, ImageToVideoEndpoint, "duration", duration);
        RequireAndSet(body, normalizedModel, ImageToVideoEndpoint, "seed", "--seed", seed);
        SetIfSupported(body, normalizedModel, ImageToVideoEndpoint, "audio", audio);

        await ApplyVideoExtrasAsync(body, normalizedModel, ImageToVideoEndpoint, extras, cancellationToken).ConfigureAwait(false);
        AddContentModeration(body, normalizedModel, ImageToVideoEndpoint, publicFigureThreshold);
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
        RunwayCliImageExtras? extras,
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
            extras,
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
        RunwayCliImageExtras? extras,
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

        // Several image variants are additionalProperties:false and accept different optional sets
        // (muse_image has no seed, grok takes `edit`, the seedream pair takes `grounding`), so every
        // optional field is gated on what the embedded spec says this model declares.
        RequireAndSet(body, normalizedModel, TextToImageEndpoint, "seed", "--seed", seed);
        SetIfSupported(body, normalizedModel, TextToImageEndpoint, "outputCount", outputCount);
        RequireAndSet(body, normalizedModel, TextToImageEndpoint, "quality", "--quality", quality);
        AddContentModeration(body, normalizedModel, TextToImageEndpoint, publicFigureThreshold);
        RequireAndSet(body, normalizedModel, TextToImageEndpoint, "outputFormat", "--output-format", extras?.OutputFormat);
        RequireAndSet(body, normalizedModel, TextToImageEndpoint, "background", "--background", extras?.Background);

        if (extras?.Grounding is { } grounding)
        {
            RequireSupport(normalizedModel, TextToImageEndpoint, "grounding", "--grounding");
            body["grounding"] = grounding;
        }

        if (extras?.Edit is { } edit)
        {
            RequireSupport(normalizedModel, TextToImageEndpoint, "edit", "--edit");
            body["edit"] = edit;
        }

        var references = await CreateReferenceImagesNodeAsync(
            referenceImages,
            normalizedModel,
            referenceSubject,
            cancellationToken).ConfigureAwait(false);

        if (references.Count == 0 &&
            RunwayModelSchema.Lookup(normalizedModel).Any(entry =>
                entry.Endpoint == TextToImageEndpoint &&
                entry.RequiredParameters.Contains("referenceImages", StringComparer.Ordinal)))
        {
            var textOnly = RunwayModelSchema.ModelsForEndpoint(TextToImageEndpoint)
                .Where(candidate => !RunwayModelSchema.Lookup(candidate).Any(entry =>
                    entry.Endpoint == TextToImageEndpoint &&
                    entry.RequiredParameters.Contains("referenceImages", StringComparer.Ordinal)));
            throw new ArgumentException(
                $"Model `{normalizedModel}` on `{TextToImageEndpoint}` requires at least one --reference-image. Models that generate from text alone: {string.Join(", ", textOnly)}.");
        }

        if (references.Count > 0)
        {
            body["referenceImages"] = references;
        }

        return body;
    }

    /// <summary>
    /// Rejects image extras the chosen model does not declare. The `gpt_image_2` path builds its request
    /// from the generated convenience type rather than the JSON body builder, so without this it would
    /// silently drop a flag like `--grounding` instead of telling the user which models accept it.
    /// </summary>
    public static void EnsureImageExtrasSupported(string normalizedModel, RunwayCliImageExtras? extras)
    {
        if (extras is null)
        {
            return;
        }

        if (!string.IsNullOrWhiteSpace(extras.OutputFormat))
        {
            RequireSupport(normalizedModel, TextToImageEndpoint, "outputFormat", "--output-format");
        }

        if (!string.IsNullOrWhiteSpace(extras.Background))
        {
            RequireSupport(normalizedModel, TextToImageEndpoint, "background", "--background");
        }

        if (extras.Grounding is not null)
        {
            RequireSupport(normalizedModel, TextToImageEndpoint, "grounding", "--grounding");
        }

        if (extras.Edit is not null)
        {
            RequireSupport(normalizedModel, TextToImageEndpoint, "edit", "--edit");
        }
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
        string? prompt,
        string? model,
        string video,
        string? ratio,
        double? duration,
        int? seed,
        bool audio,
        string? publicFigureThreshold,
        RunwayCliVideoExtras extras,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(extras);

        var normalizedModel = NormalizeVideoModel(model, DefaultVideoToVideoModel, VideoToVideoEndpoint);
        var videoUri = await NormalizeInputAssetAsync(video, cancellationToken).ConfigureAwait(false);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
        };

        // aleph2 and gemini_omni_flash name the input `videoUri`; the seedance/hailuo families use `promptVideo`.
        body[RunwayModelSchema.SupportsParameter(normalizedModel, VideoToVideoEndpoint, "promptVideo") ? "promptVideo" : "videoUri"] = videoUri;

        if (!string.IsNullOrWhiteSpace(prompt))
        {
            body["promptText"] = prompt;
        }
        else if (RunwayModelSchema.Lookup(normalizedModel)
            .Any(entry => entry.Endpoint == VideoToVideoEndpoint && entry.RequiredParameters.Contains("promptText", StringComparer.Ordinal)))
        {
            throw new ArgumentException($"Model '{normalizedModel}' requires a prompt on {VideoToVideoEndpoint}.");
        }

        // aleph2 deprecated `ratio` in favour of `targetAspectRatio`: never send both.
        if (string.IsNullOrWhiteSpace(extras.TargetAspectRatio))
        {
            SetIfSupported(body, normalizedModel, VideoToVideoEndpoint, "ratio", ratio);
        }
        SetIfSupported(body, normalizedModel, VideoToVideoEndpoint, "duration", duration);
        RequireAndSet(body, normalizedModel, VideoToVideoEndpoint, "seed", "--seed", seed);
        SetIfSupported(body, normalizedModel, VideoToVideoEndpoint, "audio", audio);

        await ApplyVideoExtrasAsync(body, normalizedModel, VideoToVideoEndpoint, extras, cancellationToken).ConfigureAwait(false);
        AddContentModeration(body, normalizedModel, VideoToVideoEndpoint, publicFigureThreshold);
        return ToGenerated<CreateVideoToVideoRequest>(body);
    }

    public static async Task<CreateCharacterPerformanceRequest> CreateCharacterPerformanceRequestAsync(
        string? characterImage,
        string? characterVideo,
        string referenceVideo,
        string? model,
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

        var normalizedModel = NormalizeVideoModel(model, DefaultCharacterPerformanceModel, CharacterPerformanceEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
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

        SetIfSupported(body, normalizedModel, CharacterPerformanceEndpoint, "ratio", ratio);
        RequireAndSet(body, normalizedModel, CharacterPerformanceEndpoint, "seed", "--seed", seed);
        if (bodyControl is { } resolvedBodyControl)
        {
            RequireSupport(normalizedModel, CharacterPerformanceEndpoint, "bodyControl", "--body-control");
            body["bodyControl"] = resolvedBodyControl;
        }

        RequireAndSet(body, normalizedModel, CharacterPerformanceEndpoint, "expressionIntensity", "--expression-intensity", expressionIntensity);
        AddContentModeration(body, normalizedModel, CharacterPerformanceEndpoint, publicFigureThreshold);
        return ToGenerated<CreateCharacterPerformanceRequest>(body);
    }

    /// <summary>
    /// Builds a <c>POST /v1/video_upscale</c> body. The two models on this endpoint take disjoint,
    /// <c>additionalProperties: false</c> parameter sets — <c>magnific_video_upscaler_creative</c> takes the
    /// detail/grain knobs and a target resolution, while <c>enhance_frame_rate</c> takes only a target
    /// framerate — so each flag is gated on what the chosen model declares.
    /// </summary>
    public static async Task<CreateVideoUpscaleRequest> CreateVideoUpscaleRequestAsync(
        string video,
        string? model,
        string? resolution,
        string? targetFramerate,
        int? creativity,
        int? sharpen,
        int? smartGrain,
        string? flavor,
        bool? fpsBoost,
        CancellationToken cancellationToken)
    {
        var normalizedModel = NormalizeVideoModel(model, DefaultVideoUpscaleModel, VideoUpscaleEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["videoUri"] = await NormalizeInputAssetAsync(video, cancellationToken).ConfigureAwait(false),
        };

        RequireAndSet(body, normalizedModel, VideoUpscaleEndpoint, "resolution", "--resolution", resolution);
        RequireAndSet(body, normalizedModel, VideoUpscaleEndpoint, "targetFramerate", "--target-framerate", targetFramerate);
        RequireAndSet(body, normalizedModel, VideoUpscaleEndpoint, "creativity", "--creativity", creativity);
        RequireAndSet(body, normalizedModel, VideoUpscaleEndpoint, "sharpen", "--sharpen", sharpen);
        RequireAndSet(body, normalizedModel, VideoUpscaleEndpoint, "smartGrain", "--smart-grain", smartGrain);
        RequireAndSet(body, normalizedModel, VideoUpscaleEndpoint, "flavor", "--flavor", flavor);

        if (fpsBoost is { } resolvedFpsBoost)
        {
            RequireSupport(normalizedModel, VideoUpscaleEndpoint, "fpsBoost", "--fps-boost");
            body["fpsBoost"] = resolvedFpsBoost;
        }

        EnsureRequiredUpscaleParameters(normalizedModel, VideoUpscaleEndpoint, body);
        return ToGenerated<CreateVideoUpscaleRequest>(body);
    }

    /// <summary>
    /// Builds a <c>POST /v1/image_upscale</c> body, gated the same way as the video endpoint.
    /// </summary>
    public static async Task<CreateImageUpscaleRequest> CreateImageUpscaleRequestAsync(
        string image,
        string? model,
        double? scaleFactor,
        int? sharpen,
        int? smartGrain,
        int? ultraDetail,
        string? flavor,
        CancellationToken cancellationToken)
    {
        var normalizedModel = NormalizeVideoModel(model, DefaultImageUpscaleModel, ImageUpscaleEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["imageUri"] = await NormalizeInputAssetAsync(image, cancellationToken).ConfigureAwait(false),
        };

        if (scaleFactor is { } resolvedScaleFactor)
        {
            RequireSupport(normalizedModel, ImageUpscaleEndpoint, "scaleFactor", "--scale-factor");
            var allowed = RunwayModelSchema.GetAllowedValues(normalizedModel, ImageUpscaleEndpoint, "scaleFactor");
            var rendered = resolvedScaleFactor.ToString(CultureInfo.InvariantCulture);
            if (allowed.Count > 0 && !allowed.Contains(rendered, StringComparer.Ordinal))
            {
                throw new ArgumentException($"--scale-factor must be one of: {string.Join(", ", allowed)}.");
            }

            body["scaleFactor"] = resolvedScaleFactor;
        }

        RequireAndSet(body, normalizedModel, ImageUpscaleEndpoint, "sharpen", "--sharpen", sharpen);
        RequireAndSet(body, normalizedModel, ImageUpscaleEndpoint, "smartGrain", "--smart-grain", smartGrain);
        RequireAndSet(body, normalizedModel, ImageUpscaleEndpoint, "ultraDetail", "--ultra-detail", ultraDetail);
        RequireAndSet(body, normalizedModel, ImageUpscaleEndpoint, "flavor", "--flavor", flavor);

        EnsureRequiredUpscaleParameters(normalizedModel, ImageUpscaleEndpoint, body);
        return ToGenerated<CreateImageUpscaleRequest>(body);
    }

    /// <summary>
    /// Fails when a required parameter of the chosen upscale model was not supplied, naming the flag.
    /// `enhance_frame_rate` requires `--target-framerate`, which the creative upscaler does not accept.
    /// </summary>
    private static void EnsureRequiredUpscaleParameters(string model, string endpoint, JsonObject body)
    {
        foreach (var entry in RunwayModelSchema.Lookup(model))
        {
            if (!string.Equals(entry.Endpoint, endpoint, StringComparison.Ordinal))
            {
                continue;
            }

            var missing = entry.RequiredParameters.Where(name => !body.ContainsKey(name)).ToList();
            if (missing.Count > 0)
            {
                throw new ArgumentException(
                    $"Model `{model}` on `{endpoint}` requires {string.Join(", ", missing.Select(RunwayModelSchema.DescribeRequiredParam))} per the Runway OpenAPI spec.");
            }
        }
    }

    public static async Task<CreateSoundEffectRequest> CreateSoundEffectRequestAsync(
        string prompt,
        string? model,
        double? duration,
        bool loop,
        RunwayCliAudioExtras? extras,
        CancellationToken cancellationToken)
    {
        var normalizedModel = NormalizeVideoModel(model, DefaultSoundEffectModel, SoundEffectEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptText"] = prompt,
        };

        // `loop` and `duration` belong to the ElevenLabs model; seed_audio takes rate/format knobs and
        // reference clips instead, under additionalProperties:false.
        if (RunwayModelSchema.SupportsParameter(normalizedModel, SoundEffectEndpoint, "loop"))
        {
            body["loop"] = loop;
        }

        SetIfSupported(body, normalizedModel, SoundEffectEndpoint, "duration", duration);
        await ApplyAudioExtrasAsync(body, normalizedModel, SoundEffectEndpoint, extras, cancellationToken).ConfigureAwait(false);
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
                ["presetId"] = NormalizeVoicePreset(voicePreset, "eleven_multilingual_sts_v2", SpeechToSpeechEndpoint),
            },
        };
        SetIfNotNull(body, "runwayVoiceId", runwayVoiceId);
        SetIfNotNull(body, "removeBackgroundNoise", removeBackgroundNoise);
        return ToGenerated<CreateSpeechToSpeechRequest>(body);
    }

    public static async Task<CreateTextToSpeechRequest> CreateTextToSpeechRequestAsync(
        string prompt,
        string? model,
        string voicePreset,
        string? referenceAudio,
        RunwayCliAudioExtras? extras,
        CancellationToken cancellationToken)
    {
        var normalizedModel = NormalizeVideoModel(model, DefaultTextToSpeechModel, TextToSpeechEndpoint);
        var body = new JsonObject
        {
            ["model"] = normalizedModel,
            ["promptText"] = prompt,
        };

        // The ElevenLabs models take a preset voice id; seed_audio clones from a reference clip instead,
        // so the two voice shapes are not interchangeable.
        var clonesVoice = RunwayModelSchema.SupportsItemProperty(normalizedModel, TextToSpeechEndpoint, "voice", "audioUri");
        if (clonesVoice)
        {
            if (referenceAudio is { Length: > 0 })
            {
                body["voice"] = new JsonObject
                {
                    ["type"] = "reference-audio",
                    ["audioUri"] = await NormalizeInputAssetAsync(referenceAudio, cancellationToken).ConfigureAwait(false),
                };
            }
        }
        else
        {
            if (referenceAudio is { Length: > 0 })
            {
                throw new ArgumentException(
                    $"Model '{normalizedModel}' speaks with a preset voice, not a cloned one. Use --voice-preset, or switch to a model that accepts --reference-audio: {string.Join(", ", ModelsSupportingItemProperty(TextToSpeechEndpoint, "voice", "audioUri"))}.");
            }

            body["voice"] = new JsonObject
            {
                ["type"] = "runway-preset",
                ["presetId"] = NormalizeVoicePreset(voicePreset, normalizedModel, TextToSpeechEndpoint),
            };
        }

        await ApplyAudioExtrasAsync(body, normalizedModel, TextToSpeechEndpoint, extras, cancellationToken).ConfigureAwait(false);
        return ToGenerated<CreateTextToSpeechRequest>(body);
    }

    /// <summary>
    /// Validates a Runway preset voice id against the spec enum for the chosen model. The ids are proper
    /// names (<c>Maya</c>, <c>Claudia</c>, ...), and the generated enum silently coerces an unknown value
    /// to its first member, so an invalid id would otherwise reach the API as a different voice.
    /// </summary>
    public static string NormalizeVoicePreset(string? value, string model, string endpoint)
    {
        var allowed = RunwayModelSchema.GetItemPropertyValues(model, endpoint, "voice", "presetId");
        if (allowed.Count == 0)
        {
            // Nothing enum-backed to check against (seed_audio clones instead of using presets).
            return value ?? string.Empty;
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            return allowed[0];
        }

        var candidate = value.Trim();
        foreach (var option in allowed)
        {
            if (string.Equals(option, candidate, StringComparison.OrdinalIgnoreCase))
            {
                return option;
            }
        }

        throw new ArgumentException(
            $"Unknown --voice-preset '{value}' for {model}. Valid ids are proper names: {string.Join(", ", allowed.Take(8))}, … ({allowed.Count} total). Run `runway voice presets` for the full list.");
    }

    private static IReadOnlyList<string> ModelsSupportingItemProperty(string endpoint, string parameterName, string itemProperty)
    {
        return [.. RunwayModelSchema.ModelsForEndpoint(endpoint)
            .Where(candidate => RunwayModelSchema.SupportsItemProperty(candidate, endpoint, parameterName, itemProperty))];
    }

    /// <summary>
    /// Applies the per-model audio knobs, gated on the spec: the eleven_v3 expressiveness controls, the
    /// seed_audio rate/format controls, and the voice-dubbing options. A flag the chosen model does not
    /// declare is refused with the models that take it.
    /// </summary>
    private static async Task ApplyAudioExtrasAsync(
        JsonObject body,
        string model,
        string endpoint,
        RunwayCliAudioExtras? extras,
        CancellationToken cancellationToken)
    {
        if (extras is null)
        {
            return;
        }

        if (extras.ReferenceAudios is { Length: > 0 } referenceAudios)
        {
            RequireSupport(model, endpoint, "referenceAudios", "--reference-audio");
            var cap = RunwayModelSchema.GetMaxItems(model, endpoint, "referenceAudios");
            if (cap is { } max && referenceAudios.Length > max)
            {
                throw new ArgumentException($"Model '{model}' accepts up to {max} reference audio clips.");
            }

            var items = new JsonArray();
            foreach (var uri in await NormalizeReferenceAssetsAsync(referenceAudios, cancellationToken).ConfigureAwait(false) ?? [])
            {
                items.Add(uri);
            }

            body["referenceAudios"] = items;
        }

        RequireAndSet(body, model, endpoint, "outputFormat", "--output-format", extras.OutputFormat);
        RequireAndSet(body, model, endpoint, "languageCode", "--language-code", extras.LanguageCode);
        RequireAndSet(body, model, endpoint, "applyTextNormalization", "--apply-text-normalization", extras.ApplyTextNormalization);
        RequireAndSet(body, model, endpoint, "sampleRate", "--sample-rate", extras.SampleRate);
        RequireAndSet(body, model, endpoint, "speechRate", "--speech-rate", extras.SpeechRate);
        RequireAndSet(body, model, endpoint, "pitchRate", "--pitch-rate", extras.PitchRate);
        RequireAndSet(body, model, endpoint, "loudnessRate", "--loudness-rate", extras.LoudnessRate);
        RequireAndSet(body, model, endpoint, "numSpeakers", "--num-speakers", extras.NumSpeakers);
        RequireAndSet(body, model, endpoint, "seed", "--seed", extras.Seed);
        RequireAndSetDouble(body, model, endpoint, "stability", "--stability", extras.Stability);
        RequireAndSetDouble(body, model, endpoint, "style", "--style", extras.Style);
        RequireAndSetDouble(body, model, endpoint, "speed", "--speed", extras.Speed);
        RequireAndSetDouble(body, model, endpoint, "similarityBoost", "--similarity-boost", extras.SimilarityBoost);
        RequireAndSetBool(body, model, endpoint, "useSpeakerBoost", "--use-speaker-boost", extras.UseSpeakerBoost);
        RequireAndSetBool(body, model, endpoint, "disableVoiceCloning", "--disable-voice-cloning", extras.DisableVoiceCloning);
        RequireAndSetBool(body, model, endpoint, "dropBackgroundAudio", "--drop-background-audio", extras.DropBackgroundAudio);
    }

    private static void RequireAndSetDouble(JsonObject body, string model, string endpoint, string name, string flag, double? value)
    {
        if (value is null)
        {
            return;
        }

        RequireSupport(model, endpoint, name, flag);
        body[name] = value.Value;
    }

    private static void RequireAndSetBool(JsonObject body, string model, string endpoint, string name, string flag, bool? value)
    {
        if (value is null)
        {
            return;
        }

        RequireSupport(model, endpoint, name, flag);
        body[name] = value.Value;
    }

    public static async Task<CreateVoiceDubbingRequest> CreateVoiceDubbingRequestAsync(
        string audio,
        string targetLanguage,
        RunwayCliAudioExtras? extras,
        CancellationToken cancellationToken)
    {
        var dubbingBody = new JsonObject
        {
            ["model"] = "eleven_voice_dubbing",
            ["audioUri"] = await NormalizeInputAssetAsync(audio, cancellationToken).ConfigureAwait(false),
            ["targetLang"] = targetLanguage,
        };

        await ApplyAudioExtrasAsync(dubbingBody, "eleven_voice_dubbing", VoiceDubbingEndpoint, extras, cancellationToken).ConfigureAwait(false);
        return ToGenerated<CreateVoiceDubbingRequest>(dubbingBody);
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

    /// <summary>
    /// Normalizes a model id for one of the video endpoints against the embedded OpenAPI spec, so the
    /// accepted set tracks whatever Runway currently ships instead of a hand-maintained list.
    /// </summary>
    public static string NormalizeVideoModel(string? value, string fallback, string endpoint)
    {
        var candidate = ApplyModelAliases(string.IsNullOrWhiteSpace(value) ? fallback : value.Trim());
        var supported = RunwayModelSchema.ModelsForEndpoint(endpoint);
        if (supported.Count == 0 || supported.Contains(candidate, StringComparer.Ordinal))
        {
            return candidate;
        }

        throw new ArgumentException(
            $"Unsupported model '{value}' for {endpoint}. Supported values: {string.Join(", ", supported)}.");
    }

    public static string NormalizeModel(string? value, string fallback, IReadOnlyCollection<string> supported)
    {
        var candidate = ApplyModelAliases(string.IsNullOrWhiteSpace(value) ? fallback : value.Trim());

        if (supported.Contains(candidate))
        {
            return candidate;
        }

        throw new ArgumentException($"Unsupported model '{value}'. Supported values: {string.Join(", ", supported)}.");
    }

    private static string ApplyModelAliases(string candidate)
    {
        return candidate switch
        {
            "gen45" or "gen4_5" or "gen4-5" => "gen4.5",
            "gen4-turbo" => "gen4_turbo",
            "seedance2-fast" => "seedance2_fast",
            "veo3.1-fast" or "veo3_1_fast" or "veo3-1-fast" => "veo3.1_fast",
            "veo3_1" or "veo3-1" => "veo3.1",
            "gemini-2.5-flash" => "gemini_2.5_flash",
            "gemini-image3-pro" or "gemini-image-3-pro" => "gemini_image3_pro",
            "gpt-image-2" => "gpt_image_2",
            "gen4-image" => "gen4_image",
            "gen4-image-turbo" => "gen4_image_turbo",
            "hailuo-3" or "hailuo_3" or "minimax-h3" => "hailuo3",
            "happyhorse" or "happyhorse-1-0" or "happyhorse_1.0" or "happyhorse-1.0" => "happyhorse_1_0",
            "seedance2-mini" => "seedance2_mini",
            "seedance2.5" or "seedance2-5" or "seedance25" or "seedance-2.5" => "seedance2_5",
            "gemini-omni-flash" or "gemini_omni-flash" => "gemini_omni_flash",
            "grok" or "grok-imagine" or "grok-imagine-1.5" or "grok-imagine-1-5" or "grok_imagine_1.5" => "grok_imagine_1_5",
            "wan-3" or "wan_3" => "wan3",
            "gemini-image3.1-flash" or "gemini-image3-1-flash" or "gemini_image3-1_flash" => "gemini_image3.1_flash",
            "muse-image" or "muse" => "muse_image",
            "seedream5-pro" or "seedream5.pro" or "seedream-5-pro" => "seedream5_pro",
            "seedream5-lite" or "seedream5.lite" or "seedream-5-lite" => "seedream5_lite",
            "grok-imagine-image-2" or "grok-imagine-image2" or "grok_imagine_image2" => "grok_imagine_image_2",
            "enhance-frame-rate" or "frame-rate" or "fps" => "enhance_frame_rate",
            "magnific-video-upscaler-creative" or "magnific-video" or "magnific" => "magnific_video_upscaler_creative",
            "magnific-precision-upscaler-v2" or "magnific-precision" or "magnific-image" => "magnific_precision_upscaler_v2",
            "gen4_aleph" or "gen4-aleph" or "aleph" or "aleph-2" => "aleph2",
            _ => candidate,
        };
    }

    public static string NormalizeTextToImageModel(string? value)
    {
        return NormalizeVideoModel(value, DefaultTextToImageModel, TextToImageEndpoint);
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

        // Cap and item shape both come from the spec: muse_image/seedream/grok accept `uri` only, the
        // gemini pair also takes `subject`, and the gen4/gpt/gemini-flash family takes a `tag`.
        var maxReferenceImages = RunwayModelSchema.GetMaxItems(normalizedModel, TextToImageEndpoint, "referenceImages");
        if (maxReferenceImages is { } cap && values.Length > cap)
        {
            throw new ArgumentException($"Runway accepts up to {cap} reference images for {normalizedModel}.");
        }

        var supportsTag = RunwayModelSchema.SupportsItemProperty(normalizedModel, TextToImageEndpoint, "referenceImages", "tag");
        var supportsSubject = RunwayModelSchema.SupportsItemProperty(normalizedModel, TextToImageEndpoint, "referenceImages", "subject");

        for (var index = 0; index < values.Length; index++)
        {
            var image = new JsonObject
            {
                ["uri"] = await NormalizeInputAssetAsync(values[index], cancellationToken).ConfigureAwait(false),
            };
            if (supportsTag)
            {
                image["tag"] = $"reference{index + 1}";
            }

            if (supportsSubject && subject is { Length: > 0 })
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

    /// <summary>
    /// Adds <c>contentModeration</c> only when the chosen model declares it. Most third-party video models
    /// (seedance, hailuo, wan, grok, gemini) use <c>additionalProperties: false</c> and reject the field.
    /// </summary>
    private static void AddContentModeration(JsonObject body, string model, string endpoint, string? publicFigureThreshold)
    {
        if (string.IsNullOrWhiteSpace(publicFigureThreshold))
        {
            return;
        }

        RequireSupport(model, endpoint, "contentModeration", "--public-figure-threshold");
        AddContentModeration(body, publicFigureThreshold);
    }

    /// <summary>
    /// Lists the models on <paramref name="endpoint"/> that accept <paramref name="parameterName"/>, so a
    /// rejected flag can tell the user which model to switch to.
    /// </summary>
    private static IReadOnlyList<string> ModelsSupporting(string endpoint, string parameterName)
    {
        return [.. RunwayModelSchema.ModelsForEndpoint(endpoint)
            .Where(candidate => RunwayModelSchema.SupportsParameter(candidate, endpoint, parameterName))];
    }

    private static void RequireSupport(string model, string endpoint, string parameterName, string flag)
    {
        if (RunwayModelSchema.SupportsParameter(model, endpoint, parameterName))
        {
            return;
        }

        var alternatives = ModelsSupporting(endpoint, parameterName);
        var trailer = alternatives.Count == 0
            ? $"No model on {endpoint} accepts it."
            : $"Models that do: {string.Join(", ", alternatives)}.";
        throw new ArgumentException($"Model '{model}' does not accept {flag} on {endpoint}. {trailer}");
    }

    private static void SetIfSupported(JsonObject body, string model, string endpoint, string name, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value) && RunwayModelSchema.SupportsParameter(model, endpoint, name))
        {
            body[name] = value;
        }
    }

    private static void SetIfSupported(JsonObject body, string model, string endpoint, string name, int? value)
    {
        if (value is not null && RunwayModelSchema.SupportsParameter(model, endpoint, name))
        {
            body[name] = value.Value;
        }
    }

    private static void SetIfSupported(JsonObject body, string model, string endpoint, string name, double? value)
    {
        if (value is not null && RunwayModelSchema.SupportsParameter(model, endpoint, name))
        {
            body[name] = value.Value;
        }
    }

    private static void SetIfSupported(JsonObject body, string model, string endpoint, string name, bool? value)
    {
        if (value is not null && RunwayModelSchema.SupportsParameter(model, endpoint, name))
        {
            body[name] = value.Value;
        }
    }

    /// <summary>
    /// Applies the reference inputs and the per-model delivery/steering knobs that are not part of every
    /// variant. A flag the chosen model does not declare is rejected with the list of models that take it,
    /// rather than being silently dropped or sent into an <c>additionalProperties: false</c> schema.
    /// </summary>
    private static async Task ApplyVideoExtrasAsync(
        JsonObject body,
        string model,
        string endpoint,
        RunwayCliVideoExtras extras,
        CancellationToken cancellationToken)
    {
        // Image references are bare `{ "uri": ... }` objects — no `type` discriminator, unlike video/audio.
        if (extras.ReferenceImages is { Length: > 0 } referenceImages)
        {
            RequireSupport(model, endpoint, "references", "--reference-image");
            body["references"] = await CreateVideoReferenceArrayAsync(referenceImages, type: null, cancellationToken).ConfigureAwait(false);
        }

        if (extras.ReferenceVideos is { Length: > 0 } referenceVideos)
        {
            RequireSupport(model, endpoint, "referenceVideos", "--reference-video");
            body["referenceVideos"] = await CreateVideoReferenceArrayAsync(referenceVideos, "video", cancellationToken).ConfigureAwait(false);
        }

        if (extras.ReferenceAudio is { Length: > 0 } referenceAudio)
        {
            RequireSupport(model, endpoint, "referenceAudio", "--reference-audio");
            body["referenceAudio"] = await CreateVideoReferenceArrayAsync(referenceAudio, "audio", cancellationToken).ConfigureAwait(false);
        }

        if (extras.Keyframes is { Length: > 0 } keyframes)
        {
            RequireSupport(model, endpoint, "keyframes", "--keyframe");
            body["keyframes"] = await CreateKeyframeArrayAsync(keyframes, cancellationToken).ConfigureAwait(false);
        }

        RequireAndSet(body, model, endpoint, "negativePrompt", "--negative-prompt", extras.NegativePrompt);
        RequireAndSet(body, model, endpoint, "resolution", "--resolution", extras.Resolution);
        RequireAndSet(body, model, endpoint, "mode", "--mode", extras.Mode);
        RequireAndSet(body, model, endpoint, "outputFormat", "--output-format", extras.OutputFormat);
        RequireAndSet(body, model, endpoint, "proresProfile", "--prores-profile", extras.ProresProfile);
        RequireAndSet(body, model, endpoint, "targetAspectRatio", "--target-aspect-ratio", extras.TargetAspectRatio);
    }

    private static void RequireAndSet(JsonObject body, string model, string endpoint, string name, string flag, string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return;
        }

        RequireSupport(model, endpoint, name, flag);
        body[name] = value;
    }

    /// <summary>
    /// Same contract as the string overload, for flags with no default: a non-null value means the user
    /// asked for it, so an unsupporting model is an error rather than a silent drop.
    /// </summary>
    private static void RequireAndSet(JsonObject body, string model, string endpoint, string name, string flag, int? value)
    {
        if (value is null)
        {
            return;
        }

        RequireSupport(model, endpoint, name, flag);
        body[name] = value.Value;
    }

    /// <summary>
    /// Normalizes a list of reference assets to URIs the API accepts: HTTPS and <c>runway://</c> URIs pass
    /// through, local paths are inlined as <c>data:</c> URIs. The single place reference assets are resolved,
    /// so every surface that takes references — the generation commands, the short-video runner, the
    /// recipes — resolves them identically. Returns null for an empty list so callers can omit the field.
    /// </summary>
    public static async Task<IReadOnlyList<string>?> NormalizeReferenceAssetsAsync(
        IReadOnlyList<string>? values,
        CancellationToken cancellationToken)
    {
        if (values is not { Count: > 0 })
        {
            return null;
        }

        var normalized = new List<string>(values.Count);
        foreach (var value in values)
        {
            normalized.Add(await NormalizeInputAssetAsync(value, cancellationToken).ConfigureAwait(false));
        }

        return normalized;
    }

    private static async Task<JsonArray> CreateVideoReferenceArrayAsync(
        string[] values,
        string? type,
        CancellationToken cancellationToken)
    {
        var items = new JsonArray();
        foreach (var uri in await NormalizeReferenceAssetsAsync(values, cancellationToken).ConfigureAwait(false) ?? [])
        {
            var item = new JsonObject
            {
                ["uri"] = uri,
            };
            if (type is { Length: > 0 })
            {
                item["type"] = type;
            }

            items.Add(item);
        }

        return items;
    }

    /// <summary>
    /// Parses <c>--keyframe</c> values shaped as <c>&lt;uri&gt;@&lt;seconds&gt;</c> (absolute offset) or
    /// <c>&lt;uri&gt;@&lt;fraction&gt;%</c> (fraction of the clip) into aleph2 keyframe objects.
    /// </summary>
    private static async Task<JsonArray> CreateKeyframeArrayAsync(string[] values, CancellationToken cancellationToken)
    {
        var items = new JsonArray();
        foreach (var value in values)
        {
            var separator = value.LastIndexOf('@');
            if (separator <= 0 || separator == value.Length - 1)
            {
                throw new ArgumentException($"Invalid --keyframe '{value}'. Use <image>@<seconds> or <image>@<percent>%.");
            }

            var asset = value[..separator];
            var position = value[(separator + 1)..].Trim();
            var fractional = position.EndsWith('%');
            if (fractional)
            {
                position = position[..^1];
            }

            if (!double.TryParse(position, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed))
            {
                throw new ArgumentException($"Invalid --keyframe position '{position}' in '{value}'.");
            }

            var item = new JsonObject
            {
                ["uri"] = await NormalizeInputAssetAsync(asset, cancellationToken).ConfigureAwait(false),
            };
            if (fractional)
            {
                item["at"] = parsed / 100d;
            }
            else
            {
                item["seconds"] = parsed;
            }

            items.Add(item);
        }

        return items;
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
