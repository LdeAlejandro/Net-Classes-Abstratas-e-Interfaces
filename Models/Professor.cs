using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstract_exercise.Models;

namespace Abstract_exercise.Models
{
    public class Professor : Pessoa
    {
         // Criando contructor, : base(nome): Esta é a chamada para o construtor da classe base en este caso seria . Quando uma classe herda de outra classe em este caso Pessoa
        public Professor(String nome) : base(nome)
        {

        }

        //criando outro metodo podera ser instacianda sem precisar de pasar o nome. obs: cuando é herdado debera ter os memos contructores do pai
        public Professor()
        {

        }
        public decimal Salario { get; set; }

        //overrided de Pessoa  Apresentar() para trocar o que o metodo faz.
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome sou o professor {Nome} de {Idade} anos. salario: {Salario}.");
        }
    }
}