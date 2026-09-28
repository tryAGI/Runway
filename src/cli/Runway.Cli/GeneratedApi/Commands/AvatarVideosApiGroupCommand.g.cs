#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class AvatarVideosApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"avatar-videos", @"Avatar Videos endpoint commands.");
                         command.Subcommands.Add(AvatarVideosCreateAvatarVideosCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}