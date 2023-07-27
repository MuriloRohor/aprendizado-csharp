Console.WriteLine("## Exercicio Colecoes 2 ##");
// 2 - Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
// etapas a seguir
// a -) Solicite via teclado o número de valores do array (deve ser um número inteiro)
// b -) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
// c -) Solicite ao usuário um valor de um número inteiro a procurar no array
// d -) Exiba se o número informado existe no array de inteiros ou não
// e -) Repita até que o texto ‘fim’ seja inserido via teclado

Console.WriteLine("Informe o número de valores da lista");
int tamanhoLista = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe os números do array");
int[] listaInteiros = new int[tamanhoLista];


for (int i = 0; i < tamanhoLista; i++)
{
    Console.Write($"listaInteiros[{i}] = ");
    listaInteiros[i]= Convert.ToInt32(Console.ReadLine());    
}

string numero;
Console.WriteLine("\nInforme o número para localizar no array(Digite 'fim' para encerrar) : \n");

do
{
    numero = Console.ReadLine();
    if (numero != "fim")
    {
        int valor = Convert.ToInt32(numero);

        if (Array.BinarySearch(listaInteiros, valor) >= 0)
        {
            Console.WriteLine($"O número {numero} existe no array");
        }
        else
        {
            Console.WriteLine($"O número {numero} não existe no array");
        }
    }
}
while (numero != "fim");

Console.ReadKey();