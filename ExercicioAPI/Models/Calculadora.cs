namespace ExerAPI.APIExercicio.Web;

class Calculadora
{
    public static newCalculadora()
    {
        double numero1, numero2, resultado = 0.0f;
        string operador;

        Console.WriteLine("Digite o primeiro número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a operação desejada + - * /: ");
        operador = (Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        if (operador == "+")
        {
            resultado = numero1 + numero2;
        }
        else if (operador == "-")
        {
            resultado = numero1 - numero2;
        }
        else if (operador == "*")
        {
            resultado = numero1 * numero2;
        }
        else if (operador == "/")
        {
            resultado = numero1 / numero2;
        }
        Console.WriteLine("O resultado é: " + resultado);
    }
}