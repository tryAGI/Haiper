#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Haiper.CLI.Commands;

internal static partial class CreateWatermarkFreeUrlCommandApiCommand
{
    private static Argument<string> CreationId { get; } = new(
        name: @"creation-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Haiper.WatermarkFreeUrl value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Haiper.WatermarkFreeUrl value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-watermark-free-url", @"Create a watermark-free URL for a video creation.");
                        command.Arguments.Add(CreationId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var creationId = parseResult.GetRequiredValue(CreationId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateWatermarkFreeUrlAsync(
                                    creationId: creationId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Haiper.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}