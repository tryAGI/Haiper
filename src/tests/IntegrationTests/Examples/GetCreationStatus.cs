/*
order: 20
title: Get creation status
slug: get-creation-status

Check the status of an existing Haiper creation.
*/

namespace Haiper.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetCreationStatus()
    {
        using var client = GetAuthenticatedClient();

        var creationId =
            Environment.GetEnvironmentVariable("HAIPER_CREATION_ID") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("HAIPER_CREATION_ID environment variable is not found.");

        var response = await client.GetCreationStatusAsync(creationId);

        response.Status.Should().NotBeNullOrWhiteSpace();
    }
}
