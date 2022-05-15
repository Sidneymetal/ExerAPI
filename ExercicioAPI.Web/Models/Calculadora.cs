using ExercicioAPI.Web.Models;

namespace ExercicioAPI.Models;
public class Calculadora
{
    public double Somar(double numero1, double numero2)
    {
        if (ValidarNumero(numero1) && ValidarNumero(numero2))
        {
            return numero1 + numero2;
        }
        throw new InputIncorreto("Esse número é inválido.");
    }
    public double Subtrair(double numero1, double numero2)
    {
        if (ValidarNumero(numero1) && ValidarNumero(numero2))
        {
            return numero1 - numero2;
        }
        throw new InputIncorreto("Esse número é inválido.");
    }

    public double Dividir(double numero1, double numero2)
    {
        if (ValidarNumero(numero1) && ValidarNumero(numero2) && ValidarMenorZero(numero1) && ValidarMenorZero(numero2))
        {
            return numero1 / numero2;
        }
        throw new InputIncorreto("Esse número é inválido.");
    }
    public double Multiplicar(double numero1, double numero2)
    {
        if (ValidarNumero(numero1) && ValidarNumero(numero2) && ValidarMenorZero(numero1) && ValidarMenorZero(numero2))
        {
            return numero1 * numero2;
        }
        throw new InputIncorreto("Esse número é inválido.");
    }
    public bool ValidarNumero(double valor)
    {
        if (valor != 0 & valor < 1000)
            return true;
        return false;
    }
    public bool ValidarMenorZero(double valor)
    {
        if (valor > 0)
            return true;
        return false;
    }
}
