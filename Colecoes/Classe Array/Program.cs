Console.WriteLine("## Classe Array ##");

string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

Console.WriteLine("\n\nExibindo o array original...");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array...");
Console.WriteLine("Infome um nome: ");
string? nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0)
    Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
else
    Console.WriteLine($"\n{nome} não foi encontrado");






Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome}  ");
    }
}