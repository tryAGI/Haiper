#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Haiper.CLI.Commands;

internal static partial class CreateKeyframeConditioningCommandApiCommand
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

    private static Option<global::Haiper.KeyframeConditioningRequestConfig> Config { get; } = new(
        name: @"--config")
    {
        Description = @"",
        Required = true,
    };
    private static readonly VideoSettingsOptionSet SettingsOptions = VideoSettingsOptionSet.Create(@"settings");
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
        var command = new Command(@"create-keyframe-conditioning", @"Create a Haiper 2.x keyframe-conditioned video from multiple images.");
                        command.Options.Add(IsPublic);
                        command.Options.Add(Prompt);
                        command.Options.Add(NegativePrompt);
                        command.Options.Add(Config);                        command.Options.Add(SettingsOptions.Seed);
                        command.Options.Add(SettingsOptions.AspectRatio);
                        command.Options.Add(SettingsOptions.Duration);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Haiper.KeyframeConditioningRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Haiper.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : (__requestBase is { } __IsPublicBaseValue ? __IsPublicBaseValue.IsPublic : default);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var negativePrompt = CliRuntime.WasSpecified(parseResult, NegativePrompt) ? parseResult.GetValue(NegativePrompt) : (__requestBase is { } __NegativePromptBaseValue ? __NegativePromptBaseValue.NegativePrompt : default);
                        var config = parseResult.GetRequiredValue(Config);

                        var __SettingsBase = __requestBase is { } __SettingsBaseValue ? __SettingsBaseValue.Settings : default;                        var settingsSeed = CliRuntime.WasSpecified(parseResult, SettingsOptions.Seed) ? parseResult.GetValue(SettingsOptions.Seed) : (__SettingsBase is { } __SettingsseedBaseValue ? __SettingsseedBaseValue.Seed : default);
                        var settingsAspectRatio = CliRuntime.WasSpecified(parseResult, SettingsOptions.AspectRatio) ? parseResult.GetValue(SettingsOptions.AspectRatio) : (__SettingsBase is { } __SettingsaspectRatioBaseValue ? __SettingsaspectRatioBaseValue.AspectRatio : default);
                        var settingsDuration = CliRuntime.WasSpecified(parseResult, SettingsOptions.Duration) ? parseResult.GetValue(SettingsOptions.Duration) : (__SettingsBase is { } __SettingsdurationBaseValue ? __SettingsdurationBaseValue.Duration : default);
                        var __SettingsSpecified = CliRuntime.WasSpecified(parseResult, SettingsOptions.Seed) || CliRuntime.WasSpecified(parseResult, SettingsOptions.AspectRatio) || CliRuntime.WasSpecified(parseResult, SettingsOptions.Duration);
                        var settings =
                            __SettingsSpecified || __SettingsBase is not null
                                ? new global::Haiper.VideoSettings
                                {
	                                Seed = settingsSeed,
                                AspectRatio = settingsAspectRatio,
                                Duration = settingsDuration,

                                }
                                : __SettingsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateKeyframeConditioningAsync(
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