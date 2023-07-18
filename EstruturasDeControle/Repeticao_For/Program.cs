Console.WriteLine("## Laço For ##");
// for executa um bloco de instruções repetidamente até que a condição especificada retorne false.

int resultado, numero;
Console.WriteLine("Informe o número inteiro maior que zero: \t");
numero = Convert.ToInt32(Console.ReadLine());
if (numero > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.ReadKey();

// loop for com 2 inicialização e 2 incremento

for (int i = 0, j = 0; i + j <= 20; i++, j++)
{
    Console.WriteLine($"i = {i} e j = {j}");
}

Console.ReadKey();

// for dentro de for 
// for dentro de for 

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y})");
    }
    Console.WriteLine();
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
