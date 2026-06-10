#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static class KnowledgeApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"knowledge", @"Knowledge endpoint commands.");
                         command.Subcommands.Add(KnowledgeCreateDocumentsCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeDeleteDocumentsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeEditDocumentsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetDocumentsCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetDocumentsByIdCommandApiCommand.Create());
        return command;
    }
}