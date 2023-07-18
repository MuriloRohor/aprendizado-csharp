// g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)

// h - Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro

// i - Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
// vai retornar um double representando a velocidade máxima do carro ( Para calcular a velocidade multiplique a potencia por 1.75)

// j- Explique o comportamento da palavra return

// Resposta h - Ao criar um novo construtor com parâmetros diferentes criamos a sobrecarga do metodo assim
// podemos utilizar o construtor informando parâmetros diferentes.

// Resposta j - A palavra return irá retornar o valor processado dentro do metodo.

Console.WriteLine("Exercício Prático 2\n");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.MostrarDados();
chevrolet.Acelerar(chevrolet.Marca);

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
ford.MostrarDados();
ford.Acelerar(ford.Marca);

Console.ReadKey();


public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }
    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando meu {marca}\n");
    }
    public void MostrarDados()
    {
        Console.WriteLine($"\nModelo: {this.Modelo}");
        Console.WriteLine($"Montadora: {this.Montadora}");
        Console.WriteLine($"Marca: {this.Marca}");
        Console.WriteLine($"Ano: {this.Ano}");
        Console.WriteLine($"Potência: {this.Potencia}\n");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}











