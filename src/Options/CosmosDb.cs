namespace Cosmos.Copilot.Options;

public record CosmosDb
{
    public required string Endpoint { get; init; }

    public required string Database { get; init; }

    public required string ChatContainer { get; init; }

    public required string CacheContainer { get; init; }
};