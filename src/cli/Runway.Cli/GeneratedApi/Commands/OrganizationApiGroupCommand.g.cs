#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class OrganizationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"organization", @"Organization endpoint commands.");
                         command.Subcommands.Add(OrganizationCreateOrganizationUsageCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationWebappAuditLogsCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationWebappAuditLogsByEventIdCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationWebappUsageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}