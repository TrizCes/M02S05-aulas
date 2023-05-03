using heranca.Model;

Pessoa aluno1 = new Aluno();
aluno1.Nome = "Maria";
((Aluno)aluno1).Matricula = 01;


Pessoa professor1 = new Professor("Vitor", "Rua três", "(47) 3333-8888", "C#");

Pessoa aluno2 = new AlunoEAD();
aluno2.Nome = "Maria";
((AlunoEAD)aluno2).Matricula = 02;
((AlunoEAD)aluno2).ProvedorInternet = "Unifique";

Console.WriteLine(aluno2.Nome);
