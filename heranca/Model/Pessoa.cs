using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Model
{
  public abstract class Pessoa
  {

    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    private DateTime Cadastro { get; set; }
    public Pessoa()
    {
      Cadastro = DateTime.Now;
    }
    public Pessoa(string nome, string endereco, string telefone) : this()
    {
      Nome = nome;
      Endereco = endereco;
      Telefone = telefone;
    }
  }
}
