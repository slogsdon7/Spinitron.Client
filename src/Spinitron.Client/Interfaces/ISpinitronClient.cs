using Spinitron.Client.Http.Inputs;
using Spinitron.Client.Models;

namespace Spinitron.Client.Interfaces;

public interface ISpinitronClient
{
    Task<Listing<Playlist>> Playlists(PlaylistParams? options = null);
    Task<Listing<Spin, SpinsMeta>> Spins(SpinParams? options = null);

    Task<Listing<Show>> Shows();
}