using KubTechChallange.Frontend.Extensions;
using KubTechChallange.Frontend.Models.Api;

namespace KubTechChallange.Frontend.Services;

public class ConcertCatalogService : IConcertCatalogService
{
    private readonly HttpClient client;

    public ConcertCatalogService(HttpClient client)
    {
        this.client = client;
    }

    public async Task<IEnumerable<Concert>> GetAll()
    {
        HttpResponseMessage response = await client.GetAsync("concert");
        return await response.ReadContentAs<List<Concert>>();
    }

    public async Task<Concert> GetConcert(Guid id)
    {
        HttpResponseMessage response = await client.GetAsync($"concert/{id}");
        return await response.ReadContentAs<Concert>();
    }
}
