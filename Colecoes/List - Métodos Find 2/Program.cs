Console.WriteLine("## List - Métodos Find 2 ##");

List<string> frutas = new() { "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" };

var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nFind : {fruta2}");

var fruta3 = frutas.FindLast(i => i.Contains('n')); // Retorna a ultima corrência
Console.WriteLine($"\nFind Last : {fruta3}");

var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindIndex : Indice={fruta4} item={frutas[fruta4]}");

var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindLastIndex : Indice={fruta5} item={frutas[fruta5]}");

var fruta6 = frutas.FindAll(i => i.Contains('n'));

Console.Write("\nFindAll : ");
foreach (var item in fruta6)
{
    Console.Write($"{item}, ");
}

Console.ReadKey();