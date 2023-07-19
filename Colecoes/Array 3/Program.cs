using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Array 3\n");

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] nomes = { "Ana", "Maria", "Paulo", "Carlos" };

foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}

foreach (string nome in nomes)
{
    Console.Write(nome + " ");
}

Console.ReadKey();
