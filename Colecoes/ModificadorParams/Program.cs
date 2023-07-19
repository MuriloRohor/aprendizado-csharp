﻿Console.WriteLine("## Modificador params ##");

int[] valores = { 1, 2, 3 };

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(1, 2 ,3 ,4);
Console.WriteLine(resultado2);


Console.ReadKey();

public class Calcular
{
    public static int Soma( params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total = total + numero;
        }
        return total;
    }
}