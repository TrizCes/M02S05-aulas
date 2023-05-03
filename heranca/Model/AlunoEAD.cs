using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Model
{
  public class AlunoEAD : Aluno
  {
    public string ProvedorInternet { get; set; }

    public AlunoEAD() { }
    public AlunoEAD(string nome, string endereco, string telefone, int matricula, string provedorInternet) : base(nome, endereco, telefone, matricula)
    {
      ProvedorInternet = provedorInternet;
    }
  }
}