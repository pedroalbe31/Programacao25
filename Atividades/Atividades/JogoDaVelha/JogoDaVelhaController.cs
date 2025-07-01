using Microsoft.AspNetCore.Mvc;

namespace JogoDaVelha
{
    public class JogoDaVelhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
