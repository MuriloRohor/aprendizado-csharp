//x- Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para
//todos os carros
//y- Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
//z- Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static.

Console.WriteLine("Exercício Prático 6\n");


Console.WriteLine("Chamando o método estático ObterValorIPVA : ");
Carro.ObterValorIPVA();
Console.WriteLine("Valor do campo ValorIpva : " + Carro.ValorIpva + "%");

Console.ReadKey();


public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
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
