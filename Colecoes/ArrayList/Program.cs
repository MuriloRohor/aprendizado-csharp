using System.Collections;

Console.WriteLine("## ArrayList ##");

// Formas de declarar um ArrayList

ArrayList lista;
lista = new ArrayList();

ArrayList lista2 = new ArrayList();
var lista3 = new ArrayList();
ArrayList lista4 = new();

// declarando o Capacity das ArrayList

ArrayList lista5 = new ArrayList(5);
var lista6 = new ArrayList(5);        // -> Capacity = 5
ArrayList lista7 = new(5);

// incluir elementos no ArrayList

lista.Add("Paulo");
lista.Add(4.5);
lista.Add(5);
lista.Add(true);           // -> Uma ArrayList permite incluir elementos de diferentes tipos de dados.
lista.Add(" ");
lista.Add(null);

// Usando inicializadores de objetos

var lista8 = new ArrayList() { "Paulo", 4.5, 5, true, " ", null };