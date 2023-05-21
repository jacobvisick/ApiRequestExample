using ApiRequestExample.Models;

namespace ApiRequestExample.Services.Interfaces
{
    public interface IAnimalFactsService
    {
        Task<List<AnimalFact>> GetAnimalFacts(int count);
    }
}
