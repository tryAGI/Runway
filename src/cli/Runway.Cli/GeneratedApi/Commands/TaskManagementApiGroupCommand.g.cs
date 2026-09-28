#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class TaskManagementApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"task-management", @"Task management endpoint commands.");
                         command.Subcommands.Add(TaskManagementDeleteTasksByIdCommandApiCommand.Create());
                         command.Subcommands.Add(TaskManagementGetTasksByIdCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}