using System.Collections;

Console.WriteLine("## ArrayList ##");

// ArrayList - Remove elementos ( Remove, RemoveAt, RemoveRange )

// Remove(Object value)              - Remove a primeira ocorrência de um objeto específico
// RemoveAt(int index)               - Remove o elemento no índice especificado
// RemoveRange(int index, int count) - Remove um número definido de elementos a partir de um índice especificado

var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

lista.Remove(null);      // -> Remove a primeira ocorrência de null no ArrayList

lista.RemoveAt(4);       // -> Remove o elemento do indice especificado (4)

lista.RemoveRange(0, 2); // -> Remove 2 elementos a partir do índice 0

Console.ReadKey();
