#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class UploadsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"uploads", @"Uploads endpoint commands.");
                         command.Subcommands.Add(UploadsCreateUploadsCommandApiCommand.Create());
        return command;
    }
}