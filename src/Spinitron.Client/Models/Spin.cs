// ReSharper disable InconsistentNaming
namespace Spinitron.Client.Models;

[UsedImplicitly]
public record Spin
{
    public long Id { get; init; }
    public long PlaylistId { get; init; }
    public DateTimeOffset Start { get; init; }
    public DateTimeOffset? End { get; init; }
    public int? Duration { get; init; }
    [JsonPropertyName("timezone")] public required string TimeZone { get; init; }
    public string? Image { get; init; }
    public bool Classical { get; init; }
    public required string Artist { get; init; }
    public string? Composer { get; init; }
    public required string Release { get; init; }
    public int? Released { get; init; }
    public DateTimeOffset? Added { get; init; }
    public string? Medium { get; init; }
    public bool VA { get; init; }
    public string? Label { get; init; }
    public required string Song { get; init; }
    public string? Note { get; init; }
    public bool? Request { get; init; }
    public bool? Local { get; init; }
    public bool? New { get; init; }
    public string? Genre { get; init; }
    public string? Work { get; init; }
    public string? Conductor { get; init; }
    public string? Performers { get; init; }
    public string? Ensemble { get; init; }
    [JsonPropertyName("catalog-number")] 
    public string? CatalogNumber { get; init; }
    public string? ISRC { get; init; }
    public string? UPC { get; init; }
    public string? ISWC { get; init; }
    [JsonPropertyName("_links")] 
    public required SpinLinks Links { get; init; }
}