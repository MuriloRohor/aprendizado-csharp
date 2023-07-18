Console.WriteLine("Construtores");

Aluno aluno = new Aluno(15, "Masculino", "s");

//operador (condição ? expressão1_se_true : expressão_se_false)
Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


class Aluno
{
    public Aluno(string nome) => Nome = nome;// 1º Construtor - Com 1 parâmetro

    public Aluno(int idade, string sexo, string aprovado) // 2º Construtor - Com 3 parâmetros
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}   
