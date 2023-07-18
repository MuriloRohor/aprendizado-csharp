Console.WriteLine("## Conversão de Tipos ##\n");

int varInt = 100;                 // int usa 4 bytes
double varDouble = varInt;        // double usa 8 bytes

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;
Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.ReadKey();

// Conversão que não pode
// double varDouble = 12.456;   // 8 bytes
// int varInt = varDouble;      // 4 bytes

double vDouble = 12.456;  // 8 bytes
int vInt = (int)vDouble; // 4 bytes

Console.WriteLine(vInt);

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2;   // 10/4 = 2.5
Console.WriteLine(resultado);

Console.ReadKey();