Console.WriteLine("## List e IEnumerable ##");

// Principais métodos de consultas LINQ

// Any() -> Determina se qualquer elemento de uma sequência existe ou atende a uma
// condição. (Determina se a coleção contém elementos)

// FirstOrDefault() -> Retorna o primeiro elemento da coleção que satifaz uma condição
// opcional. Retorna o valor padrão do tipo caso não encontre nenhum elemento.

// OrderBy() -> Classifica os elementos na coleção em ordem crescente com base em uma
// determinada condição e retorna a coleção classificada.

// ToList() -> Recebe um tipo IEnumerable e o converte em um tipo List.

// Where() -> Retorna todos os elementos da coleção que satisfazem uma determinada condição.(execução adiada)

// List<T> x IEnumerable<T>
// - IEnumerable descreve um comportamento e List implementa esse comportamento.

// - IEnumerable é "read-only", ou seja, eu não consigo alterar a coleção, somente ler.

// - List implementa uma variedade de métodos capazes de acessar e alterar a coleção.


// - IEnumerable possui um método para retornar o próximo item na coleão
// Não precisa ter toda a coleção na memória.
// Nã sabe quantos elementos a coleção possui.
// Ao ser iterada em um laço foreach ela vai retornando o próximo item até o fim da coleção
// Dá ao compilador a chance de adiar a execução
// somente é executada ao ser iterada em um laço foreach/for ou ter um valor extraído


// - List possui toda a coleção em memória e sabe quantos itens possui a coleção




