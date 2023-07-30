﻿namespace Classes___Agregacao;

public class Departamento
{
    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }

    public string? Nome { get; set; }
    private List<Professor>? professores { get; set; }

    public void IncluirProfesor(Professor professor)
    {
        professores?.Add(professor);
    }

    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de : {Nome}\n");

        foreach (var prof in professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
    }

}
