using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_exercise.Models
{
    public class Pessoa
    {
        //constructor abstract agora sera obrigatorio a implementacao de nome na herança
        public Pessoa (string nome)
        {
            Nome = nome;
        }

        //Criando outro constructor agora as heranças terao a opcao de pasar o nome ou nao
        public Pessoa ()
        {

        }

        public string Nome { get; set; }
        public int Idade { get; set; }


        // com virtual indicamos que este metodo pode ser alterado com polimorfismo
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}

