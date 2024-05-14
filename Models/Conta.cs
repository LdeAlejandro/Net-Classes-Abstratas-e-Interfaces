

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_exercise.Models
{
    //informamos que sera abstracta com abstract,  unma classe abstrata tem como objetivo exclusivamente um modelo para ser herdado
    public abstract class Conta
    {
        //propiedade da classe abstracta
        protected decimal saldo ;

        //metodo abstracto, nao precisa de chaves {} y deve ser impletado na herança obrigatoriamente, 

        public abstract void Creditar(decimal valor);
       

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }

        
    }
}