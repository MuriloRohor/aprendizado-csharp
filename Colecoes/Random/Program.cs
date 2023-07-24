Console.WriteLine("## Random ##");
// métodos classe Random
// Next(), Next(int), Next(int, int), NextDouble(), NextByte(Byte[]), NextInt64(...)

// A classe Random possui dois construtores:

// Random()      - Inicializa uma nova instância da classe Random usando um valor da semente padrão.
// Random(int32) - Inicializa uma nova instância da classe Random usando um valor da semente definido.

Random random = new Random(); // -> Gera a semente usando o relógio do sistema
Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20));
Console.WriteLine(random.Next(0,20));
Console.WriteLine(random.NextDouble());

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(random.Next(0,100));
}

Random random1 = new Random(2023); // - Gera o valor utilizando a semente 2023

byte[] randBytes = new byte[10];

random.NextBytes(randBytes);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(random.Next(randBytes[i]));
}


Random sorteio = new Random();
int[] numerosSorteados = new int[6];

for (int i = 0; i < numerosSorteados.Length; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados\n");
Console.WriteLine(string.Join(" ", numerosSorteados));

