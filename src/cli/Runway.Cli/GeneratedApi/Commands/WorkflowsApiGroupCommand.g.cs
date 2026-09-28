#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class WorkflowsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"workflows", @"Workflows endpoint commands.");
                         command.Subcommands.Add(WorkflowsCreateWorkflowsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WorkflowsGetWorkflowInvocationsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WorkflowsGetWorkflowsCommandApiCommand.Create());
                         command.Subcommands.Add(WorkflowsGetWorkflowsByIdCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}