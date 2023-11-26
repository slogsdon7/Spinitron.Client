namespace Spinitron.Client.Models;

[UsedImplicitly]
public record SpinsMeta
{
    [JsonPropertyName("CurrentPage")]
    public int CurrentPage { get; init; } 
    [JsonPropertyName("PerPage")]
    public int PerPage { get; init; }
}

[UsedImplicitly]
public record Meta
{
    [JsonPropertyName("TotalCount")] public int TotalCount { get; init; }
    [JsonPropertyName("PageCount")] public int PageCount { get; init; }
    [JsonPropertyName("CurrentPage")] public int CurrentPage { get; init; }
    [JsonPropertyName("PerPage")] public int PerPage { get; init; }
}