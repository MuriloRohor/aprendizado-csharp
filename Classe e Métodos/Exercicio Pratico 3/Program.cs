//l- Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
//potencia e retorna um int representando o aumento de potencia.(para aumentar a potência incremente 3 ao parâmetro recebido)

//m - Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o comportamento da passagem do argumento por valor

//n- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
//chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 5 ao parâmetro recebido)

//o- Explique a sobrecarga de métodos

//p - Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o
//comportamento da passagem do argumento por referência.



Console.WriteLine("Exercício Prático 3\n");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado : " + chevrolet.Potencia);

Console.WriteLine("Aumentando a Potencia (por valor : + 3CV) : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);


Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.Write("\nAumentando a Potencia (por referência : +5CV) : ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);

Console.Write("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado : " + ford.Potencia);


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
    public double VelocidadeMaxima(int potencia)
    {
        return this.Potencia * 1.75;
    }
    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }
    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }
}
