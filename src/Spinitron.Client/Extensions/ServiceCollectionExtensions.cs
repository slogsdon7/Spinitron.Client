using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;

namespace Spinitron.Client.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSpinitronClient(this IServiceCollection services, string token)
    {
        services.AddHttpClient<ISpinitronClient, SpinitronClient>(c =>
        {
            c.BaseAddress = new Uri("https://spinitron.com/api/");
            c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        });
        return services;
    }
}