using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Model
{
  public class Professor : Pessoa
  {
    public string Especialidade { get; set; }

    public Professor() { }
    public Professor(string nome, string endereco, string telefone, string especialidade) : base(nome, endereco, telefone)
    {
      Especialidade = especialidade;
    }
  }
}