Console.WriteLine("## Nullable Types ##\n");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

// simplificando a declaração

int? i2 = null;
double? d2 = null;
bool? b2 = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

// atribuindo um tipo anulável a um tipo não anulável

int? A = null;
int B = A ?? 0;
Console.WriteLine(B);

int? x = 4;
int? y = 5;
int? z = x * y;
Console.WriteLine(z);

// Propriedades somente leitura HasValue, Value

int? c = 100;
if (c.HasValue)
{
    Console.WriteLine($"b = {c.Value}");
}
else
{
    Console.WriteLine("c não´possui um valor");
}

Console.ReadKey();