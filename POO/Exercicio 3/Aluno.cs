namespace Exercicio_3;

public class Aluno : Pessoa
{
    public Aluno(string Nome) : base(Nome)
    {
        this.Nome = Nome;
    }
    public void Estudar()
    {
        Console.WriteLine("Estudando...");
    }

}
