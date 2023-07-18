Console.WriteLine("## Operadores Lógicos ##\n");

// AND(&&) = Retornará False se apenas uma das condições for False.
// OR(||) = Retorna True se apenas uma das condições for True.
// NOT(!) = Inverte o resultado, retorna False se o resultado de expressão
// for True e vice-versa.

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");

// operador AND -> &&
resultado = c1 && c2;
Console.WriteLine($"Operador AND(&&): {resultado}");

// operador OR -> ||
resultado = c1 || c2;
Console.WriteLine($"Operador OR (||): {resultado}");

// operador OR -> !
resultado = !c2;
Console.WriteLine($"Operador NOT (!): {resultado}");

Console.ReadKey();
