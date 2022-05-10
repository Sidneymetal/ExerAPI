using Microsoft.AspNetCore.Mvc;
namespace ExercicioAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("Somar")]
    public IActionResult Adicao(double numero1, double numero2)
    {
        if(numero1 < 1000 & numero2 < 1000)
        {
            return Ok(numero1 + numero2);            
        }
        return BadRequest("O número não pode ser maior do que 999.");
        
    }
    [HttpGet("Subtrair")]
    public double Subtracao(double numero1, double numero2)
    {
        return numero1 - numero2;
    }
    [HttpGet("Multiplicar")]
    public double Multiplicacao(double numero1, double numero2)
    {
        return numero1 * numero2;
    }
    [HttpGet("Dividir")]
    public double Divisao(double numero1, double numero2)
    {
        return numero1 / numero2;
    }
}

