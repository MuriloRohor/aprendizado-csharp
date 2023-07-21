using System.Collections;

Console.WriteLine("## ArrayList 4 ##");

// ArrayList  - Verificar se um elemento está na coleção.
// Contains() - Determina se um elemento especificado existe na ArrayList ou não. O método retorna True se existir caso contrário retorna False.
// Sort()     - Ordena os elementos do mesmo tipo na ordem ascendente.
// Clear()    - Remove todos os elementos de uma ArrayList sem alterar sua capacidade.

var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

var res1 = lista.Contains(5);        // True
var res2 = lista.Contains(null);     // True

bool res3 = lista.Contains(45);      // False
bool res4 = lista.Contains("Mari");  // False

Console.WriteLine(lista.Contains("Mari"));


var lista2 = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

lista2.Sort(); // Ana, Carlos, Diná, Maria, Zilda.

lista2.Clear(); // elementos da lista foram apagados.

Console.ReadKey();