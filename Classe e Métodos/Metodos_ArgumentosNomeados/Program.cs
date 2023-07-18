Console.WriteLine("## Argumentos Nomeados ##\n");

Email email = new();

email.Enviar("teste@email.com", "Urgente", "Reunião de Orçamento");

// argumentos nomeados

email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião de Orçamento");
email.Enviar(titulo: "Urgente", assunto: "Reunião de Orçamento", destino: "teste@email.com");
email.Enviar(assunto: "Reunião de Orçamento", titulo: "Urgente" ,destino: "teste@email.com");


Console.ReadKey();
public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}
