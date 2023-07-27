using System.Reflection;

Console.WriteLine("## Herança - New ##");

// Se um membro de uma classe derivada tiver o mesmo nome do membro de uma classe base,
// o compilador vai emitir um aviso que indica que o membro da classe derivada oculta o membro da classe base

// Quando um método na classe derivada oculta um membro da classe base, este substitui (override) o membro da classe base.

// Se você realmente deseja ocultar um membro da classe base, pode usar o modificador new para o membro na subclasse

Aluno aluno = new Aluno();

aluno.Nome = "Vagner";
aluno.Curso = "Quimica";

Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, Eu sou o (a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set;}
    public new string Saudacao() 
        => $"Oi, Eu sou o (a) {Nome} do curso de : {Curso}.";
}