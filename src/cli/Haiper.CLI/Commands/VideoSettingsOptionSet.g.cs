#nullable enable

using System.CommandLine;

namespace Haiper.CLI.Commands;

internal sealed record VideoSettingsOptionSet(
    Option<long?> Seed,
                     Option<global::Haiper.VideoSettingsAspectRatio?> AspectRatio,
                     Option<int?> Duration)
{
    public static VideoSettingsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new VideoSettingsOptionSet(
                        Seed: new Option<long?>($"--{normalizedPrefix}seed")
                {
                    Description = @"",
                },
                AspectRatio: new Option<global::Haiper.VideoSettingsAspectRatio?>($"--{normalizedPrefix}aspect-ratio")
                {
                    Description = @"",
                },
                Duration: new Option<int?>($"--{normalizedPrefix}duration")
                {
                    Description = @"",
                }
        );
    }
}