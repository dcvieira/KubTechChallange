using KubTechChallange.Catalog.Model;

namespace KubTechChallange.Catalog.Repositories;

public interface IConcertRepository
{
  IEnumerable<Concert> GetConcerts();
  Task<Concert> GetConcertById(Guid concertId);
}
