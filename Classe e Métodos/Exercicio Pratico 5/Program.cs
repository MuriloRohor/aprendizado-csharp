// t - Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora,
// Marca, Potencia e Ano e que exiba as informações destes atributos no console.

// u- Para este método defina o parâmetro Ano como opcional e faça duas chamadas ao método usando o conceito de argumentos
// nomeados não informando o ano na primeira chamada e informando o ano na segunda chamada.

// v- Explique o uso do parâmetro opcional e dos argumentos nomeados

Console.WriteLine("Exercício Prático 5\n");


Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine("\nUsando argumentos nomeados e parâmetros opcionais \n");

Console.WriteLine("Sem informar o parâmetro opcional Ano");
ford.ExibirInfo(Modelo: ford.Modelo, Montadora: ford.Montadora,
Marca: ford.Marca, Potencia: ford.Potencia);

Console.WriteLine("\nInformando o parâmetro opcional Ano");
ford.ExibirInfo(Modelo: ford.Modelo, Montadora: ford.Montadora,
Marca: ford.Marca, Potencia: ford.Potencia, Ano: ford.Ano);

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
        Console.WriteLine($"Ano: {this.Ano}");
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
