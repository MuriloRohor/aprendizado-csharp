Console.WriteLine("## Generics - Introdução ##");

// Na linguagem C# Generics significa não ser específico para um determinado tipo de dados.

// A linguagem C# permite definir classes, interfaces, campos, métodos, propriedades, eventos, delegates e operadores genéricos usando o parâmetro de tipo
// e sem o tipo de dados específico.

// O recurso Generics permite que classes, métodos e interfaces possam ser parametrizados por tipo

// Já utilizamos o recurso Generics quando tratamos das coleções List<int>, List<string> e List<object>

// || Generics - Sintaxe ||

// Um tipo genérico é declarado especificando um parâmetro de tipo entre colchetes angulares (<T>) após um nome de tipo

// NomeTipo<T> onde T é o parâmetro de tipo.

public class ClasseGeneric<T>
{
    // codigo

    public void MetodoGeneric<T>(T a)
    {
        // codigo
    }
}

public interface INterfaceGeneric<T>
{
    // codigo
}


// 2 parâmetros de Tipo

public class ClasseGeneric<T1, T2>
{
    // codigo

    public void MetodoGeneric<T1,T2>(T1 a, T2 b)
    {
        // codigo
    }

}

public interface INterfaceGeneric<T1,T2>
{
    // codigo
}

// Também é permitido definir restrições para restringir o código do cliente afim de especificar determinados tipos ao instanciar tipos genéricos.

// Podemos definir uma ou mais restrições no tipo genérico usando a clásula where após o nome do tipo genérico seguido de dois pontos e a seguir a restrição
// que desejamos definir

// NomeTipo<T> where T : <restrição>



