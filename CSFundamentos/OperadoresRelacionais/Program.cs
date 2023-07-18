Console.WriteLine("## Operadores Relacionais ##");
// o resultado de uma operação relacional terá como resultado true ou false
// Ex: ( ==, >, <, >=, <=, != )

int x = 10;
int y = 20;

Console.WriteLine($"Valor de x {x}");
Console.WriteLine($"Valor de y {y}");

Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

// utilizando com strings

string a = "Hello";
string b = "hello";

Console.WriteLine($"Valor de a {a}");
Console.WriteLine($"Valor de b {b}");

Console.WriteLine(a == b);
Console.WriteLine(a != b);
Console.WriteLine(a.Equals(b));