Console.WriteLine("## Exercicios Colecoes ##");

// 1 - Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
// as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

// a - Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
// b - Exiba os nomes da segunda e da penúltima fruta no console
// c - Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
// d - Ordene a coleção de frutas na ordem ascendente
// e - Exiba no console a coleção de nomes de frutas na ordem inversa

string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

ExibirArray(frutas);

Console.WriteLine($"Segunda Fruta : {frutas[1]}");
Console.WriteLine($"Penúltima Fruta : {frutas[frutas.Length -2]}");

frutas[2] = "Kiwi";
frutas[frutas.Length -1] = "Caqui";

ExibirArray(frutas);

Array.Sort(frutas);
Array.Reverse(frutas);
ExibirArray(frutas);


Console.ReadKey();

static void ExibirArray(string[] lista)
{
    for (int i = 0; i < lista.Length; i++)
    {
        Console.Write($"{lista[i]} ");
    }
    Console.WriteLine($"Quantidade : {lista.Length}");
}

