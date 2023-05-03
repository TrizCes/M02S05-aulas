using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerenciadorDeCartoes.Model
{
  public class CartaoDebito : Cartao
  {
    public override void Debitar(double valor)
    {
      Saldo -= valor;
    }
    public override void Creditar(double valor)
    {
      Saldo += valor;
    }
  }
}