using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polimorfismo.Model.Pessoas
{
  public class Professor : Pessoa
  {
    public string Especialidade { get; set; }
    private string funcao = "Professor";

    public Professor() { }
    public Professor(string nome, string endereco, string telefone, string especialidade) : base(nome, endereco, telefone)
    {
      Especialidade = especialidade;
    }

    public override string ConverterTexto()
    {
      return $"Função: {funcao}, {base.ConverterTexto()}, Especialidade: {Especialidade}";
    }
  }
}