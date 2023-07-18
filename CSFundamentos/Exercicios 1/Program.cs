﻿// 1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
using System.Drawing;

int idade = 35;
Console.WriteLine(idade);

// 2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

// 3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine(altura);

// 4 - Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);

// 5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor.
const int ANO = 12;
Console.WriteLine(ANO);

// 6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine(nota);

/* 7- Quais as diferenças entre os tipos por valor e os tipos por referência 

 - Tipos por valor: Cópia completa do valor, manipulação segura. 
   Exemplos: inteiros, números de ponto flutuante, caracteres, estruturas.
   Armazenam os dados diretamente onde cada variável tem a cópia dos dados e são armazenados na memória Stack

 - Tipos por referência: Referência ao objeto, compartilhamento de dados, eficiência. 
   Exemplos: arrays, strings, objetos.
   Não armazenam os dados diretamente e cada variável contém uma referência ao local da memória onde os dados estão. São armazenados na memória Heap

*/

// 8 - Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
int _x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = false;
string name = "Manoel";
decimal salario = 950.99m;
DateTime hoje = DateTime.Now;

/* 9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
referência (R) :
(V) int n = 1;
(R) string titulo = "A vida";
(V) float f = 12.45f;
(V) double d = 5.45;
(V) decimal valor = 10.99m;
(V) char sexo = ‘M’;
(R) object o = null
*/

/* 10- O que é um nullable type e qual a sua utilidade ?
  ele determina que a variavel aceite valores null.
  oferece mecanismo para lidar com situações que o valores pode estar ausente ou indefinido.
 */

/* 11 - O que é Camel Case ? Dê um exemplo de sua aplicação.
   Camel Case é uma convenção usada em variáveis, parâmetros e campos internos privados
   A primeira letra da primeira palavra é iniciada com minúscula. A letra de cada palavra seguinte
   deve ser iniciada com maiúscula.
   Ex: somarTotal, validarCpf.
*/

/* 12 - O que é Pascal Case ? Dê um exemplo de sua aplicação.
   Pascal Case é uma conveção usada em nomes de classes, métodos, interfaces, propriedades
   A primeira letra de cada palavra é iniciada com maiúscula.
   Ex: ValorComDesconto, TotalDePedidos.
*/

/*13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
operação de soma)
*/
int x = 77, y = 66;
Console.WriteLine(x + y);

/* 14 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string
bool: false.
char: '\0' ou '(U+0000)'.
int: 0.
double: 0.0.
float: 0.0f.
decimal: 0.0m.
string: "".
*/

/* 15 - Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis 
considerando a nomenclatura usada:
(F) double 1valor = 12.45; 
(F) string #nome = "Pedro"; 
(V) float _temperatura = 12.45f; 
(F) double int = 5; 
(F) decimal renda extra = 91.45m;
(F) bool status$conta = false;
(V) string titulo3 = “Tópico 1”; 
(V) float salario_mensal = 1999.55f;
(V) int percentualValorDesconto = 5;
(V) const bool MENSALIDADE_EM_DIA = true;
*/