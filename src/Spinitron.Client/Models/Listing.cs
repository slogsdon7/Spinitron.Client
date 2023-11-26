namespace Spinitron.Client.Models;

[UsedImplicitly]
public record Listing<T, TMeta>
{
    public required T[] Items { get; [UsedImplicitly] init; }
    [JsonPropertyName("_links")]
    public required ListingLinks ListingLinks { get; [UsedImplicitly] init; }
    [JsonPropertyName("_meta")]
    public required TMeta Meta { get; [UsedImplicitly] init; }
}

[UsedImplicitly]
public record Listing<T> : Listing<T, Meta>;