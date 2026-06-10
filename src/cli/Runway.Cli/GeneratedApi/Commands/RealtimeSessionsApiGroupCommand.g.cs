#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class RealtimeSessionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"realtime-sessions", @"Realtime Sessions endpoint commands.");
                         command.Subcommands.Add(RealtimeSessionsCreateRealtimeSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeSessionsDeleteRealtimeSessionsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeSessionsGetRealtimeSessionsByIdCommandApiCommand.Create());
        return command;
    }
}