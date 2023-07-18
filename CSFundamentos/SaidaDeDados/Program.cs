Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

// Escreve na mesma linha 'Maria tem 25 anos'
Console.WriteLine(nome);
Console.WriteLine(" tem ");
Console.WriteLine(idade);
Console.WriteLine(" anos ");

//usar a concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos ");

// usa a interpolação de string : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");

// usar place holders : usa {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);