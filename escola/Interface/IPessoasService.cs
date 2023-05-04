using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escola.Interface
{
  public interface IPessoasService
  {
    public void FiltroPorNome(string nome);
    public void ExibirPessoas();
    public void CadastrarAluno();
    public void CadastrarProfessor();
  }
}