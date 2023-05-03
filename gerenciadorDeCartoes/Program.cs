using gerenciadorDeCartoes.Model;
public class Program
{

  private static void Main(string[] args)
  {
    CartaoCredito itaucard = new CartaoCredito();
    itaucard.Creditar(256); //compra
    itaucard.Debitar(50); //deposito

    Console.WriteLine("Itaucard: " + itaucard.GetSaldo());

    Cartao mastercard = new CartaoDebito();
    mastercard.Creditar(256); //deposito
    mastercard.Debitar(50); //compra

    Console.WriteLine("Mastercard: " + mastercard.GetSaldo());
  }
}
