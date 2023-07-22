Console.WriteLine("## List - Métodos Find ##");

// Find - retorna o primeiro elemento que corresponde ao predicado forncedio

// FindLast - retorna o último elemento que corresponde ao predicado fornecido

// FindIndex - retorna o índice do primeiro elemento que corresponde ao predicado fornecido.
// ele retorna -1 se não houver correspondência encontrada.

// FindLastIndex - retorna o índice do último elemento que corresponde ao predicado fornecido.
// ele retorna -1 se não houver correspondência encontrada.

// FindAll - recupera todos os elementos que correspondem às condições definidas pelo predicado especificado.

List<string> frutas = new() { "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" };

var fruta1 = frutas.Find(Procura);
Console.WriteLine($"\nPredicado => {fruta1}");


// Ao invés de criar uma função que retorna true ou false podemos usar uma expressão lambda.

// Uma expressão lambda é uma função anônima.
// Para criar uma expressão lambda, devemos especificar:
// - os parâmetros de entrada no lado esquerdo do operador lambda (=>)
// - e definir a expressão ou o bloco de instruções do lado direito do operador lambda.

var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nExpressão lambda => {fruta2}");

Console.ReadKey();
static bool Procura(string item)
{
    return item.StartsWith('L'); // Predicado é uma função que a partir de uma expressão retorna verdadeiro ou falso conforme a lógica da expressão definida na função
}



