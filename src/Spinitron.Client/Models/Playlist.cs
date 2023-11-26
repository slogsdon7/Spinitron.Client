// ReSharper disable UnusedMember.Global
namespace Spinitron.Client.Models;


[UsedImplicitly]
public record Playlist
{
    public long Id { get; init; }
    public long PersonaId { get; init; }
    public long? ShowId { get; init; }
    public DateTimeOffset Start { get; init; } 
    public DateTimeOffset End { get; init; }
    public int Duration { get; init; }
    public required string Timezone { get; init; }
    public required string Category { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
    public int? Since { get; init; }
    public required string Url { get; init; }
    public required int HideDj { get; init; }
    public string? Image { get; init; }
    public int Automation { get; init; }
    public string? EpisodeName { get; init; }
    public string? EpisodeDescription { get; init; }
    [JsonPropertyName("spinsCount")]
    public string? SpinsCount { get; init; }

    [JsonPropertyName("_links")]
    public required PlaylistLinks Links { get; init; }

}