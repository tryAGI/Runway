#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class StartGeneratingApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"start-generating", @"Start generating endpoint commands.");
                         command.Subcommands.Add(StartGeneratingCreateCharacterPerformanceCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateImageToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateSoundEffectCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateSpeechToSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateTextToImageCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateTextToSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateTextToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateVideoToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateVoiceDubbingCommandApiCommand.Create());
                         command.Subcommands.Add(StartGeneratingCreateVoiceIsolationCommandApiCommand.Create());
        return command;
    }
}