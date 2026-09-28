#nullable enable

using System.CommandLine;

namespace Haiper.CLI.Commands;

internal static partial class DefaultApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CancelCreationCommandApiCommand.Create());
                         command.Subcommands.Add(CreateImageToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(CreateKeyframeConditioningCommandApiCommand.Create());
                         command.Subcommands.Add(CreateTextToImageCommandApiCommand.Create());
                         command.Subcommands.Add(CreateTextToVideoCommandApiCommand.Create());
                         command.Subcommands.Add(CreateWatermarkFreeUrlCommandApiCommand.Create());
                         command.Subcommands.Add(GetCreationDetailCommandApiCommand.Create());
                         command.Subcommands.Add(GetCreationStatusCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}