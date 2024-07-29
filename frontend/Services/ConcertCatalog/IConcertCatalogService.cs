using KubTechChallange.Frontend.Models.Api;

namespace KubTechChallange.Frontend.Services;

public interface IConcertCatalogService
{
    Task<IEnumerable<Concert>> GetAll();

    Task<Concert> GetConcert(Guid id);

}
