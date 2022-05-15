using ExercicioAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace ExercicioAPI.Web.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("Somar")]
    public IActionResult Somar(double valor1, double valor2)
    {
        {
            try
            {
                var calc = new Calculadora();
                var resultado = calc.Somar(valor1, valor2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

    [HttpGet("Subtrair")]
    public IActionResult Subtrair(double valor1, double valor2)
    {
        {
            try
            {
                var calc = new Calculadora();
                var resultado = calc.Subtrair(valor1, valor2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

    [HttpGet("Dividir")]
    public IActionResult Dividir(double valor1, double valor2)
    {
        {
            try
            {
                var calc = new Calculadora();
                var resultado = calc.Dividir(valor1, valor2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


    [HttpGet("Multiplicar")]
    public IActionResult Multiplicar(double valor1, double valor2)
    {
        {
            try
            {
                var calc = new Calculadora();
                var resultado = calc.Multiplicar(valor1, valor2);
                return Ok(resultado);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

