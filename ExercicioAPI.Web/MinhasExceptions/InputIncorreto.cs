namespace ExercicioAPI.Web.Models;
public class InputIncorreto : Exception
{
    public InputIncorreto()
    {

    }
    public InputIncorreto(string msg) : base(msg)
    {

    }
}