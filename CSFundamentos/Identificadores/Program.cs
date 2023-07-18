Console.WriteLine("Definindo Identificadores\n");

// identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

/* identificadores inválidos
int 5idade;
int $valor;
int valor#total;
string nome Completo;*/

// para nomes de variáveis : camel case
string descontoTotal;
string desconto_Total;

Console.ReadLine();

// constantes : maiúsculas

const double PI = 3.14;
const string PREFIXO = "11";
const string PREFIXO_SP = "11";

// para nomes de classe e métodos: pascal case
class ImprimirTexto
{
    public void ImprimirNome()
    {
        Console.WriteLine("Murilo");
    }
}