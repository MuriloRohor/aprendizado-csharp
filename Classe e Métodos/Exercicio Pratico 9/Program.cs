//-Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros : Branco, Vermelho, Preto, Cinza, Prata e Azul
//- Inicie o valor da enumeração com 1
//- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro
//- Defina um menu de opções exibindo o nome da Cor e o seu valor
//- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor
//- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da cor a partir do valor da Cor recebida

using CarroEnum;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("## Exercicio Pratico 9 ##");

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("Selecione a Cor do carro");
int cor = Convert.ToInt32(Console.ReadLine());

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);

chevrolet.Acelerar(chevrolet.Marca);

chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca, chevrolet.Potencia, chevrolet.Cor);

Console.ReadKey();


public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Cor;
    public int Potencia;
    public static double ValorIpva;
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
    public Carro(string? Modelo, string Montadora, string Marca, int Ano, int Potencia, int Cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = Cor;

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
    public void ExibirInfo(string Modelo, string Montadora, string Marca, int Potencia, int Cor = 1, int Ano = 2010)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
        Console.WriteLine((Cores)Cor);
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
