#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RealtimeSessionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"realtime-sessions", @"Realtime Sessions endpoint commands.");
                         command.Subcommands.Add(RealtimeSessionsCreateRealtimeSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeSessionsDeleteRealtimeSessionsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeSessionsGetRealtimeSessionsByIdCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}