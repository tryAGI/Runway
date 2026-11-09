/// <summary>
/// The CLI's output contract, in one place so every code path honours it.
///
/// <para>
/// stdout carries only machine-readable results — task IDs, downloaded file paths, JSON documents — so a
/// command can be piped into another without filtering. Progress, status and other prose go to stderr,
/// and <c>--quiet</c> silences that prose while leaving errors and stdout untouched. That split is what
/// makes `runway image "..." | runway image-to-video --image - "push in"` work.
/// </para>
/// </summary>
internal static class RunwayCliConsole
{
    /// <summary>Set once from the command line; suppresses informational stderr output.</summary>
    public static bool Quiet { get; set; }

    /// <summary>Writes an informational line to stderr unless --quiet was passed. Never used for errors.</summary>
    public static void WriteInfo(string message)
    {
        if (!Quiet)
        {
            Console.Error.WriteLine(message);
        }
    }

    /// <inheritdoc cref="WriteInfo"/>
    public static Task WriteInfoAsync(string message) =>
        Quiet ? Task.CompletedTask : Console.Error.WriteLineAsync(message);
}
