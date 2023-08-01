namespace Exercicio_1;

public class Carro : IVeiculo
{
    public int Gasolina { get; set; } = 0;

    public bool Abastecer(int gasolina)
    {
        Gasolina = gasolina;
        return true;
    }

    public void Dirigir()
    {
        if (Gasolina > 0)
        {
            Console.WriteLine("Dirigindo...");
        }
        else
        {
            Console.WriteLine("Sem Gasolina...");
        }
    }
}
