//- Explique como poderíamos substituir o método ObterValorIPVA() de forma a inicializar o campo estático
//  ValorIpva quando uma instância da classe fosse criada.
//- Implemente o código que realiza essa substituição
//- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para internal ?
//- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para private ?
Console.WriteLine("## Exercicio Pratico 10 ##");

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2023, 120);

ford.MostrarDados();

// Resposta:

// Alterar o modificador de acesso do campo estático ValorIpva para internal não traria nenhuma alteração na
// execução do programa pois ele vai continuar sendo acessível no mesmo assembly. Agora o campo não vai estar
// mais acessível fora do assembly.
// Alterar o modificador de acesso do campo estático ValorIpva para internal vai fazer com que ele seja acessível
// somente dentro da classe Carro.


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

    static Carro()
    {
        ValorIpva = 4;
    }

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
    //public static void ObterValorIPVA()
    //{
    //    ValorIpva = 4;
    //}
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

