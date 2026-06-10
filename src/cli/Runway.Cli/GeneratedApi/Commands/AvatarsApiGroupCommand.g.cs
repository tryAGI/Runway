#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class AvatarsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"avatars", @"Avatars endpoint commands.");
                         command.Subcommands.Add(AvatarsCreateAvatarsCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsDeleteAvatarConversationsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsDeleteAvatarsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsEditAvatarsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsGetAvatarConversationsCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsGetAvatarConversationsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsGetAvatarUsageCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsGetAvatarsCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsGetAvatarsByIdCommandApiCommand.Create());
        return command;
    }
}