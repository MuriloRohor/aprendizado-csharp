Console.WriteLine("## Arrays Multidimensionais ##");

int[,] a;                                  // a -> null
a = new int[2, 2];                         // define o tamanho e atribui os valores padrões 0.
a = new int[2, 2] { { 0, 1 }, { 2, 3 } };  // inicializa os array com os valores definidos.
a = new int[2, 2]                          // outro exemplo de incialização.
{                                
    { 0, 1 }, 
    { 2, 3 }
};

int[,] b = new int[2, 2] { { 0, 1 }, { 2, 3 } };  // exemplo de uma declaração simplificada.
int[,] c = { { 0, 1 }, { 2, 3 } };                // simplicando ainda mais


// atribuindo valores aos indices
a[0, 0] = 3;
a[0, 1] = 2;
a[1, 0] = 1;
a[1, 1] = 0;

Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

Console.ReadKey();