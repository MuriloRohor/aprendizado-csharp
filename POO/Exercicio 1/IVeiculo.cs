namespace Exercicio_1;

public interface IVeiculo
{
    int Gasolina { get; set; }

    public void Dirigir();
    public bool Abastecer(int gasolina);
}
