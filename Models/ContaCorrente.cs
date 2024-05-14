using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_exercise.Models
{
    public class ContaCorrente 
    {
        public ContaCorrente(int numeroDeConta, decimal saldoInicial)
        {
            NumeroDeConta = numeroDeConta;
            saldo = saldoInicial;
        }
        public int NumeroDeConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado.");
            }
            else
            {
                Console.WriteLine($"Sem saldo suficiente.");
            }
        }

        
            public void ExibirSaldo()
            {
              Console.WriteLine($"Saldo atual: {saldo}");  
            }
            


    }
}