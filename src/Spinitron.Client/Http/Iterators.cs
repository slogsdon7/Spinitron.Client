using Microsoft.Extensions.Logging;
using Spinitron.Client.Http.Inputs;
using Spinitron.Client.Models;

namespace Spinitron.Client.Http;

public static class Iterators
{
    public static async IAsyncEnumerable<Playlist> AllPlaylists(this ISpinitronClient client, PlaylistParams parameters)
    {
        bool hasNext;
        do {
            var result = await client.Playlists(parameters);
            hasNext = result.ListingLinks.Next is not null;
            foreach (var playlist in result.Items)
                yield return playlist;
            parameters = parameters with { Page = result.Meta.CurrentPage + 1 };
            Thread.Sleep(1000);
        } while (hasNext);
    }

    public static async IAsyncEnumerable<Spin> AllSpins(this ISpinitronClient client, SpinParams? parameters = null, ILogger? logger = null)
    {
        parameters ??= new SpinParams();
        bool hasNext;
        do
        {
            var result = await client.Spins(parameters);
            logger?.LogInformation("Got {Count} spins", result.Items.Length);
            hasNext = result.Items.Length > 0;
            foreach (var spin in result.Items)
            {
                yield return spin;
            }
            parameters = parameters with { Page = parameters.Page + 1 };
            Thread.Sleep(800);
        } while (hasNext);
    }
}