using Herancas___Downcasting_e_Upcasting;

Console.WriteLine("Herança - Downcasting e Upcasting");


Forma circulo = new Circulo(10, 20); //upcasting -> Converte a instância do tipo Circulo para o tipo da classe Forma.

Circulo circulo2 = new Circulo(10, 20); 
Forma forma2 = circulo2;             //upcasting



circulo.Desenhar();

// Embora forma e circulo se refiram ao mesmo objeto, forma tem uma visão mais restrita deste objeto pois pode acessar somente o método Desenhar.
// Para poder acessar o método PintarCirculo() da classe Circulo temos que fazer o DownCasting de Forma para Circulo.


// Downcasting ->

// A operação de Downcasting converte um objeto de um tipo geral (classe base) para um tipo mais especializado (classe filha).

// Podemos entender o downcasting como a atribuição de um objeto da classe base para um objeto da classe derivada.

// A operação de downcasting deve ser feita de forma explícita pois pode falhar e lançar uma exceção, ou seja, é uma operação que nem sempre é possível de ser realizada.

Circulo circulo3 = new Circulo(10, 20);
Forma forma3 = circulo3;     //upcasting -> implicita

Circulo c = (Circulo)forma3; // downcasting -> explicita : downcasting da variável forma3 que é do tipo Forma para Circulo

c.PintarCirculo();
c.Desenhar();                // A instância C pode acessar o método PintarCirculo() e também Desenhar()

Console.WriteLine(c == forma3);
Console.WriteLine(c == circulo3);

// Se o downcasting falhar ocorre uma exceção do tipo InvalidCastException
Console.ReadKey();