Console.WriteLine("## Construtores ##");

Aluno aluno = new Aluno("Moises", 32, "Masculino", "S");

//operador (condição ? expressão1_se_true : expressão_se_false)
Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadKey();

public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
