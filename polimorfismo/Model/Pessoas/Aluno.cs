using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polimorfismo.Model.Pessoas
{
  public class Aluno : Pessoa
  {
    public int Matricula { get; set; }
    private string funcao = "Aluno";
    public Aluno() { }
    public Aluno(string nome, string endereco, string telefone, int matricula) : base(nome, endereco, telefone)
    {
      Matricula = matricula;
    }
    public override string ConverterTexto()
    {
      return $"Função: {funcao}, {base.ConverterTexto()}, Matricula: {Matricula}";
    }
  }
}