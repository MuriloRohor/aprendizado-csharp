Console.WriteLine("## Métodos com Retorno ##");

Calculadora calc = new Calculadora();
Console.WriteLine($"Soma = {calc.Somar(10, 10)}");

Console.ReadKey();

public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    public int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}
