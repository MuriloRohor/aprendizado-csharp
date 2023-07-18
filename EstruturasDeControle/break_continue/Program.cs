Console.WriteLine("break e continue");

// instrução break

for (; ; )
{
    Console.WriteLine("Tecle algo (X sai)");
    var opcao = Console.ReadLine();

    Console.WriteLine(opcao?.ToUpper());

    if (opcao == "X" || opcao == "x")
    {
        Console.WriteLine("Tchau...");
        break;
    }
}

// instrução continue

for (int i = 1; i <= 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

int n = 1;
while (n <= 10)
{
    if (n == 5)
    {
        n++;
        continue;
    }
    Console.WriteLine($"n={n}");
    n++;
}
