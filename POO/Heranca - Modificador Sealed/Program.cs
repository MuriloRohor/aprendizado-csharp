Console.WriteLine("## Herança - Modificador sealed ##");

// Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela.

Cliente cliente = new Cliente();
//cliente.Nome = "José";
cliente.ExibirNome();


Console.ReadKey();
sealed class Pessoa
{
    public string? Nome { get; set; }
    public void ExibirNome() 
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente //: Pessoa
{
    public void ExibirNome()
    {
        //Console.WriteLine($"Nome do cliente : {Nome}");
    }
}


// Podemos usar o modificador sealed em um método ou propriedade que substitui um método ou propriedade virtual em uma classe base.

// Com isso você permite que classes sejam derivadas de sua classe e evita que outros desenvolvedores que estejam usando suas classes substituam métodos e propriedades virtuais específicos.

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1() 
    {
        Console.WriteLine("Classe1.Metodo1()");      
    }
    protected override void Metodo2() 
    {
        Console.WriteLine("Classe1.Metodo2()");      
    }
}

class Classe2 : Classe1
{
    protected override void Metodo1()
    {
        Console.WriteLine("Classe2.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2()");
    }

}