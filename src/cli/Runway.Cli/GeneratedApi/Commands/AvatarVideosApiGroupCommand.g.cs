#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class AvatarVideosApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"avatar-videos", @"Avatar Videos endpoint commands.");
                         command.Subcommands.Add(AvatarVideosCreateAvatarVideosCommandApiCommand.Create());
        return command;
    }
}