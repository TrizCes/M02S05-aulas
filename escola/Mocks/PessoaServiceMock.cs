using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using escola.Interface;

namespace escola.Mocks
{
  public interface PessoaServiceMock : IPessoasService
  {
    public void CadastrarAluno()
    {
      Console.WriteLine("Mock Cadastrar Alunos ");
    }

    public void CadastrarProfessor()
    {
      Console.WriteLine("Mock Cadastrar professor ");
    }

    public void ExibirPessoas()
    {
      Console.WriteLine("Mock Exibir Pessoas ");
    }

    public void FiltroPorNome(string nome)
    {
      Console.WriteLine("Mock Filtro Por nome ");
    }
  }
}
