using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace statica.Model
{
  public abstract class Pessoa
  {
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    private DateTime DataCadastro { get; set; }
    public Pessoa()
    {
      DataCadastro = DateTime.Now;
    }
    public Pessoa(string nome, string endereco, string telefone) : this()
    {
      Nome = nome;
      Endereco = endereco;
      Telefone = telefone;
    }

    public virtual string ConverterTexto()
    {
      return $"Nome:  {Nome}, Endereco: {Endereco}, Telefone: {Telefone}";
    }

    public override string ToString()
    {
      return $"Nome: {Nome}, Telefone: {Telefone}, Endereco: {Endereco}";
    }
  }
}