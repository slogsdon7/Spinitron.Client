namespace Spinitron.Client.Models;

[UsedImplicitly]
public record Show(
    int Id,
    DateTimeOffset Start,
    DateTimeOffset End,
    int Duration,
    string Timezone,
    bool OneOff,
    string Category,
    string Title,
    string Description,
    int? Since,
    string Url,
    int HideDj,
    string Image
)
{
    [JsonPropertyName("_links")]
    public required ShowLinks Links { get; init; }
}