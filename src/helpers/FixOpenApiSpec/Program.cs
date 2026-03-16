using System.Globalization;
using System.Text.RegularExpressions;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var primitiveStringLiteralAssignmentRegex = new Regex(
    @"(?<prefix>\b(?<type>bool|byte|sbyte|short|ushort|int|uint|long|ulong|nint|nuint|float|double|decimal)\??\s+\w+\s*(?:\{[^{}]*\}\s*)?=\s*)""(?<value>[^""\r\n]+)""(?<suffix>\s*[,;)])",
    RegexOptions.Compiled | RegexOptions.CultureInvariant);

if (Directory.Exists(path))
{
    var changedFiles = await NormalizeGeneratedFilesAsync(path).ConfigureAwait(false);
    Console.WriteLine($"Normalized primitive const literals in {changedFiles} generated file(s).");
    return;
}

var yamlOrJson = await File.ReadAllTextAsync(path).ConfigureAwait(false);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2).ConfigureAwait(false);
yamlOrJson = NormalizeYamlPrimitiveConsts(yamlOrJson);

await File.WriteAllTextAsync(path, yamlOrJson).ConfigureAwait(false);

async Task<int> NormalizeGeneratedFilesAsync(string directoryPath)
{
    var changedFiles = 0;

    foreach (var filePath in Directory.EnumerateFiles(directoryPath, "*.g.cs", SearchOption.AllDirectories))
    {
        var source = await File.ReadAllTextAsync(filePath).ConfigureAwait(false);
        var normalized = primitiveStringLiteralAssignmentRegex.Replace(
            source,
            static match =>
            {
                var literal = ConvertPrimitiveLiteral(
                    match.Groups["type"].Value,
                    match.Groups["value"].Value);

                return literal is null
                    ? match.Value
                    : $"{match.Groups["prefix"].Value}{literal}{match.Groups["suffix"].Value}";
            });

        if (!string.Equals(source, normalized, StringComparison.Ordinal))
        {
            await File.WriteAllTextAsync(filePath, normalized).ConfigureAwait(false);
            changedFiles++;
        }
    }

    return changedFiles;
}

static string NormalizeYamlPrimitiveConsts(string yaml)
{
    yaml = Regex.Replace(
        yaml,
        @"(?m)^(?<indent>\s*)const:\s+'(?<value>[+-]?(?:\d+(?:\.\d+)?|\.\d+)(?:[eE][+-]?\d+)?)'\r?\n\k<indent>type:\s+(?<type>number|integer)\s*$",
        static match => $"{match.Groups["indent"].Value}const: {match.Groups["value"].Value}{Environment.NewLine}{match.Groups["indent"].Value}type: {match.Groups["type"].Value}");

    yaml = Regex.Replace(
        yaml,
        @"(?m)^(?<indent>\s*)const:\s+'(?<value>True|False|true|false)'\r?\n\k<indent>type:\s+boolean\s*$",
        static match => $"{match.Groups["indent"].Value}const: {match.Groups["value"].Value.ToLowerInvariant()}{Environment.NewLine}{match.Groups["indent"].Value}type: boolean");

    return yaml;
}

static string? ConvertPrimitiveLiteral(string typeName, string literalValue)
{
    return typeName.TrimEnd('?') switch
    {
        "bool" when bool.TryParse(literalValue, out var boolValue)
            => boolValue ? "true" : "false",
        "sbyte" when sbyte.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var sbyteValue)
            => sbyteValue.ToString(CultureInfo.InvariantCulture),
        "byte" when byte.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var byteValue)
            => byteValue.ToString(CultureInfo.InvariantCulture),
        "short" when short.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var shortValue)
            => shortValue.ToString(CultureInfo.InvariantCulture),
        "ushort" when ushort.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var ushortValue)
            => ushortValue.ToString(CultureInfo.InvariantCulture),
        "int" when int.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var intValue)
            => intValue.ToString(CultureInfo.InvariantCulture),
        "uint" when uint.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var uintValue)
            => uintValue.ToString(CultureInfo.InvariantCulture),
        "long" when long.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var longValue)
            => longValue.ToString(CultureInfo.InvariantCulture),
        "ulong" when ulong.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var ulongValue)
            => ulongValue.ToString(CultureInfo.InvariantCulture),
        "nint" when long.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var nintValue)
            => nintValue.ToString(CultureInfo.InvariantCulture),
        "nuint" when ulong.TryParse(literalValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var nuintValue)
            => nuintValue.ToString(CultureInfo.InvariantCulture),
        "float" when float.TryParse(literalValue, NumberStyles.Float, CultureInfo.InvariantCulture, out var floatValue)
            => $"{floatValue.ToString("R", CultureInfo.InvariantCulture)}F",
        "double" when double.TryParse(literalValue, NumberStyles.Float, CultureInfo.InvariantCulture, out var doubleValue)
            => doubleValue.ToString("R", CultureInfo.InvariantCulture),
        "decimal" when decimal.TryParse(literalValue, NumberStyles.Number, CultureInfo.InvariantCulture, out var decimalValue)
            => $"{decimalValue.ToString(CultureInfo.InvariantCulture)}m",
        _ => null,
    };
}
