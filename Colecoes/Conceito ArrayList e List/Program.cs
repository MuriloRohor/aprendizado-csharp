using System.Collections;

Console.WriteLine("## Conceitos ArrayList e List ##");

// Boxing : É a conversão de um Value Type para um Reference Type.
// Unboxing : É quando um Reference Type (object) volta a ser um Value Type.

int num = 23;
Object obj = num; // Boxing
int i = (int)obj; // Unboxing

// Comportamento ArrayList ->

// Uma coleção ArrayList pode armazenar elementos de diversos tipos de dados: Value Type e Reference Type.

// Qualquer tipo de referência ou valor que é adicionado a um ArrayList é implicitamente convertido para System.Object.

// Se os itens são tipos de valor, eles devem sofrer boxing quando adicionado à coleção, e unboxing quando eles são recuperados da coleção.

// São operaçõesq ue degradam o desempenho, e o efeito de realizar as operações boxing e unboxing pode ser bastante significativo em cenários onde
// devemos percorrer grandes coleções.


// Comportamento List<T> ->

// É uma coleção de objetos fortemente tipados onde T representa o tipo dos dados dos elementos que serão armazenados na coleção.

// Na coleção List<T> não existe a necessidade de que todos os itens sejam convertidos para Object e também ela permite que o compilador faça a verificação de tipo.

// Incluir e recuperar elementos de uma Lista<T> não são realizadas as operações de boxing e unboxing.


// Comparando comportamentos de List<T> e ArrayList.

// ArrayList
ArrayList lista = new ArrayList();
lista.Add(3);              // boxing
lista.Add(105);            // boxing

// Recuperar o Valor
var elemento = lista[0];   // unboxing
int item = (int)lista[1];  // unboxing


//List<T>
List<int> lista2 = new List<int>();
lista2.Add(3);             // sem boxing
lista2.Add(105);           // sem boxing

// Recuperar valor
var elemento2 = lista2[0]; // sem unboxing
int item2 = lista2[1];     // sem unboxing

