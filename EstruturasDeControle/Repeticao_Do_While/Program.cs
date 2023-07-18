Console.WriteLine("## Instrução Do While ##\n");
// While -> Pode não executar as instruções nenhuma vez
// Do-While -> Executa as instruções pelo menos uma vez
int i = 1;

do
{
    Console.WriteLine($"\ni = {i}\n");
    i++;
    if (i > 7)
    {
        break;
    }
}
while (i <= 10);

Console.ReadKey();


// instrução do-while aninhadas
int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    while (y<5);
    {
        x++;
        Console.WriteLine();
    }
}
while (x<5);
