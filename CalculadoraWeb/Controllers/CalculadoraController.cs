using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora_Teste_Automatizado.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {

        [HttpGet("sum/a={valor1}&b={valor2}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult SomarWeb(double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();

            double resultado = calculadora.Somar(valor1, valor2);


            
            return Ok("Valor da Soma = " + resultado.ToString());
        }


        [HttpGet]
        public string Get()
        {
            return "Para fazer funciona tem que colocar o endpoint igual api/myapp/sum/a={valor1}&b={valor2} na URL";
        }
    }
}
