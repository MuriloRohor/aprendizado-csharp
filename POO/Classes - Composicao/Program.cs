Console.WriteLine("## Classes - Composição ##");

// Relacionamento "É um" - Representado pela Herança.

// Relacionamento "Tem um" - Representado pela Composição e pela Agregação.

// A Composição e Agregação são técnicas de programação que permitem que uma classe
// "contenha" um ou mias objetos de outras classes para formar um grande objeto realizando
// algumas funcionalidades específicas

// O contêiner é a superclasse ou classe pai e as clases contidas na superclasse são subclasses
// ou classes filhas, onde a classe pai (superclasse) e as classes filhas (subclasses) possuem um
// relacionamento "tem-um".

// Composição ->

// Um relacionamento de composição ocorre quando um objeto de uma classe é composto de um ou mais objeto
// de outras outras classes.

// Este relacionamento é formado quando uma classe tem uma referência a outra
// clase como uma propriedades de instância.

// Na composição, uma classe que contém a referência a outra classe é a classe pai sendo
// a proprietária da classe filha, e a classe filha não existe sem a classe pai.

// A composição é um realacionamento do tipo : "Tem um"

// Representa uma relação Todo - parte
// - O objeto todo(pai) é responsável por criar e destruir as suas partes (filhas);
// - A parte (filha) não existe sem o todo (pai)
// - Um mesmo objeto-parte não pode se associar a mais de um objeto-Todo;

Console.ReadKey();

public class Casa
{
    private readonly Telhado _telhado;
    private readonly Alicerce _alicerce;

    public Casa()
    {
        _telhado = new Telhado();
        _alicerce = new Alicerce();
    }
}

public class Telhado
{
    //...
}

public class Alicerce
{
    //...
}

// A classe Casa contém referências ás classes Telhado e Alicerce expressando o relacionamento de Composição entre a classe
// Casa e as classes Telhado e Alicerce.

// As classes Telhado e Alicerce não fazem sentido sem a classe Casa.

// Usando a composição, podemos escolher as funcionalidades que queremos implementarna classe composta(Casa) com base nos seus
// componentes (Telhado e Alicerce). "Na herança a classe base teria acesso a todos os membros da classe derivada".