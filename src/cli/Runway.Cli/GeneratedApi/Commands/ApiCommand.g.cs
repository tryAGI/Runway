#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");
          command.Options.Add(CliOptions.ApiKey);
          command.Options.Add(CliOptions.BaseUrl);
          command.Options.Add(CliOptions.Json);
          command.Options.Add(CliOptions.Output);
          command.Options.Add(CliOptions.OutputDirectory);
                         command.Subcommands.Add(AvatarVideosApiGroupCommand.Create());
                         command.Subcommands.Add(AvatarsApiGroupCommand.Create());
                         command.Subcommands.Add(KnowledgeApiGroupCommand.Create());
                         command.Subcommands.Add(OrganizationApiGroupCommand.Create());
                         command.Subcommands.Add(RealtimeSessionsApiGroupCommand.Create());
                         command.Subcommands.Add(StartGeneratingApiGroupCommand.Create());
                         command.Subcommands.Add(TaskManagementApiGroupCommand.Create());
                         command.Subcommands.Add(UploadsApiGroupCommand.Create());
                         command.Subcommands.Add(VoicesApiGroupCommand.Create());
                         command.Subcommands.Add(WorkflowsApiGroupCommand.Create());
        return command;
    }
}