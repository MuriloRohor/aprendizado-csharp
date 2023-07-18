Console.WriteLine("## Operador Uniário e Ternário ##");

Console.WriteLine("Informe o número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.ReadKey();

// Operador condicional ternário (?, :)

Console.WriteLine("Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

// (condicao ? expressao_se_true : expressao_se_false;)
// se for true retorna a primeira expressão "Quente" e se for false retorna a segunda expressã "Normal".

var resultado = temp > 27 ? "Quente" : "Normal";
Console.WriteLine($"O Tempo está {resultado}");

Console.WriteLine("Digite o valor de x ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de y "); 
double y = Convert.ToDouble(Console.ReadLine());

var resultado2 = x > y ? "x é maior que y" :
                 x < y ? "x é menor que y" :
                 x == y ?  "x é igual a y" : "Sem Resultado";

Console.WriteLine(resultado2);