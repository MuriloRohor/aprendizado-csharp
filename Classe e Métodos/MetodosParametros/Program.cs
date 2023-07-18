Console.WriteLine("## Métodos com Parâmetros ##");

MinhaClasse objeto = new MinhaClasse();

// valores dos argumentos
objeto.Saudacao("Murilo", DateTime.Now.ToShortDateString());

Aluno aluno1 = new Aluno();
aluno1.Consultar();


Console.ReadKey();
public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}
public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Nome: ");
        aluno1.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno1.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno1.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno1.Aprovado = Console.ReadLine();


        Curso curso = new Curso();
        curso.Resultado(aluno1);

    }

}
public class Curso
{
    public void Resultado(Aluno aluno1)
    {
        Console.WriteLine($"O aluno {aluno1.Nome}, sexo {aluno1.Sexo} com {aluno1.Idade} anos ");
        if (aluno1.Aprovado == "sim")
        {
            Console.WriteLine("\n foi Aprovado");

        }
        else
        {
            Console.WriteLine("\n foi Reprovado");
        }
    }
}
