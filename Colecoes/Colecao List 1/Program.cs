Console.WriteLine("## Coleção List<T> ##");

// Uma List<T> pode conter elementos do tipo especificado por T, fornece verificação de tipo em tempo de compilação.
// Os elementos podem ser adicionados a uma List<T> usando os métodos Add(), AddRanger(), Insert() e InsertRange() ou usando a sintaxe de inicialização de coleção.
// É uma estrutura dinâmica que pode ser redimensionada
// inicia vazia e seus elementos são alocados sob demanda
// uma variável refere-se ao objeto ral, que deve ser instanciado na memória Heap.

// Especificar o parãmetro de tipo T para definir o tipo dos elementos que irá armazenar
// Usando o new e em seguida o método Add para incluir elementos ou utilizar inicializador de coleção para criar uma List<T> em uma única etapa.
List<string> lista; 

lista = new List<string>();

List<int> lista1 = new List<int>();
var lista2 = new List<float>();          // -> Outras formas de inicializar
List<double> lista3 = new();

lista.Add("Paulo");
lista.Add("Maria");
lista.Add("Bia");
lista.Add("Pedro");