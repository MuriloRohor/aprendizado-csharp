using Classes___Agregacao;

Console.WriteLine("Classes - Agragação");
// Um relacionamento de agregação é um tipo especial de composição onde objetos de uma classe
// podem conter um ou mais objetos de outra classe

// A agregação é um relacionamento do tipo : "Tem um"
// Representa uma relação Todo - parte
// - A parte e o todo são independentes
// - A parte pode existir sem o todo

Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Maria", "Inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemática");

Departamento dep1 = new Departamento("Exatas");

dep1.IncluirProfesor(prof1);
dep1.IncluirProfesor(prof4);
dep1.ListaProfessores();

Console.ReadKey();

Departamento dep2 = new Departamento("Humanas");

dep2.IncluirProfesor(prof2);
dep2.IncluirProfesor(prof3);
dep2.ListaProfessores();

Console.ReadKey();