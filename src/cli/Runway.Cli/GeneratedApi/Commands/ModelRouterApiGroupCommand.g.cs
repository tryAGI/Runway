#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class ModelRouterApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"model-router", @"Model Router endpoint commands.");
                         command.Subcommands.Add(ModelRouterCreateGenerateAudioCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterCreateGenerateImageCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterCreateGenerateVideoCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterCreateRoutersCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterDeleteRoutersByIdCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterEditRoutersByIdCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterGetRoutersCommandApiCommand.Create());
                         command.Subcommands.Add(ModelRouterGetRoutersByIdCommandApiCommand.Create());
        return command;
    }
}