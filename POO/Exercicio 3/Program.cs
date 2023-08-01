using Exercicio_3;

Console.WriteLine("## Exercicio 3 ##");

// Crie um programa que solicite ao usuário três nomes de pessoas e os armazene em
// uma matriz de objetos do tipo Pessoa. Haverá duas pessoas do tipo Aluno e uma
// pessoa do tipo Professor.
// Para isso, crie uma classe Pessoa que possua uma propriedade Nome do tipo string, um
// construtor que receba o nome como parâmetro e sobrescreva o método ToString().

// Então crie mais duas classes que herdam da classe Pessoa, elas serão chamadas de
// Aluno e Professor. A classe Aluno possui um método Estudar que escreve pelo console
// que o aluno está estudando. A classe Professor terá um método Explicar que grava no
// console que o professor está explicando. 

// Lembre - se de também criar dois construtores nas classes filhas que chamam o
// construtor pai da classe Pessoa.

// Termine o programa lendo as pessoas (o professor e os alunos) e execute os métodos
// Explicar e Estudar.

int total = 3;
Pessoa[] pessoas = new Pessoa[total];
for (int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.Write("Informe o nome do Professor: ");
        pessoas[i] = new Professor(Console.ReadLine());
    }
    else
    {
        Console.Write("Infome o nome do Alunos: ");
        pessoas[i] = new Aluno(Console.ReadLine());
    }
}

for (int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Professor...");
        ((Professor)pessoas[i]).Explicar();
    }
    else
    {
        Console.WriteLine("Aluno...");
        ((Aluno)pessoas[i]).Estudar();
    }
}