Console.WriteLine("## Polimorfismo ##");

// É considerado o terceiro pilar da programação orientada objetos.

// A palavra Polimorfismo é uma palavra grega que significa "de muitas formas".

// Polimorfismo é o princípio pelo qual duas ou mais classes derivadas de uma mesma superclasse podem invocar métodos que têm a mesma indentificação (assinatura)
// mas comportamentos distintos, especializados para cada classe derivada, usando para tanto uma referência a um objeto do tipo superclasse.

// Usando polimorfismo podemos:
// - Invocar métodos da classe derivada através da classe base em tempo de execução;
// - Permitir que classes forneçam diferentes implementações de métodos que são chamados com o mesmo nome;

// Polimorfismo : Tipos

// 1 - Polimorfismo em tempo de compilação (Overloading ou Sobrecarga);

// Utiliza a sobrecarga de métodos e operadores sendo também chamado de ligação precoce (early binding). A utilização da sobrecarga (overloading) de métodos realiza
// a tarefas com distintos parâmetros de entrada.

// Permite que classes forneçam diferentes implementações que são chamados pelo mesmo nome

// 2 - Polimorfismo em tempo de execução (Overrinding ou Sobrescrita);

// Pode ser feito usando herança e métodos virtuais. Quando sobrescrevemos(override) os métodos virtuais estamos alterando
// o comportamento dos métodos para a classe derivada. Isto também é conhecido como ligação tardia (late binding).

// Polimorfismo : Implementação

// Polimorfismo com Herança
// - Classes derivadas sobrescrevendo os membros da classe base

// Polimorfismo com interface
// - Classes que implementam a interface com comportamentos diferentes.
// - Métodos com mesmo nome nas classes mas funcionalidades diferentes.

// Polimorfismo com classe abstrata
// - As classes derivadas incluem detalhes de implementação nos métodos abstratos