Console.WriteLine("Operadores - is e as");

// O operador as é usado para realizar a conversão entre tipos de referência ou tipos anuláveis compatíveis.

// Este operador retorna o objeto quando ele é compatível com o tipo dado e retorna null
// se a conversão não for possivel ao invés de gerar uma exceção.

// Ao ralizar uma operação de downcasting (base -> derivada) ele avalia o resultado para null
// ao invés de lançar uma exceção (InvalidCastException) caso a operação não seja possivel.

// O operador as é um operador de conversão de tipos(referência e anuláveis).

// Fazendo a conversão usando o operador as 

Object carroObj = new Carro();

try
{
    var x = (string)carroObj;
}
catch (Exception ex)
{
    Console.WriteLine("\nA conversão falhou...");
    Console.WriteLine(ex.Message);
}

var y = carroObj as string; // avalia y como null

if(y != null)
{
    Console.WriteLine("converteu obj para string");
}
else
{
    Console.WriteLine("Não foi possivel converter, y é null");
}

Console.ReadKey();


class Carro
{}

