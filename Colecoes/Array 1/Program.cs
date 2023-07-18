Console.WriteLine("## Array ##");
// Podemos declarar um array definindo o tipo dos seus elementos abrindo e fechando colchetes([])
// seguindo do nome da variável que identifica o array
// Ex:  TipoDados[] NomeDoArray 

// declaração do array
int[] numeros;

numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = new string[5] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

string[] nomes2 = new string[] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

string[] nomes3 = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[3]);
Console.WriteLine(nomes[4]);

// declarando um array
int[] numeros1;

//alocar memória
numeros1 = new int[3]; // iniciou os 3 indices e atribui o valor padrão 0

numeros1[0] = 1;
numeros1[1] = 2;
numeros1[2] = 3;


Console.ReadKey();