#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Haiper.CLI.Commands;

internal static partial class CreateTextToImageCommandApiCommand
{
    private static Option<bool?> IsPublic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-public",
        description: @"");

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> NegativePrompt { get; } = new(
        name: @"--negative-prompt")
    {
        Description = @"",
    };

    private static Option<global::Haiper.TextToImageRequestConfig?> Config { get; } = new(
        name: @"--config")
    {
        Description = @"",
    };

    private static Option<global::Haiper.ImageSettings?> Settings { get; } = new(
        name: @"--settings")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Haiper.NewCreation value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Haiper.NewCreation value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-text-to-image", @"Create a Haiper 2.x text-to-image generation.");
                        command.Options.Add(IsPublic);
                        command.Options.Add(Prompt);
                        command.Options.Add(NegativePrompt);
                        command.Options.Add(Config);
                        command.Options.Add(Settings);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Haiper.TextToImageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Haiper.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : __requestBase is not null ? __requestBase.IsPublic : default;
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var negativePrompt = CliRuntime.WasSpecified(parseResult, NegativePrompt) ? parseResult.GetValue(NegativePrompt) : __requestBase is not null ? __requestBase.NegativePrompt : default;
                        var config = CliRuntime.WasSpecified(parseResult, Config) ? parseResult.GetValue(Config) : __requestBase is not null ? __requestBase.Config : default;
                        var settings = CliRuntime.WasSpecified(parseResult, Settings) ? parseResult.GetValue(Settings) : __requestBase is not null ? __requestBase.Settings : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTextToImageAsync(
                                    isPublic: isPublic,
                                    prompt: prompt,
                                    negativePrompt: negativePrompt,
                                    config: config,
                                    settings: settings,
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