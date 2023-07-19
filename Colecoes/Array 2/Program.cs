Console.WriteLine("Arrays 2");

// Utilizando laço para interar arrays

int[] numeros = new int[10] {1, 2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10 };
string[] nomes = { "Ana", "Maria", "Paulo", "Carlos" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
}

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
}

Console.ReadKey();