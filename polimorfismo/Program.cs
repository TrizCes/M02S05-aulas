using polimorfismo.Model;
using polimorfismo.Model.Pessoas;

public class Program
{
  public static void Main(string[] args)
  {
    Aluno aluno1 = new Aluno("Lua", "Rua quatro", "(01)98888-9874", 123);

    Professor prof1 = new Professor("Prof1", "Rua Cinco", "(01)95647-9874", "C#");

    Console.WriteLine(aluno1.ConverterTexto());
    Console.WriteLine(prof1.ConverterTexto());
  }
}