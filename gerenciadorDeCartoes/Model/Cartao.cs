using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerenciadorDeCartoes.Model
{
  public class Cartao
  {
    protected double Saldo;

    public Cartao() { }
    public virtual void Creditar(double valor) { }
    public virtual void Debitar(double valor) { }
    public double GetSaldo()
    {
      return Saldo;
    }
  }
}