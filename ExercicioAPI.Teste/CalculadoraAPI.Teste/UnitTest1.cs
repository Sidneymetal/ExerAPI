using Xunit;
using ExercicioAPI.Models;
namespace CalculadoraAPI.Teste;

public class CalculadoraTest
{
    [Fact]
    public void TestarASomaSomaDeDoisMaisDoisIgualAQuatro()
    {
        var calc = new Calculadora();
        var esperado = 4;
        var resultado = calc.Somar(2, 2);
        Assert.Equal(esperado, resultado); 
    }
}