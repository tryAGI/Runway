using System.Globalization;
using System.Text;

internal sealed record RunwayCliMarketingBrief
{
    public string? ProductOneLiner { get; init; }
    public string? ProductCategory { get; init; }

    public string? AudiencePersona { get; init; }
    public string? AudienceAwarenessStage { get; init; }
    public string? AudiencePainPoints { get; init; }

    public string? GoalObjective { get; init; }
    public string? GoalCallToAction { get; init; }
    public string? GoalSuccessMetric { get; init; }

    public string? MessageValueProposition { get; init; }
    public string? MessageDifferentiators { get; init; }
    public string? MessageProofPoints { get; init; }

    public string? VoiceTone { get; init; }
    public string? VoiceWordsToAvoid { get; init; }

    public string? FormatPlatform { get; init; }
    public string? FormatAspectRatio { get; init; }
    public string? FormatLengthSeconds { get; init; }
    public string? FormatCaptionsOnScreen { get; init; }

    public bool IsEmpty =>
        IsBlank(ProductOneLiner) &&
        IsBlank(ProductCategory) &&
        IsBlank(AudiencePersona) &&
        IsBlank(AudienceAwarenessStage) &&
        IsBlank(AudiencePainPoints) &&
        IsBlank(GoalObjective) &&
        IsBlank(GoalCallToAction) &&
        IsBlank(GoalSuccessMetric) &&
        IsBlank(MessageValueProposition) &&
        IsBlank(MessageDifferentiators) &&
        IsBlank(MessageProofPoints) &&
        IsBlank(VoiceTone) &&
        IsBlank(VoiceWordsToAvoid) &&
        IsBlank(FormatPlatform) &&
        IsBlank(FormatAspectRatio) &&
        IsBlank(FormatLengthSeconds) &&
        IsBlank(FormatCaptionsOnScreen);

    private static bool IsBlank(string? value) => string.IsNullOrWhiteSpace(value);
}

internal static class RunwayCliMarketingBriefStore
{
    public const string FileName = "MARKETING.md";

    private static readonly string[] AwarenessStages = ["problem-aware", "solution-aware", "product-aware"];
    private static readonly string[] Objectives = ["awareness", "leads", "activation", "conversion"];
    private static readonly string[] Platforms = ["youtube-shorts", "tiktok", "reels", "instagram-feed", "x", "linkedin", "web"];
    private static readonly string[] YesNo = ["yes", "no"];

    public static string ResolvePath(string directory)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(directory);
        return Path.Combine(directory, FileName);
    }

    public static async Task<RunwayCliMarketingBrief> ReadAsync(string directory, CancellationToken cancellationToken)
    {
        var path = ResolvePath(directory);
        if (!File.Exists(path))
        {
            return new RunwayCliMarketingBrief();
        }

        var text = await File.ReadAllTextAsync(path, Encoding.UTF8, cancellationToken).ConfigureAwait(false);
        return Parse(text);
    }

    public static async Task<bool> WriteAsync(
        string directory,
        RunwayCliMarketingBrief brief,
        CancellationToken cancellationToken)
    {
        var path = ResolvePath(directory);
        var nextText = ToMarkdown(brief);
        if (File.Exists(path))
        {
            var existing = await File.ReadAllTextAsync(path, Encoding.UTF8, cancellationToken).ConfigureAwait(false);
            if (NormalizeForComparison(existing) == NormalizeForComparison(nextText))
            {
                return false;
            }
        }

        await File.WriteAllTextAsync(
            path,
            nextText,
            new UTF8Encoding(encoderShouldEmitUTF8Identifier: false),
            cancellationToken).ConfigureAwait(false);
        return true;
    }

    public static string ToMarkdown(RunwayCliMarketingBrief brief)
    {
        ArgumentNullException.ThrowIfNull(brief);
        var builder = new StringBuilder();
        builder.AppendLine("# MARKETING.md");
        builder.AppendLine();
        builder.AppendLine("## Product");
        AppendField(builder, "One-liner", brief.ProductOneLiner);
        AppendField(builder, "Category", brief.ProductCategory);
        builder.AppendLine();
        builder.AppendLine("## Audience");
        AppendField(builder, "Persona", brief.AudiencePersona);
        AppendField(builder, "Awareness stage", brief.AudienceAwarenessStage);
        AppendField(builder, "Pain points", brief.AudiencePainPoints);
        builder.AppendLine();
        builder.AppendLine("## Goal");
        AppendField(builder, "Primary objective", brief.GoalObjective);
        AppendField(builder, "Call to action", brief.GoalCallToAction);
        AppendField(builder, "Success metric", brief.GoalSuccessMetric);
        builder.AppendLine();
        builder.AppendLine("## Message");
        AppendField(builder, "Core value proposition", brief.MessageValueProposition);
        AppendField(builder, "Differentiators", brief.MessageDifferentiators);
        AppendField(builder, "Proof points", brief.MessageProofPoints);
        builder.AppendLine();
        builder.AppendLine("## Voice");
        AppendField(builder, "Tone", brief.VoiceTone);
        AppendField(builder, "Words to avoid", brief.VoiceWordsToAvoid);
        builder.AppendLine();
        builder.AppendLine("## Format");
        AppendField(builder, "Platform", brief.FormatPlatform);
        AppendField(builder, "Aspect ratio", brief.FormatAspectRatio);
        AppendField(builder, "Length seconds", brief.FormatLengthSeconds);
        AppendField(builder, "Captions on screen", brief.FormatCaptionsOnScreen);
        return builder.ToString();
    }

    public static RunwayCliMarketingBrief Parse(string markdown)
    {
        ArgumentNullException.ThrowIfNull(markdown);
        var section = string.Empty;
        var fields = new Dictionary<(string Section, string Key), string>(BriefKeyComparer.Instance);

        foreach (var rawLine in markdown.Split('\n'))
        {
            var line = rawLine.TrimEnd('\r').TrimEnd();
            if (line.StartsWith("## ", StringComparison.Ordinal))
            {
                section = line[3..].Trim();
                continue;
            }

            if (!line.StartsWith("- ", StringComparison.Ordinal))
            {
                continue;
            }

            var item = line[2..];
            var colon = item.IndexOf(':', StringComparison.Ordinal);
            if (colon < 0)
            {
                continue;
            }

            var key = item[..colon].Trim();
            var value = item[(colon + 1)..].Trim();
            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(value))
            {
                continue;
            }

            fields[(section, key)] = value;
        }

        return new RunwayCliMarketingBrief
        {
            ProductOneLiner = Get(fields, "Product", "One-liner"),
            ProductCategory = Get(fields, "Product", "Category"),
            AudiencePersona = Get(fields, "Audience", "Persona"),
            AudienceAwarenessStage = Get(fields, "Audience", "Awareness stage"),
            AudiencePainPoints = Get(fields, "Audience", "Pain points"),
            GoalObjective = Get(fields, "Goal", "Primary objective"),
            GoalCallToAction = Get(fields, "Goal", "Call to action"),
            GoalSuccessMetric = Get(fields, "Goal", "Success metric"),
            MessageValueProposition = Get(fields, "Message", "Core value proposition"),
            MessageDifferentiators = Get(fields, "Message", "Differentiators"),
            MessageProofPoints = Get(fields, "Message", "Proof points"),
            VoiceTone = Get(fields, "Voice", "Tone"),
            VoiceWordsToAvoid = Get(fields, "Voice", "Words to avoid"),
            FormatPlatform = Get(fields, "Format", "Platform"),
            FormatAspectRatio = Get(fields, "Format", "Aspect ratio"),
            FormatLengthSeconds = Get(fields, "Format", "Length seconds"),
            FormatCaptionsOnScreen = Get(fields, "Format", "Captions on screen"),
        };
    }

    public static async Task<RunwayCliMarketingBrief> AskMissingAsync(
        RunwayCliMarketingBrief brief,
        TextReader input,
        TextWriter output,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(brief);
        ArgumentNullException.ThrowIfNull(input);
        ArgumentNullException.ThrowIfNull(output);

        if (brief.IsEmpty)
        {
            await output.WriteLineAsync("No MARKETING.md found in the working directory; let's build one together.").ConfigureAwait(false);
        }
        else
        {
            await output.WriteLineAsync("Loaded MARKETING.md from the working directory; asking only for missing fields.").ConfigureAwait(false);
            ReportLoaded(output, brief);
        }

        await output.WriteLineAsync().ConfigureAwait(false);

        var productOneLiner = await AskTextAsync(input, output, "Product", "One-liner — what does it do, in one sentence?", brief.ProductOneLiner, cancellationToken).ConfigureAwait(false);
        var productCategory = await AskTextAsync(input, output, "Product", "Category (e.g. SaaS, hardware, course)", brief.ProductCategory, cancellationToken).ConfigureAwait(false);

        var audiencePersona = await AskTextAsync(input, output, "Audience", "Persona — who is this for?", brief.AudiencePersona, cancellationToken).ConfigureAwait(false);
        var audienceAwarenessStage = await AskChoiceAsync(input, output, "Audience", "Awareness stage", AwarenessStages, brief.AudienceAwarenessStage, cancellationToken).ConfigureAwait(false);
        var audiencePainPoints = await AskTextAsync(input, output, "Audience", "Pain points (comma-separated, optional)", brief.AudiencePainPoints, allowEmpty: true, cancellationToken).ConfigureAwait(false);

        var goalObjective = await AskChoiceAsync(input, output, "Goal", "Primary objective", Objectives, brief.GoalObjective, cancellationToken).ConfigureAwait(false);
        var goalCta = await AskTextAsync(input, output, "Goal", "Call to action — what should viewers do?", brief.GoalCallToAction, cancellationToken).ConfigureAwait(false);
        var goalSuccessMetric = await AskTextAsync(input, output, "Goal", "Success metric (optional)", brief.GoalSuccessMetric, allowEmpty: true, cancellationToken).ConfigureAwait(false);

        var messageValueProp = await AskTextAsync(input, output, "Message", "Core value proposition", brief.MessageValueProposition, cancellationToken).ConfigureAwait(false);
        var messageDiffs = await AskTextAsync(input, output, "Message", "Differentiators (optional)", brief.MessageDifferentiators, allowEmpty: true, cancellationToken).ConfigureAwait(false);
        var messageProof = await AskTextAsync(input, output, "Message", "Proof points (optional)", brief.MessageProofPoints, allowEmpty: true, cancellationToken).ConfigureAwait(false);

        var voiceTone = await AskTextAsync(input, output, "Voice", "Tone — three adjectives (e.g. bold, witty, calm)", brief.VoiceTone, cancellationToken).ConfigureAwait(false);
        var voiceAvoid = await AskTextAsync(input, output, "Voice", "Words to avoid (optional)", brief.VoiceWordsToAvoid, allowEmpty: true, cancellationToken).ConfigureAwait(false);

        var formatPlatform = await AskChoiceAsync(input, output, "Format", "Platform", Platforms, brief.FormatPlatform, cancellationToken).ConfigureAwait(false);
        var (defaultRatio, defaultLength) = ResolvePlatformDefaults(formatPlatform);
        var formatRatio = await AskTextAsync(input, output, "Format", "Aspect ratio", brief.FormatAspectRatio ?? defaultRatio, allowEmpty: true, cancellationToken).ConfigureAwait(false);
        var formatLength = await AskTextAsync(input, output, "Format", "Length seconds", brief.FormatLengthSeconds ?? defaultLength, allowEmpty: true, cancellationToken).ConfigureAwait(false);
        var formatCaptions = await AskChoiceAsync(input, output, "Format", "Captions on screen", YesNo, brief.FormatCaptionsOnScreen ?? "yes", cancellationToken).ConfigureAwait(false);

        return new RunwayCliMarketingBrief
        {
            ProductOneLiner = productOneLiner,
            ProductCategory = productCategory,
            AudiencePersona = audiencePersona,
            AudienceAwarenessStage = audienceAwarenessStage,
            AudiencePainPoints = audiencePainPoints,
            GoalObjective = goalObjective,
            GoalCallToAction = goalCta,
            GoalSuccessMetric = goalSuccessMetric,
            MessageValueProposition = messageValueProp,
            MessageDifferentiators = messageDiffs,
            MessageProofPoints = messageProof,
            VoiceTone = voiceTone,
            VoiceWordsToAvoid = voiceAvoid,
            FormatPlatform = formatPlatform,
            FormatAspectRatio = formatRatio,
            FormatLengthSeconds = formatLength,
            FormatCaptionsOnScreen = formatCaptions,
        };
    }

    public static (string Ratio, string LengthSeconds) ResolvePlatformDefaults(string? platform)
    {
        return (platform ?? string.Empty).Trim().ToLowerInvariant() switch
        {
            "youtube-shorts" or "tiktok" or "reels" => ("720:1280", "30"),
            "instagram-feed" => ("1080:1080", "30"),
            "linkedin" => ("1280:720", "60"),
            "x" => ("1280:720", "30"),
            "web" => ("1920:1080", "60"),
            _ => ("1280:720", "30"),
        };
    }

    public static string? RenderPlannerSection(RunwayCliMarketingBrief brief)
    {
        ArgumentNullException.ThrowIfNull(brief);
        if (brief.IsEmpty)
        {
            return null;
        }

        var builder = new StringBuilder();
        builder.AppendLine("Marketing brief (the video must serve this brief — reflect tone in voiceover/dialogue cues, honor the audience awareness stage in the hook, and end on the CTA):");
        AppendBullet(builder, "Audience", JoinAudience(brief));
        AppendBullet(builder, "Pain points", brief.AudiencePainPoints);
        AppendBullet(builder, "Objective", brief.GoalObjective);
        AppendBullet(builder, "Call to action", brief.GoalCallToAction);
        AppendBullet(builder, "Success metric", brief.GoalSuccessMetric);
        AppendBullet(builder, "Core message", brief.MessageValueProposition);
        AppendBullet(builder, "Differentiators", brief.MessageDifferentiators);
        AppendBullet(builder, "Proof points", brief.MessageProofPoints);
        AppendBullet(builder, "Tone", brief.VoiceTone);
        AppendBullet(builder, "Words to avoid", brief.VoiceWordsToAvoid);
        AppendBullet(builder, "Platform", JoinFormat(brief));
        return builder.ToString().TrimEnd();
    }

    private static string? JoinAudience(RunwayCliMarketingBrief brief)
    {
        if (string.IsNullOrWhiteSpace(brief.AudiencePersona) && string.IsNullOrWhiteSpace(brief.AudienceAwarenessStage))
        {
            return null;
        }

        if (string.IsNullOrWhiteSpace(brief.AudienceAwarenessStage))
        {
            return brief.AudiencePersona;
        }

        if (string.IsNullOrWhiteSpace(brief.AudiencePersona))
        {
            return string.Create(CultureInfo.InvariantCulture, $"({brief.AudienceAwarenessStage})");
        }

        return string.Create(CultureInfo.InvariantCulture, $"{brief.AudiencePersona} ({brief.AudienceAwarenessStage})");
    }

    private static string? JoinFormat(RunwayCliMarketingBrief brief)
    {
        var parts = new List<string>();
        if (!string.IsNullOrWhiteSpace(brief.FormatPlatform)) { parts.Add(brief.FormatPlatform); }
        var details = new List<string>();
        if (!string.IsNullOrWhiteSpace(brief.FormatAspectRatio)) { details.Add(brief.FormatAspectRatio); }
        if (!string.IsNullOrWhiteSpace(brief.FormatLengthSeconds)) { details.Add(string.Create(CultureInfo.InvariantCulture, $"{brief.FormatLengthSeconds}s")); }
        if (string.Equals(brief.FormatCaptionsOnScreen, "yes", StringComparison.OrdinalIgnoreCase)) { details.Add("captions on"); }
        else if (string.Equals(brief.FormatCaptionsOnScreen, "no", StringComparison.OrdinalIgnoreCase)) { details.Add("captions off"); }
        if (parts.Count == 0 && details.Count == 0)
        {
            return null;
        }

        if (details.Count == 0)
        {
            return parts[0];
        }

        var detail = string.Join(", ", details);
        return parts.Count == 0 ? detail : string.Create(CultureInfo.InvariantCulture, $"{parts[0]} ({detail})");
    }

    private static void AppendBullet(StringBuilder builder, string label, string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return;
        }

        builder.Append("- ").Append(label).Append(": ").AppendLine(value.Trim());
    }

    private static void ReportLoaded(TextWriter output, RunwayCliMarketingBrief brief)
    {
        Report(output, "Product.OneLiner", brief.ProductOneLiner);
        Report(output, "Product.Category", brief.ProductCategory);
        Report(output, "Audience.Persona", brief.AudiencePersona);
        Report(output, "Audience.AwarenessStage", brief.AudienceAwarenessStage);
        Report(output, "Audience.PainPoints", brief.AudiencePainPoints);
        Report(output, "Goal.Objective", brief.GoalObjective);
        Report(output, "Goal.CallToAction", brief.GoalCallToAction);
        Report(output, "Goal.SuccessMetric", brief.GoalSuccessMetric);
        Report(output, "Message.ValueProposition", brief.MessageValueProposition);
        Report(output, "Message.Differentiators", brief.MessageDifferentiators);
        Report(output, "Message.ProofPoints", brief.MessageProofPoints);
        Report(output, "Voice.Tone", brief.VoiceTone);
        Report(output, "Voice.WordsToAvoid", brief.VoiceWordsToAvoid);
        Report(output, "Format.Platform", brief.FormatPlatform);
        Report(output, "Format.AspectRatio", brief.FormatAspectRatio);
        Report(output, "Format.LengthSeconds", brief.FormatLengthSeconds);
        Report(output, "Format.CaptionsOnScreen", brief.FormatCaptionsOnScreen);
    }

    private static void Report(TextWriter output, string key, string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return;
        }

        output.WriteLine(string.Create(CultureInfo.InvariantCulture, $"[loaded] {key} = \"{value.Trim()}\""));
    }

    private static async Task<string> AskTextAsync(
        TextReader input,
        TextWriter output,
        string section,
        string question,
        string? existing,
        CancellationToken cancellationToken)
    {
        return await AskTextAsync(input, output, section, question, existing, allowEmpty: false, cancellationToken).ConfigureAwait(false);
    }

    private static async Task<string> AskTextAsync(
        TextReader input,
        TextWriter output,
        string section,
        string question,
        string? existing,
        bool allowEmpty,
        CancellationToken cancellationToken)
    {
        if (!string.IsNullOrWhiteSpace(existing))
        {
            return existing.Trim();
        }

        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await output.WriteAsync(string.Create(CultureInfo.InvariantCulture, $"[{section}] {question}\n> ")).ConfigureAwait(false);
            var line = await input.ReadLineAsync(cancellationToken).ConfigureAwait(false);
            if (line is null)
            {
                throw new OperationCanceledException("Marketing brief input stream ended before all required fields were collected.");
            }

            var trimmed = line.Trim();
            if (trimmed.Length > 0)
            {
                return trimmed;
            }

            if (allowEmpty)
            {
                return string.Empty;
            }

            await output.WriteLineAsync("This field is required. Please provide a value.").ConfigureAwait(false);
        }
    }

    private static async Task<string> AskChoiceAsync(
        TextReader input,
        TextWriter output,
        string section,
        string question,
        IReadOnlyList<string> choices,
        string? existing,
        CancellationToken cancellationToken)
    {
        if (!string.IsNullOrWhiteSpace(existing) &&
            choices.Any(choice => string.Equals(choice, existing.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            return existing.Trim().ToLowerInvariant();
        }

        var menu = new StringBuilder();
        for (var i = 0; i < choices.Count; i++)
        {
            menu.AppendLine(string.Create(CultureInfo.InvariantCulture, $"  [{i + 1}] {choices[i]}"));
        }

        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await output.WriteAsync(string.Create(CultureInfo.InvariantCulture, $"[{section}] {question}\n{menu}> ")).ConfigureAwait(false);
            var line = await input.ReadLineAsync(cancellationToken).ConfigureAwait(false);
            if (line is null)
            {
                throw new OperationCanceledException("Marketing brief input stream ended before all required fields were collected.");
            }

            var trimmed = line.Trim();
            if (trimmed.Length == 0)
            {
                continue;
            }

            if (int.TryParse(trimmed, NumberStyles.Integer, CultureInfo.InvariantCulture, out var index) &&
                index >= 1 && index <= choices.Count)
            {
                return choices[index - 1];
            }

            var match = choices.FirstOrDefault(choice => string.Equals(choice, trimmed, StringComparison.OrdinalIgnoreCase));
            if (match is { Length: > 0 })
            {
                return match;
            }

            await output.WriteLineAsync(string.Create(CultureInfo.InvariantCulture, $"Choose one of: {string.Join(", ", choices)}")).ConfigureAwait(false);
        }
    }

    private static string? Get(IDictionary<(string Section, string Key), string> fields, string section, string key)
    {
        return fields.TryGetValue((section, key), out var value) ? value : null;
    }

    private static void AppendField(StringBuilder builder, string key, string? value)
    {
        builder.Append("- ").Append(key).Append(": ");
        if (!string.IsNullOrWhiteSpace(value))
        {
            builder.Append(value.Trim());
        }

        builder.AppendLine();
    }

    private static string NormalizeForComparison(string text)
    {
        return text.Replace("\r\n", "\n", StringComparison.Ordinal).TrimEnd();
    }

    private sealed class BriefKeyComparer : IEqualityComparer<(string Section, string Key)>
    {
        public static readonly BriefKeyComparer Instance = new();

        public bool Equals((string Section, string Key) x, (string Section, string Key) y)
        {
            return string.Equals(x.Section, y.Section, StringComparison.OrdinalIgnoreCase)
                && string.Equals(x.Key, y.Key, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode((string Section, string Key) value)
        {
            return HashCode.Combine(
                value.Section.ToLowerInvariant(),
                value.Key.ToLowerInvariant());
        }
    }
}
