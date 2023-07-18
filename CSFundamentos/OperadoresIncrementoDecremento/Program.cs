using System;

Console.WriteLine("## Operadores Incremento e Decremento ##\n");

int x = 10;
x++;        // x = x + 1
Console.WriteLine(x);

// operações

// y++ -> primeiro resolve a expressão depois incrementa

int y = 0;
int z = 0;
int resultado = y++ + 10;   // o valor será 10
Console.WriteLine($"pós-incremento -> {resultado}");
Console.WriteLine($"Valor de y -> {y}\n");

// ++z -> primeiro incrementa depois resolve a expressão

int resultado2 = ++z + 10;  // o valor será 11
Console.WriteLine($"pré-incremento -> {resultado2}");
Console.WriteLine($"Valor de z -> {z}\n");

Console.ReadLine();



// a-- -> primeiro resolve a expressão depois incrementa

int a = 0;
int b = 0;
int resultado3 = a-- + 10;  // o valor será 10
Console.WriteLine($"pós-decremento -> {resultado3}");
Console.WriteLine($"Valor de a -> {a}\n");

// --b -> primeiro incrementa depois resolve a expressão

int resultado4 = --b + 10;  // o valor será 9
Console.WriteLine($"pré-decremento -> {resultado4}");
Console.WriteLine($"Valor de b -> {b}\n");

Console.ReadLine();




