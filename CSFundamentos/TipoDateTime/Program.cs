Console.WriteLine("## Struct DateTime ##\n");
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// criar uma data especifica usa formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2022, 09, 04, 11, 10, 20);
Console.WriteLine(dataHoje);

// definir as horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);
Console.ReadKey();


// extrair informações da tata atual
DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

Console.ReadKey();