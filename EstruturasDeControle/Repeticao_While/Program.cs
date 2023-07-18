Console.WriteLine("## Instrução While ##");

int i = 1;

while (i <= 10)
{
    Console.WriteLine($"i = {i}");
    i++;
}


int a = 10;

while (a > 0)
{
    Console.WriteLine($"a = {a}");
    a--;
}

Console.ReadKey();

// Imprimir a tabuada de um número maior que zero

int numero;
int contador = 1;

Console.WriteLine("\nDigite um numero maior que zero\t");
numero = Convert.ToInt32(Console.ReadLine());

if(numero > 0)
{
    // loop while
    Console.WriteLine($"\n## Tabuada do {numero}##\n");
    while(contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero!!");
}

Console.ReadKey();

// Saindo do loop com break

while(true)
{
    Console.WriteLine("\n Informe um numero inteiro: (Para sair tecle 999)");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number == 999)
    {
        break;
    }

    if(number % 2 == 0)
    {
        Console.WriteLine($"{number} é PAR");
    }

    else
    {
        Console.WriteLine($"{number} é IMPAR");
    }
}

Console.ReadKey();

// While aninahdas : coordenadas do plano (x, y)

int x = 0;

while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");