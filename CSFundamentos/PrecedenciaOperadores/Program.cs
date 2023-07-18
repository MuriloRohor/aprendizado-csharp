Console.WriteLine("## Precedência de operadores ##");
// (*, /, %, +, -)
// (!, &&, ||)

int x = 10 - 2 * 3;
Console.WriteLine($"10 - 2 * 3 = {x}\n");

x = (10 - 2) * 3;
Console.WriteLine($"(10 - 2) * 3 = {x}\n");

bool y = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine($"!(9 != 8) && 5 >= 7 || 8 >= 6 = {y}\n");

y = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine($"!(9 != 8) && (5 >= 7 || 8 >= 6) = {y}\n");


int a = 5, b = 6, c = 4;

int r = --a * b - ++c;
Console.WriteLine(r);