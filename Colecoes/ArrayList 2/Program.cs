using System.Collections;

Console.WriteLine("## ArrayList ##");

// ArrayList -> Adicionar elementos ( Add, Insert )

// O método Add permite incluir um único elemento ao final de uma ArrayList
// O método Insert(int index, Object value) permite incluir um elemento em uma posição qualquer usando um índice específico

var lista = new ArrayList() { "Maria", 5, true, " ", null };

lista.Add(3.5);                // -> Adiciona o elemento ao final do ultimo indice da lista

lista.Insert(2, "Paulo");      // -> Adiciona a string "Paulo" no indíce 2s




// ArrayList - Adicionar coleção de elementos - ( AddRange, InsertRange )

// O método AddRange(ICollection) - Adiciona a coleção de elementos ao final do ArrayList
// O método InsertRange(int index, ICollection) - Adiciona a coleção de elementos na ArrayList na posição do índice especificado

var lista2 = new ArrayList() { "Maria", 5, true };
int[] array1 = { 1, 2, 3 };

lista2.AddRange(array1);       //  -> Adicionou os elemtos do array "array1" ao final da ArrayList "lista2" ( "Maria", 5, true1, 1, 2, 3 )

lista2.InsertRange(2, array1); // -> Insere os elementos do array "array1" no indice 2 da ArrayList "lista2" ( "Maria", 5, 1, 2, 3, true, 1, 2, 3 )

Console.ReadKey();
