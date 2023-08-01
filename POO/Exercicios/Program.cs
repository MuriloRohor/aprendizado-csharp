
Console.WriteLine("Hello, World!");
// 1 - Uma classe derivada pode interromper a herança virtual declarando um override como :
// ( )inherits ( )extends ( )private ( )not inheritable ( x )sealed

//=========================================================================================================================================================
//=========================================================================================================================================================

// 2 - Qual das palavras-chave a seguir é usada para alterar os dados e o comportamento de
// uma classe base substituindo um membro de uma classe base por um novo membro
// derivado ?
// ( )new ( )base ( )overloads (x)override ( )overridable

//=========================================================================================================================================================
//=========================================================================================================================================================

// 3 - Qual das seguintes afirmações está correta?
// A( ) Os métodos estáticos podem ser um método virtual.
// B( ) Os métodos abstratos não podem ser um método virtual.
// C( ) É obrigatório substituir um método virtual.
// D(x) Ao substituir um método virtual, os nomes e as assinaturas do método de substituição devem ser os
// mesmos do método virtual que está sendo substituído.
// E( ) Podemos substituir métodos virtuais e não virtuais.

//=========================================================================================================================================================
//=========================================================================================================================================================


// Quais dos seguintes requisitos são necessários para o polimorfismo em tempo de execução?
// 1 - O método base substituído deve ser virtual ou abstract
// 2 - Tanto o método override quanto o método virtual devem ter o mesmo modificador de nível
// de acesso.
// 3 - Uma declaração override pode alterar a acessibilidade do método virtual.
// 4 - Uma propriedade abstrata herdada não pode ser substituída em uma classe derivada.
// 5 - Um método abstrato é implicitamente um método virtual.
// ( )1 e 3  (x)1, 2, e 5  ( )2, 3 e 4  ( )somente 4


//=========================================================================================================================================================
//=========================================================================================================================================================

// Qual o resultado da execução do código acima
// considerando as classes A e B.
// Onde B herda da classe A.

// B b = new B();
// b.i = 1;
// b.j = 2;
// b.Exibir();
// Console.ReadKey();

// class A
// {
//    public int i;
//    public void Exibir()
//    {
//        Console.WriteLine(i);
//    }
// }
// class B : A
// {
//     public int j;
//     public void Exibir()
//     {
//        Console.WriteLine(j);
//     }
// }

// Resposta -> b.Exibir() vai retornar o valor 2 ja que ele está escutando o método da classe base.

//=========================================================================================================================================================
//=========================================================================================================================================================

// Qual o resultado da execução do código acima
// considerando as classes A e B, onde B herda da classe A ?

// A a = new A();
// B b = new B();
// A x;
// x = a;
// x.Exibir();
// x = b;
// x.Exibir();

// class A
// {
//    public virtual void Exibir()
//    {
//        Console.WriteLine("A");
//    }
// }
// class B : A
// {
//    public override void Exibir()
//    {
//        Console.WriteLine(" B ");
//    }
// }

// Resposta -> vai imprimir a letra A e depois a letra B.

//=========================================================================================================================================================
//=========================================================================================================================================================
