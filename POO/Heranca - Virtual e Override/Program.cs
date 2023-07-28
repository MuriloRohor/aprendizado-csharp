Console.WriteLine("## Herança - virtual e override ##");

// Se você quiser que um membro da subclasse substitua um membro com o mesmo nome na classe base dever fazer o seguinte :

var gato = new Gato() { Nome = "bichano" };
gato.ExibirNome();

var cao = new Cachorro() { Nome = "pipoca" };
cao.ExibirNome();


Console.ReadKey();
//classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibirNome()
    {
        Console.WriteLine($"Meu nome é {Nome}.");
    } 
}

//classe derivada
class Gato : Animal
{
    public string? Curso { get; set; }

    public override void ExibirNome()
    {
        Console.WriteLine($"Eu sou um gato. Meu nome é : {Nome}.");
    }
}

class Cachorro : Animal
{

}