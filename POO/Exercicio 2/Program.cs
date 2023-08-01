
using Exercicio_2;

Console.WriteLine("## Exercicio 2 ##");

// Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação
// orientada a objetos. 

// Para começar, crie uma classe chamada LivroFotos com um atributo privado numPaginas do
// tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
// páginas do álbum de fotos

// O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
// construtor adicional, com o qual podemos especificar o número de páginas que queremos
// no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
// 64 páginas.

// Por fim, execute as seguintes ações:
// - Criar um álbum de fotos padrão e exibir o número de páginas
// - Criar um álbum de fotos com 24 páginas e exibir o número de páginas
// - Criar um álbum de fotos grande e exibir o número de páginas

LivroFotos albumPadrao = new LivroFotos();
LivroFotos album24 = new LivroFotos(24);
SuperLivroFotos album64 = new SuperLivroFotos();

Console.WriteLine($"Álbum de fotos padrão : Nº - Páginas {albumPadrao.GetNumeroPaginas()}");
Console.WriteLine($"Álbum de fotos médio  : Nº - Páginas {album24.GetNumeroPaginas()}");
Console.WriteLine($"Álbum de fotos grande : Nº - Páginas {album64.GetNumeroPaginas()}");


Console.ReadKey();