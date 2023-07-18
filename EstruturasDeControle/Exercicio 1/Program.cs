Console.WriteLine("Exercicio 1");

// 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
//Console.WriteLine("Digite 3 números inteiros");

//int n1 = Convert.ToInt32(Console.ReadLine());
//int n2 = Convert.ToInt32(Console.ReadLine());
//int n3 = Convert.ToInt32(Console.ReadLine());

//if (n1 > n2 && n1 > n3)
//{
//    Console.WriteLine($"O primeiro número: {n1} é o maior");
//}
//else if (n2 > n1 && n2 > n3)
//{
//    Console.WriteLine($"O segundo número: {n2} é o maior");
//}
//else
//{
//    Console.WriteLine($"O terceiro número: {n3} é o maior");
//}


// Escreva um programa para calcular a raiz da equação quadrática :
// - Para calcular as raízes use a fórmula de Báskara
// - Considere a, b e c números inteiros (positivos, negativos e o zero)

//Console.WriteLine("Informe o valor de a, b e c\n");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//double delta = Math.Pow(b, 2) - 4 * a * c;

//if (delta > 0)
//{
//    Console.WriteLine("Ambas as raízes são reais e diferentes\n");
//    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//    Console.WriteLine($"x1 = {x1} e x2 = {x2}");
//}
//else
//{
//    Console.WriteLine("As raízes são imaginárias.\nSem solução para os números reais.");
//}



// 3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.
//int soma = 0;
//int num = 1;

//while (num <= 10)
//{
//    soma += num;
//    num++;

//}
//Console.WriteLine($"while: A soma dos números é {soma}");
//soma = 0;
//num = 0;
//for (num = 1; num <= 10; num++)
//{
//    soma += num;
//}
//Console.WriteLine($"for: A soma dos números é {soma}");
//soma = 0;
//num = 0;
//do
//{
//    soma += num;
//    num++;
//}
//while (num <= 10);
//Console.WriteLine($"do-while: A soma dos números é {soma}");




// 4 - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado
//   - Verifique se o número é maior que zero e emita uma mensagem
//   - Considere a tabela de multiplicação de 1 até 10
//   - Após exibir a tabela torne a solicitar outro número
//   - Para sair do loop defina uma condição de saída

//Console.WriteLine("Digite um número maior que 0");
//int num2 = Convert.ToInt32(Console.ReadLine());

//while (num2 > 0)
//{
//    Console.WriteLine($"{num2} é maior que zero");
//    for (int i = 0; i <= 10; i++)
//    {
//        Console.WriteLine($"{num2} x {i} = { num2* i}");
//    }
//    break;

//}



// 5 - Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de
// resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
// Não utilize a instrução break.

// Dica : Usar loop while e instruções if-elseif

//bool repetidor = false;
//while (repetidor == false) 
//{
//    Console.WriteLine("Qual a instrução para sair de um loop ?\r\na.quit\r\nb.continue\r\nc.break\r\nd.exit");
//    string? resposta = Console.ReadLine();


//    if (resposta == "a")
//    {
//        Console.WriteLine("Resposta Errada!");
//    }
//    else if (resposta == "b")
//    {
//        Console.WriteLine("Resposta Errada!");
//    }
//    else if (resposta == "c")
//    {
//        Console.WriteLine("Resposta Correta!");
//        repetidor = true;
//    }
//    else if (resposta == "d")
//    {
//        Console.WriteLine("Resposta Errada!");
//    }
//    else if (resposta == "x") 
//    {
//        Console.WriteLine("Saindo...");
//        repetidor = true;
//    }
//}


// 6 - Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:
//   - Incrementando 2 em cada passo
//   - Incrementando 1 em cada passo
//   - Com e loop infinito (use "break" e "continue")

// Incrementando 1 passo

//for (int i = 10; i <= 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        if (i == 16)
//        {
//            continue;
//        }
//        Console.WriteLine($"{i} é par");
//    }
//}

//// Incrementando 2 passo

//for (int i = 10; i <= 20; i += 2)
//{
//    if (i == 16)
//    {
//        continue;
//    }
//    Console.WriteLine($"{i} é par");
//}

//// loop infinito

//for (int i = 10; i  > 0; i += 2)
//{
//    if (i % 2 == 0)
//    {
//        if (i == 16)
//        {
//            continue;
//        }
//        Console.WriteLine($"{i} é par");
//    }

//}


//7 - Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:
//*
//**
//***
//****(dica: loop aninhado)

//string piramide = "";
//string ast = "*";

//while (true)
//{
//    piramide += ast;
//    Console.WriteLine(piramide);
//    Console.ReadKey();
//}

// 8 - Escreva um programa para calcular o fatorial de um número inteiro.
// O fatorial de um número é representado por : n! => n * (n – 1) *(n – 2) ....2 * 1
// Exemplo: fatorial de 6 é representado por 6! = 6*5*4*3*2*1

//int numFat = Convert.ToInt32(Console.ReadLine());
//int calc = 0;
//int mult = numFat;
//for (int a = numFat; a > 1; a--)
//{
//    calc = mult * (a -1);
//    mult = calc;
//    Console.WriteLine($"{mult} * {a-1} = {calc}");  
//}

// 9 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

//int a = 2;
//int b;
//do
//{
//    b = 1;
//    do
//    {
//        Console.WriteLine($"{a} x {b} = {a*b}");
//        b++;
//    }
//    while (b<=10);
//    a++;
//}
//while (a<=6);

// 10 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)

//do
//{
//    Console.WriteLine("Digite sua nota!");
//    int nota = Convert.ToInt32(Console.ReadLine());
//    switch (nota)
//    {
//        case 10:
//            Console.WriteLine("A+");
//            break;
//        case 9:
//            Console.WriteLine("A");
//            break;
//        case 8:
//            Console.WriteLine("B");
//            break;
//        case 7:
//            Console.WriteLine("B");
//            break;
//        case 6:
//            Console.WriteLine("C");
//            break;
//        case 5:
//            Console.WriteLine("E");
//            break;
//        case 'x':
//            Console.WriteLine();
//            break;
//        default:
//            Console.WriteLine("F");
//            break;
//    }
//}
//while (true);

// 11 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números
// inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e
// quando isso ocorrer exibir uma mensagem de alerta)
//while (true)
//{
//    Console.ReadKey();
//    Console.Clear();
//    Console.WriteLine("Digite o primeiro nº: ");
//    int n1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Digite o operador: ");
//    char operador = Convert.ToChar(Console.ReadLine());
//    Console.WriteLine("Digite o segundo nº: ");
//    int n2 = Convert.ToInt32(Console.ReadLine());
//    switch (operador)
//    {
//        case '+':
//            Console.WriteLine($"{n1} + {n2} = {n1+n2}");
//            break;

//        case '-':
//            Console.WriteLine($"{n1} + {n2} = {n1-n2}");
//            break;
//        case '*':
//            Console.WriteLine($"{n1} * {n2} = {n1*n2}");
//            break;
//        case '/':
//            if (n1 == 0 || n2 == 0){
//                Console.WriteLine("Divisão por 0 não existe");
//                break;
//            }
//            Console.WriteLine($"{n1} / {n2} = {n1/n2}");
//            break;
//    }
//}
