using Microsoft.AspNetCore.Mvc;
namespace ExercicioAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("Somar")]
    public double Adicao(double numero1, double numero2)
    {
        return numero1 + numero2;
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

