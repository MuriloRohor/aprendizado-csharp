Console.WriteLine("## Intrução if ##\n");

Console.WriteLine("Cliente Especial (S/N)");
string resposta = Console.ReadLine();

if (resposta == "s" || resposta == "S")
{
    Console.WriteLine("Desconto 10%");
}
Console.WriteLine("Fim do programa");
Console.ReadKey();

int x, y;

Console.WriteLine("Informe o valor de x\t");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\t");
y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("x é maior que y");
}
if(x < y)
{
    Console.WriteLine("x é menor que y");
}
if(x == y)
{
    Console.WriteLine("x é igual a y");
}