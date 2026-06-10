#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class WorkflowsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"workflows", @"Workflows endpoint commands.");
                         command.Subcommands.Add(WorkflowsCreateWorkflowsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WorkflowsGetWorkflowInvocationsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WorkflowsGetWorkflowsCommandApiCommand.Create());
                         command.Subcommands.Add(WorkflowsGetWorkflowsByIdCommandApiCommand.Create());
        return command;
    }
}