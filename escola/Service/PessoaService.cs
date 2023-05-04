using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Model;
using escola.Interface;

namespace escola.Service
{
  public class PessoaService : IPessoasService
  {
    List<Pessoa> pessoas = new List<Pessoa>();
    public void CadastrarAluno()
    {
      var aluno = new Aluno();

      Console.WriteLine("Qual o número de matrícula?");
      int matricula;
      while (!int.TryParse(Console.ReadLine(), out matricula))
      {
        Console.WriteLine("Numero de matrícula inválido, digite um numero valido");
      }
      aluno.Matricula = matricula;

      Console.WriteLine("Qual o seu nome?");
      aluno.Nome = Console.ReadLine();
      Console.WriteLine("Qual o seu Endereço?");
      aluno.Endereco = Console.ReadLine();
      Console.WriteLine("Qual o seu Telefone?");
      aluno.Telefone = Console.ReadLine();

      pessoas.Add(aluno);

    }

    public void CadastrarProfessor()
    {
      var professor = new Professor();

      Console.WriteLine("Qual a Especialização ?");
      professor.Especialidade = Console.ReadLine();
      Console.WriteLine("Qual o seu nome?");
      professor.Nome = Console.ReadLine();
      Console.WriteLine("Qual o seu Endereço?");
      professor.Endereco = Console.ReadLine();
      Console.WriteLine("Qual o seu Telefone?");
      professor.Telefone = Console.ReadLine();

      pessoas.Add(professor);

    }

    public void ExibirPessoas()
    {
      foreach (var pessoa in pessoas)
      {
        Console.WriteLine(pessoa.ToString());
      }
    }

    public void FiltroPorNome(string nome)
    {
      var filtro = pessoas.Where(x => x.Nome == nome);
      foreach (var pessoa in filtro)
      {
        Console.WriteLine(pessoa.ToString());
      }
    }
  }
}