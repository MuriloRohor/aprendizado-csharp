using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

// 1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
//     Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.
string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine(nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine($"O aluno {nome} tem {idade} anos e nota {nota}\n");

Console.ReadKey();

// 2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
Console.WriteLine($"Aluno: {nome}\nIdade: {idade} anos\nNota: {nota}\n");




// 3 - Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double
// ( ) long
// (x) decimal
float f = 10.5f;
float resultado = f;



// 4 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (x) double para long
// (x) double para float
// (x) decimal para float
// (x) long para int
// (x) double para decimal

int i = 10;
long resultado2 = i;
Console.WriteLine(resultado);


// 5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
char l1, l2, l3;

Console.WriteLine("Digite uma letra: ");
l1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite uma letra: ");
l2 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite uma letra: ");
l3 = Convert.ToChar(Console.ReadLine());


Console.WriteLine("Usando concatenação " + l3 + l2 + l1);
Console.WriteLine($"Usando interpolação {l3} {l2} {l1}\n");

Console.ReadKey();

// 6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal)10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical



//7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
//exibindo o resultado:

Console.WriteLine("Digite o valor de x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A soma de x e y = {x + y}");
Console.WriteLine($"A subtração de x e y = {x - y}");
Console.WriteLine($"A multiplicação de x e y = {x * y}");
Console.WriteLine($"A exponenciação de x e y = {Math.Pow(x, y)}");
Console.WriteLine($"A divisão de x e y = {x / y}");
Console.WriteLine($"O resto de x e y = {x % y}\n");

Console.ReadKey();

// 8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
// a b e c .
// Valores : a = 1 , b = 12 e c = -13
int a = 1, b = 12, c = -13;
double delta, x1, x2;

delta = Math.Pow(b, 2) - 4 * a * c;

x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;
Console.WriteLine($"Valor de x1 = {x1}\nValor de x2 = {x2}\n");


Console.ReadKey();

// 9 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ 
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
// inválido’: (use o operador condicional ternário)
Console.WriteLine("Digite o usuario: ");
string usuario = Console.ReadLine();

Console.WriteLine("Digite a senha: ");
int senha =  Convert.ToInt32(Console.ReadLine());

string login = (usuario == "maria" || usuario == "admin") && senha == 123 ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(login);

Console.ReadKey();

// 10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando 
// a nomenclatura usada:
// (V) string? nome; é um exemplo de nullable reference type;
// (F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
// (F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
// (V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
// (F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
// (F) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
// (V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
// (F) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
// (F) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
// (V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
// (V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"




//11 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
Console.WriteLine("Exercícios fase 2");

Console.WriteLine("Digite o valor de x: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y: ");
int n2 = Convert.ToInt32(Console.ReadLine());

string calc = n1 % 2 == 0 && n2 % 2 == 0 ? "x e y são pares" :
            n1 % 2 == 0 ? "x é par" :
            n2 % 2 == 0 ? "y é par" : "x e y não são pares";

Console.WriteLine(calc);

Console.ReadKey();

// 12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
// console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415)
//-6 + x * 5
//(13 - 2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x ^ 2 + x + 10
//pi* x^2

Console.WriteLine("Digite um Valor: ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(-6 + n3 * 5);
Console.WriteLine((13-2) * n3);
Console.WriteLine((n3 + -2) * (20/n3));
Console.WriteLine((12 + n3) / (n3 - 4));

double rel = 3 * Math.Pow(n3, 2) + n3 + 10;
double area = Math.PI * Math.Pow(n3, 2); 

Console.WriteLine(rel);
Console.WriteLine(area);

Console.ReadKey();

// 13 - Considere o seguinte trecho de código:
// int y = 5;
// y = (y++) + y + (++y); ou y = y++ + y + ++y;
int e = 5;
e = (e++) + e + (++e);
Console.WriteLine(e);




// 14 - Escreva um programa que solicite a temperatura em graus Celsius e converta para 
// Kelvin e Farhenheit usando as fórmulas a seguir:
// -Converter para Kelvin => K = C + 273;
// -Converter para Farhenheit => F = (C * 9) / 5 + 32;

Console.WriteLine("Digite a temperatura em Celsius (Cº): ");
double tempC = Convert.ToDouble(Console.ReadLine());
double tempK = tempC + 273;
double tempF = (tempC * 9) / 5 + 32;
Console.WriteLine($"Temperatura em Celsius {tempC}ºC\nTemperatura em Farhenheit {tempF}ºF\nTemperatura em Kelvin {tempK} K ");




// 15 - Escolha a opção que representa a exibição do resultado para o código usando os 
// operadores de decremento e incremento (pré e pós): 
// R: 5 2 2 2

