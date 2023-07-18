// w - Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.
// w1 - Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se for informado maior que 2022 seja atribuído 2022 ao valor do ano.
// w2- Explicar a diferença entre campo e propriedade.

using System.Reflection;

Console.WriteLine("Exercício Prático 6\n");

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2023, 120);

ford.MostrarDados();


Console.ReadKey();


public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int ano;
    public int Ano 
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
           

        }
    }
    public int Potencia;
    public static double ValorIpva;

    public Carro(string? Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;

    }
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando meu {marca}\n");
    }
    public void MostrarDados()
    {
        Console.WriteLine($"\nModelo: {this.Modelo}");
        Console.WriteLine($"Montadora: {this.Montadora}");
        Console.WriteLine($"Marca: {this.Marca}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Potência: {this.Potencia}\n");
    }
    public void ExibirInfo(string Modelo, string Montadora, string Marca, int Potencia, int Ano = 2010)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
    }
    public static void ObterValorIPVA()
    {
        ValorIpva = 4;
    }
    public double VelocidadeMaxima(int potencia)
    {
        return this.Potencia * 1.75;
    }
    public int AumentarPotencia(int potencia)
    {
        return this.Potencia += potencia;
    }
    public int AumentarPotencia(ref int potencia)
    {
        return this.Potencia += potencia;
    }
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = potencia * 1.75;
        return potencia;
    }
}

