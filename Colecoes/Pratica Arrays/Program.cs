﻿Console.WriteLine("## Exercicios ##");

// criar os arrays
string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("### Alunos ###");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

foreach (string nome in nomes)
{
    Console.Write($"{nome} ");
}

var somaNotas = 0.0;
var totalNotas = notas.Count();

foreach (double nota in notas)
{
    somaNotas = somaNotas + nota;
    Console.Write($"{nota} ");
}

Console.WriteLine($"\nMédia Aritmética : \n {somaNotas/totalNotas}");

Console.ReadKey();