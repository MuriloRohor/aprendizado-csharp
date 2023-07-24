using Exercicio___List;
using System.Diagnostics;

Console.WriteLine("## Exercício List<T> ##\n");

// Dada uma classe Aluno definida com duas propriedas:
// 1- Nome do tipo string
// 2- Nota do tipo Double

// Crie uma lista de objetos do tipo Aluno usando a coleção List<T> com os seguintes dados que representam o nome e a nota do aluno
// Maria - 8.75, Manoel - 6.95, Amanda - 7.25, Carlos - 6.55, Jaime - 8.50, Debora - 5.95, Alicia - 9.25
// Sandra - 5.55, Marta - 7.85, Sueli - 9.15

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);

var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

//alunos.Sort();
var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();
ExibirAlunos(listaOrdenada);

var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine("\nAlunos com nota maior que 8\n");
ExibirAlunos(alunosNotaOito);



Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de alunos\n");
    Console.WriteLine("\nNome\tNota");
    double somaNotas = 0.0;

    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Nota}");
        somaNotas += item.Nota;
    }

    double mediaNotas = somaNotas / alunos.Count;
    Console.WriteLine($"\nMédia das notas : {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos : {alunos.Count}");
}