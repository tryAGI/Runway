#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class ModelRouterDeleteRoutersByIdCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"The Model Router's primary key ID (UUID).",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-routers-by-id", @"Delete Model Router
Delete a Model Router configuration. Deleted Model Routers cannot be used for generation.");
                        command.Arguments.Add(Id);
                        command.Options.Add(XRunwayVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.ModelRouter.DeleteRoutersByIdAsync(
                                    id: id,
                                    xRunwayVersion: xRunwayVersion,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}