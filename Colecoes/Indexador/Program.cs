Console.WriteLine("## Indexadores ##");

// Os indexadores permitem que as instâncias de uma classe ou struct sejam indexada como um array. Eles lembram as propriedades mas seus assesores (get, set) recebem parâmetros".

// Um indexador é um membro da classe que permite acessar uma variável de membro da classe ou struct usando os recursos de um arrays.

// Quando você define um indexador para uma classe, essa classe se comporta como um array virtual e podemos acessar a instância da classe
// usando o operador de acesso ao array ([]) e também usar índices para acessar e atribuir valores como nos arrays.

// public int this[int index]
// {
//     get { }
//     set { }
// }

// Declaramos um indexador como um método passando um modificador de acesso (public, private, protected ou internal) seguido de um valor de retorno(não pode ser void).
// - O nome do indexador será a palavra reservada this;
// - A lista de parâmetros de entrada devem ser envolvida em colchetes [];
// - Ao final basta definir os assessores get e o set para definiar a lógica de acesso retornando e atribuindo um valor.


Time time = new Time();

//atribuindo valor
time[1] = "Vasco";
time[2] = "Palmeiras";
time[3] = "São Paulo";
time[-1] = "Santos";
time[100] = "Bahia";

//obtendo os valores
string time1 = time[1];
string time2 = time[2];
string time3 = time[3];
string time4 = time[-1];
string time5 = time[100];

Console.WriteLine(time1);
Console.WriteLine(time2);
Console.WriteLine(time3);
Console.WriteLine(time4);
Console.WriteLine(time5);

Console.ReadKey();

public class Time
{
    // definindo os limites do array
    string[] valor = new string[10];

    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < valor.Length)
            {
                //retornando o valor
                return valor[i];
            }
            return "Erro";
        }
        set
        {
            if (i >= 0 && i < valor.Length)
            {
                //atribuir o valor
                valor[i] = value;
            }
        }
    }
}

// Os acessores (get e set) possuem a lógica que assegura que o array não será acessado fora dos seus limites (10 elementos).
// - Um acessor get retorna um valor. Um acessor set define um valor.
// - A palavra-chave this é usada para definir os indexadores.
// - A palavra-chave value é usado para definir o valor que está sendo atribuído pelo indexador set.
// - Um indexador não pode ser estático

// A utilidade de um indexador é fornecer uma sintaxe para acessar, através do índice, itens de um objeto que represente uma coleção.