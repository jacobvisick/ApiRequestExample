using ApiRequestExample.Models;
using ApiRequestExample.Services.Interfaces;
using System.Net.Http.Headers;

namespace ApiRequestExample.Services
{
    /*
     * For reference:
     * https://alexwohlbruck.github.io/cat-facts/docs/endpoints/facts.html
     */

    public class AnimalFactsService : IAnimalFactsService
    {
        // this is the object that will send/receive our requests to the API
        private readonly HttpClient _httpClient;

        // this is the base URL of the API, and we'll request a specific endpoint later
        private static readonly string _baseUrl = "https://cat-fact.herokuapp.com";

        public AnimalFactsService()
        {
            // instantiate the HttpClient
            _httpClient = new HttpClient();

            // and add "application/json" to our headers so that we accept JSON responses
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // We will send a GET request to their facts endpoint, i.e.
        // GET /facts/random?animal_type=cat&amount=2
        public async Task<List<AnimalFact>> GetAnimalFacts(int count)
        {
            // this is the URL where we'll be retrieving data from
            string endpointUrl = $"{_baseUrl}/facts/random?animal_type=cat&amount={count}";

            // send the request and receive a response
            HttpResponseMessage response = await _httpClient.GetAsync(endpointUrl);

            try
            {
                // You can look at your the console/output terminal to see the JSON we got from the API
                // Not at all required, but maybe helpfulk while you're testing
                Console.WriteLine(await response.Content.ReadAsStringAsync());

                // parse the response into our Model
                List<AnimalFact>? animalFacts = await response.Content.ReadFromJsonAsync<List<AnimalFact>>();

                return animalFacts ?? new(); // return an empty list if animalFacts is null for some reason
            }
            catch (Exception ex)
            {
                /* 
                 * if the JSON doesn't match the model, we'll get an exception thrown!
                 * this catch block allows you to log the error or something instead of
                 * blowing up the app 
                 */
                
                return new List<AnimalFact>();
                throw;
            }
        }

        // the same code as above, but with no comments in case it's easier to read
        public async Task<List<AnimalFact>> GetAnimalFactsWithoutTheComments(int count)
        {
            string endpointUrl = $"{_baseUrl}/facts/random?animal_type=cat&amount={count}";
            HttpResponseMessage response = await _httpClient.GetAsync(endpointUrl);

            try
            {
                List<AnimalFact>? animalFacts = await response.Content.ReadFromJsonAsync<List<AnimalFact>>();
                return animalFacts ?? new();
            }
            catch (Exception)
            {
                return new List<AnimalFact>();
                throw;
            }
        }
    }
}
