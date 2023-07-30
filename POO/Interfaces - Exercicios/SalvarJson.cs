namespace Interfaces___Exercicios;

public class SalvarJson : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquvio Json");
    }

    public override void Nome()
    {
        Console.WriteLine("Definir nome Json");
    }
}
