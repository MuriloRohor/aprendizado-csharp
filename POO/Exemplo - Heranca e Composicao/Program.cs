using Exemplo___Heranca_e_Composicao;

Console.WriteLine("Herança e Composição");

ComportamentoAndar andar = new ComportamentoAndar();
ComportamentoNadar nadar = new ComportamentoNadar();

var homem = new Homem(andar);
homem.Locomocao();

var macaco = new Macaco(andar);
macaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();

Console.ReadKey();
