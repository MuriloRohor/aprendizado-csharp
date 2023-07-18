using System.Security.Cryptography;

Console.WriteLine("## Classes e Objetos ##");

Pessoa p1 = new Pessoa(); 
p1.nome = "Pedro";
p1.idade = 20;
p1.sexo = "Masculino";

Console.WriteLine($"Nome: {p1.nome}\nIdade: {p1.idade}\nSexo: {p1.sexo}");

Pessoa p2 = new Pessoa();
p2.nome = "Fernanda";
p2.idade = 30;
p2.sexo = "Feminino";

Console.WriteLine($"Nome: {p2.nome}\nIdade: {p2.idade}\nSexo: {p2.sexo}");

//syntaxe diferentes
Pessoa p3 = new Pessoa();
Pessoa p4 = new();
var p5 = new Pessoa();

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
