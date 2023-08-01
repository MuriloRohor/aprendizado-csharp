using System.Runtime.CompilerServices;

namespace Exercicio_2;

public class LivroFotos
{
    public LivroFotos()
    {
        numPaginas = 16;
    }
    public LivroFotos(int numPaginas)
    {
        this.numPaginas += numPaginas;
    }

    protected int numPaginas;

    public int GetNumeroPaginas()
    {
        return numPaginas;
    }
}
