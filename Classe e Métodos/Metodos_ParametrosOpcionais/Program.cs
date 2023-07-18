Console.WriteLine("## Parâmetros Opcionais ##");

Console.WriteLine("Informe o Destino");
var destino = Console.ReadLine();

Console.WriteLine("Informe o Titulo");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o Assunto");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

// não posso fazer
// email.Enviar(destino, , assunto);

email.Enviar(destino, assunto: assunto);


Console.ReadKey();
public class Email
{
    public void Enviar(string destino = "Destino Padrão", string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}
