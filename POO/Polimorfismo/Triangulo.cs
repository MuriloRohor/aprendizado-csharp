﻿namespace Polimorfismo;

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um Triângulo...");
        base.Desenhar();
    }
}
