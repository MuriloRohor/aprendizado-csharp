Console.WriteLine("## Inferência Tipos ##");

var nome = "Maria";
var idade = 25;
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} e ganha {salario.ToString("c")}");

// var limitações

// var salario2 = null;         - não é possivel atribuir nulo
// var titulo;                  - precisa ser inicializada
// var mensal, imposto, total;  - não pode ter varios declaradores

// não é permitido mudar o tipo após inicializar
// var num = 10;
// num = "Teste";


var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("MeuMetodo");
    }
}
