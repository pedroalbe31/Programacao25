using Microsoft.AspNetCore.Mvc;

namespace Atividade1703.Controllers
{
    public class Result
    {
        public int numero { get; set; }
    }

    public class AtividadeController : Controller
    {

        [HttpGet]
        public IActionResult convertoNumber()
        {
            return View("Index", new Result());
        }

        [HttpPost]
        public IActionResult Index1()
        {
            Result numero = new Result();
            return View("Index", numero);
        }

        private static string Convertor(int numero, string )
        {
            if (numero == 0)
            {
                return "zero";

                string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
                string[] dezenas = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sesssenta", "setenta", "oitenta", "noventa" };
                string[] centenas = { "", "cem", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };


                string texto = "";
                if (numero >= 1000)
                {
                    texto += unidades[numero / 1000] + "mil";
                    numero %= 1000;
                }
                if (numero >= 100) { }

            }
        }

    }
}