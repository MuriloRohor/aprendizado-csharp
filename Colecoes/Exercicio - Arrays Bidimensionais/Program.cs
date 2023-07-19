Console.WriteLine("## Exercícios Arrays Bidimensionais ##");


// alocando memoria para o array
string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
	for (int j = 0; j < alunos.GetLength(1); j++)
	{
        Console.WriteLine($"Informe o nome do aluno na posição [{i},{j}]: ");
        string? aluno = Console.ReadLine();
        alunos[i, j] = aluno;
        Console.WriteLine($"Aluno : {aluno} = posição {i},{j}");
    }
}

Console.WriteLine("\n# Alunos #\n");
ExibirAlunos(alunos);

Console.ReadKey();

static void ExibirAlunos(string[,] alunos)
{
    int count = 1;
    foreach (var nome in alunos)
    {
        if (count > 5 && count < 7)
            Console.Write("\n");
        Console.Write($"{nome}, ");
        count++;
    }
}