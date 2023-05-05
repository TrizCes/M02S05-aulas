using statica;

Calculadora calculadora = new Calculadora();

var soma = Calculadora.Soma(5, 3); // metodo static é chamado diretamente pela classe "Calculadora"

var subtracao = calculadora.Subtracao(6, 3); //metodo não static necessita que seja instanciado;

Contador i = new Contador();

i.IncrementaNum();
i.IncrementaNum();
i.IncrementaNum();

Console.WriteLine(i.GetNum());

Contador i2 = new Contador();

i2.IncrementaNum();
i2.IncrementaNum();


Console.WriteLine(i2.GetNum());