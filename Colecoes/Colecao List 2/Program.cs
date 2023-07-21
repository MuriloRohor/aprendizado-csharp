Console.WriteLine("## Coleções List 2 ##");
// Inclusão de intens                                 : Add(T) e Insert(int index, T value)
// Inclusão de coleções                               : AddRange(ICollection) e InsertRange(int index, ICollection)
// Verificar se um elemento esta na lista             : Contains(T)
// Remoção de itens                                   : Remove(T value), Remove At(int index), RemoveRange(int index, int count)
// Ordenação da lista e remoção de todos os elementos : Sort(), Clear()

// Acesso aos elementos usando o índice : lista[indice]; (System.ArgumentOutOfRangeException)

var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos" };

lista.Add("Marta");           // Adicionado apos o ultimo elemento.
lista.Insert(2, "Bia");       // Adiciona em um indice especificado.

string[] array1 = { "Diná", "Carlos" };

lista.AddRange(array1);       // Adicionadoa a coleção apos o ultimo elemento.
lista.InsertRange(1, array1); // Adiciona a coleção em um indice especificado.

var lista2 = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

lista2.Remove(7);              // Remove a primeira ocorrência do valor 7 na lista.
lista2.RemoveAt(4);            // Remove o valor na posição 4.
lista2.RemoveRange(0, 2);      // A partir do indice 0 irá remover 2 valores.

var primeiro = lista[0];       // -> acessando os indices da lista
var quarto = lista[3];

var lista3 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };


// Utilizando for e foreach

for (int i = 0; i < lista3.Count; i++)
{
    Console.Write($"{lista3[i]} ");
}

foreach (var elemento in lista3)
{
    Console.Write($"{elemento }");
}

// Verificar se um elemento esta na coleção

var lista4 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

var res1 = lista4.Contains("Ana");         // True
var res2 = lista4.Contains("Zé");          // True


bool res3 = lista4.Contains("Ze");         // False
bool res4 = lista4.Contains("Mari");       // False

Console.WriteLine(lista.Contains("Mari")); // False


// Ordenar e remover os elementos

var lista5 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

ExibirLista(lista5);

lista5.Sort();         // -> ordena a lista

ExibirLista(lista5);

lista5.Clear();        // -> Limpou a coleção




static void ExibirLista(List<string> lista)
{
    foreach (var elemento in lista)
    {
        Console.Write($"{elemento} ");
    }
}