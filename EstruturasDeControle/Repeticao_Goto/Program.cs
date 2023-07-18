Console.WriteLine("## Estrutura de repetição com goto/label ##");
// A instrução goto pode ser usada para transferir o controle de uma parte para
// outra parte do programa com a ajuda de um identificador chamado label

int i = 1;

 repetir:
 Console.WriteLine($"i = {i}");
 i++;

if (i <= 10)
    goto repetir;

Console.WriteLine("Fim do processamento...");

Console.ReadKey();
