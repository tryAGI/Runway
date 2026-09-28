#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class KnowledgeApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"knowledge", @"Knowledge endpoint commands.");
                         command.Subcommands.Add(KnowledgeCreateDocumentsCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeDeleteDocumentsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeEditDocumentsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetDocumentsCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetDocumentsByIdCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}