using System.Net.Http.Json;
using Flurl;
using Microsoft.Extensions.Logging;
using Spinitron.Client.Converters;
using Spinitron.Client.Http.Inputs;
using Spinitron.Client.Models;

namespace Spinitron.Client.Http;

public class SpinitronClient(HttpClient client, ILogger<SpinitronClient> logger) : ISpinitronClient
{
    private async Task<T> Get<T>(string endpoint, Dictionary<string, object?>? queryParams = null)
    {
        
        var serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        };
        serializerOptions.Converters.Add(new DateTimeOffsetConverterUsingDateTimeParse());
        var uri = endpoint.SetQueryParams(queryParams);
        var response = await client.GetAsync(uri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>(serializerOptions) ?? throw new InvalidOperationException();
    }
    
    public Task<Listing<Playlist>> Playlists(PlaylistParams? options = null) => Get<Listing<Playlist>>("playlists", options?.ToDictionary());

    public Task<Listing<Spin, SpinsMeta>> Spins(SpinParams? options = null) => Get<Listing<Spin, SpinsMeta>>("spins", options?.ToDictionary());
    public Task<Listing<Show>> Shows() => Get<Listing<Show>>("shows");
}