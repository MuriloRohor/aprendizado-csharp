using System.Threading.Channels;

Console.WriteLine("## Instrução Switch Case ##");

// numero de parcelas 

int compra = 600;

Console.WriteLine($"Valor da compra {compra.ToString("c")}");
Console.WriteLine("Informe o nº de parcelas (1 a 3)");

int numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {compra/numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("\nValor inválido, informe 1, 2 ou 3");
        break;
}

Console.WriteLine("\nFim de processamento...");
Console.ReadKey();

// par ou ímpar

Console.WriteLine("\nInforme um número inteiro");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0: 
        Console.WriteLine($"\n{numero} é par");
        break;
    case 1:
        Console.WriteLine($"\n{numero} é impar");
        break; 
}

Console.ReadKey();

// dias dos meses do ano

Console.WriteLine("\nInforme um mês do ano: ");
string mes = Console.ReadLine().ToLower();
switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Esté mês tem 31 dias");
        break;
    case "fevereiro": 
        Console.WriteLine("Este mês tem 28 dias ou 29 dias");
        break;
    default:
        Console.WriteLine("Estê mês tem 30 dias");
        break;
}

// instrução switch - aninhadas

int cargo = 0;
int funcao = 0;
Console.WriteLine("\nVocê é Gerente(1) ou Programador(2) ?\t");
cargo = Convert.ToInt32(Console.ReadLine());
if (cargo == 2)
{
    Console.WriteLine("\nVocê é Junior(1) ou Senior(2) ?\t");
    funcao = Convert.ToInt32(Console.ReadLine());
}
switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem-Vindo Gerente.");
        break;
    case 2:
        Console.WriteLine("\nBem-Vindo Programador.");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Junior.");
                break;
            case 2:
                Console.WriteLine("\nVocê é Senior.");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te idenrificar");
        break;
}