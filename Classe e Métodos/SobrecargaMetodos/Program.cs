Console.WriteLine("## Assinatura de método - Sobrecarga ##");
Email email = new Email();

email.Enviar("Rua 123");
email.Enviar(100, "Rua 123");
email.Enviar("Rua 123", 100);
email.Enviar("Rua 123", "Assunto Teste");

Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão");
    }
    
    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagemento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}