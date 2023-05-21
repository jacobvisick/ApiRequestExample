using ApiRequestExample.Models;
using ApiRequestExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApiRequestExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnimalFactsService _factsService;

        public HomeController(ILogger<HomeController> logger,
                              IAnimalFactsService factsService)
        {
            _logger = logger;
            _factsService = factsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AnimalFacts()
        {
            List<AnimalFact> facts = await _factsService.GetAnimalFacts(3);
            return View(facts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}