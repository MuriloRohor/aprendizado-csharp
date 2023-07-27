using System.Timers;

Console.WriteLine("## Herança e Object ##");

// Toda a classe é derivada da classe Object, e, a classe Object não deriva de nenhuma classe
// Ela é a classe Base (Pai) de todas as classes.

// A classe Object dá supore a todas as classes na hierarquia de classes do .NET e fornece serviçoes de baixo nivel
// para as classes derivadas.

// Os métodos definidos na classe Object estão disponíveis em todos os objetos do sistema e as classes derivadas podem
// substituir alguns desses méotdos.

// - Equals      : Suporta comparações entre objetos;
// - GetHashCode : Gera um número hash para o objeto;
// - ToString    : Retorna a representação do objeto como uma string;
// - GetType     : Retorna a informação sobre o tipo;

Nada nada = new Nada();

Console.ReadKey();
public class Nada
{

}