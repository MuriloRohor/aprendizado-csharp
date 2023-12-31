﻿using Heranca___Exercicio;

Console.WriteLine("## Herança - Exercicio ##");
// Escrever um programa onde devemos usar os conceitos de abstração, encapsulamento e herança para expressar o comportamento de
// contas bancárias considerando o seguinte cenário :

// Em um banco temos clientes que possuem contas que são identificadas por um Número e Nome do cliente.
// As operações que serão permitidas são as operações básicas de depositar, sacar e exibir o saldo.

// CONSIDERE 3 TIPOS DE CONTAS:

// 1 - contas correntes comuns : São contas comuns dos clientes e realizam todas as operações básicas.
// 2 - contas de poupança      : São contas especificas que se destacam por possuírem juros mensais que são aplicados ao saldo da conta.
// 3 - contas de investimento  : São contas especificas que se destacam por possuir uma taxa de remuneraão que é aplicada ao saldo da conta
// e uma taxa de imposto que é descontado do saldo da conta.

// CONSIDERE AS SEGUINTES PREMISSAS:

// a - O saldo incial das contar é zero.
// b - O juros da conta de popança é 0.5% e os rendimentos devem ser calculados ao se efetuar um deposito e deve ser acrescido ao salda da conta.
// c - A taxa da conta de investimentos é 0.9% e deve ser aplicada a cada depósito e acrescida ao saldo.
// d - O imposto da conta de investimento é 0.1%

// Realizar para cada conta a atribuição dos valores das propriedadas e exibir no console.

// Fazer um depósito de R$ 1.000,00 e um saque de R$ 100,00 para cada tipo de conta exibindo o resultado no console.

// Fazer um saque de R$ 2.000,00 em cada conta e exibir o saldo no console.

Console.WriteLine("\nConta Corrente : Número: 111 Titular: Maria");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";
Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta : {conta.Saldo.ToString("c")}");

Console.ReadKey();

Console.WriteLine("\nConta Poupança : Número: 222 Titular: José");
ContaPoupanca contaPoupanca = new();
contaPoupanca.Numero = 222;
contaPoupanca.Titular = "José";
Console.WriteLine("Depositando R$ 1.000,00");
contaPoupanca.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo da Conta Poupança : {contaPoupanca.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
contaPoupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta Poupança : {contaPoupanca.Saldo.ToString("c")}");

Console.ReadKey();

Console.WriteLine("\nConta Investimento : Número: 333 Titular: Ana");
ContaInvestimento contaInvestimento = new();
contaInvestimento.Numero = 333;
contaInvestimento.Titular = "Ana";
Console.WriteLine("Depositando R$ 1.000,00");
contaInvestimento.Depositar(1000);
Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 100,00");
contaInvestimento.Sacar(100);
Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");
Console.WriteLine("Sacando R$ 2.000,00");
contaInvestimento.Sacar(2000);
Console.WriteLine($"Saldo da Conta Investimento : {contaInvestimento.Saldo.ToString("c")}");


Console.ReadKey();
