using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Interface;
using escola.Mocks;

namespace escola.Service
{
  public class MenuService
  {
    private readonly IPessoasService _pessoaService;

    public MenuService(IPessoasService pessoaService)
    {
      _pessoaService = pessoaService;
    }
    public void ExibirMenu()
    {

      Console.WriteLine("Bem vindo a escola digite uma opção para continuar:");
      Console.WriteLine("1 - Cadastrar Aluno");
      Console.WriteLine("2 - Cadastrar Professor");
      Console.WriteLine("3 - Exibir Cadastros");
      Console.WriteLine("4 - Filtrar por nome ");
      Console.WriteLine("6 - Sair");

      string opção = Console.ReadLine();

      switch (opção)
      {
        case "1":
          _pessoaService.CadastrarAluno();
          break;
        case "2":
          _pessoaService.CadastrarProfessor();
          break;
        case "3":
          _pessoaService.ExibirPessoas();
          break;
        case "4":
          Console.WriteLine("Por qual nome deseja filtrar ?");
          _pessoaService.FiltroPorNome(Console.ReadLine());
          break;
        case "6":
          return;
        default:
          Console.WriteLine("Opção inválida");
          break;
      }
      Console.WriteLine("\n");
      ExibirMenu();
    }
  }
}