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
aluno.Sort(); // Ordenando
ListarAlunos(aluno);

//Contains(T item): retorna um valor booleano indicando se o item pesquisado existe na lista.
bool contem = aluno.Contains("Carlos");
Console.WriteLine(contem ? "Aluno Carlos existe" : "Aluno Carlos não existe");




void ListarAlunos(List<string> aluno)
{
  foreach (var nome in aluno)
  {
    Console.WriteLine($"Aluno: {nome}");
  }
}

// REFERÊNCIA das definições dos métodos e propriedades: http://www.linhadecodigo.com.br/artigo/3676/listt-trabalhando-com-listas-genericas-em-csharp.aspx
// https://www.macoratti.net/14/12/c_deleg3.htm




