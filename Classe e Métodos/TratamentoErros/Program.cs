﻿Console.WriteLine("## Tratamento de Erros ##");

Console.WriteLine("X / Y");

Console.WriteLine("Informe o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());


try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");
    Console.WriteLine($"\n Erro: <<< {ex.Message} >>>");
    Console.WriteLine($"\n Detalhes: {ex?.StackTrace}");
}
finally
{
    Console.WriteLine("Processamento Concluído...");
}


Console.ReadKey();
