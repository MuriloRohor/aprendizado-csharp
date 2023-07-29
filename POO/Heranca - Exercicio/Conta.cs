namespace Heranca___Exercicio;

public class Conta
{
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; } = 0.00m;

    public virtual decimal Sacar(decimal valor)
    {
        Saldo -= valor;
        return Saldo;
    }

    public virtual decimal Depositar(decimal valor)
    {
        Saldo += valor;
        return Saldo;
    }
}
