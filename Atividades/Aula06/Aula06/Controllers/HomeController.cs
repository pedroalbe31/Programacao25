using System.Diagnostics;
using Aula06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public class Animal 
        { 
            public int Id { get; set; }
            public string Name { get; set; }
            public string Especie { get; set; }
            public string Raca { get; set; }
            public DateTime DataNascimento { get; set; }
        
        
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
