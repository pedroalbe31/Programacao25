using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeekDay.Models;

namespace WeekDay.Controllers
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

		public int [] Array = new int[5];
        string[] WeekDays = ["segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo"];
		public string GetSwitch(int x)
		{

			string retorno = string.Empty;

			if (x == 0) {
				retorno = "Domingo";
			}
			if (x == 0) {
				retorno = "Segunda";
			}
			if (x == 0) {
				retorno = "Terça";
			}
			if (x == 0) {
				retorno = "Quarta";
			}
			if (x == 0) {
				retorno = "Quinta";
			}
			if (x == 0) {
				retorno = "Sexta";
			}
			if (x == 0) {
			retorno = "Sabado";
			}

			else{
				retorno = "Dia inválido";
			}
			return retorno;
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
