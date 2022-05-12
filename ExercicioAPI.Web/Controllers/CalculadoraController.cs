using Microsoft.AspNetCore.Mvc;
namespace ExercicioAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    public static List<Pessoa> PessoaDaClasse { get; set; } = new List<Pessoa>();

    [HttpPost()]
    public IActionResult SetPessoa(Pessoa pessoa)
    {
    PessoaDaClasse.Add(pessoa);
    return Ok(PessoaDaClasse);
    }
}

