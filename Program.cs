using Abstract_exercise.Models;
using Abstract_exercise.Interfaces;



//*************************************************************************************************



//*************************************************************************************************
//as intefaces nao podem ser instaciadas, mas podem ser usadas da seguinte manera: 
ICalculadora c1 = new Calculadora();

Console.WriteLine($"Soma: {c1.Somar(1,3)}");
Console.WriteLine($"Substrair: {c1.Subtrair(1,3)}");
Console.WriteLine($"Multiplicar: {c1.Multiplicar(1,3)}");
Console.WriteLine($"Dividir: {c1.Dividir(1,3)}");


//*************************************************************************************************
// Computador c = new Computador();

// Console.WriteLine(c.ToString());

//*************************************************************************************************
//instanciando pessoa
// Pessoa p1 = new Pessoa("Alejandro");

// //Agora as classes instanciadas exigem o nome da classe Pessoa herdada do constructor Pessoa 
// Aluno a1 =  new Aluno("Pedrito");   
// a1.Apresentar();

//*************************************************************************************************
// Corrente c = new Corrente();

// c.Creditar(500);
// c.ExibirSaldo();