using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Abstract_exercise.Models
{
    public class Aluno : Pessoa
    {
        // Criando contructor, : base(nome): Esta é a chamada para o construtor da classe base en este caso seria . Quando uma classe herda de outra classe em este caso Pessoa
        public Aluno(String nome) : base(nome)
        {

        }

        //criando outro metodo podera ser instacianda sem precisar de pasar o nome. obs: cuando é herdado debera ter os memos contructores do pai
        public Aluno()
        {

        }
        public double Nota { get; set; }
        public string Email { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou um aluno nota {Nota}, meu email é {Email}.");
        }

    }
}