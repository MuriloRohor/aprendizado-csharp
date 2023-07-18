Console.WriteLine("## Conversão de tipos ##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 1245678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();
Console.WriteLine(s1); 
Console.WriteLine(s2); 
Console.WriteLine(s3);

int numeroInt = 10;
double numeroDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(numeroInt));
Console.WriteLine(Convert.ToDouble(numeroInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

int varInt2 = 100000;
Console.WriteLine(Convert.ToByte(varInt2));
Console.ReadKey();
