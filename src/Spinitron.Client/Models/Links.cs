namespace Spinitron.Client.Models;

[UsedImplicitly]
public record Link(Uri Href);

[UsedImplicitly]
public record PlaylistLinks(Link Self, Link Persona, Link Show, Link Spins);

[UsedImplicitly]
public record ShowLinks(Link Self, Link[] Personas, Link Playlists);

[UsedImplicitly]
public record SpinLinks(Link Self, Link Playlist);

[UsedImplicitly]
public record ListingLinks(Link Self, Link First, Link? Last, Link? Next);