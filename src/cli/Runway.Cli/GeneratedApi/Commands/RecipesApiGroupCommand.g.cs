#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RecipesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"recipes", @"Recipes endpoint commands.");
                         command.Subcommands.Add(RecipesCreateRecipesAdLocalizationCommandApiCommand.Create());
                         command.Subcommands.Add(RecipesCreateRecipesMarketingStockImageCommandApiCommand.Create());
                         command.Subcommands.Add(RecipesCreateRecipesMultiShotVideoCommandApiCommand.Create());
                         command.Subcommands.Add(RecipesCreateRecipesProductAdCommandApiCommand.Create());
                         command.Subcommands.Add(RecipesCreateRecipesProductCampaignImageCommandApiCommand.Create());
                         command.Subcommands.Add(RecipesCreateRecipesProductSwapCommandApiCommand.Create());
                         command.Subcommands.Add(RecipesCreateRecipesProductUgcCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}