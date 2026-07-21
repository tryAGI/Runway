#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class GenerateApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"generate", @"Generate endpoint commands.");
                         command.Subcommands.Add(GenerateCreateGenerateVideoCommandApiCommand.Create());
        return command;
    }
}