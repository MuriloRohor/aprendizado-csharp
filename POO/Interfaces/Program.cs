Console.WriteLine("## Interfaces ##");
// Uma interface é um tipo de classe que pode conter as assinaturas de métodos, eventos
// propriedades e indexadores, e também pode conter métodos públicos e estáticos que
// contém uma implementação

// Os membros da interface são públicos por padrão, e você pode especificar explicitamente
// modoficadores de acessibilidade, como public, protected, internal, private, protected internal
// ou private protected.

// Um membro private dever ter uma implementação padrão.

// Uma interface não pode conter campos de instância, construtores de instância ou finalizadores.

// Para implementar um membro de interface, o membro correspondente da classe de implementação deve ser público,
// não estático e ter o mesmo nome e assinatura de membro de interface.

// Interfaces - Regra Geral

// Uma interface não pode ser instanciada diretamente e seus membros abstratos são
// implementador por qualquer classe ou struct que implemente a interface.

// Uma interface funciona como um contrato entre si e qualquer classe que a implementa

// Uma classe ou struct pode implementar(herdar) várias interfaces.

// Uma classe que implementa uma interface é obrigada a implementar todos os seus membros abstratos

// Uma classe pode herdar uma classe base e também implementar uma ou mais interfaces.

// Se uma classe base implementa uma interface, qualquer classe que é derivada da classe
// base herda essa implementação.

// Uma interface pode herdar de uma ou mais interfaces. A interface derivada herda os membros de suas interfaces base.

// - Uma interface não pode ser instanciada
// - Pode conter membros abstratos
// - Pode conter implementação
// - As classes que herdam a interface devem implementar
// os métodos abstratos
// - Uma classe pode implementar mais de uma interface.

IControle d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Exibir();

Console.ReadLine();

interface IControle
{
    // public IControle() { }
    // int status;

    string Nome { get; set; }
    void Desenhar();

    public void Exibir()
    {
        Console.WriteLine("teste...");
    }

}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty;

    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}