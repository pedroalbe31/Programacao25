using System.Diagnostics;
using System.Diagnostics.Contracts;
using Aula03.Models;
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
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string GetIf(int x)
        {
            /*
                Estrutura sintática do IF
                if(expressão boleana)
                    {
                        Sentença de código a ser executada, caso a condição seja verdadeira
                    }

                Caso o If tenha apenas uma linha de comando a ser executada na condicional, não há necessidade
                do uso das chaves.
                if(expressão boleana)
                    Apenas um comando
             */
        
            string retorno = string.Empty;
            //int x = 10;

            if (x < 9)
                retorno =  "x é maior que 9";

            //x = 8;
            if (x > 9)
                retorno = "x é maior que 9";
            else
                retorno = "x é menor que 9";

           //x = 11;

            if (x == 10)
            {
                retorno = "Ora ora ";
                retorno += "X é igual a 10";
            }
            else if (x == 9)
            {
                retorno = "Hummmm";
                retorno += "X é igual a 9";
            }
            else if (x == 8)
            {
                retorno = "Bahhhh";
                retorno += "X é igual a 8 tchê";
            }
            else
            {
                retorno = "Sei lá que número é X";
            }

                return retorno;
        }

        [HttpGet]
        public string GetSwitch(int x)
        {
            string retorno = string.Empty;

            switch (x)
            {
                case 0:
                    retorno = "x é zero"; 
                    break;
                case 1:
                    retorno = "x é um";
                    break;
                case 2:
                    retorno = "x é dois";
                    break;
                case 3:
                    retorno = "x é três";
                    break;
                default:
                    retorno = "x é algum número não previsto";
                    break;
            }

            return retorno;
        }

        [HttpGet]
        public string GetFor(int x)
        {
            /*
             O comando de repetição FOR, possui a seguinto sintaxe:
            for( <inicializador>; expressão condicional; <expressão de repetição>)
            {
                comandos a serem executados
            }
            Inicializador: elemento contador . Tradicionalmente utilizado o i = indíce;
            Expressão condicional: especifica o teste a ser verificado quando o loop estiver executado o número definido de interações (flag);
            Expressão de repetição: especifica a ação a ser executada com a variável contadora (contador).
            Geralmente um acúmulo ou decrécimo (acumulador);
             */

            string retorno = string.Empty;

            for (int i = 1; i <= x; i++)
            {
                // E se eu quisesse interromper o laço?
                // Caso ele fosse maior que 50
                if (i > 50)
                    break; // O comando break interrompe o laço

                // Caso eu deseje que o laço siga em frente
                // Forçando a continuar a execução
                if ((i % 2) != 0)
                    continue;


                retorno += $"{i}; ";            
            }
            return retorno;
        }

        [HttpGet]
        public string GetForeach(string color)
        {
            /*
                o comando foreach (para cada) é utilizado para    
                iterar por uma sequência de items em uma coleção
                e servir como uma opção simples de repetição.
            */
            string[] colors = { "Vermelho", "Preto", "Azul", "Amarelo", "Verde", "Branco", "Azul-Marinho", "Rosa", "Roxo", "Cinza" };

            string retorno = string.Empty;

            if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1)))
                retorno = "A cor escolhida é válida";
            else
                retorno =  "Cor escolhida inválida";

            foreach (string s in colors)
            {
                retorno += $" [{s}]";         
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
