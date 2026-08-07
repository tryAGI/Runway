#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class OrganizationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"organization", @"Organization endpoint commands.");
                         command.Subcommands.Add(OrganizationCreateOrganizationUsageCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationWebappAuditLogsCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationWebappAuditLogsByEventIdCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationGetOrganizationWebappUsageCommandApiCommand.Create());
        return command;
    }
}