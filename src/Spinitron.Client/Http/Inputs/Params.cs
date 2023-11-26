namespace Spinitron.Client.Http.Inputs;

public interface IQueryParams
{
    Dictionary<string, object?> ToDictionary();
}
public abstract record BaseParams : IQueryParams
{
    public DateTimeOffset? Start { get; init; }
    public DateTimeOffset? End { get; init; }
    public long Count { get; init; } = 200;
    public long Page { get; init; } = 1;

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            ["start"] = Start,
            ["end"] = End,
            ["count"] = Count,
            ["page"] = Page
        };
    }
}


[UsedImplicitly]
public record PlaylistParams : BaseParams
{
    public long? ShowId { get; init; }
    public long? PersonaId { get; init; }

    public new Dictionary<string, object?> ToDictionary()
    {
        var dict = base.ToDictionary();
        dict.Add("show_id",ShowId);
        dict.Add("persona_id",PersonaId);
        return dict;
    }
}

public record SpinParams : BaseParams
{
    public long? PlaylistId { get; init; }
    public long? ShowId { get; init; }
    
    public new Dictionary<string, object?> ToDictionary()
    {
        var dict = base.ToDictionary();
        dict.Add("show_id",ShowId);
        dict.Add("playlist_id", PlaylistId);
        return dict;
    }
    
}