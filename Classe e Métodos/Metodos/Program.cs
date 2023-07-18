Console.WriteLine("## Métodos ##\n");

MinhaClasse objeto = new MinhaClasse();

objeto.Saudacao();

Console.ReadKey();
class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo");
        ExibirDataAtual();
    }
    public void ExibirDataAtual() => // as setas compacta os metodos com uma instrução
        Console.WriteLine(DateTime.Now.ToShortDateString());
}
