// ESTUDOS LIST<>

string[] nomes = { "Ana", "João", "Carlos", "Maria", "Paula", "Barbara" };
List<string> aluno = new List<string>();

// AddRange(IEnumerable<T> collection): adiciona todos os itens da coleção que foi passada como parâmetro à lista.
Console.WriteLine("Adicionado com AddRange()");
aluno.AddRange(nomes);
ListarAlunos(aluno);

// Sort(): ordena a lista utilizando o comparador padrão do tipo de item contido na lista. Este método também pode receber como parâmetro objetos que definem a forma como a comparação entre os itens deve ser feita.
Console.WriteLine("Ordenado com Sort()");
aluno.Sort();
ListarAlunos(aluno);

// Capacity: representa o número de elementos que a lista pode suportar sem que precise ser redimensionada. A partir desse número, novos elementos farão com que o compilador aloque mais memória para a lista.
Console.WriteLine($"Tamanho da Lista: {aluno.Capacity}");

// Count: retorna (apenas leitura) a quantidade de itens que atualmente existe na lista.
Console.WriteLine($"Quantidade de Elementos na Lista: {aluno.Count} ");

Console.WriteLine("Adicionando aluno com Add()");
aluno.Add("Pedro");
Console.WriteLine("Ordenando após inserção:");
aluno.Sort(); // Ordenando
ListarAlunos(aluno);

//Contains(T item): retorna um valor booleano indicando se o item pesquisado existe na lista.
Console.WriteLine("Verificando se aluno existe com Contains()");
bool contem = aluno.Contains("Carlos");
Console.WriteLine(contem ? "Aluno Carlos existe" : "Aluno Carlos não existe");

//Insert(int index, T item): funciona semelhante ao Add, mas insere o item em uma posição definida por index.

Console.WriteLine("Adicionando aluno com Insert() - Index 2");
aluno.Insert(2, "Júlio");
ListarAlunos(aluno);
Console.WriteLine("Ordenando após inserção:");
aluno.Sort();
ListarAlunos(aluno);

//InsertRange(int index, IEnumerable<T> collection): funciona semelhante ao AddRange, mas insere a nova lista na posição definida por index.
Console.WriteLine("Inserindo com InsertRange() - Index 4" +
                  "\nObs.: Adiciona um array");
string[] novosAlunos = { "Ana Paula, José, Patrick" };
aluno.InsertRange(4, novosAlunos);
ListarAlunos(aluno);
Console.WriteLine("Ordenando após inserção:");
aluno.Sort();
ListarAlunos(aluno);

//Remove(T item): remove o item da lista e retorna um booleano indicando o sucesso da operação. Caso o item não seja encontrado, também retorna false.
Console.WriteLine("Removendo lista de alunos adicionada acima com Remove()");
bool removido = aluno.Remove("Ana Paula, José, Patrick");
Console.WriteLine(removido ? "Alunos removidos" : "Alunos não removidos");
ListarAlunos(aluno);

// Count e Capacity
Console.WriteLine($"Quantidade de Elementos na Lista: {aluno.Count} ");
Console.WriteLine($"Tamanho da Lista: {aluno.Capacity}");

// ToArray(): retorna um vetor do tipo contido na lista.
Console.WriteLine("Retornando um array com os itens da lista com ToArray()");
var arr = aluno.ToArray();

Console.WriteLine("Listando alunos retornados no array");
foreach (var nome in arr)
{
  Console.WriteLine($"Aluno: {nome}");
}


// Função para listar todos alunos
void ListarAlunos(List<string> aluno)
{
  foreach (var nome in aluno)
  {
    Console.WriteLine($"Aluno: {nome}");
  }
}

// REFERÊNCIA das definições dos métodos e propriedades: http://www.linhadecodigo.com.br/artigo/3676/listt-trabalhando-com-listas-genericas-em-csharp.aspx
// https://www.macoratti.net/14/12/c_deleg3.htm




