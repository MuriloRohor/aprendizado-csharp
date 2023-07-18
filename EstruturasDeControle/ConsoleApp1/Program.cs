Console.WriteLine("## Instrução if-ekse-if  ##\n");

Console.WriteLine("\nInforme a nota do aluno\t");

double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em Recuperação");
}
else if (nota >= 6 && nota <=9)
{
    Console.WriteLine("Aluno Aprovado");
}
else if (nota > 9)
{
    Console.WriteLine("Aluno Aprovado com Distinção");
}

Console.WriteLine("\n Fim do Processamento...");

Console.ReadKey();
