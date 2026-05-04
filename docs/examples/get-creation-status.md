# Get creation status

Check the status of an existing Haiper creation.

This example assumes `using Haiper;` is in scope and `apiKey` contains your Haiper API key.

```csharp
using var client = new HaiperClient(apiKey);

var creationId =
    Environment.GetEnvironmentVariable("HAIPER_CREATION_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException("HAIPER_CREATION_ID environment variable is not found.");

var response = await client.GetCreationStatusAsync(creationId);
```