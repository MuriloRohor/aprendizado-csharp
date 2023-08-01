namespace Exercicio_3;

public class Professor : Pessoa 
{
    public Professor(string Nome) : base(Nome)
    {
        this.Nome = Nome;
    }

    public void Explicar()
    {
        Console.WriteLine("Explicando...");
    }
}
