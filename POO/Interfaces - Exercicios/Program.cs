using Interfaces___Exercicios;

Console.WriteLine("## Interfaces - Exercicios ##");

// Criar um programa C# que usa interfaces para salvar arquivos nos formatos Xml e Json.

// - Criar a interface ISalvar definindo o método abstrato Salvar()
// - Criar uma classe abstrata ArquivoBase e definir um método virtual Nome().
// - Criar as classes SalvarXml e SalvarJson e herdar a classe base e implementar a interface
// nas suas classes.
// - Testar a implementação.
// - Incluir o método não abstrato Compactar() na interface definindo uma implementação.
// - Acessar este método.

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

Console.ReadKey();