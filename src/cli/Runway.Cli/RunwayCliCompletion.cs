using System.CommandLine;
using System.Text;
using Runway;

/// <summary>
/// Emits a shell completion script for the CLI. The script is generated from the live command tree and
/// the OpenAPI spec embedded in the SDK, so subcommands, options and the accepted values of
/// <c>--model</c> stay correct after a spec refresh regenerates the command surface — there is no
/// hand-maintained word list to go stale.
/// </summary>
internal static class RunwayCliCompletion
{
    /// <summary>Shells the generator can emit for.</summary>
    public static IReadOnlyList<string> SupportedShells { get; } = ["bash", "zsh", "fish"];

    /// <summary>
    /// Per-command model completions. The keys are command paths as typed; the values come from the spec,
    /// so a model Runway adds shows up without touching this file.
    /// </summary>
    private static readonly (string CommandPath, string Endpoint)[] ModelEndpoints =
    [
        ("text-to-video", RunwayCliGeneration.TextToVideoEndpoint),
        ("video", RunwayCliGeneration.TextToVideoEndpoint),
        ("short-video", RunwayCliGeneration.TextToVideoEndpoint),
        ("image-to-video", RunwayCliGeneration.ImageToVideoEndpoint),
        ("video-to-video", RunwayCliGeneration.VideoToVideoEndpoint),
        ("image", RunwayCliGeneration.TextToImageEndpoint),
        ("video-upscale", RunwayCliGeneration.VideoUpscaleEndpoint),
        ("image-upscale", RunwayCliGeneration.ImageUpscaleEndpoint),
        ("text-to-speech", RunwayCliGeneration.TextToSpeechEndpoint),
        ("sound-effect", RunwayCliGeneration.SoundEffectEndpoint),
        ("character-performance", RunwayCliGeneration.CharacterPerformanceEndpoint),
    ];

    public static string Generate(string shell, Command root)
    {
        ArgumentNullException.ThrowIfNull(root);

        return shell?.Trim().ToLowerInvariant() switch
        {
            "bash" => GenerateBash(root),
            "zsh" => GenerateZsh(root),
            "fish" => GenerateFish(root),
            _ => throw new ArgumentException(
                $"Unsupported shell '{shell}'. Accepted values: {string.Join(", ", SupportedShells)}."),
        };
    }

    /// <summary>Top-level command names, plus the options every command accepts.</summary>
    private static List<string> TopLevelCommands(Command root) =>
        [.. root.Subcommands.Where(c => !c.Hidden).Select(c => c.Name).OrderBy(n => n, StringComparer.Ordinal)];

    private static List<string> OptionsFor(Command command) =>
        [.. command.Options
            .Where(option => !option.Hidden)
            .SelectMany(option => new[] { option.Name }.Concat(option.Aliases))
            .Distinct(StringComparer.Ordinal)
            .OrderBy(name => name, StringComparer.Ordinal)];

    private static List<string> SubcommandsFor(Command command) =>
        [.. command.Subcommands.Where(c => !c.Hidden).Select(c => c.Name).OrderBy(n => n, StringComparer.Ordinal)];

    private static string ModelsFor(string endpoint) =>
        string.Join(' ', RunwayModelSchema.ModelsForEndpoint(endpoint));

    private static string GenerateBash(Command root)
    {
        var builder = new StringBuilder();
        builder.AppendLine("# runway completion bash — generated from the embedded OpenAPI spec.");
        builder.AppendLine("# Install: runway completion bash > /usr/local/etc/bash_completion.d/runway");
        builder.AppendLine("_runway_completions() {");
        builder.AppendLine("  local cur prev words cword");
        builder.AppendLine("  COMPREPLY=()");
        builder.AppendLine("  cur=\"${COMP_WORDS[COMP_CWORD]}\"");
        builder.AppendLine("  prev=\"${COMP_WORDS[COMP_CWORD-1]}\"");
        builder.AppendLine($"  local commands=\"{string.Join(' ', TopLevelCommands(root))}\"");
        builder.AppendLine($"  local global_options=\"{string.Join(' ', OptionsFor(root))}\"");
        builder.AppendLine();
        builder.AppendLine("  # Model completions depend on which command is being typed.");
        builder.AppendLine("  local sub=\"\"");
        builder.AppendLine("  local i");
        builder.AppendLine("  for ((i=1; i<COMP_CWORD; i++)); do");
        builder.AppendLine("    case \"${COMP_WORDS[i]}\" in");
        builder.AppendLine("      -*) ;;");
        builder.AppendLine("      *) if [[ -z \"$sub\" ]]; then sub=\"${COMP_WORDS[i]}\"; fi ;;");
        builder.AppendLine("    esac");
        builder.AppendLine("  done");
        builder.AppendLine();
        builder.AppendLine("  if [[ \"$prev\" == \"--model\" ]]; then");
        builder.AppendLine("    case \"$sub\" in");
        foreach (var (commandPath, endpoint) in ModelEndpoints)
        {
            builder.AppendLine($"      {commandPath}) COMPREPLY=( $(compgen -W \"{ModelsFor(endpoint)}\" -- \"$cur\") ); return 0 ;;");
        }

        builder.AppendLine("    esac");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  if [[ \"$prev\" == \"--format\" ]]; then");
        builder.AppendLine("    COMPREPLY=( $(compgen -W \"text json\" -- \"$cur\") ); return 0");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  if [[ \"$cur\" == -* ]]; then");
        builder.AppendLine("    local options=\"$global_options\"");
        builder.AppendLine("    case \"$sub\" in");
        foreach (var command in root.Subcommands.Where(c => !c.Hidden).OrderBy(c => c.Name, StringComparer.Ordinal))
        {
            var options = OptionsFor(command);
            if (options.Count > 0)
            {
                builder.AppendLine($"      {command.Name}) options=\"$options {string.Join(' ', options)}\" ;;");
            }
        }

        builder.AppendLine("    esac");
        builder.AppendLine("    COMPREPLY=( $(compgen -W \"$options\" -- \"$cur\") ); return 0");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  if [[ -z \"$sub\" ]]; then");
        builder.AppendLine("    COMPREPLY=( $(compgen -W \"$commands\" -- \"$cur\") ); return 0");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  case \"$sub\" in");
        foreach (var command in root.Subcommands.Where(c => !c.Hidden).OrderBy(c => c.Name, StringComparer.Ordinal))
        {
            var subcommands = SubcommandsFor(command);
            if (subcommands.Count > 0)
            {
                builder.AppendLine($"    {command.Name}) COMPREPLY=( $(compgen -W \"{string.Join(' ', subcommands)}\" -- \"$cur\") ) ;;");
            }
        }

        builder.AppendLine("  esac");
        builder.AppendLine("}");
        builder.AppendLine("complete -F _runway_completions runway");
        return builder.ToString();
    }

    private static string GenerateZsh(Command root)
    {
        var builder = new StringBuilder();
        builder.AppendLine("#compdef runway");
        builder.AppendLine("# runway completion zsh — generated from the embedded OpenAPI spec.");
        builder.AppendLine("# Install: runway completion zsh > \"${fpath[1]}/_runway\"");
        builder.AppendLine("_runway() {");
        builder.AppendLine("  local -a commands");
        builder.Append("  commands=(");
        foreach (var command in root.Subcommands.Where(c => !c.Hidden).OrderBy(c => c.Name, StringComparer.Ordinal))
        {
            builder.Append($" '{command.Name}:{Escape(command.Description)}'");
        }

        builder.AppendLine(" )");
        builder.AppendLine();
        builder.AppendLine("  if (( CURRENT == 2 )); then");
        builder.AppendLine("    _describe -t commands 'runway command' commands && return");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  local sub=\"${words[2]}\"");
        builder.AppendLine("  if [[ \"${words[CURRENT-1]}\" == \"--model\" ]]; then");
        builder.AppendLine("    case \"$sub\" in");
        foreach (var (commandPath, endpoint) in ModelEndpoints)
        {
            builder.AppendLine($"      {commandPath}) _values 'model' {ModelsFor(endpoint)} && return ;;");
        }

        builder.AppendLine("    esac");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  if [[ \"${words[CURRENT-1]}\" == \"--format\" ]]; then");
        builder.AppendLine("    _values 'format' text json && return");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  case \"$sub\" in");
        foreach (var command in root.Subcommands.Where(c => !c.Hidden).OrderBy(c => c.Name, StringComparer.Ordinal))
        {
            var words = SubcommandsFor(command).Concat(OptionsFor(command)).Concat(OptionsFor(root)).Distinct(StringComparer.Ordinal);
            builder.AppendLine($"    {command.Name}) _values 'argument' {string.Join(' ', words.Select(Quote))} ;;");
        }

        builder.AppendLine("  esac");
        builder.AppendLine("}");
        builder.AppendLine("_runway \"$@\"");
        return builder.ToString();
    }

    private static string GenerateFish(Command root)
    {
        var builder = new StringBuilder();
        builder.AppendLine("# runway completion fish — generated from the embedded OpenAPI spec.");
        builder.AppendLine("# Install: runway completion fish > ~/.config/fish/completions/runway.fish");
        builder.AppendLine("complete -c runway -f");
        foreach (var command in root.Subcommands.Where(c => !c.Hidden).OrderBy(c => c.Name, StringComparer.Ordinal))
        {
            builder.AppendLine($"complete -c runway -n '__fish_use_subcommand' -a '{command.Name}' -d '{Escape(command.Description)}'");
            foreach (var subcommand in SubcommandsFor(command))
            {
                builder.AppendLine($"complete -c runway -n '__fish_seen_subcommand_from {command.Name}' -a '{subcommand}'");
            }

            foreach (var option in OptionsFor(command).Where(name => name.StartsWith("--", StringComparison.Ordinal)))
            {
                builder.AppendLine($"complete -c runway -n '__fish_seen_subcommand_from {command.Name}' -l '{option[2..]}'");
            }
        }

        foreach (var option in OptionsFor(root).Where(name => name.StartsWith("--", StringComparison.Ordinal)))
        {
            builder.AppendLine($"complete -c runway -l '{option[2..]}'");
        }

        foreach (var (commandPath, endpoint) in ModelEndpoints)
        {
            builder.AppendLine(
                $"complete -c runway -n '__fish_seen_subcommand_from {commandPath}' -l model -x -a '{ModelsFor(endpoint)}'");
        }

        builder.AppendLine("complete -c runway -l format -x -a 'text json'");
        return builder.ToString();
    }

    private static string Escape(string? text) =>
        (text ?? string.Empty).Replace("'", " ", StringComparison.Ordinal).Replace("\n", " ", StringComparison.Ordinal);

    private static string Quote(string value) => $"'{value}'";
}
