// IList<>
using ilist.Models;

Estudante e1 = new Estudante() { Nome = "Jorge", Sobrenome = "Alves", Idade = 34 };
Estudante e2 = new Estudante() { Nome = "Maria", Sobrenome = "Souza", Idade = 22 };
Estudante e3 = new Estudante() { Nome = "Paulo", Sobrenome = "Amaral", Idade = 28 };

IList<Estudante> listaEstudante = new List<Estudante>(){ e1, e2, e3};

foreach (var e in listaEstudante)
{
  Console.WriteLine($"Aluno: {e.Nome} {e.Sobrenome}\nIdade: {e.Idade}");
}