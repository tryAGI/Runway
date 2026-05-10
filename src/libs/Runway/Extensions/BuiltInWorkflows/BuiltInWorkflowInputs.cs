#pragma warning disable CA1034 // Nested derived records form a closed discriminated union; that's the intent.
#pragma warning disable CA1819 // BytesValue holds a payload; an immutable byte[] is the natural shape.

namespace Runway;

/// <summary>
/// One input value supplied to a built-in workflow run. Use the static factory methods
/// (<see cref="FromText"/>, <see cref="FromStream"/>, etc.) — you typically don't construct
/// derived types directly.
/// </summary>
public abstract record BuiltInWorkflowValue
{
    /// <summary>Free-form text supplied for a Prompt input.</summary>
    public sealed record TextValue(string Text) : BuiltInWorkflowValue;

    /// <summary>Local file content supplied as a stream for an Image / Video / Audio input.</summary>
    public sealed record StreamValue(Stream Stream, string FileName) : BuiltInWorkflowValue;

    /// <summary>Local file content supplied as bytes for an Image / Video / Audio input.</summary>
    public sealed record BytesValue(byte[] Bytes, string FileName) : BuiltInWorkflowValue;

    /// <summary>Pre-existing remote URI (https / runway / data) supplied for an Image / Video / Audio input.</summary>
    public sealed record UriValue(Uri Uri) : BuiltInWorkflowValue;

    /// <summary>Path to a local file that should be auto-uploaded for an Image / Video / Audio input.</summary>
    public sealed record FilePathValue(string Path) : BuiltInWorkflowValue;

    /// <summary>Numeric primitive for a Number input.</summary>
    public sealed record NumberValue(double Number) : BuiltInWorkflowValue;

    /// <summary>Boolean primitive for a Boolean input.</summary>
    public sealed record BooleanValue(bool Boolean) : BuiltInWorkflowValue;

    /// <summary>Wrap a free-form text prompt.</summary>
    public static BuiltInWorkflowValue FromText(string text) => new TextValue(text);

    /// <summary>Wrap a stream of file content. Caller is responsible for disposing the stream after the run completes.</summary>
    public static BuiltInWorkflowValue FromStream(Stream stream, string fileName = "file.bin") => new StreamValue(stream, fileName);

    /// <summary>Wrap an in-memory byte array.</summary>
    public static BuiltInWorkflowValue FromBytes(byte[] bytes, string fileName = "file.bin") => new BytesValue(bytes, fileName);

    /// <summary>Wrap a remote https / runway / data URI.</summary>
    public static BuiltInWorkflowValue FromUri(Uri uri) => new UriValue(uri);

    /// <summary>Wrap a local file path. The runner will upload it before submitting.</summary>
    public static BuiltInWorkflowValue FromFilePath(string path) => new FilePathValue(path);

    /// <summary>Wrap a numeric primitive.</summary>
    public static BuiltInWorkflowValue FromNumber(double value) => new NumberValue(value);

    /// <summary>Wrap a boolean primitive.</summary>
    public static BuiltInWorkflowValue FromBoolean(bool value) => new BooleanValue(value);

    /// <summary>
    /// Smart-resolve a string into a <see cref="BuiltInWorkflowValue"/> for an asset input:
    /// recognized URI prefixes (<c>https://</c>, <c>runway://</c>, <c>data:</c>) become a <see cref="UriValue"/>;
    /// any other string is treated as a local file path (<see cref="FilePathValue"/>).
    /// </summary>
    public static BuiltInWorkflowValue FromAssetString(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        if (value.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ||
            value.StartsWith("runway://", StringComparison.OrdinalIgnoreCase) ||
            value.StartsWith("data:", StringComparison.OrdinalIgnoreCase))
        {
            return new UriValue(new Uri(value, UriKind.Absolute));
        }
        return new FilePathValue(value);
    }
}

/// <summary>
/// Fluent builder for the inputs supplied to a built-in workflow run. Keys are the workflow's input
/// flags (e.g. <c>--image</c>, <c>--hairstyle</c>) — see <see cref="BuiltInWorkflow.Inputs"/>.
/// </summary>
public sealed class BuiltInWorkflowInputs
{
    private readonly Dictionary<string, BuiltInWorkflowValue> _values = new(StringComparer.Ordinal);

    /// <summary>Direct map of flag → value, for inspection.</summary>
    public IReadOnlyDictionary<string, BuiltInWorkflowValue> Values => _values;

    /// <summary>Create a fresh builder.</summary>
    public BuiltInWorkflowInputs() { }

    /// <summary>Convenience factory for chained construction.</summary>
    public static BuiltInWorkflowInputs Create() => new();

    /// <summary>Set an input directly with a typed value.</summary>
    public BuiltInWorkflowInputs Set(string flag, BuiltInWorkflowValue value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(flag);
        ArgumentNullException.ThrowIfNull(value);
        _values[flag] = value;
        return this;
    }

    /// <summary>Set a Prompt / text input (or treat the string as a smart-resolved asset for asset flags).</summary>
    public BuiltInWorkflowInputs Set(string flag, string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(flag);
        ArgumentNullException.ThrowIfNull(value);
        _values[flag] = BuiltInWorkflowValue.FromText(value);
        return this;
    }

    /// <summary>Set an asset (Image / Video / Audio) input from a stream.</summary>
    public BuiltInWorkflowInputs SetStream(string flag, Stream stream, string fileName = "file.bin")
    {
        return Set(flag, BuiltInWorkflowValue.FromStream(stream, fileName));
    }

    /// <summary>Set an asset (Image / Video / Audio) input from in-memory bytes.</summary>
    public BuiltInWorkflowInputs SetBytes(string flag, byte[] bytes, string fileName = "file.bin")
    {
        return Set(flag, BuiltInWorkflowValue.FromBytes(bytes, fileName));
    }

    /// <summary>Set an asset (Image / Video / Audio) input from a remote URI.</summary>
    public BuiltInWorkflowInputs SetUri(string flag, Uri uri)
    {
        return Set(flag, BuiltInWorkflowValue.FromUri(uri));
    }

    /// <summary>Set an asset (Image / Video / Audio) input from a local file path.</summary>
    public BuiltInWorkflowInputs SetFilePath(string flag, string path)
    {
        return Set(flag, BuiltInWorkflowValue.FromFilePath(path));
    }

    /// <summary>Set a Number primitive input.</summary>
    public BuiltInWorkflowInputs SetNumber(string flag, double value)
    {
        return Set(flag, BuiltInWorkflowValue.FromNumber(value));
    }

    /// <summary>Set a Boolean primitive input.</summary>
    public BuiltInWorkflowInputs SetBoolean(string flag, bool value)
    {
        return Set(flag, BuiltInWorkflowValue.FromBoolean(value));
    }
}
