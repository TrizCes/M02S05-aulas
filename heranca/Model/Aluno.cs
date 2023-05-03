using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Model
{
  public class Aluno : Pessoa
  {
    public int Matricula { get; set; }
    public Aluno() { }
    public Aluno(string nome, string endereco, string telefone, int matricula) : base(nome, endereco, telefone)
    {
      Matricula = matricula;
    }
  }
}
