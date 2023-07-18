// r - Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
// como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai
// retornar a nova velocidade como um double.(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
// s - Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o comportamento do parâmetro out.

Console.WriteLine("Exercício Prático 4\n");



Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.WriteLine("\nUsando parâmetro out => Aumenta potencia e velocidade ");

double novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);

Console.WriteLine("-Nova Potencia : " + novaPotencia);
Console.WriteLine("-Nova Velocidade Máxima : " + velocidade);



Console.ReadKey();


class Carro
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
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }
}


