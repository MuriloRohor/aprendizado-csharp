Console.WriteLine("## Heranca - Construtores ##");

// A classe base e a classe derivada podem possuir seus próprios construtores
// A classe derivada não herda o construtor da classe base mas pode invocá-lo
// Ao criar uma instância da classe derivada o construtor da classe base sem parâmetros será invocado primeiro
// e depois será invocado o construtor da classe derivada

// a palavra-chave base é usada para acessar membros de classe base de dentro de uma classe derivada
// - Ela é usada para especificar qual construtor de classe base deve ser chamado ao criar instâncias da classe derivada.
Aluno aluno1 = new();
Aluno aluno2 = new("José");

Console.ReadKey();

//base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}

//derivada
class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno com parametro");
    }
}