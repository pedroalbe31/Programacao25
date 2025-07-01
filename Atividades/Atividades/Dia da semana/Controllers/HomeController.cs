using System.Diagnostics;
using Dia_da_semana.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }               

        

        [HttpGet]
        public string GetDayOfWeek(int day)
        {
            string retorno;

            switch (day)
            {
                case 0:
                    retorno = "Domingo";
                    break;
                case 1:
                    retorno = "Segunda-feira";
                    break;
                case 2:
                    retorno = "Terça-feira";
                    break;
                case 3:
                    retorno = "Quarta-feira";
                    break;
                case 4:
                    retorno = "Quinta-feira";
                    break;
                case 5:
                    retorno = "Sexta-feira";
                    break;
                case 6:
                    retorno = "Sábado";
                    break;
                default:
                    retorno = "Número inválido. Por favor, insira um número de 0 a 6.";
                    break;
            }

            return retorno;
        }

        public IActionResult Index()
        {
            return View();
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