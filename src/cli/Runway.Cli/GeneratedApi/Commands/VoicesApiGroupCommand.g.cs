#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class VoicesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"voices", @"Voices endpoint commands.");
                         command.Subcommands.Add(VoicesCreateVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesCreateVoicesPreviewCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesDeleteVoicesByIdCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesEditVoicesByIdCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesGetVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesGetVoicesByIdCommandApiCommand.Create());
        return command;
    }
}