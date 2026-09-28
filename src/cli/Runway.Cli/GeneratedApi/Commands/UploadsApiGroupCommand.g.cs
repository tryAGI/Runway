#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class UploadsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"uploads", @"Uploads endpoint commands.");
                         command.Subcommands.Add(UploadsCreateUploadsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}