using Microsoft.AspNetCore.Mvc;
using KubTechChallange.Catalog.Repositories;
using KubTechChallange.Catalog.Model;

namespace KubTechChallange.Catalog.Controllers;

[ApiController]
[Route("[controller]")]
public class ConcertController : ControllerBase
{
    private readonly IConcertRepository concertRepository;
    private readonly ILogger<ConcertController> logger;

    public ConcertController(IConcertRepository repository, ILogger<ConcertController> logger)
    {
        concertRepository = repository;
        this.logger = logger;
    }

    [HttpGet(Name = "GetConcerts")]
    public  IEnumerable<Concert> GetAll()
    {
      return concertRepository.GetConcerts();
    }

    [HttpGet("{id}", Name = "GetById")]
    public async Task<Concert> GetById(Guid id)
    {
        return await concertRepository.GetConcertById(id);
    }
}
