Console.WriteLine("## Tipos Anonimos ##");

var aluno = new
{
    Nome = "Maria",
    Idade = 43
};

Console.WriteLine(aluno.Nome + " " + aluno.Idade);

var aluno2 = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "jairo@email.com",
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};

Console.WriteLine(aluno2.Nome);
Console.WriteLine(aluno2.Endereco.Cidade);

var alunos = new[]
{
    new {id = 1, Nome = "Maria", Email = "maria@email.com"},
    new {id = 2, Nome = "Sonia", Email = "sonia@email.com"},
    new {id = 3, Nome = "Bruno", Email = "bruno@email.com"}
};

Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);











Console.ReadKey();
