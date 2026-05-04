namespace Haiper.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HaiperClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HAIPER_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("HAIPER_API_KEY environment variable is not found.");

        var client = new HaiperClient(apiKey);
        
        return client;
    }
}
