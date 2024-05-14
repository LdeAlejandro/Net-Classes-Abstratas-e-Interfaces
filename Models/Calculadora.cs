using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstract_exercise.Models;
// //tem que colocar a referencia
using Abstract_exercise.Interfaces;

namespace Abstract_exercise.Models
{
    public class Calculadora : ICalculadora
    {
        //tudo o que tiver a interfaces devera estar na classe donde for implementada, em este caso Soma, Subtrair, Multiplicar dividir.
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }


    }
}